namespace NZZ.DataSync.App
{
    partial class FormSetupScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetupScheduler));
            this.PnFooter = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAbort = new System.Windows.Forms.Button();
            this.ClWeekdays = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFooter
            // 
            this.PnFooter.Controls.Add(this.BtnSave);
            this.PnFooter.Controls.Add(this.BtnAbort);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 260);
            this.PnFooter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(359, 76);
            this.PnFooter.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::NZZ.DataSync.App.Properties.Resources.floppy_32;
            this.BtnSave.Location = new System.Drawing.Point(200, 15);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(146, 49);
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
            this.BtnAbort.Location = new System.Drawing.Point(14, 15);
            this.BtnAbort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(108, 46);
            this.BtnAbort.TabIndex = 0;
            this.BtnAbort.Text = "Schließen";
            this.BtnAbort.UseVisualStyleBackColor = false;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // ClWeekdays
            // 
            this.ClWeekdays.FormattingEnabled = true;
            this.ClWeekdays.Location = new System.Drawing.Point(94, 15);
            this.ClWeekdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClWeekdays.Name = "ClWeekdays";
            this.ClWeekdays.Size = new System.Drawing.Size(139, 184);
            this.ClWeekdays.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wochentag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Uhrzeit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 207);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FormSetupScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 336);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClWeekdays);
            this.Controls.Add(this.PnFooter);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetupScheduler";
            this.Text = "Automatische Ausführung";
            this.PnFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.CheckedListBox ClWeekdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}