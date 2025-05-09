namespace Company.Formlar
{
    partial class DepartmanTablosu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxDepartmanlar = new System.Windows.Forms.ComboBox();
            this.gPanelDepartmanlar = new Guna.UI2.WinForms.Guna2Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelYoneticiIsmi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTemizle = new System.Windows.Forms.Label();
            this.labelToplamPersonelSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.gPanelPersonel = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPersonelTCKimlikNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonPersonelSil = new System.Windows.Forms.Button();
            this.buttonPersonelEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.gPanelALT = new Guna.UI2.WinForms.Guna2Panel();
            this.gPanelDepartmanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.gPanelPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDepartmanlar
            // 
            this.comboBoxDepartmanlar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDepartmanlar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDepartmanlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxDepartmanlar.FormattingEnabled = true;
            this.comboBoxDepartmanlar.Location = new System.Drawing.Point(36, 65);
            this.comboBoxDepartmanlar.Name = "comboBoxDepartmanlar";
            this.comboBoxDepartmanlar.Size = new System.Drawing.Size(250, 28);
            this.comboBoxDepartmanlar.TabIndex = 1;
            this.comboBoxDepartmanlar.SelectedValueChanged += new System.EventHandler(this.comboBoxDepartmanlar_SelectedValueChanged);
            // 
            // gPanelDepartmanlar
            // 
            this.gPanelDepartmanlar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPanelDepartmanlar.BackColor = System.Drawing.SystemColors.Control;
            this.gPanelDepartmanlar.BorderColor = System.Drawing.Color.Gainsboro;
            this.gPanelDepartmanlar.BorderRadius = 10;
            this.gPanelDepartmanlar.BorderThickness = 1;
            this.gPanelDepartmanlar.Controls.Add(this.labelInfo);
            this.gPanelDepartmanlar.Controls.Add(this.labelYoneticiIsmi);
            this.gPanelDepartmanlar.Controls.Add(this.label2);
            this.gPanelDepartmanlar.Controls.Add(this.label5);
            this.gPanelDepartmanlar.Controls.Add(this.guna2Panel1);
            this.gPanelDepartmanlar.Controls.Add(this.labelTemizle);
            this.gPanelDepartmanlar.Controls.Add(this.labelToplamPersonelSayisi);
            this.gPanelDepartmanlar.Controls.Add(this.label1);
            this.gPanelDepartmanlar.Controls.Add(this.guna2DataGridView1);
            this.gPanelDepartmanlar.Controls.Add(this.comboBoxDepartmanlar);
            this.gPanelDepartmanlar.Controls.Add(this.buttonSearch);
            this.gPanelDepartmanlar.Controls.Add(this.textBoxSearch);
            this.gPanelDepartmanlar.FillColor = System.Drawing.Color.White;
            this.gPanelDepartmanlar.Location = new System.Drawing.Point(30, 314);
            this.gPanelDepartmanlar.Name = "gPanelDepartmanlar";
            this.gPanelDepartmanlar.Size = new System.Drawing.Size(762, 560);
            this.gPanelDepartmanlar.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(473, 44);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(168, 16);
            this.labelInfo.TabIndex = 38;
            this.labelInfo.Text = "Girilen Karakter Sayısı: 0";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelYoneticiIsmi
            // 
            this.labelYoneticiIsmi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYoneticiIsmi.BackColor = System.Drawing.Color.White;
            this.labelYoneticiIsmi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYoneticiIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelYoneticiIsmi.Location = new System.Drawing.Point(197, 497);
            this.labelYoneticiIsmi.Name = "labelYoneticiIsmi";
            this.labelYoneticiIsmi.Size = new System.Drawing.Size(190, 30);
            this.labelYoneticiIsmi.TabIndex = 37;
            this.labelYoneticiIsmi.Text = "--";
            this.labelYoneticiIsmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(57, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Yönetici Adı Soyadı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "DEPARTMAN TABLOLARI";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 1;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(23, 44);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(250, 1);
            this.guna2Panel1.TabIndex = 34;
            // 
            // labelTemizle
            // 
            this.labelTemizle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemizle.AutoSize = true;
            this.labelTemizle.BackColor = System.Drawing.Color.White;
            this.labelTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTemizle.Location = new System.Drawing.Point(628, 95);
            this.labelTemizle.Name = "labelTemizle";
            this.labelTemizle.Size = new System.Drawing.Size(55, 16);
            this.labelTemizle.TabIndex = 18;
            this.labelTemizle.Text = "Temizle";
            this.labelTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTemizle.Click += new System.EventHandler(this.labelTemizle_Click);
            // 
            // labelToplamPersonelSayisi
            // 
            this.labelToplamPersonelSayisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelToplamPersonelSayisi.BackColor = System.Drawing.Color.White;
            this.labelToplamPersonelSayisi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamPersonelSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelToplamPersonelSayisi.Location = new System.Drawing.Point(621, 497);
            this.labelToplamPersonelSayisi.Name = "labelToplamPersonelSayisi";
            this.labelToplamPersonelSayisi.Size = new System.Drawing.Size(79, 30);
            this.labelToplamPersonelSayisi.TabIndex = 14;
            this.labelToplamPersonelSayisi.Text = "--";
            this.labelToplamPersonelSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(452, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toplam Personel Sayısı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 20;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(40, 139);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(683, 318);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BackgroundImage = global::Company.Properties.Resources.search_interface_symbol;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSearch.Location = new System.Drawing.Point(689, 62);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(32, 32);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSearch.Location = new System.Drawing.Point(476, 64);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 28);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // gPanelPersonel
            // 
            this.gPanelPersonel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPanelPersonel.BackColor = System.Drawing.SystemColors.Control;
            this.gPanelPersonel.BorderColor = System.Drawing.Color.Gainsboro;
            this.gPanelPersonel.BorderRadius = 10;
            this.gPanelPersonel.BorderThickness = 1;
            this.gPanelPersonel.Controls.Add(this.comboBox1);
            this.gPanelPersonel.Controls.Add(this.label17);
            this.gPanelPersonel.Controls.Add(this.textBoxPersonelTCKimlikNo);
            this.gPanelPersonel.Controls.Add(this.label16);
            this.gPanelPersonel.Controls.Add(this.buttonPersonelSil);
            this.gPanelPersonel.Controls.Add(this.buttonPersonelEkle);
            this.gPanelPersonel.Controls.Add(this.label11);
            this.gPanelPersonel.Controls.Add(this.guna2Panel3);
            this.gPanelPersonel.FillColor = System.Drawing.Color.White;
            this.gPanelPersonel.Location = new System.Drawing.Point(30, 44);
            this.gPanelPersonel.Name = "gPanelPersonel";
            this.gPanelPersonel.Size = new System.Drawing.Size(762, 241);
            this.gPanelPersonel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(487, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 28);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(483, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 20);
            this.label17.TabIndex = 50;
            this.label17.Text = "Departmanlar";
            // 
            // textBoxPersonelTCKimlikNo
            // 
            this.textBoxPersonelTCKimlikNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPersonelTCKimlikNo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPersonelTCKimlikNo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPersonelTCKimlikNo.Location = new System.Drawing.Point(240, 122);
            this.textBoxPersonelTCKimlikNo.MaxLength = 11;
            this.textBoxPersonelTCKimlikNo.Name = "textBoxPersonelTCKimlikNo";
            this.textBoxPersonelTCKimlikNo.Size = new System.Drawing.Size(216, 28);
            this.textBoxPersonelTCKimlikNo.TabIndex = 47;
            this.textBoxPersonelTCKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonelTCKimlikNo_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(236, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Personel T.C. Kimlik No";
            // 
            // buttonPersonelSil
            // 
            this.buttonPersonelSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPersonelSil.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelSil.Image = global::Company.Properties.Resources._003_user;
            this.buttonPersonelSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonelSil.Location = new System.Drawing.Point(79, 149);
            this.buttonPersonelSil.Name = "buttonPersonelSil";
            this.buttonPersonelSil.Size = new System.Drawing.Size(121, 39);
            this.buttonPersonelSil.TabIndex = 38;
            this.buttonPersonelSil.Text = "Sil";
            this.buttonPersonelSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPersonelSil.UseVisualStyleBackColor = true;
            this.buttonPersonelSil.Click += new System.EventHandler(this.buttonPersonelSil_Click);
            // 
            // buttonPersonelEkle
            // 
            this.buttonPersonelEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPersonelEkle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonelEkle.Image = global::Company.Properties.Resources._004_add_user;
            this.buttonPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPersonelEkle.Location = new System.Drawing.Point(79, 84);
            this.buttonPersonelEkle.Name = "buttonPersonelEkle";
            this.buttonPersonelEkle.Size = new System.Drawing.Size(121, 39);
            this.buttonPersonelEkle.TabIndex = 35;
            this.buttonPersonelEkle.Text = "Ekle";
            this.buttonPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPersonelEkle.UseVisualStyleBackColor = true;
            this.buttonPersonelEkle.Click += new System.EventHandler(this.buttonPersonelEkle_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(19, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "PERSONEL İŞLEMLERİ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.BorderRadius = 1;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Location = new System.Drawing.Point(23, 38);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 1);
            this.guna2Panel3.TabIndex = 32;
            // 
            // gPanelALT
            // 
            this.gPanelALT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gPanelALT.Location = new System.Drawing.Point(-10, 880);
            this.gPanelALT.Name = "gPanelALT";
            this.gPanelALT.Size = new System.Drawing.Size(762, 27);
            this.gPanelALT.TabIndex = 4;
            // 
            // DepartmanTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.gPanelALT);
            this.Controls.Add(this.gPanelPersonel);
            this.Controls.Add(this.gPanelDepartmanlar);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "DepartmanTablosu";
            this.Text = "DepartmanTablosu";
            this.Load += new System.EventHandler(this.DepartmanTablosu_Load);
            this.gPanelDepartmanlar.ResumeLayout(false);
            this.gPanelDepartmanlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.gPanelPersonel.ResumeLayout(false);
            this.gPanelPersonel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDepartmanlar;
        private Guna.UI2.WinForms.Guna2Panel gPanelDepartmanlar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label labelToplamPersonelSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTemizle;
        private Guna.UI2.WinForms.Guna2Panel gPanelPersonel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPersonelTCKimlikNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonPersonelSil;
        private System.Windows.Forms.Button buttonPersonelEkle;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelYoneticiIsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfo;
        private Guna.UI2.WinForms.Guna2Panel gPanelALT;
    }
}