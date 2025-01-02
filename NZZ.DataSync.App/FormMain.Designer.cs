namespace NZZ.DataSync.App
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MiOpenApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MiStartSynchronization = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MiExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnShowSettings = new System.Windows.Forms.Button();
            this.BtnExitApplication = new System.Windows.Forms.Button();
            this.BtnOpenAppLocation = new System.Windows.Forms.Button();
            this.BtnStartSync = new System.Windows.Forms.Button();
            this.BtnSetupTimer = new System.Windows.Forms.Button();
            this.BtnSetupPaths = new System.Windows.Forms.Button();
            this.CmNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.CmNotifyIcon;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "NZZ.DataSync";
            this.MyNotifyIcon.Visible = true;
            // 
            // CmNotifyIcon
            // 
            this.CmNotifyIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiOpenApp,
            this.MiStartSynchronization,
            this.toolStripSeparator2,
            this.MiExitApplication});
            this.CmNotifyIcon.Name = "CmNotifyIcon";
            this.CmNotifyIcon.Size = new System.Drawing.Size(184, 76);
            // 
            // MiOpenApp
            // 
            this.MiOpenApp.Name = "MiOpenApp";
            this.MiOpenApp.Size = new System.Drawing.Size(183, 22);
            this.MiOpenApp.Text = "Anwendung öffnen";
            this.MiOpenApp.Click += new System.EventHandler(this.MiOpenApp_Click);
            // 
            // MiStartSynchronization
            // 
            this.MiStartSynchronization.Image = global::NZZ.DataSync.App.Properties.Resources.NormalSync_32;
            this.MiStartSynchronization.Name = "MiStartSynchronization";
            this.MiStartSynchronization.Size = new System.Drawing.Size(183, 22);
            this.MiStartSynchronization.Text = "Jetzt synchronisieren";
            this.MiStartSynchronization.Click += new System.EventHandler(this.MiStartSynchronization_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // MiExitApplication
            // 
            this.MiExitApplication.Name = "MiExitApplication";
            this.MiExitApplication.Size = new System.Drawing.Size(183, 22);
            this.MiExitApplication.Text = "Beenden";
            this.MiExitApplication.Click += new System.EventHandler(this.MiExitApplication_Click);
            // 
            // MyToolTip
            // 
            this.MyToolTip.BackColor = System.Drawing.Color.White;
            this.MyToolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // BtnShowSettings
            // 
            this.BtnShowSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowSettings.Image = global::NZZ.DataSync.App.Properties.Resources.gear_64;
            this.BtnShowSettings.Location = new System.Drawing.Point(287, 198);
            this.BtnShowSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnShowSettings.Name = "BtnShowSettings";
            this.BtnShowSettings.Size = new System.Drawing.Size(84, 84);
            this.BtnShowSettings.TabIndex = 6;
            this.MyToolTip.SetToolTip(this.BtnShowSettings, "Öffnet die Einstellungen der Anwendung.");
            this.BtnShowSettings.UseVisualStyleBackColor = false;
            this.BtnShowSettings.Click += new System.EventHandler(this.BtnShowSettings_Click);
            // 
            // BtnExitApplication
            // 
            this.BtnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.BtnExitApplication.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExitApplication.Image = global::NZZ.DataSync.App.Properties.Resources.exit_64;
            this.BtnExitApplication.Location = new System.Drawing.Point(287, 289);
            this.BtnExitApplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExitApplication.Name = "BtnExitApplication";
            this.BtnExitApplication.Size = new System.Drawing.Size(84, 84);
            this.BtnExitApplication.TabIndex = 5;
            this.MyToolTip.SetToolTip(this.BtnExitApplication, "Beendet die Anwendung komplett.");
            this.BtnExitApplication.UseVisualStyleBackColor = false;
            this.BtnExitApplication.Click += new System.EventHandler(this.BtnExitApplication_Click);
            // 
            // BtnOpenAppLocation
            // 
            this.BtnOpenAppLocation.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenAppLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenAppLocation.Image = global::NZZ.DataSync.App.Properties.Resources.magnifier_data_64;
            this.BtnOpenAppLocation.Location = new System.Drawing.Point(197, 198);
            this.BtnOpenAppLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpenAppLocation.Name = "BtnOpenAppLocation";
            this.BtnOpenAppLocation.Size = new System.Drawing.Size(84, 84);
            this.BtnOpenAppLocation.TabIndex = 4;
            this.MyToolTip.SetToolTip(this.BtnOpenAppLocation, "Öffnet das Verzeichnis der Anwendung.");
            this.BtnOpenAppLocation.UseVisualStyleBackColor = false;
            this.BtnOpenAppLocation.Click += new System.EventHandler(this.BtnOpenAppLocation_Click);
            // 
            // BtnStartSync
            // 
            this.BtnStartSync.BackColor = System.Drawing.Color.Transparent;
            this.BtnStartSync.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartSync.Image = global::NZZ.DataSync.App.Properties.Resources.NormalSync;
            this.BtnStartSync.Location = new System.Drawing.Point(14, 198);
            this.BtnStartSync.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStartSync.Name = "BtnStartSync";
            this.BtnStartSync.Size = new System.Drawing.Size(175, 175);
            this.BtnStartSync.TabIndex = 2;
            this.MyToolTip.SetToolTip(this.BtnStartSync, "Führt die Synchronisation aller Verzeichnisse aus.");
            this.BtnStartSync.UseVisualStyleBackColor = false;
            this.BtnStartSync.Click += new System.EventHandler(this.BtnStartSync_Click);
            // 
            // BtnSetupTimer
            // 
            this.BtnSetupTimer.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetupTimer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetupTimer.Image = global::NZZ.DataSync.App.Properties.Resources.calendar_clock;
            this.BtnSetupTimer.Location = new System.Drawing.Point(196, 15);
            this.BtnSetupTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSetupTimer.Name = "BtnSetupTimer";
            this.BtnSetupTimer.Size = new System.Drawing.Size(175, 175);
            this.BtnSetupTimer.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.BtnSetupTimer, "Öffnet den Terminplaner.");
            this.BtnSetupTimer.UseVisualStyleBackColor = false;
            this.BtnSetupTimer.Click += new System.EventHandler(this.BtnSetupTimer_Click);
            // 
            // BtnSetupPaths
            // 
            this.BtnSetupPaths.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetupPaths.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetupPaths.Image = global::NZZ.DataSync.App.Properties.Resources.folder_house;
            this.BtnSetupPaths.Location = new System.Drawing.Point(14, 15);
            this.BtnSetupPaths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSetupPaths.Name = "BtnSetupPaths";
            this.BtnSetupPaths.Size = new System.Drawing.Size(175, 175);
            this.BtnSetupPaths.TabIndex = 0;
            this.MyToolTip.SetToolTip(this.BtnSetupPaths, "Öffnet die Liste an Verzeichnissen.");
            this.BtnSetupPaths.UseVisualStyleBackColor = false;
            this.BtnSetupPaths.Click += new System.EventHandler(this.BtnSetupPaths_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.BtnShowSettings);
            this.Controls.Add(this.BtnExitApplication);
            this.Controls.Add(this.BtnOpenAppLocation);
            this.Controls.Add(this.BtnStartSync);
            this.Controls.Add(this.BtnSetupTimer);
            this.Controls.Add(this.BtnSetupPaths);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data-Sync";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.CmNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.Button BtnSetupPaths;
        private System.Windows.Forms.Button BtnSetupTimer;
        private System.Windows.Forms.Button BtnStartSync;
        private System.Windows.Forms.ContextMenuStrip CmNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem MiOpenApp;
        private System.Windows.Forms.ToolStripMenuItem MiStartSynchronization;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MiExitApplication;
        private System.Windows.Forms.Button BtnOpenAppLocation;
        private System.Windows.Forms.Button BtnExitApplication;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Button BtnShowSettings;
    }
}

