namespace WpLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnUseCfg = new System.Windows.Forms.Button();
            this.cBoxProConfig = new System.Windows.Forms.ComboBox();
            this.cBoxSteamDir = new System.Windows.Forms.ComboBox();
            this.cBoxAutoexec = new System.Windows.Forms.CheckBox();
            this.cBoxVideo = new System.Windows.Forms.CheckBox();
            this.cBoxConfig = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(25, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 73);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(183, 38);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(152, 73);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "REGISTER";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(25, 12);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(152, 20);
            this.tbUser.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(183, 12);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(152, 20);
            this.tbPass.TabIndex = 3;
            // 
            // btnUseCfg
            // 
            this.btnUseCfg.Location = new System.Drawing.Point(105, 182);
            this.btnUseCfg.Name = "btnUseCfg";
            this.btnUseCfg.Size = new System.Drawing.Size(230, 63);
            this.btnUseCfg.TabIndex = 9;
            this.btnUseCfg.Text = "use CFG";
            this.btnUseCfg.UseVisualStyleBackColor = true;
            this.btnUseCfg.Click += new System.EventHandler(this.btnUseCfg_Click);
            // 
            // cBoxProConfig
            // 
            this.cBoxProConfig.FormattingEnabled = true;
            this.cBoxProConfig.Location = new System.Drawing.Point(25, 154);
            this.cBoxProConfig.Name = "cBoxProConfig";
            this.cBoxProConfig.Size = new System.Drawing.Size(310, 21);
            this.cBoxProConfig.TabIndex = 14;
            this.cBoxProConfig.SelectedIndexChanged += new System.EventHandler(this.cBoxProConfig_SelectedIndexChanged);
            // 
            // cBoxSteamDir
            // 
            this.cBoxSteamDir.FormattingEnabled = true;
            this.cBoxSteamDir.Location = new System.Drawing.Point(25, 127);
            this.cBoxSteamDir.Name = "cBoxSteamDir";
            this.cBoxSteamDir.Size = new System.Drawing.Size(310, 21);
            this.cBoxSteamDir.TabIndex = 13;
            // 
            // cBoxAutoexec
            // 
            this.cBoxAutoexec.AutoSize = true;
            this.cBoxAutoexec.Checked = true;
            this.cBoxAutoexec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxAutoexec.Location = new System.Drawing.Point(25, 228);
            this.cBoxAutoexec.Name = "cBoxAutoexec";
            this.cBoxAutoexec.Size = new System.Drawing.Size(71, 17);
            this.cBoxAutoexec.TabIndex = 12;
            this.cBoxAutoexec.Text = "Autoexec";
            this.cBoxAutoexec.UseVisualStyleBackColor = true;
            // 
            // cBoxVideo
            // 
            this.cBoxVideo.AutoSize = true;
            this.cBoxVideo.Checked = true;
            this.cBoxVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxVideo.Location = new System.Drawing.Point(25, 205);
            this.cBoxVideo.Name = "cBoxVideo";
            this.cBoxVideo.Size = new System.Drawing.Size(53, 17);
            this.cBoxVideo.TabIndex = 11;
            this.cBoxVideo.Text = "Video";
            this.cBoxVideo.UseVisualStyleBackColor = true;
            // 
            // cBoxConfig
            // 
            this.cBoxConfig.AutoSize = true;
            this.cBoxConfig.Checked = true;
            this.cBoxConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxConfig.Location = new System.Drawing.Point(25, 181);
            this.cBoxConfig.Name = "cBoxConfig";
            this.cBoxConfig.Size = new System.Drawing.Size(56, 17);
            this.cBoxConfig.TabIndex = 10;
            this.cBoxConfig.Text = "Config";
            this.cBoxConfig.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 265);
            this.Controls.Add(this.cBoxProConfig);
            this.Controls.Add(this.cBoxSteamDir);
            this.Controls.Add(this.cBoxAutoexec);
            this.Controls.Add(this.cBoxVideo);
            this.Controls.Add(this.cBoxConfig);
            this.Controls.Add(this.btnUseCfg);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnUseCfg;
        private System.Windows.Forms.ComboBox cBoxProConfig;
        private System.Windows.Forms.ComboBox cBoxSteamDir;
        private System.Windows.Forms.CheckBox cBoxAutoexec;
        private System.Windows.Forms.CheckBox cBoxVideo;
        private System.Windows.Forms.CheckBox cBoxConfig;
    }
}

