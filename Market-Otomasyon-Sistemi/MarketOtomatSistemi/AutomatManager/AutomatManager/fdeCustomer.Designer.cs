namespace AutomatManager
{
    partial class fdeCustomer
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
            this.gButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.gButtonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.gButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.gButtonFind = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gTextBoxIdFDE = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gTextBoxNameAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTextBoxPhoneAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTextBoxBalanceAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTextBoxSurnameAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gButtonClear
            // 
            this.gButtonClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonClear.BackColor = System.Drawing.Color.DarkKhaki;
            this.gButtonClear.BorderRadius = 10;
            this.gButtonClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonClear.FillColor = System.Drawing.Color.Transparent;
            this.gButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonClear.ForeColor = System.Drawing.Color.White;
            this.gButtonClear.Location = new System.Drawing.Point(17, 187);
            this.gButtonClear.Name = "gButtonClear";
            this.gButtonClear.Size = new System.Drawing.Size(180, 45);
            this.gButtonClear.TabIndex = 30;
            this.gButtonClear.Text = "Clear";
            this.gButtonClear.Click += new System.EventHandler(this.gButtonClear_Click);
            // 
            // gButtonEdit
            // 
            this.gButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gButtonEdit.BorderRadius = 10;
            this.gButtonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonEdit.FillColor = System.Drawing.Color.Transparent;
            this.gButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonEdit.ForeColor = System.Drawing.Color.White;
            this.gButtonEdit.Image = global::AutomatManager.Properties.Resources.edit;
            this.gButtonEdit.Location = new System.Drawing.Point(17, 88);
            this.gButtonEdit.Name = "gButtonEdit";
            this.gButtonEdit.Size = new System.Drawing.Size(180, 45);
            this.gButtonEdit.TabIndex = 27;
            this.gButtonEdit.Text = "Edit";
            this.gButtonEdit.Click += new System.EventHandler(this.gButtonEdit_Click);
            // 
            // gButtonDelete
            // 
            this.gButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gButtonDelete.BorderRadius = 10;
            this.gButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonDelete.FillColor = System.Drawing.Color.Transparent;
            this.gButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonDelete.ForeColor = System.Drawing.Color.White;
            this.gButtonDelete.Image = global::AutomatManager.Properties.Resources.delete;
            this.gButtonDelete.Location = new System.Drawing.Point(203, 187);
            this.gButtonDelete.Name = "gButtonDelete";
            this.gButtonDelete.Size = new System.Drawing.Size(180, 45);
            this.gButtonDelete.TabIndex = 29;
            this.gButtonDelete.Text = "Delete";
            this.gButtonDelete.Click += new System.EventHandler(this.gButtonDelete_Click);
            // 
            // gButtonFind
            // 
            this.gButtonFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gButtonFind.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gButtonFind.BorderRadius = 10;
            this.gButtonFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gButtonFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gButtonFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gButtonFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gButtonFind.FillColor = System.Drawing.Color.Transparent;
            this.gButtonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gButtonFind.ForeColor = System.Drawing.Color.White;
            this.gButtonFind.Image = global::AutomatManager.Properties.Resources.find;
            this.gButtonFind.Location = new System.Drawing.Point(203, 88);
            this.gButtonFind.Name = "gButtonFind";
            this.gButtonFind.Size = new System.Drawing.Size(180, 45);
            this.gButtonFind.TabIndex = 28;
            this.gButtonFind.Text = "Find";
            this.gButtonFind.Click += new System.EventHandler(this.gButtonFind_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(115, 22);
            this.guna2HtmlLabel1.TabIndex = 32;
            this.guna2HtmlLabel1.Text = "Customer ID:";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gTextBoxIdFDE
            // 
            this.gTextBoxIdFDE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxIdFDE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxIdFDE.BorderRadius = 10;
            this.gTextBoxIdFDE.BorderThickness = 3;
            this.gTextBoxIdFDE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxIdFDE.DefaultText = "";
            this.gTextBoxIdFDE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxIdFDE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxIdFDE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxIdFDE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxIdFDE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxIdFDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxIdFDE.ForeColor = System.Drawing.Color.SteelBlue;
            this.gTextBoxIdFDE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxIdFDE.Location = new System.Drawing.Point(162, 23);
            this.gTextBoxIdFDE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxIdFDE.MaxLength = 8;
            this.gTextBoxIdFDE.Name = "gTextBoxIdFDE";
            this.gTextBoxIdFDE.PasswordChar = '\0';
            this.gTextBoxIdFDE.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxIdFDE.PlaceholderText = "Enter id...";
            this.gTextBoxIdFDE.SelectedText = "";
            this.gTextBoxIdFDE.Size = new System.Drawing.Size(180, 36);
            this.gTextBoxIdFDE.TabIndex = 22;
            this.gTextBoxIdFDE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxIdFDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxIdFDE_KeyPress);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(450, 216);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(119, 22);
            this.guna2HtmlLabel6.TabIndex = 44;
            this.guna2HtmlLabel6.Text = "Balance (TL):";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(450, 92);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(192, 22);
            this.guna2HtmlLabel5.TabIndex = 45;
            this.guna2HtmlLabel5.Text = "Surname of Customer:";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(450, 154);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(132, 22);
            this.guna2HtmlLabel4.TabIndex = 46;
            this.guna2HtmlLabel4.Text = "Phone Number:";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(450, 30);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(166, 22);
            this.guna2HtmlLabel2.TabIndex = 47;
            this.guna2HtmlLabel2.Text = "Name of Customer:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gTextBoxNameAdd
            // 
            this.gTextBoxNameAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxNameAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxNameAdd.BorderRadius = 10;
            this.gTextBoxNameAdd.BorderThickness = 3;
            this.gTextBoxNameAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxNameAdd.DefaultText = "";
            this.gTextBoxNameAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxNameAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxNameAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxNameAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxNameAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxNameAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.gTextBoxNameAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxNameAdd.Location = new System.Drawing.Point(700, 23);
            this.gTextBoxNameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxNameAdd.MaxLength = 20;
            this.gTextBoxNameAdd.Name = "gTextBoxNameAdd";
            this.gTextBoxNameAdd.PasswordChar = '\0';
            this.gTextBoxNameAdd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxNameAdd.PlaceholderText = "Eg:Ali";
            this.gTextBoxNameAdd.SelectedText = "";
            this.gTextBoxNameAdd.Size = new System.Drawing.Size(180, 36);
            this.gTextBoxNameAdd.TabIndex = 23;
            this.gTextBoxNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxNameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxNameAdd_KeyPress);
            // 
            // gTextBoxPhoneAdd
            // 
            this.gTextBoxPhoneAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxPhoneAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxPhoneAdd.BorderRadius = 10;
            this.gTextBoxPhoneAdd.BorderThickness = 3;
            this.gTextBoxPhoneAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxPhoneAdd.DefaultText = "";
            this.gTextBoxPhoneAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxPhoneAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxPhoneAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxPhoneAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxPhoneAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxPhoneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxPhoneAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.gTextBoxPhoneAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxPhoneAdd.Location = new System.Drawing.Point(700, 147);
            this.gTextBoxPhoneAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxPhoneAdd.MaxLength = 10;
            this.gTextBoxPhoneAdd.Name = "gTextBoxPhoneAdd";
            this.gTextBoxPhoneAdd.PasswordChar = '\0';
            this.gTextBoxPhoneAdd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxPhoneAdd.PlaceholderText = "Eg: 545XXXXXXX";
            this.gTextBoxPhoneAdd.SelectedText = "";
            this.gTextBoxPhoneAdd.Size = new System.Drawing.Size(180, 36);
            this.gTextBoxPhoneAdd.TabIndex = 25;
            this.gTextBoxPhoneAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxPhoneAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxPhoneAdd_KeyPress);
            // 
            // gTextBoxBalanceAdd
            // 
            this.gTextBoxBalanceAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxBalanceAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxBalanceAdd.BorderRadius = 10;
            this.gTextBoxBalanceAdd.BorderThickness = 3;
            this.gTextBoxBalanceAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxBalanceAdd.DefaultText = "";
            this.gTextBoxBalanceAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxBalanceAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxBalanceAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxBalanceAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxBalanceAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxBalanceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxBalanceAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.gTextBoxBalanceAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxBalanceAdd.Location = new System.Drawing.Point(700, 209);
            this.gTextBoxBalanceAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxBalanceAdd.Name = "gTextBoxBalanceAdd";
            this.gTextBoxBalanceAdd.PasswordChar = '\0';
            this.gTextBoxBalanceAdd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxBalanceAdd.PlaceholderText = "Eg: 0 - 300";
            this.gTextBoxBalanceAdd.SelectedText = "";
            this.gTextBoxBalanceAdd.Size = new System.Drawing.Size(180, 36);
            this.gTextBoxBalanceAdd.TabIndex = 26;
            this.gTextBoxBalanceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxBalanceAdd.TextChanged += new System.EventHandler(this.gTextBoxBalanceAdd_TextChanged);
            this.gTextBoxBalanceAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxBalanceAdd_KeyPress);
            // 
            // gTextBoxSurnameAdd
            // 
            this.gTextBoxSurnameAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gTextBoxSurnameAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxSurnameAdd.BorderRadius = 10;
            this.gTextBoxSurnameAdd.BorderThickness = 3;
            this.gTextBoxSurnameAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTextBoxSurnameAdd.DefaultText = "";
            this.gTextBoxSurnameAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTextBoxSurnameAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTextBoxSurnameAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxSurnameAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTextBoxSurnameAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxSurnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.gTextBoxSurnameAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.gTextBoxSurnameAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTextBoxSurnameAdd.Location = new System.Drawing.Point(700, 85);
            this.gTextBoxSurnameAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gTextBoxSurnameAdd.Name = "gTextBoxSurnameAdd";
            this.gTextBoxSurnameAdd.PasswordChar = '\0';
            this.gTextBoxSurnameAdd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gTextBoxSurnameAdd.PlaceholderText = "Eg:Dağ";
            this.gTextBoxSurnameAdd.SelectedText = "";
            this.gTextBoxSurnameAdd.Size = new System.Drawing.Size(180, 36);
            this.gTextBoxSurnameAdd.TabIndex = 24;
            this.gTextBoxSurnameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gTextBoxSurnameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gTextBoxSurnameAdd_KeyPress);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(55, 310);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(876, 159);
            this.dataGridViewCustomer.TabIndex = 48;
            this.dataGridViewCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMachine_CellEnter);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMan.ForeColor = System.Drawing.Color.MediumPurple;
            this.radioButtonMan.Location = new System.Drawing.Point(812, 273);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(65, 24);
            this.radioButtonMan.TabIndex = 51;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonWoman.ForeColor = System.Drawing.Color.MediumPurple;
            this.radioButtonWoman.Location = new System.Drawing.Point(700, 273);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(92, 24);
            this.radioButtonWoman.TabIndex = 50;
            this.radioButtonWoman.Text = "Woman";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(450, 271);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlLabel3.TabIndex = 49;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Gender:";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fdeCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(981, 493);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.gTextBoxNameAdd);
            this.Controls.Add(this.gTextBoxPhoneAdd);
            this.Controls.Add(this.gTextBoxBalanceAdd);
            this.Controls.Add(this.gTextBoxSurnameAdd);
            this.Controls.Add(this.gButtonClear);
            this.Controls.Add(this.gButtonEdit);
            this.Controls.Add(this.gButtonDelete);
            this.Controls.Add(this.gButtonFind);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gTextBoxIdFDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fdeCustomer";
            this.Text = "fdeCustomer";
            this.Load += new System.EventHandler(this.fdeCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button gButtonClear;
        private Guna.UI2.WinForms.Guna2Button gButtonEdit;
        private Guna.UI2.WinForms.Guna2Button gButtonDelete;
        private Guna.UI2.WinForms.Guna2Button gButtonFind;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxIdFDE;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxNameAdd;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxPhoneAdd;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxBalanceAdd;
        private Guna.UI2.WinForms.Guna2TextBox gTextBoxSurnameAdd;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}