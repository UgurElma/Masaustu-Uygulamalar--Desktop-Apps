namespace Company
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gPanelPasswords = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitleBir = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonGönder = new System.Windows.Forms.Button();
            this.textBoxTCKimlikNo = new System.Windows.Forms.TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textBoxUserPin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.gPictureBoxLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.gPanelPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.gPanelPasswords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 525);
            this.panel1.TabIndex = 0;
            // 
            // gPanelPasswords
            // 
            this.gPanelPasswords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gPanelPasswords.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.gPanelPasswords.BorderRadius = 10;
            this.gPanelPasswords.BorderThickness = 1;
            this.gPanelPasswords.Controls.Add(this.labelTitleBir);
            this.gPanelPasswords.Controls.Add(this.guna2Panel2);
            this.gPanelPasswords.Controls.Add(this.buttonGönder);
            this.gPanelPasswords.Controls.Add(this.textBoxTCKimlikNo);
            this.gPanelPasswords.FillColor = System.Drawing.SystemColors.Control;
            this.gPanelPasswords.Location = new System.Drawing.Point(12, 103);
            this.gPanelPasswords.Name = "gPanelPasswords";
            this.gPanelPasswords.Size = new System.Drawing.Size(255, 329);
            this.gPanelPasswords.TabIndex = 0;
            this.gPanelPasswords.Visible = false;
            // 
            // labelTitleBir
            // 
            this.labelTitleBir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleBir.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitleBir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitleBir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitleBir.Location = new System.Drawing.Point(35, 42);
            this.labelTitleBir.Name = "labelTitleBir";
            this.labelTitleBir.Size = new System.Drawing.Size(194, 20);
            this.labelTitleBir.TabIndex = 33;
            this.labelTitleBir.Text = "ŞİFRE BULMA";
            this.labelTitleBir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Location = new System.Drawing.Point(31, 65);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 1);
            this.guna2Panel2.TabIndex = 32;
            // 
            // buttonGönder
            // 
            this.buttonGönder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGönder.AutoSize = true;
            this.buttonGönder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonGönder.FlatAppearance.BorderSize = 0;
            this.buttonGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGönder.ForeColor = System.Drawing.Color.White;
            this.buttonGönder.Location = new System.Drawing.Point(42, 188);
            this.buttonGönder.Name = "buttonGönder";
            this.buttonGönder.Size = new System.Drawing.Size(168, 42);
            this.buttonGönder.TabIndex = 5;
            this.buttonGönder.Text = "İstek Gönder";
            this.buttonGönder.UseVisualStyleBackColor = false;
            this.buttonGönder.Click += new System.EventHandler(this.buttonGönder_Click);
            // 
            // textBoxTCKimlikNo
            // 
            this.textBoxTCKimlikNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTCKimlikNo.ForeColor = System.Drawing.Color.Silver;
            this.textBoxTCKimlikNo.Location = new System.Drawing.Point(16, 119);
            this.textBoxTCKimlikNo.MaxLength = 11;
            this.textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            this.textBoxTCKimlikNo.Size = new System.Drawing.Size(225, 32);
            this.textBoxTCKimlikNo.TabIndex = 4;
            this.textBoxTCKimlikNo.Text = "T.C. kimlik numarası";
            this.textBoxTCKimlikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTCKimlikNo.Enter += new System.EventHandler(this.textBoxTCKimlikNo_Enter);
            this.textBoxTCKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTCKimlikNo_KeyPress);
            this.textBoxTCKimlikNo.Leave += new System.EventHandler(this.textBoxTCKimlikNo_Leave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserID.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUserID.Location = new System.Drawing.Point(414, 222);
            this.textBoxUserID.MaxLength = 11;
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(225, 32);
            this.textBoxUserID.TabIndex = 1;
            this.textBoxUserID.Text = "T.C. kimlik numarası";
            this.textBoxUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserID.Enter += new System.EventHandler(this.textBoxUserID_Enter);
            this.textBoxUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserID_KeyPress);
            this.textBoxUserID.Leave += new System.EventHandler(this.textBoxUserID_Leave);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCompanyName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCompanyName.Location = new System.Drawing.Point(305, 103);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(448, 36);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "Şirket İsmi";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserID
            // 
            this.labelUserID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(371, 185);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(137, 25);
            this.labelUserID.TabIndex = 3;
            this.labelUserID.Text = "Kullanıcı ID:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(371, 281);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(162, 25);
            this.labelUserPassword.TabIndex = 4;
            this.labelUserPassword.Text = "Kullanıcı Şifre:";
            // 
            // textBoxUserPin
            // 
            this.textBoxUserPin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUserPin.Location = new System.Drawing.Point(414, 319);
            this.textBoxUserPin.MaxLength = 4;
            this.textBoxUserPin.Name = "textBoxUserPin";
            this.textBoxUserPin.Size = new System.Drawing.Size(225, 32);
            this.textBoxUserPin.TabIndex = 2;
            this.textBoxUserPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserPin.UseSystemPasswordChar = true;
            this.textBoxUserPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserPin_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(439, 390);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(168, 42);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.linkLabel1.Location = new System.Drawing.Point(480, 453);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Temizle";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelExit.LinkColor = System.Drawing.Color.Red;
            this.linkLabelExit.Location = new System.Drawing.Point(727, 9);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(26, 25);
            this.linkLabelExit.TabIndex = 4;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "X";
            this.linkLabelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // gPictureBoxLogo
            // 
            this.gPictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.gPictureBoxLogo.ErrorImage = global::Company.Properties.Resources.logoexample;
            this.gPictureBoxLogo.Image = global::Company.Properties.Resources.logoexample;
            this.gPictureBoxLogo.ImageRotate = 0F;
            this.gPictureBoxLogo.Location = new System.Drawing.Point(494, 36);
            this.gPictureBoxLogo.Name = "gPictureBoxLogo";
            this.gPictureBoxLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gPictureBoxLogo.Size = new System.Drawing.Size(64, 64);
            this.gPictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gPictureBoxLogo.TabIndex = 5;
            this.gPictureBoxLogo.TabStop = false;
            this.gPictureBoxLogo.UseTransparentBackground = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.linkLabel2.Location = new System.Drawing.Point(519, 354);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(120, 25);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Şifremi unuttum.";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.linkLabelExit;
            this.ClientSize = new System.Drawing.Size(765, 525);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.gPictureBoxLogo);
            this.Controls.Add(this.linkLabelExit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUserPin);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.gPanelPasswords.ResumeLayout(false);
            this.gPanelPasswords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxUserPin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelExit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gPictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2Panel gPanelPasswords;
        private System.Windows.Forms.Button buttonGönder;
        private System.Windows.Forms.TextBox textBoxTCKimlikNo;
        private System.Windows.Forms.Label labelTitleBir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}

