using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Sync
{
    public class Synchronizer : IDisposable
    {
        public Synchronizer(ExceptionHandler exHandler)
        {
            ExHandler = exHandler;

            InProgress = false;
        }

        public bool InProgress { get; private set; }

        private Database database = null;

        private ExceptionHandler ExHandler = null;

        private bool stopSync = false;
        private bool stopWasDetected = false;

        public event FolderCountChangedHandler FolderCountChanged = null;
        public event FileCountChangedHandler FileCountChanged = null;

        public event SyncProgressHandler SyncProgressChanged = null;

        public event FolderProgressHandler FolderInfoFired = null;

        public event EventHandler SaveDatabase = null;

        public void Dispose()
        {
            // Zerstöre Events
            FolderCountChanged = null;
            FileCountChanged = null;
            SyncProgressChanged = null;
            FolderInfoFired = null;
        }

        public void Start(Database dbObject)
        {
            database = dbObject;

            Thread thread = new Thread(StartInThread);

            thread.Start();
        }

        private async void StartInThread()
        {
            if (!InProgress)
            {
                InProgress = true;

                ExHandler.Handle("Synchronization started!");
                RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Info, string.Format("Die Synchronisation wurde gestart: {0}",  DateTime.Now.ToString())));

                if (database.Folders.Count > 0)
                {
                    CountEventArgs folderArgs = new CountEventArgs(database.Folders.Count, 0);

                    RaiseFolderCountChanged(folderArgs);

                    try
                    {
                        string protocolFormat = "Snyc {0}: {1}";

                        RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Info, "Anzahl zu synchronisierender Verzeichnisse: " + database.Folders.Count.ToString()));

                        foreach (Objects.LocalFolder folder in database.Folders)
                        {
                            if (CheckForStop())
                            {
                                break;
                            }

                            folderArgs.ActualNumber++;

                            RaiseFolderCountChanged(folderArgs);

                            // Wenn Verzeichnis markiert als nicht zu synchroniseren, dann überspringe es
                            if (folder.Ignore)
                            {
                                ExHandler.Handle(MethodBase.GetCurrentMethod(), string.Format(protocolFormat, folder.Name, "The directory was marked as 'do not sync'!"));
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, "Das Verzeichnis wurde als 'Nicht synchronisieren' markiert!"));

                                continue;
                            }
                            else
                            {
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Info, "Synchronisation des Verzeichnisses wurde begonnen, prüfe zu synchronisierenden Inhalt..."));
                            }

                            ExHandler.Handle(protocolFormat, folder.Name, "Sync startet.");

                            // Wenn Quellverzeichnis nicht existiert/verfügbar ist, dann überspringe es
                            if (!Directory.Exists(folder.Path))
                            {
                                ExHandler.Handle(MethodBase.GetCurrentMethod(), string.Format(protocolFormat, folder.Name, "The source directory was not found: " + folder.Path));
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, "Das Quellverzeichnis wurde nicht gefunden!"));

                                continue;
                            }

                            // Wenn Zielverzeichnis nicht existiert/verfügbar ist, dann überspringe es
                            if (!Directory.Exists(folder.NetworkPath))
                            {
                                ExHandler.Handle(MethodBase.GetCurrentMethod(), string.Format(protocolFormat, folder.Name, "The target directory was not found: " + folder.NetworkPath));
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, "Das Zielverzeichnis wurde nicht gefunden!"));

                                continue;
                            }

                            DirectoryInfo sourceDirectory = new DirectoryInfo(folder.Path);
                            DirectoryInfo targetDirectory = new DirectoryInfo(folder.NetworkPath);

                            string searchPattern = (string.IsNullOrEmpty(folder.SearchPattern) ? "*.*" : folder.SearchPattern);

                            FileInfo[] sourceFiles = sourceDirectory.GetFiles(searchPattern, SearchOption.AllDirectories);

                            if (sourceFiles.Length > 1)
                            {
                                FileInfo[] targetFiles = targetDirectory.GetFiles(searchPattern, SearchOption.AllDirectories);

                                ExHandler.Handle(protocolFormat, folder.Name, "Source-files found: " + sourceFiles.Length.ToString());
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, string.Format("Es werden {0} Dateien synchronisiert.", sourceFiles.Length)));

                                CountEventArgs fileArgs = new CountEventArgs(sourceFiles.Length, 0);

                                RaiseFileCountChanged(fileArgs);

                                foreach (FileInfo sourceFile in sourceFiles)
                                {
                                    if (CheckForStop())
                                    {
                                        break;
                                    }

                                    fileArgs.ActualNumber++;

                                    RaiseFileCountChanged(fileArgs);

                                    ExHandler.Handle(protocolFormat, folder.Name, "Sync file: " + sourceFile.Name);

                                    // Ermittle aus Dateipfad den Dateinamen mit Unterverzeichnissen, wobei das Quellverzeichnis als Stammverzeichnis fungiert
                                    string subFilePath = sourceFile.FullName.Substring(folder.Path.Length, sourceFile.FullName.Length - folder.Path.Length);

                                    // Suche nach bereits existierender Zieldatei
                                    FileInfo targetFile = targetFiles.FirstOrDefault(file => file.FullName.EndsWith(subFilePath));

                                    bool writeFile = false;
                                    string targetFilePath = null;

                                    // Erstelle Zieldateipfad
                                    if (targetFile == null)
                                    {
                                        writeFile = true;
                                        targetFilePath = folder.NetworkPath + subFilePath;
                                    }
                                    else if (folder.Overwrite)
                                    {
                                        writeFile = true;
                                        targetFilePath = targetFile.FullName;
                                    }

                                    if (writeFile)
                                    {
                                        try
                                        {
                                            // Öffne Quelldatei
                                            using (Stream sourceStream = new FileStream(sourceFile.FullName, FileMode.Open))
                                            {
                                                // Erzeuge Unterverzeichnis wenn nötig
                                                if (!Directory.Exists(Path.GetDirectoryName(targetFilePath)))
                                                    Directory.CreateDirectory(Path.GetDirectoryName(targetFilePath));

                                                // Schreibe Zieldatei
                                                using (Stream targetStream = new FileStream(targetFilePath, FileMode.Create))
                                                {
                                                    await sourceStream.CopyToAsync(targetStream);

                                                    targetStream.Close();
                                                }
                                                sourceStream.Close();
                                            }

                                            ExHandler.Handle(protocolFormat, folder.Name, "File synchronized.");
                                        }
                                        catch (Exception ex)
                                        {
                                            ExHandler.Handle(MethodBase.GetCurrentMethod(), ex, false);

                                            RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, string.Format("Die Datei {0} konnte nicht synchronisiert werden!", sourceFile.Name)));
                                            RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Exception, ex.Message));
                                        }
                                    }
                                    else
                                        ExHandler.Handle(protocolFormat, folder.Name, "File allready exists in backup, skip.");
                                }
                            }
                            else
                            {
                                ExHandler.Handle(protocolFormat, folder.Name, "No files found!");
                                RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Warning, "Verzeichnis enthält keine Dateien."));
                            }

                            folder.LastSync = DateTime.Now;

                            RaiseSaveDatabase();

                            RaiseFolderInfo(new FolderInfoArgs(folder, FolderInfoArgs.InfoType.Info, "Synchronisation des Verzeichnisses wurde beendet."));
                        }
                    }
                    catch (Exception ex)
                    {
                        ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);

                        RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Exception, ex));
                    }
                    finally
                    {
                        InProgress = false;

                        ExHandler.Handle("Synchronization finished!");
                        RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Info, string.Format("Die Synchronisation wurde beendet: {0}", DateTime.Now.ToString())));
                    }
                }
                else
                {
                    ExHandler.Handle("No folders defined!");
                    RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Warning, "Es wurden keine zu synchronisierenden Verzeichnisse definiert!"));
                }
            }
            else
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), "Sync allready in progress!");
                RaiseSyncProgressChanged(new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Warning, "Die Synchronisation wurde bereits gestartet!"));
            }
        }

        private void RaiseFolderCountChanged(CountEventArgs args)
        {
            if (FolderCountChanged != null)
                FolderCountChanged(this, args);
        }
        private void RaiseFileCountChanged(CountEventArgs args)
        {
            if (FileCountChanged != null)
                FileCountChanged(this, args);
        }

        private void RaiseSyncProgressChanged(SyncProgressArgs args)
        {
            if (SyncProgressChanged != null)
                SyncProgressChanged(this, args);
        }

        private void RaiseFolderInfo(FolderInfoArgs args)
        {
            if (FolderInfoFired != null)
                FolderInfoFired(this, args);
        }

        private void RaiseSaveDatabase()
        {
            if (SaveDatabase != null)
                SaveDatabase(this, new EventArgs());
        }

        public void Stop()
        {
            if (InProgress)
            {
                stopSync = true;
            }
            else
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), "Sync not in progress!");
            }
        }

        private bool CheckForStop()
        {
            if (stopSync && !stopWasDetected)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), "The sync progress was stopped manuelly!");

                RaiseSyncProgressChanged( new SyncProgressArgs(InProgress, SyncProgressArgs.ProgressType.Warning, "Die Synchronisation wurde gestoppt!"));

                stopWasDetected = true;
            }

            return stopSync;
        }

        private enum ProtocolEntryType
        {
            INFO, WARNING, ERROR
        }

        public delegate void FolderCountChangedHandler(object sender, CountEventArgs args);
        public delegate void FileCountChangedHandler(object sender, CountEventArgs args);

        public delegate void SyncProgressHandler(object sender, SyncProgressArgs args);

        public delegate void FolderProgressHandler(object sender, FolderInfoArgs args);

        public class CountEventArgs
        {
            public CountEventArgs(int total = 1, int actualNumber = 0)
            {
                Total = total;
                ActualNumber = actualNumber;
            }

            public int Total = 0;
            public int ActualNumber = 0;
        }

        public class SyncProgressArgs
        {
            public SyncProgressArgs(bool inProgress, ProgressType type, string text)
            {
                InProgress = inProgress;
                ArgType = type;
                Text = text;
            }

            public SyncProgressArgs(bool inProgress, ProgressType type, Exception ex)
            {
                InProgress = inProgress;
                ArgType = type;
                Ex = ex;
            }

            public bool InProgress = false;

            public ProgressType ArgType = ProgressType.Info;

            public string Text = null;

            public Exception Ex = null;

            public enum ProgressType
            {
                Info, Warning, Exception
            }
        }

        public class FolderInfoArgs
        {
            public FolderInfoArgs(Objects.LocalFolder folder, InfoType type)
            {
                Folder = folder;
                ArgType = type;
            }

            public FolderInfoArgs(Objects.LocalFolder folder, InfoType type, string text)
                : this(folder, type)
            {
                Text = text;
            }

            public FolderInfoArgs(Objects.LocalFolder folder, InfoType type, Exception ex)
                : this(folder, type)
            {
                Ex = ex;
            }

            public Objects.LocalFolder Folder = null;

            public InfoType ArgType = InfoType.Info;

            public string Text = null;

            public Exception Ex = null;

            public enum InfoType
            {
                Info, Warning, Exception
            }
        }
    }
}