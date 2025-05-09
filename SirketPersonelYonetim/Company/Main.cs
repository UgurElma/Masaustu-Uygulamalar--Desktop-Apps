using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Company
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        int id = 1;
        SqlDataReader sqlDataReader;
        SqlConnection sqlConnection;
        List<string> departmans = new List<string>();

        public Main()
        {
            InitializeComponent();
            random = new Random();
            buttonClose.Visible = false;
            buttonYenile.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index  = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    buttonClose.Visible = true;
                    buttonYenile.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void buttonKullaniciProfil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.PersonelProfile(), sender);
            id = 1;
        }

        private void buttonPersoneller_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.PersonelOperations(), sender);
            id = 2;
        }

        private void buttonDepartmanlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.DepartmanOperation(), sender);
            id = 3;
        }

        private void buttonProjeler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.ProjeOperation(), sender);
            id = 4;
        }

        private void buttonDepartmanTablolari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.DepartmanTablosu(), sender);
            id = 5;
        }

        private void buttonProjeTablolari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.ProjeTablosu(), sender);
            id = 6;
        }

        private void buttonYöneticiAyarlari_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.YoneticiAyarlari(), sender);
            id = 7;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            DateEkle();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            GetTheDepartments();
            Yetkilendirme();
            DateEkle();
            pictureBox1.ImageLocation = Login.logoYolu;
        }
        private void Yetkilendirme()
        {
            if (Login.yetkiDurumu == "0")
            {
                buttonPersoneller.Enabled = true;
                buttonYöneticiAyarlari.Enabled = true;
            }
            else if(Login.yetkiDurumu == "1")
            {
                foreach (Control control in panelMenu.Controls)
                {
                    if (control is Button && control.Text != "  Şirket Ayarları")
                    {
                        control.Enabled = true;
                    }
                }
            }
            else 
            {
                buttonKullaniciProfil.Enabled = true;
                if (Login.yetkiDurumu != "7")
                {
                    string[] karekterler = Login.yetkiDurumu.Split(',');
                    foreach (var s in karekterler)
                    {
                        if (int.TryParse(s, out int sayi))
                        {
                            if (sayi == 2)
                            {
                                buttonPersoneller.Enabled = true;
                                buttonDepartmanTablolari.Enabled = true;
                            }
                            if (sayi == 4)
                            {
                                buttonProjeler.Enabled = true;
                                buttonProjeTablolari.Enabled = true;
                                buttonDepartmanTablolari.Enabled = true;
                            }
                            if (sayi == 5)
                            {
                                buttonDepartmanlar.Enabled = true;
                                buttonDepartmanTablolari.Enabled = true;
                            }
                            if(sayi == 6)
                            {
                                buttonDepartmanTablolari.Enabled = true;
                            }
                        }
                    }
                }
                GetMyDepartments();
                GetMyProjectManager();
            }
        }
        private void GetMyProjectManager()
        {
            try
            {
                int toplam = GetTableCount("Projeler");
                for (int i = 0; i < toplam; i++)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@row", i);
                    cmd.Parameters.AddWithValue("@tckimlikno", Login.tcKimlikNo);
                    cmd.Parameters.AddWithValue("@column", "ProjeBaskaniTC");
                    cmd.Parameters.AddWithValue("@table", "Projeler");
                    sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        buttonProjeTablolari.Enabled = true;
                        sqlConnection.Close();
                        break;
                    }
                    sqlConnection.Close();
                }
            }
            catch
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        private int GetTableCount(string _name)
        {
            int count = 0;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("GetPersonelCount", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table_name", _name.Replace(" ", ""));
            sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
                count = sqlDataReader.GetInt32(0);
            sqlConnection.Close();
            return count;
        }
        private void GetMyDepartments()
        {
            try
            {
                for (int j = 0; j < departmans.Count; j++)
                {
                    int toplam = GetTableCount(departmans[j]);
                    for (int i = 0; i < toplam; i++)
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@row", i);
                        cmd.Parameters.AddWithValue("@tckimlikno", Login.tcKimlikNo);
                        cmd.Parameters.AddWithValue("@column", "TCKimlikNo");
                        cmd.Parameters.AddWithValue("@table", departmans[j].Replace(" ", ""));
                        sqlDataReader = cmd.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            if (departmans[j] == "İnsan Kaynakları")
                            {
                                buttonPersoneller.Enabled = true;
                            }
                            else if (departmans[j] == "Departman Yönetimi")
                            {
                                buttonDepartmanlar.Enabled = true;
                                buttonDepartmanTablolari.Enabled = true;
                            }
                            else if(departmans[j] == "Proje Yönetimi")
                            {
                                Login.yetkiDurumu += ",8,";
                                buttonProjeTablolari.Enabled = true;
                            }
                            sqlConnection.Close();
                            break;
                        }
                        sqlConnection.Close();
                    }
                }
            }
            catch
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void GetTheDepartments()
        {
            try
            {
                sqlConnection.Open();
                int i = 0;
                while (true)
                {
                    SqlCommand cmd = new SqlCommand("GetDepartmanName", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@row", i);
                    cmd.Parameters.AddWithValue("@column", "DepartmanIsmi");
                    cmd.Parameters.AddWithValue("@table", "Departman");
                    sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        departmans.Add(sqlDataReader[0].ToString());
                    }
                    else
                    {
                        break;
                    }
                    sqlDataReader.Close();
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Departmanlar alınamadı! Sayfayı yenileyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void DateEkle()
        {
            labelDate.Text = DateTime.Now.ToString();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            panelTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonClose.Visible = false;
            buttonYenile.Visible = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            buttonClose_Click(sender, e);
            if (id == 1)
                buttonKullaniciProfil_Click(buttonKullaniciProfil, e);
            else if (id == 2)
                buttonPersoneller_Click(buttonPersoneller, e);
            else if (id == 3)
                buttonDepartmanlar_Click(buttonDepartmanlar, e);
            else if (id == 4)
                buttonProjeler_Click(buttonProjeler, e);
            else if (id == 5)
                buttonDepartmanTablolari_Click(buttonDepartmanTablolari, e);
            else if (id == 6)
                buttonProjeTablolari_Click(buttonProjeTablolari, e);
            else if(id == 7)
                buttonYöneticiAyarlari_Click(buttonYöneticiAyarlari, e);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istermisiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonMaximazed_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMinimazied_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
