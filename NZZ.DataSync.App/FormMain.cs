using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZZ.DataSync.App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Members
        private FormFolderSetup frmSetupPaths = null;

        private FormSync frmSync = null;

        private FormConfig frmConfig = null;

        private FormSetupScheduler frmSetupScheduler = null;

        private bool closeFormNow = false;
        #endregion

        #region Properties
        internal Logic.Database Database { get; private set; }

        internal Logic.ExceptionHandler ExHandler { get; private set; }

        internal string DbFileName { get { return Path.Combine(Application.StartupPath, "NZZ.DataSync.Database.dasy"); } }
        #endregion

        private void SetSyncControls(bool enabled)
        {
            BtnSetupPaths.Enabled = enabled;
            BtnStartSync.Enabled = enabled;
        }

        private void OpenSyncForm(bool silent)
        {
            if (frmSync == null)
            {
                frmSync = new FormSync(this, silent);
                frmSync.FormClosed += FrmSync_FormClosed;
                frmSync.SyncProgressChanged += FrmSync_SyncProgressChanged;

                frmSync.Show();
            }
            else if (!frmSync.Visible)
                frmSync.Visible = true;
            else
                frmSync.BringToFront();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                ExHandler = new Logic.ExceptionHandler(Application.StartupPath);
                ExHandler.Handle("Application started.");

                Database = Logic.Database.Load(DbFileName);

                if (Database == null)
                {
                    SetSyncControls(false);

                    ExHandler.Handle(MethodBase.GetCurrentMethod(), "Es ist ein Problem beim Laden der Datenbank aufgetreten!", true);
                }
                else
                    ExHandler.Handle("Database-file loaded: " + DbFileName);
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnSetupPaths_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmSetupPaths == null)
                {
                    frmSetupPaths = new FormFolderSetup(this);
                    frmSetupPaths.FormClosed += FrmSetupPaths_FormClosed;
                    frmSetupPaths.ShowDialog();
                }
                else
                    frmSetupPaths.BringToFront();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnSetupTimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmSetupScheduler == null)
                {
                    frmSetupScheduler = new FormSetupScheduler(this);
                    frmSetupScheduler.FormClosed += FrmSetupScheduler_FormClosed;
                    frmSetupScheduler.ShowDialog();
                }
                else
                    frmSetupScheduler.BringToFront();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!closeFormNow)
                {
                    e.Cancel = true;

                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void MiOpenApp_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = true;
                this.BringToFront();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void MiExitApplication_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Wenn Synchronisation gerade läuft, dann muss dies hier behandelt werden!

                closeFormNow = true;

                this.Close();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnOpenAppLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath);
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnShowSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmConfig == null)
                {
                    frmConfig = new FormConfig(this);
                    frmConfig.FormClosed += FrmConfig_FormClosed;
                    frmConfig.ShowDialog();
                }
                else
                    frmConfig.BringToFront();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnExitApplication_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Wenn Synchronisation gerade läuft, dann muss dies hier behandelt werden!

                closeFormNow = true;

                this.Close();
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void BtnStartSync_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSyncForm(false);
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void MiStartSynchronization_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSyncForm(true);
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FrmSetupPaths_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmSetupPaths.FormClosed -= FrmSetupPaths_FormClosed;
                frmSetupPaths = null;
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FrmSetupScheduler_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmSetupScheduler.FormClosed -= FrmSetupScheduler_FormClosed;
                frmSetupScheduler = null;
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FrmSync_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmSync.FormClosed -= FrmSync_FormClosed;
                frmSync.SyncProgressChanged -= FrmSync_SyncProgressChanged;
                frmSync = null;
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmConfig.FormClosed -= FrmConfig_FormClosed;
                frmConfig = null;
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }

        private void FrmSync_SyncProgressChanged(object sender, Logic.Sync.Synchronizer.SyncProgressArgs args)
        {
            try
            {
                MiStartSynchronization.Enabled = !args.InProgress;

                // NotifyIcon zeigt keine Sprechblasen an (Windows 10 - Entwicklungsrechner), do something

                //MyNotifyIcon.Visible = true;

                //int timeOut = 0;
                //string message = string.Empty;
                //ToolTipIcon icon = ToolTipIcon.None;

                //switch (args.ArgType)
                //{
                //    case Logic.Sync.Synchronizer.SyncProgressArgs.ProgressType.Info:
                //        timeOut = 500;
                //        message = args.Text;
                //        icon = ToolTipIcon.Info;
                //        break;
                //    case Logic.Sync.Synchronizer.SyncProgressArgs.ProgressType.Warning:
                //        timeOut = 2000;
                //        message = args.Text;
                //        icon = ToolTipIcon.Warning;
                //        break;
                //    case Logic.Sync.Synchronizer.SyncProgressArgs.ProgressType.Exception:
                //        timeOut = 5000;
                //        message = args.Ex.Message;
                //        icon = ToolTipIcon.Error;
                //        break;
                //}

                //MyNotifyIcon.ShowBalloonTip(timeOut, "Synchronisation", message, icon);
            }
            catch (Exception ex)
            {
                ExHandler.Handle(MethodBase.GetCurrentMethod(), ex);
            }
        }
    }
}
