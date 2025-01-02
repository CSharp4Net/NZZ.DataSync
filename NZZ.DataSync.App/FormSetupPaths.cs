using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZZ.DataSync.App
{
    public partial class FormFolderSetup : Form
    {
        public FormFolderSetup(FormMain parent)
        {
            AppForm = parent;

            InitializeComponent();
        }

        private Logic.Objects.LocalFolder _selectedFolder = null;

        private FormMain AppForm { get; set; }

        private Logic.Objects.LocalFolder SelectedFolder
        {
            get { return _selectedFolder; }
            set
            {
                _selectedFolder = value;

                if (_selectedFolder == null)
                {
                    GrpFolderDetails.Enabled = false;

                    ClearFolderDetails();
                }
                else
                {
                    GrpFolderDetails.Enabled = true;

                    LoadFolderDetails();
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                ReloadFolders();

                SelectedFolder = null;
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void ReloadFolders()
        {
            LvLocalFolder.Items.Clear();

            foreach (Logic.Objects.LocalFolder folder in AppForm.Database.Folders.OrderBy(folder => folder.ID))
            {
                ListViewItem folderItem = LvLocalFolder.Items.Add(folder.Name);

                folderItem.Text = string.Format("{0} ({1})", folder.Name, folder.Path);
                folderItem.Tag = folder.ID;

                if (folder.Ignore)
                {
                    folderItem.ImageKey = folder.ImgKey + "_ignore";
                }
                else
                {
                    folderItem.ImageKey = folder.ImgKey;
                }
            }
        }

        private void LoadFolderDetails()
        {
            TbID.Text = SelectedFolder.ID.ToString();
            TbName.Text = SelectedFolder.Name;
            TbPath.Text = SelectedFolder.Path;
            TbNetworkPath.Text = SelectedFolder.NetworkPath;
            CkOverwrite.Checked = SelectedFolder.Overwrite;
            TbSearchPattern.Text = SelectedFolder.SearchPattern;
            CkIgnore.Checked = SelectedFolder.Ignore;

            if (SelectedFolder.LastSync > DateTime.MinValue)
                TbLastSync.Text = string.Format("am {0} Uhr", SelectedFolder.LastSync.ToString("dd.MM.yyyy HH:mm"));
            else
                TbLastSync.Text = string.Empty;

            PcImage.Image = ImgListLocalFolder.Images[SelectedFolder.ImgKey];
            PcImage.Tag = SelectedFolder.ImgKey.ToString();
        }

        private void ClearFolderDetails()
        {
            TbID.Text = string.Empty;
            TbName.Text = string.Empty;
            TbPath.Text = string.Empty;
            TbNetworkPath.Text = string.Empty;
            CkOverwrite.Checked = false;
            TbSearchPattern.Text = string.Empty;
            CkIgnore.Checked = false;
            TbLastSync.Text = string.Empty;

            PcImage.Image = null;
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedFolder.Name = TbName.Text;
                SelectedFolder.Path = TbPath.Text;
                SelectedFolder.NetworkPath = TbNetworkPath.Text;
                SelectedFolder.ImgKey = PcImage.Tag.ToString();
                SelectedFolder.Overwrite = CkOverwrite.Checked;
                SelectedFolder.SearchPattern = TbSearchPattern.Text;
                SelectedFolder.Ignore = CkIgnore.Checked;

                Logic.Database.Save(AppForm.DbFileName, AppForm.Database);

                ReloadFolders();

                SelectedFolder = null;
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnAddLocalFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.Objects.LocalFolder folder = new Logic.Objects.LocalFolder();

                if (AppForm.Database.Folders.Count > 0)
                    folder.ID = AppForm.Database.Folders.Max(f => f.ID) + 1;
                else
                    folder.ID = 1;

                folder.Name = "Neu";
                folder.Path = "<Bitte auswählen>";
                folder.ImgKey = "folder";
                folder.NetworkPath = "<Bitte auswählen>";

                AppForm.Database.Folders.Add(folder);

                ReloadFolders();

                // neues Element auswählen
                LvLocalFolder.SelectedIndices.Clear();
                LvLocalFolder.SelectedIndices.Add(LvLocalFolder.Items.Count - 1);
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnRemoveLocalFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFolder != null)
                {
                    if (MessageBox.Show(this, "Möchten Sie das ausgewählte Verzeichnis wirklich entfernen?", "Achtung", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AppForm.Database.Folders.Remove(SelectedFolder);

                        ReloadFolders();

                        ClearFolderDetails();

                        SelectedFolder = null;

                        Logic.Database.Save(AppForm.DbFileName, AppForm.Database);
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void LvLocalFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LvLocalFolder.SelectedIndices.Count > 0)
                {
                    // nur Einzelselektion erlaubt, lade Eigenschaften
                    SelectedFolder = AppForm.Database.Folders.First(folder => folder.ID == (int)LvLocalFolder.SelectedItems[0].Tag);
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnChoosePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFolder != null)
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();


                    if (!SelectedFolder.Path.StartsWith("<") && Directory.Exists(SelectedFolder.Path))
                    {
                        dialog.SelectedPath = SelectedFolder.Path;
                    }

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        DirectoryInfo folderInfo = new DirectoryInfo(dialog.SelectedPath);

                        TbName.Text = folderInfo.Name;
                        TbPath.Text = folderInfo.FullName;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnChooseNetworkPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFolder != null)
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();


                    if (!SelectedFolder.NetworkPath.StartsWith("<"))
                    {
                        dialog.SelectedPath = SelectedFolder.NetworkPath;
                    }

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        TbNetworkPath.Text = dialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFolder != null)
                {
                    Custom.DialogChooseFromImageList dialog = new Custom.DialogChooseFromImageList(AppForm, ImgListLocalFolder);

                    dialog.SelectedImageKey = SelectedFolder.ImgKey;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        PcImage.Image = ImgListLocalFolder.Images[dialog.SelectedImageKey];
                        PcImage.Tag = dialog.SelectedImageKey;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnTestSync_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedFolder != null)
                {
                    if (!Directory.Exists(TbPath.Text))
                    {
                        MessageBox.Show("Der angegebene Pfad wurde nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!Directory.Exists(TbNetworkPath.Text))
                    {
                        MessageBox.Show("Das angegebene Backup-Verzeichnis wurde nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string testFileName = Path.Combine(TbNetworkPath.Text, string.Format("DataSync_TEST_{0}.txt", DateTime.Now.ToString("yyyyMMdd_HHmmssfff")));

                        try
                        {
                            using (StreamWriter writer = new StreamWriter(testFileName, false))
                            {
                                writer.Write("NZZ.DataSync - Testdatei!");
                                writer.Close();
                            }

                            File.Delete(testFileName);

                            MessageBox.Show("Synchronisation kann durchgeführt werden!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Schreiben in Backup-Verzeichnis fehlgeschlagen! " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
    }
}