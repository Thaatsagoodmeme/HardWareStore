namespace MB_Accounting
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBoxMBAccounting = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBoxKey = new System.Windows.Forms.PictureBox();
            this.pictureBoxKeyYellow = new System.Windows.Forms.PictureBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new MB_Accounting.RoundButton();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserYellow = new System.Windows.Forms.PictureBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxCVSK = new System.Windows.Forms.PictureBox();
            this.panelLoginBorder = new System.Windows.Forms.Panel();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMBAccountingYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxCVSKWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxSun = new System.Windows.Forms.PictureBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.pbxAntenna = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMBAccounting)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVSK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMBAccountingYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVSKWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAntenna)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMBAccounting
            // 
            this.pictureBoxMBAccounting.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMBAccounting.Image = global::MB_Accounting.Properties.Resources.MB_Accounting_Logo;
            this.pictureBoxMBAccounting.Location = new System.Drawing.Point(319, -31);
            this.pictureBoxMBAccounting.Name = "pictureBoxMBAccounting";
            this.pictureBoxMBAccounting.Size = new System.Drawing.Size(550, 315);
            this.pictureBoxMBAccounting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMBAccounting.TabIndex = 0;
            this.pictureBoxMBAccounting.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pictureBoxKey);
            this.panelLogin.Controls.Add(this.pictureBoxKeyYellow);
            this.panelLogin.Controls.Add(this.lblValidation);
            this.panelLogin.Controls.Add(this.tbxPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.pictureBoxUser);
            this.panelLogin.Controls.Add(this.pictureBoxUserYellow);
            this.panelLogin.Controls.Add(this.tbxEmail);
            this.panelLogin.Location = new System.Drawing.Point(239, 304);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(712, 270);
            this.panelLogin.TabIndex = 2;
            // 
            // pictureBoxKey
            // 
            this.pictureBoxKey.BackColor = System.Drawing.Color.White;
            this.pictureBoxKey.Image = global::MB_Accounting.Properties.Resources.key;
            this.pictureBoxKey.Location = new System.Drawing.Point(80, 141);
            this.pictureBoxKey.Name = "pictureBoxKey";
            this.pictureBoxKey.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKey.TabIndex = 2;
            this.pictureBoxKey.TabStop = false;
            // 
            // pictureBoxKeyYellow
            // 
            this.pictureBoxKeyYellow.Image = global::MB_Accounting.Properties.Resources.key_yellow;
            this.pictureBoxKeyYellow.Location = new System.Drawing.Point(80, 141);
            this.pictureBoxKeyYellow.Name = "pictureBoxKeyYellow";
            this.pictureBoxKeyYellow.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxKeyYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKeyYellow.TabIndex = 6;
            this.pictureBoxKeyYellow.TabStop = false;
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(224, 19);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 17);
            this.lblValidation.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(65, 130);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(585, 45);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.Active1 = System.Drawing.Color.HotPink;
            this.btnLogin.Active2 = System.Drawing.Color.HotPink;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Inactive1 = System.Drawing.Color.HotPink;
            this.btnLogin.Inactive2 = System.Drawing.Color.HotPink;
            this.btnLogin.Location = new System.Drawing.Point(233, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 30;
            this.btnLogin.Size = new System.Drawing.Size(240, 58);
            this.btnLogin.Stroke = false;
            this.btnLogin.StrokeColor = System.Drawing.Color.Transparent;
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Transparency = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.White;
            this.pictureBoxUser.Image = global::MB_Accounting.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(80, 60);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(23, 33);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxUserYellow
            // 
            this.pictureBoxUserYellow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserYellow.Image = global::MB_Accounting.Properties.Resources.user_yellow;
            this.pictureBoxUserYellow.Location = new System.Drawing.Point(80, 60);
            this.pictureBoxUserYellow.Name = "pictureBoxUserYellow";
            this.pictureBoxUserYellow.Size = new System.Drawing.Size(23, 33);
            this.pictureBoxUserYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserYellow.TabIndex = 6;
            this.pictureBoxUserYellow.TabStop = false;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(65, 54);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(585, 45);
            this.tbxEmail.TabIndex = 2;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
            // 
            // pictureBoxCVSK
            // 
            this.pictureBoxCVSK.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCVSK.Image = global::MB_Accounting.Properties.Resources.by_CVSK_Solutions;
            this.pictureBoxCVSK.Location = new System.Drawing.Point(503, 621);
            this.pictureBoxCVSK.Name = "pictureBoxCVSK";
            this.pictureBoxCVSK.Size = new System.Drawing.Size(196, 94);
            this.pictureBoxCVSK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCVSK.TabIndex = 1;
            this.pictureBoxCVSK.TabStop = false;
            // 
            // panelLoginBorder
            // 
            this.panelLoginBorder.Location = new System.Drawing.Point(238, 303);
            this.panelLoginBorder.Name = "panelLoginBorder";
            this.panelLoginBorder.Size = new System.Drawing.Size(714, 272);
            this.panelLoginBorder.TabIndex = 2;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMoon.Image = global::MB_Accounting.Properties.Resources.moon;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMoon.TabIndex = 3;
            this.pictureBoxMoon.TabStop = false;
            this.pictureBoxMoon.Click += new System.EventHandler(this.pictureBoxMoon_Click);
            // 
            // pictureBoxMBAccountingYellow
            // 
            this.pictureBoxMBAccountingYellow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMBAccountingYellow.Image = global::MB_Accounting.Properties.Resources.MB_Accounting_Logo_Yellow;
            this.pictureBoxMBAccountingYellow.Location = new System.Drawing.Point(319, -31);
            this.pictureBoxMBAccountingYellow.Name = "pictureBoxMBAccountingYellow";
            this.pictureBoxMBAccountingYellow.Size = new System.Drawing.Size(550, 315);
            this.pictureBoxMBAccountingYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMBAccountingYellow.TabIndex = 4;
            this.pictureBoxMBAccountingYellow.TabStop = false;
            // 
            // pictureBoxCVSKWhite
            // 
            this.pictureBoxCVSKWhite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCVSKWhite.Image = global::MB_Accounting.Properties.Resources.by_CVSK_Solutions_White;
            this.pictureBoxCVSKWhite.Location = new System.Drawing.Point(503, 621);
            this.pictureBoxCVSKWhite.Name = "pictureBoxCVSKWhite";
            this.pictureBoxCVSKWhite.Size = new System.Drawing.Size(196, 94);
            this.pictureBoxCVSKWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCVSKWhite.TabIndex = 5;
            this.pictureBoxCVSKWhite.TabStop = false;
            // 
            // pictureBoxSun
            // 
            this.pictureBoxSun.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSun.Image = global::MB_Accounting.Properties.Resources.sun;
            this.pictureBoxSun.Location = new System.Drawing.Point(1066, 654);
            this.pictureBoxSun.Name = "pictureBoxSun";
            this.pictureBoxSun.Size = new System.Drawing.Size(86, 62);
            this.pictureBoxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSun.TabIndex = 6;
            this.pictureBoxSun.TabStop = false;
            this.pictureBoxSun.Click += new System.EventHandler(this.pictureBoxSun_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.Orange;
            this.lblConnection.Location = new System.Drawing.Point(83, 692);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(137, 33);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Status:  ?";
            // 
            // pbxAntenna
            // 
            this.pbxAntenna.BackColor = System.Drawing.Color.Transparent;
            this.pbxAntenna.Image = global::MB_Accounting.Properties.Resources.antenna;
            this.pbxAntenna.Location = new System.Drawing.Point(22, 688);
            this.pbxAntenna.Name = "pbxAntenna";
            this.pbxAntenna.Size = new System.Drawing.Size(51, 43);
            this.pbxAntenna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAntenna.TabIndex = 8;
            this.pbxAntenna.TabStop = false;
            this.pbxAntenna.Click += new System.EventHandler(this.pbxAntenna_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.pbxAntenna);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLoginBorder);
            this.Controls.Add(this.pictureBoxMBAccounting);
            this.Controls.Add(this.pictureBoxMBAccountingYellow);
            this.Controls.Add(this.pictureBoxCVSK);
            this.Controls.Add(this.pictureBoxCVSKWhite);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxSun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar Accounting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMBAccounting)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVSK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMBAccountingYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCVSKWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAntenna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMBAccounting;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxCVSK;
        private System.Windows.Forms.TextBox tbxPassword;
        private RoundButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBoxKey;
        private System.Windows.Forms.Panel panelLoginBorder;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxMBAccountingYellow;
        private System.Windows.Forms.PictureBox pictureBoxCVSKWhite;
        private System.Windows.Forms.PictureBox pictureBoxKeyYellow;
        private System.Windows.Forms.PictureBox pictureBoxSun;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.PictureBox pbxAntenna;
        private System.Windows.Forms.PictureBox pictureBoxUserYellow;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox tbxEmail;
    }
}

