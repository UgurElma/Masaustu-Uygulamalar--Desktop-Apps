namespace UserScene
{
    partial class FormUserScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserScene));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.groupBoxBG = new System.Windows.Forms.GroupBox();
            this.panelOperation = new System.Windows.Forms.Panel();
            this.checkBoxControl = new System.Windows.Forms.CheckBox();
            this.radioButtonLoadMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelNumLock = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.groupBoxBG.SuspendLayout();
            this.panelOperation.SuspendLayout();
            this.panelNumLock.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxID.Location = new System.Drawing.Point(86, 42);
            this.textBoxID.MaxLength = 8;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(186, 27);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.Text = "Enter your id...";
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.Enter += new System.EventHandler(this.textBoxID_Enter);
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIndex.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxIndex.Location = new System.Drawing.Point(67, 146);
            this.textBoxIndex.MaxLength = 2;
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(62, 27);
            this.textBoxIndex.TabIndex = 6;
            this.textBoxIndex.Text = "index";
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIndex.Visible = false;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            this.textBoxIndex.Enter += new System.EventHandler(this.textBoxIndex_Enter);
            this.textBoxIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIndex_KeyPress);
            this.textBoxIndex.Leave += new System.EventHandler(this.textBoxIndex_Leave);
            // 
            // groupBoxBG
            // 
            this.groupBoxBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBG.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxBG.Controls.Add(this.panelOperation);
            this.groupBoxBG.Controls.Add(this.labelBalance);
            this.groupBoxBG.Controls.Add(this.panelNumLock);
            this.groupBoxBG.Controls.Add(this.buttonFinish);
            this.groupBoxBG.Location = new System.Drawing.Point(113, 78);
            this.groupBoxBG.Name = "groupBoxBG";
            this.groupBoxBG.Size = new System.Drawing.Size(990, 545);
            this.groupBoxBG.TabIndex = 2;
            this.groupBoxBG.TabStop = false;
            this.groupBoxBG.Text = "Setup Machine";
            // 
            // panelOperation
            // 
            this.panelOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOperation.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelOperation.Controls.Add(this.checkBoxControl);
            this.panelOperation.Controls.Add(this.radioButtonLoadMoney);
            this.panelOperation.Controls.Add(this.radioButtonBuy);
            this.panelOperation.Controls.Add(this.textBoxAmount);
            this.panelOperation.Controls.Add(this.textBoxIndex);
            this.panelOperation.Controls.Add(this.textBoxID);
            this.panelOperation.Location = new System.Drawing.Point(120, 148);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(358, 271);
            this.panelOperation.TabIndex = 9;
            // 
            // checkBoxControl
            // 
            this.checkBoxControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxControl.AutoSize = true;
            this.checkBoxControl.ForeColor = System.Drawing.Color.YellowGreen;
            this.checkBoxControl.Location = new System.Drawing.Point(225, 203);
            this.checkBoxControl.Name = "checkBoxControl";
            this.checkBoxControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxControl.Size = new System.Drawing.Size(92, 24);
            this.checkBoxControl.TabIndex = 8;
            this.checkBoxControl.Text = "Control";
            this.checkBoxControl.UseVisualStyleBackColor = true;
            this.checkBoxControl.Visible = false;
            // 
            // radioButtonLoadMoney
            // 
            this.radioButtonLoadMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonLoadMoney.AutoSize = true;
            this.radioButtonLoadMoney.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonLoadMoney.FlatAppearance.BorderSize = 0;
            this.radioButtonLoadMoney.ForeColor = System.Drawing.Color.YellowGreen;
            this.radioButtonLoadMoney.Location = new System.Drawing.Point(188, 94);
            this.radioButtonLoadMoney.Name = "radioButtonLoadMoney";
            this.radioButtonLoadMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonLoadMoney.Size = new System.Drawing.Size(131, 24);
            this.radioButtonLoadMoney.TabIndex = 5;
            this.radioButtonLoadMoney.TabStop = true;
            this.radioButtonLoadMoney.Text = "Load Money";
            this.radioButtonLoadMoney.UseVisualStyleBackColor = true;
            this.radioButtonLoadMoney.Visible = false;
            this.radioButtonLoadMoney.CheckedChanged += new System.EventHandler(this.radioButtonLoadMoney_CheckedChanged);
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonBuy.Location = new System.Drawing.Point(58, 94);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(62, 24);
            this.radioButtonBuy.TabIndex = 4;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.Visible = false;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAmount.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxAmount.Location = new System.Drawing.Point(235, 146);
            this.textBoxAmount.MaxLength = 3;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(62, 27);
            this.textBoxAmount.TabIndex = 7;
            this.textBoxAmount.Text = "--";
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAmount.Visible = false;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            this.textBoxAmount.Enter += new System.EventHandler(this.textBoxAmount_Enter);
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            this.textBoxAmount.Leave += new System.EventHandler(this.textBoxAmount_Leave);
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBalance.AutoSize = true;
            this.labelBalance.ForeColor = System.Drawing.Color.Gold;
            this.labelBalance.Location = new System.Drawing.Point(689, 50);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(126, 20);
            this.labelBalance.TabIndex = 7;
            this.labelBalance.Text = "Bakiye: --- TL";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNumLock
            // 
            this.panelNumLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNumLock.BackColor = System.Drawing.Color.AliceBlue;
            this.panelNumLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNumLock.Controls.Add(this.buttonDelete);
            this.panelNumLock.Controls.Add(this.buttonConfirm);
            this.panelNumLock.Controls.Add(this.buttonThree);
            this.panelNumLock.Controls.Add(this.buttonSix);
            this.panelNumLock.Controls.Add(this.buttonNine);
            this.panelNumLock.Controls.Add(this.buttonZero);
            this.panelNumLock.Controls.Add(this.buttonTwo);
            this.panelNumLock.Controls.Add(this.buttonOne);
            this.panelNumLock.Controls.Add(this.buttonFive);
            this.panelNumLock.Controls.Add(this.buttonFour);
            this.panelNumLock.Controls.Add(this.buttonEight);
            this.panelNumLock.Controls.Add(this.buttonSeven);
            this.panelNumLock.Controls.Add(this.buttonClear);
            this.panelNumLock.Location = new System.Drawing.Point(578, 111);
            this.panelNumLock.Name = "panelNumLock";
            this.panelNumLock.Size = new System.Drawing.Size(350, 337);
            this.panelNumLock.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(123, 273);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirm.BackColor = System.Drawing.Color.Green;
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(236, 273);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 50);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThree.BackColor = System.Drawing.Color.Azure;
            this.buttonThree.Location = new System.Drawing.Point(236, 141);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(60, 60);
            this.buttonThree.TabIndex = 1;
            this.buttonThree.TabStop = false;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSix.BackColor = System.Drawing.Color.Azure;
            this.buttonSix.Location = new System.Drawing.Point(236, 77);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(60, 60);
            this.buttonSix.TabIndex = 1;
            this.buttonSix.TabStop = false;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNine.BackColor = System.Drawing.Color.Azure;
            this.buttonNine.Location = new System.Drawing.Point(236, 11);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(60, 60);
            this.buttonNine.TabIndex = 1;
            this.buttonNine.TabStop = false;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonZero.BackColor = System.Drawing.Color.Azure;
            this.buttonZero.Location = new System.Drawing.Point(143, 207);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(60, 60);
            this.buttonZero.TabIndex = 1;
            this.buttonZero.TabStop = false;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTwo.BackColor = System.Drawing.Color.Azure;
            this.buttonTwo.Location = new System.Drawing.Point(143, 141);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(60, 60);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.TabStop = false;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOne.BackColor = System.Drawing.Color.Azure;
            this.buttonOne.Location = new System.Drawing.Point(50, 141);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(60, 60);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.TabStop = false;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFive.BackColor = System.Drawing.Color.Azure;
            this.buttonFive.Location = new System.Drawing.Point(143, 77);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(60, 60);
            this.buttonFive.TabIndex = 1;
            this.buttonFive.TabStop = false;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFour.BackColor = System.Drawing.Color.Azure;
            this.buttonFour.Location = new System.Drawing.Point(50, 77);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(60, 60);
            this.buttonFour.TabIndex = 1;
            this.buttonFour.TabStop = false;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEight.BackColor = System.Drawing.Color.Azure;
            this.buttonEight.Location = new System.Drawing.Point(143, 11);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(60, 60);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.TabStop = false;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSeven.BackColor = System.Drawing.Color.Azure;
            this.buttonSeven.Location = new System.Drawing.Point(50, 11);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(60, 60);
            this.buttonSeven.TabIndex = 1;
            this.buttonSeven.TabStop = false;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.BackColor = System.Drawing.Color.Olive;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(10, 273);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 50);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.ForeColor = System.Drawing.Color.Gold;
            this.labelCompanyName.Location = new System.Drawing.Point(38, 18);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(140, 20);
            this.labelCompanyName.TabIndex = 7;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFinish.ForeColor = System.Drawing.Color.White;
            this.buttonFinish.Location = new System.Drawing.Point(251, 437);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(100, 50);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Finish Operation";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Visible = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormUserScene
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UserScene.Properties.Resources.backgorund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.groupBoxBG);
            this.Controls.Add(this.labelCompanyName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormUserScene_Load);
            this.groupBoxBG.ResumeLayout(false);
            this.groupBoxBG.PerformLayout();
            this.panelOperation.ResumeLayout(false);
            this.panelOperation.PerformLayout();
            this.panelNumLock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.GroupBox groupBoxBG;
        private System.Windows.Forms.Panel panelNumLock;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.RadioButton radioButtonLoadMoney;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.CheckBox checkBoxControl;
        private System.Windows.Forms.Panel panelOperation;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonFinish;
    }
}

