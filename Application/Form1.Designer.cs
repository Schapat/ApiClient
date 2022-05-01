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
            this.cBoxSteamDir = new System.Windows.Forms.ComboBox();
            this.cBoxProConfig = new System.Windows.Forms.ComboBox();
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
            this.cBoxConfig.Checked = true;
            this.cBoxConfig.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.cBoxVideo.Checked = true;
            this.cBoxVideo.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.cBoxAutoexec.Checked = true;
            this.cBoxAutoexec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxAutoexec.Location = new System.Drawing.Point(12, 113);
            this.cBoxAutoexec.Name = "cBoxAutoexec";
            this.cBoxAutoexec.Size = new System.Drawing.Size(71, 17);
            this.cBoxAutoexec.TabIndex = 3;
            this.cBoxAutoexec.Text = "Autoexec";
            this.cBoxAutoexec.UseVisualStyleBackColor = true;
            // 
            // cBoxSteamDir
            // 
            this.cBoxSteamDir.FormattingEnabled = true;
            this.cBoxSteamDir.Location = new System.Drawing.Point(12, 12);
            this.cBoxSteamDir.Name = "cBoxSteamDir";
            this.cBoxSteamDir.Size = new System.Drawing.Size(321, 21);
            this.cBoxSteamDir.TabIndex = 4;
            // 
            // cBoxProConfig
            // 
            this.cBoxProConfig.FormattingEnabled = true;
            this.cBoxProConfig.Location = new System.Drawing.Point(12, 39);
            this.cBoxProConfig.Name = "cBoxProConfig";
            this.cBoxProConfig.Size = new System.Drawing.Size(321, 21);
            this.cBoxProConfig.TabIndex = 5;
            this.cBoxProConfig.SelectedIndexChanged += new System.EventHandler(this.cBoxProConfig_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 144);
            this.Controls.Add(this.cBoxProConfig);
            this.Controls.Add(this.cBoxSteamDir);
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
        private System.Windows.Forms.ComboBox cBoxSteamDir;
        private System.Windows.Forms.ComboBox cBoxProConfig;
    }
}

