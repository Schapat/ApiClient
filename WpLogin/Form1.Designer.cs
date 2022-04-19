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
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.cBoxProConfig = new System.Windows.Forms.ComboBox();
            this.cBoxSteamDirectorys = new System.Windows.Forms.ComboBox();
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
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(25, 148);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(298, 20);
            this.txtBoxOutput.TabIndex = 4;
            // 
            // cBoxProConfig
            // 
            this.cBoxProConfig.FormattingEnabled = true;
            this.cBoxProConfig.Location = new System.Drawing.Point(25, 195);
            this.cBoxProConfig.Name = "cBoxProConfig";
            this.cBoxProConfig.Size = new System.Drawing.Size(121, 21);
            this.cBoxProConfig.TabIndex = 7;
            // 
            // cBoxSteamDirectorys
            // 
            this.cBoxSteamDirectorys.FormattingEnabled = true;
            this.cBoxSteamDirectorys.Location = new System.Drawing.Point(202, 195);
            this.cBoxSteamDirectorys.Name = "cBoxSteamDirectorys";
            this.cBoxSteamDirectorys.Size = new System.Drawing.Size(121, 21);
            this.cBoxSteamDirectorys.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 390);
            this.Controls.Add(this.cBoxSteamDirectorys);
            this.Controls.Add(this.cBoxProConfig);
            this.Controls.Add(this.txtBoxOutput);
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
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.ComboBox cBoxProConfig;
        private System.Windows.Forms.ComboBox cBoxSteamDirectorys;
    }
}

