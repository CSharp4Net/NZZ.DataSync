namespace NZZ.DataSync.App
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.PnFooter = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.CkComputeMD5 = new System.Windows.Forms.CheckBox();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnSave);
            this.PnFooter.Controls.Add(this.BtnAbort);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 316);
            this.PnFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(650, 62);
            this.PnFooter.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::NZZ.DataSync.App.Properties.Resources.floppy_32;
            this.BtnSave.Location = new System.Drawing.Point(513, 12);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 40);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAbort
            // 
            this.BtnAbort.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbort.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbort.Location = new System.Drawing.Point(12, 12);
            this.BtnAbort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(93, 37);
            this.BtnAbort.TabIndex = 0;
            this.BtnAbort.Text = "Schließen";
            this.BtnAbort.UseVisualStyleBackColor = false;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // CkComputeMD5
            // 
            this.CkComputeMD5.AutoSize = true;
            this.CkComputeMD5.Location = new System.Drawing.Point(12, 12);
            this.CkComputeMD5.Name = "CkComputeMD5";
            this.CkComputeMD5.Size = new System.Drawing.Size(177, 20);
            this.CkComputeMD5.TabIndex = 4;
            this.CkComputeMD5.Text = "MD5-Vergleich verwenden";
            this.MyToolTip.SetToolTip(this.CkComputeMD5, "Wenn aktiviert werden bei der Synchronisation nur Dateien überschrieben, deren MD" +
        "5-Prüfsumme sich von der Quelldatei unterscheidet.\r\n");
            this.CkComputeMD5.UseVisualStyleBackColor = true;
            this.CkComputeMD5.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            // 
            // MyToolTip
            // 
            this.MyToolTip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 378);
            this.Controls.Add(this.CkComputeMD5);
            this.Controls.Add(this.PnFooter);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anwendungseinstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.PnFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox CkComputeMD5;
        private System.Windows.Forms.ToolTip MyToolTip;
    }
}