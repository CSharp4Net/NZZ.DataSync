using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZZ.DataSync.App
{
    public partial class FormSync : Form
    {
        public FormSync(FormMain parent, bool silent)
        {
            AppForm = parent;

            InSilent = silent;

            InitializeComponent();
        }

        public event Logic.Sync.Synchronizer.SyncProgressHandler SyncProgressChanged = null;

        private FormMain AppForm { get; set; }

        public Logic.Sync.Synchronizer Synchronizer { get; private set; }

        public bool InSilent { get; private set; }

        public bool InProgress
        {
            get
            {
                if (Synchronizer != null)
                {
                    return Synchronizer.InProgress;
                }
                else
                    return false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                if (InSilent)
                {
                    RunSync();
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void RunSync()
        {
            TvSyncProtocol.Nodes.Clear();

            Synchronizer = new Logic.Sync.Synchronizer(AppForm.ExHandler);
            Synchronizer.FolderCountChanged += Synchronizer_FolderCountChanged;
            Synchronizer.FileCountChanged += Synchronizer_FileCountChanged;
            Synchronizer.SyncProgressChanged += Synchronizer_SyncProgressChanged;
            Synchronizer.FolderInfoFired += Synchronizer_FolderInfoFired;
            Synchronizer.SaveDatabase += Synchronizer_SaveDatabase;

            PbFolderProgress.Value = 0;
            PbFolderProgress.Maximum = 1;

            PbFileProgress.Value = 0;
            PbFileProgress.Maximum = 1;

            Synchronizer.Start(AppForm.Database);
        }

        private void RaiseSyncProgressChanged(object sender, Logic.Sync.Synchronizer.SyncProgressArgs args)
        {
            if (SyncProgressChanged != null)
                SyncProgressChanged(sender, args);
        }

        private void Synchronizer_SyncProgressChanged(object sender, Logic.Sync.Synchronizer.SyncProgressArgs args)
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action<object, Logic.Sync.Synchronizer.SyncProgressArgs>(Synchronizer_SyncProgressChanged), sender, args);
                else
                {
                    BtnStartProgress.Enabled = !args.InProgress;
                    BtnStopProcess.Enabled = args.InProgress;

                    TreeNode node = TvSyncProtocol.Nodes.Add(args.Text);

                    switch (args.ArgType)
                    {
                        case Logic.Sync.Synchronizer.SyncProgressArgs.ProgressType.Warning:
                            node.ImageKey = "Warning";
                            node.SelectedImageKey = "Warning";
                            break;
                        case Logic.Sync.Synchronizer.SyncProgressArgs.ProgressType.Exception:
                            node.ImageKey = "Error";
                            node.SelectedImageKey = "Error";
                            node.Text = args.Ex.Message;
                            break;
                        default:
                            node.ImageKey = "Info";
                            node.SelectedImageKey = "Info";
                            break;
                    }

                    RaiseSyncProgressChanged(sender, args);

                    // Wenn Synchronisieren beendet, dann zerstöre Objekt
                    if (!args.InProgress)
                    {
                        Synchronizer.FolderCountChanged -= Synchronizer_FolderCountChanged;
                        Synchronizer.FileCountChanged -= Synchronizer_FileCountChanged;
                        Synchronizer.SyncProgressChanged -= Synchronizer_SyncProgressChanged;
                        Synchronizer.FolderInfoFired -= Synchronizer_FolderInfoFired;
                        Synchronizer.SaveDatabase -= Synchronizer_SaveDatabase;

                        Synchronizer.Dispose();
                        Synchronizer = null;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void Synchronizer_FileCountChanged(object sender, Logic.Sync.Synchronizer.CountEventArgs args)
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action<object, Logic.Sync.Synchronizer.CountEventArgs>(Synchronizer_FileCountChanged), sender, args);
                else
                {
                    if (args.Total != PbFileProgress.Maximum)
                        PbFileProgress.Maximum = args.Total;

                    PbFileProgress.Value = args.ActualNumber;

                    LbFileCount.Text = string.Format(LbFileCount.Tag.ToString(), args.ActualNumber, args.Total);
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void Synchronizer_FolderCountChanged(object sender, Logic.Sync.Synchronizer.CountEventArgs args)
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action<object, Logic.Sync.Synchronizer.CountEventArgs>(Synchronizer_FolderCountChanged), sender, args);
                else
                {
                    if (args.Total != PbFolderProgress.Maximum)
                        PbFolderProgress.Maximum = args.Total;

                    PbFolderProgress.Value = args.ActualNumber;

                    LbFolderCount.Text = string.Format(LbFolderCount.Tag.ToString(), args.ActualNumber, args.Total);
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void Synchronizer_FolderInfoFired(object sender, Logic.Sync.Synchronizer.FolderInfoArgs args)
        {
            try
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action<object, Logic.Sync.Synchronizer.FolderInfoArgs>(Synchronizer_FolderInfoFired), sender, args);
                else
                {
                    TreeNode node = null;

                    if (!TvSyncProtocol.Nodes.ContainsKey(args.Folder.ID.ToString()))
                    {
                        node = TvSyncProtocol.Nodes.Add(args.Folder.ID.ToString(), args.Folder.Name);
                        node.ImageKey = args.Folder.ImgKey;
                        node.SelectedImageKey = args.Folder.ImgKey;
                    }
                    else
                        node = TvSyncProtocol.Nodes[args.Folder.ID.ToString()];

                    TreeNode childNode = childNode = node.Nodes.Add(args.Text);

                    switch (args.ArgType)
                    {
                        case Logic.Sync.Synchronizer.FolderInfoArgs.InfoType.Warning:
                            childNode.ImageKey = "Warning";
                            childNode.SelectedImageKey = "Warning";
                            break;
                        case Logic.Sync.Synchronizer.FolderInfoArgs.InfoType.Exception:
                            childNode.ImageKey = "Error";
                            childNode.SelectedImageKey = "Error";
                            childNode.Text = args.Ex.Message;
                            break;
                        default:
                            childNode.ImageKey = "Info";
                            childNode.SelectedImageKey = "Info";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
        
        private void Synchronizer_SaveDatabase(object sender, EventArgs e)
        {
            try
            {
                Logic.Database.Save(AppForm.DbFileName, AppForm.Database);
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
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

        private void BtnStartProgress_Click(object sender, EventArgs e)
        {
            try
            {
                RunSync();
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnStopProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (Synchronizer != null)
                {
                    Synchronizer.Stop();
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FormSync_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (InProgress)
                {
                    e.Cancel = true;

                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                AppForm.ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
    }
}
