namespace ProConfigLoader 
{ 
    partial class Form1
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
            this.btnUseCfg = new System.Windows.Forms.Button();
            this.cBoxConfig = new System.Windows.Forms.CheckBox();
            this.cBoxVideo = new System.Windows.Forms.CheckBox();
            this.cBoxAutoexec = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUseCfg
            // 
            this.btnUseCfg.Location = new System.Drawing.Point(92, 66);
            this.btnUseCfg.Name = "btnUseCfg";
            this.btnUseCfg.Size = new System.Drawing.Size(241, 63);
            this.btnUseCfg.TabIndex = 0;
            this.btnUseCfg.Text = "use CFG";
            this.btnUseCfg.UseVisualStyleBackColor = true;
            this.btnUseCfg.Click += new System.EventHandler(this.btnUseCfg_Click);
            // 
            // cBoxConfig
            // 
            this.cBoxConfig.AutoSize = true;
            this.cBoxConfig.Location = new System.Drawing.Point(12, 66);
            this.cBoxConfig.Name = "cBoxConfig";
            this.cBoxConfig.Size = new System.Drawing.Size(56, 17);
            this.cBoxConfig.TabIndex = 1;
            this.cBoxConfig.Text = "Config";
            this.cBoxConfig.UseVisualStyleBackColor = true;
            // 
            // cBoxVideo
            // 
            this.cBoxVideo.AutoSize = true;
            this.cBoxVideo.Location = new System.Drawing.Point(12, 90);
            this.cBoxVideo.Name = "cBoxVideo";
            this.cBoxVideo.Size = new System.Drawing.Size(53, 17);
            this.cBoxVideo.TabIndex = 2;
            this.cBoxVideo.Text = "Video";
            this.cBoxVideo.UseVisualStyleBackColor = true;
            // 
            // cBoxAutoexec
            // 
            this.cBoxAutoexec.AutoSize = true;
            this.cBoxAutoexec.Location = new System.Drawing.Point(12, 113);
            this.cBoxAutoexec.Name = "cBoxAutoexec";
            this.cBoxAutoexec.Size = new System.Drawing.Size(71, 17);
            this.cBoxAutoexec.TabIndex = 3;
            this.cBoxAutoexec.Text = "Autoexec";
            this.cBoxAutoexec.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(321, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 144);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cBoxAutoexec);
            this.Controls.Add(this.cBoxVideo);
            this.Controls.Add(this.cBoxConfig);
            this.Controls.Add(this.btnUseCfg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUseCfg;
        private System.Windows.Forms.CheckBox cBoxConfig;
        private System.Windows.Forms.CheckBox cBoxVideo;
        private System.Windows.Forms.CheckBox cBoxAutoexec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

