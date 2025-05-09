namespace AutomatManager.UserControls
{
    partial class UC_Settings
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gGroupBoxPhotoName = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gTextBoxMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.gTextBoxManagerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTextBoxCompanyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gPictureBoxManager = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gPictureBoxCompany = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gGroupBoxPassword = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gTextBoxOldPassord = new Guna.UI2.WinForms.Guna2TextBox();
            this.gButtonChange = new Guna.UI2.WinForms.Guna2Button();
            this.gTextBoxNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.gLabelID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gGroupBoxPhotoName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxCompany)).BeginInit();
            this.gGroupBoxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gGroupBoxPhotoName
            // 
            this.gGroupBoxPhotoName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gGroupBoxPhotoName.BorderRadius = 10;
            this.gGroupBoxPhotoName.Controls.Add(this.gTextBoxMail);
            this.gGroupBoxPhotoName.Controls.Add(this.gButtonSave);
            this.gGroupBoxPhotoName.Controls.Add(this.gTextBoxManagerName);
            this.gGroupBoxPhotoName.Controls.Add(this.gTextBoxCompanyName);
            this.gGroupBoxPhotoName.Controls.Add(this.gPictureBoxManager);
            this.gGroupBoxPhotoName.Controls.Add(this.gPictureBoxCompany);
            this.gGroupBoxPhotoName.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gGroupBoxPhotoName.FillColor = System.Drawing.Color.CadetBlue;
            this.gGroupBoxPhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gGroupBoxPhotoName.ForeColor = System.Drawing.Color.White;
            this.gGroupBoxPhotoName.Location = new System.Drawing.Point(3, 59);
            this.gGroupBoxPhotoName.Name = "gGroupBoxPhotoName";
            this.gGroupBoxPhotoName.Size = new System.Drawing.Size(530, 431);
            this.gGroupBoxPhotoName.TabIndex = 0;
            this.gGroupBoxPhotoName.Text = "Mail & Photo & Name Settings";
            // 
            // gTextBoxMail
            // 
            this.gTextBoxMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gTextBoxMail.BorderRadius = 5;
            this.gTextBoxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxMail.DefaultText = "";
            this.gTextBoxMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxMail.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gTextBoxMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxMail.ForeColor = System.Drawing.Color.DimGray;
            this.gTextBoxMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxMail.Location = new System.Drawing.Point(101, 59);
            this.gTextBoxMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxMail.MaxLength = 50;
            this.gTextBoxMail.Name = "gTextBoxMail";
            this.gTextBoxMail.PasswordChar = '\0';
            this.gTextBoxMail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gTextBoxMail.PlaceholderText = "Enter your mail...";
            this.gTextBoxMail.SelectedText = "";
            this.gTextBoxMail.Size = new System.Drawing.Size(331, 48);
            this.gTextBoxMail.TabIndex = 13;
            this.gTextBoxMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gButtonSave
            // 
            this.gButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonSave.BorderColor = System.Drawing.Color.Teal;
            this.gButtonSave.BorderRadius = 5;
            this.gButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonSave.FillColor = System.Drawing.Color.Teal;
            this.gButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonSave.ForeColor = System.Drawing.Color.Aqua;
            this.gButtonSave.Location = new System.Drawing.Point(171, 337);
            this.gButtonSave.Name = "gButtonSave";
            this.gButtonSave.Size = new System.Drawing.Size(180, 45);
            this.gButtonSave.TabIndex = 16;
            this.gButtonSave.Text = "Save";
            this.gButtonSave.Click += new System.EventHandler(this.gButtonSave_Click);
            // 
            // gTextBoxManagerName
            // 
            this.gTextBoxManagerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxManagerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gTextBoxManagerName.BorderRadius = 5;
            this.gTextBoxManagerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxManagerName.DefaultText = "";
            this.gTextBoxManagerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxManagerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxManagerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxManagerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxManagerName.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gTextBoxManagerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxManagerName.ForeColor = System.Drawing.Color.DimGray;
            this.gTextBoxManagerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxManagerName.Location = new System.Drawing.Point(278, 238);
            this.gTextBoxManagerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxManagerName.MaxLength = 40;
            this.gTextBoxManagerName.Name = "gTextBoxManagerName";
            this.gTextBoxManagerName.PasswordChar = '\0';
            this.gTextBoxManagerName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gTextBoxManagerName.PlaceholderText = "Enter Manager Name...";
            this.gTextBoxManagerName.SelectedText = "";
            this.gTextBoxManagerName.Size = new System.Drawing.Size(237, 48);
            this.gTextBoxManagerName.TabIndex = 15;
            this.gTextBoxManagerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxManagerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxManagerName_KeyPress);
            // 
            // gTextBoxCompanyName
            // 
            this.gTextBoxCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxCompanyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gTextBoxCompanyName.BorderRadius = 5;
            this.gTextBoxCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxCompanyName.DefaultText = "";
            this.gTextBoxCompanyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxCompanyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxCompanyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxCompanyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxCompanyName.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gTextBoxCompanyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxCompanyName.ForeColor = System.Drawing.Color.DimGray;
            this.gTextBoxCompanyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxCompanyName.Location = new System.Drawing.Point(18, 238);
            this.gTextBoxCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxCompanyName.MaxLength = 40;
            this.gTextBoxCompanyName.Name = "gTextBoxCompanyName";
            this.gTextBoxCompanyName.PasswordChar = '\0';
            this.gTextBoxCompanyName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gTextBoxCompanyName.PlaceholderText = "Enter Company Name...";
            this.gTextBoxCompanyName.SelectedText = "";
            this.gTextBoxCompanyName.Size = new System.Drawing.Size(237, 48);
            this.gTextBoxCompanyName.TabIndex = 14;
            this.gTextBoxCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxCompanyName_KeyPress);
            // 
            // gPictureBoxManager
            // 
            this.gPictureBoxManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPictureBoxManager.BackColor = System.Drawing.Color.Transparent;
            this.gPictureBoxManager.ErrorImage = global::AutomatManager.Properties.Resources.user;
            this.gPictureBoxManager.FillColor = System.Drawing.Color.Transparent;
            this.gPictureBoxManager.Image = global::AutomatManager.Properties.Resources.user;
            this.gPictureBoxManager.ImageRotate = 0F;
            this.gPictureBoxManager.Location = new System.Drawing.Point(345, 114);
            this.gPictureBoxManager.Name = "gPictureBoxManager";
            this.gPictureBoxManager.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gPictureBoxManager.Size = new System.Drawing.Size(100, 100);
            this.gPictureBoxManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gPictureBoxManager.TabIndex = 2;
            this.gPictureBoxManager.TabStop = false;
            this.gPictureBoxManager.UseTransparentBackground = true;
            this.gPictureBoxManager.Click += new System.EventHandler(this.gPictureBoxManager_Click);
            // 
            // gPictureBoxCompany
            // 
            this.gPictureBoxCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPictureBoxCompany.BackColor = System.Drawing.Color.Transparent;
            this.gPictureBoxCompany.ErrorImage = global::AutomatManager.Properties.Resources.app_icon;
            this.gPictureBoxCompany.FillColor = System.Drawing.Color.Transparent;
            this.gPictureBoxCompany.Image = global::AutomatManager.Properties.Resources.app_icon;
            this.gPictureBoxCompany.ImageRotate = 0F;
            this.gPictureBoxCompany.Location = new System.Drawing.Point(84, 114);
            this.gPictureBoxCompany.Name = "gPictureBoxCompany";
            this.gPictureBoxCompany.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gPictureBoxCompany.Size = new System.Drawing.Size(100, 100);
            this.gPictureBoxCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gPictureBoxCompany.TabIndex = 0;
            this.gPictureBoxCompany.TabStop = false;
            this.gPictureBoxCompany.UseTransparentBackground = true;
            this.gPictureBoxCompany.Click += new System.EventHandler(this.gPictureBoxCompany_Click);
            // 
            // gGroupBoxPassword
            // 
            this.gGroupBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gGroupBoxPassword.BorderRadius = 10;
            this.gGroupBoxPassword.Controls.Add(this.gTextBoxOldPassord);
            this.gGroupBoxPassword.Controls.Add(this.gButtonChange);
            this.gGroupBoxPassword.Controls.Add(this.gTextBoxNewPassword);
            this.gGroupBoxPassword.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gGroupBoxPassword.FillColor = System.Drawing.Color.CadetBlue;
            this.gGroupBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gGroupBoxPassword.ForeColor = System.Drawing.Color.White;
            this.gGroupBoxPassword.Location = new System.Drawing.Point(568, 59);
            this.gGroupBoxPassword.Name = "gGroupBoxPassword";
            this.gGroupBoxPassword.Size = new System.Drawing.Size(530, 431);
            this.gGroupBoxPassword.TabIndex = 6;
            this.gGroupBoxPassword.Text = "Password Settings";
            // 
            // gTextBoxOldPassord
            // 
            this.gTextBoxOldPassord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxOldPassord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gTextBoxOldPassord.BorderRadius = 5;
            this.gTextBoxOldPassord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxOldPassord.DefaultText = "";
            this.gTextBoxOldPassord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxOldPassord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxOldPassord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxOldPassord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxOldPassord.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gTextBoxOldPassord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxOldPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxOldPassord.ForeColor = System.Drawing.Color.DimGray;
            this.gTextBoxOldPassord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxOldPassord.Location = new System.Drawing.Point(139, 114);
            this.gTextBoxOldPassord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxOldPassord.MaxLength = 4;
            this.gTextBoxOldPassord.Name = "gTextBoxOldPassord";
            this.gTextBoxOldPassord.PasswordChar = '\0';
            this.gTextBoxOldPassord.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gTextBoxOldPassord.PlaceholderText = "Enter current password...";
            this.gTextBoxOldPassord.SelectedText = "";
            this.gTextBoxOldPassord.Size = new System.Drawing.Size(237, 48);
            this.gTextBoxOldPassord.TabIndex = 17;
            this.gTextBoxOldPassord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxOldPassord.TextChanged += new System.EventHandler(this.gTextBoxOldPassord_TextChanged);
            this.gTextBoxOldPassord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxOldPassord_KeyPress);
            // 
            // gButtonChange
            // 
            this.gButtonChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonChange.BorderColor = System.Drawing.Color.Teal;
            this.gButtonChange.BorderRadius = 5;
            this.gButtonChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonChange.Enabled = false;
            this.gButtonChange.FillColor = System.Drawing.Color.Teal;
            this.gButtonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonChange.ForeColor = System.Drawing.Color.Aqua;
            this.gButtonChange.Location = new System.Drawing.Point(171, 337);
            this.gButtonChange.Name = "gButtonChange";
            this.gButtonChange.Size = new System.Drawing.Size(180, 45);
            this.gButtonChange.TabIndex = 19;
            this.gButtonChange.Text = "Change";
            this.gButtonChange.Click += new System.EventHandler(this.gButtonChange_Click);
            // 
            // gTextBoxNewPassword
            // 
            this.gTextBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gTextBoxNewPassword.BorderRadius = 5;
            this.gTextBoxNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxNewPassword.DefaultText = "";
            this.gTextBoxNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxNewPassword.FillColor = System.Drawing.Color.PaleTurquoise;
            this.gTextBoxNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxNewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.gTextBoxNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxNewPassword.Location = new System.Drawing.Point(139, 223);
            this.gTextBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxNewPassword.MaxLength = 4;
            this.gTextBoxNewPassword.Name = "gTextBoxNewPassword";
            this.gTextBoxNewPassword.PasswordChar = '●';
            this.gTextBoxNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gTextBoxNewPassword.PlaceholderText = "Enter new password...";
            this.gTextBoxNewPassword.SelectedText = "";
            this.gTextBoxNewPassword.Size = new System.Drawing.Size(237, 48);
            this.gTextBoxNewPassword.TabIndex = 18;
            this.gTextBoxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxNewPassword.UseSystemPasswordChar = true;
            this.gTextBoxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxNewPassword_KeyPress);
            // 
            // gLabelID
            // 
            this.gLabelID.BackColor = System.Drawing.Color.Transparent;
            this.gLabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gLabelID.Location = new System.Drawing.Point(21, 12);
            this.gLabelID.Name = "gLabelID";
            this.gLabelID.Size = new System.Drawing.Size(35, 31);
            this.gLabelID.TabIndex = 7;
            this.gLabelID.Text = "ID: ";
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gLabelID);
            this.Controls.Add(this.gGroupBoxPassword);
            this.Controls.Add(this.gGroupBoxPhotoName);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1101, 493);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.gGroupBoxPhotoName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPictureBoxCompany)).EndInit();
            this.gGroupBoxPassword.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gGroupBoxPhotoName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gPictureBoxCompany;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gPictureBoxManager;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxCompanyName;
        private Guna.UI2.WinForms.Guna2Button gButtonSave;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxManagerName;
        private Guna.UI2.WinForms.Guna2GroupBox gGroupBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxOldPassord;
        private Guna.UI2.WinForms.Guna2Button gButtonChange;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel gLabelID;
    }
}
