namespace AutomatManager.UserControls
{
    partial class UC_Machine
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonFDEMachine = new System.Windows.Forms.Button();
            this.buttonAddMachine = new System.Windows.Forms.Button();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonFDEMachine);
            this.panelMenu.Controls.Add(this.buttonAddMachine);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(120, 493);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonFDEMachine
            // 
            this.buttonFDEMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFDEMachine.FlatAppearance.BorderSize = 0;
            this.buttonFDEMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFDEMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFDEMachine.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFDEMachine.Location = new System.Drawing.Point(0, 60);
            this.buttonFDEMachine.Name = "buttonFDEMachine";
            this.buttonFDEMachine.Size = new System.Drawing.Size(120, 60);
            this.buttonFDEMachine.TabIndex = 1;
            this.buttonFDEMachine.Text = "Find Delete Edit";
            this.buttonFDEMachine.UseVisualStyleBackColor = true;
            this.buttonFDEMachine.Click += new System.EventHandler(this.buttonFDEMachine_Click);
            // 
            // buttonAddMachine
            // 
            this.buttonAddMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddMachine.FlatAppearance.BorderSize = 0;
            this.buttonAddMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddMachine.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddMachine.Location = new System.Drawing.Point(0, 0);
            this.buttonAddMachine.Name = "buttonAddMachine";
            this.buttonAddMachine.Size = new System.Drawing.Size(120, 60);
            this.buttonAddMachine.TabIndex = 0;
            this.buttonAddMachine.Text = "Add";
            this.buttonAddMachine.UseVisualStyleBackColor = true;
            this.buttonAddMachine.Click += new System.EventHandler(this.buttonAddMachine_Click);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackgroundImage = global::AutomatManager.Properties.Resources.cabinetvendingmachine;
            this.panelDesktopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(120, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(981, 493);
            this.panelDesktopPanel.TabIndex = 1;
            // 
            // UC_Machine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "UC_Machine";
            this.Size = new System.Drawing.Size(1101, 493);
            this.Load += new System.EventHandler(this.UC_Machine_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAddMachine;
        private System.Windows.Forms.Button buttonFDEMachine;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}
