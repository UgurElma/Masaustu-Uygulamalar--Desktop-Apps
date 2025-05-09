using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Company
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string tcKimlikNo, sifre, adsoyad, tlfno, email, dogumtarihi, cinsiyet, maas, adres, yetkiDurumu;
        public static string adminID, adminAdSoyad, kurulusTarihi, sirketIsmi, logoYolu;
        public static string connString = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=CompanyManager;Integrated Security=True;";
        SqlConnection sqlConnection;
        Main main;

        private void textBoxUserID_Enter(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "T.C. kimlik numarası")
            {
                textBoxUserID.Text = string.Empty;
                textBoxUserID.ForeColor = Color.Black;
            }
        }

        private void textBoxUserID_Leave(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == string.Empty)
            {
                textBoxUserID.Text = "T.C. kimlik numarası";
                textBoxUserID.ForeColor = Color.Silver;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxUserID.Text = string.Empty;
            textBoxUserPin.Text = string.Empty;
            textBoxUserID_Leave(sender, e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == adminID)
            {
                if(textBoxUserPin.Text == sifre)
                {
                    yetkiDurumu = "0";
                    MessageBox.Show("Admin giriş yapıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tcKimlikNo = adminID;
                    main = new Main();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("FindPersonelInfo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TCKimlikNo", textBoxUserID.Text);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    if (textBoxUserPin.Text == sqlDataReader[1].ToString())
                    {
                        tcKimlikNo = sqlDataReader[0].ToString();
                        sifre = sqlDataReader[1].ToString();
                        adsoyad = sqlDataReader[2].ToString();
                        tlfno = sqlDataReader[3].ToString();
                        email = sqlDataReader[4].ToString();
                        adres = sqlDataReader[5].ToString();
                        cinsiyet = sqlDataReader[6].ToString();
                        dogumtarihi = sqlDataReader[7].ToString();
                        maas = sqlDataReader[8].ToString();
                        if (Convert.ToBoolean(sqlDataReader[9]) == false)
                        {
                            sqlDataReader.Close();
                            DepartmanYoneticisiMi();
                        }
                        else
                        {
                            MessageBox.Show("Yönetici girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            yetkiDurumu = "1";
                        }
                        main = new Main();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yanlış şifre girdiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış T.C. kimlik numarası girdiniz!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
        }

        private void DepartmanYoneticisiMi()
        {
            try
            {
                int i = 0;
                while (true)
                {
                    SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@row", i);
                    cmd.Parameters.AddWithValue("@tckimlikno", textBoxUserID.Text);
                    cmd.Parameters.AddWithValue("@column", "YoneticiTC");
                    cmd.Parameters.AddWithValue("@table", "Departman");
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        if (sqlDataReader[0].ToString() == "İnsan Kaynakları")
                        {
                            if (yetkiDurumu == "6")
                                yetkiDurumu = null;
                            yetkiDurumu += "2,";
                            MessageBox.Show("İnsan Kaynakları yöneticisi girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (sqlDataReader[0].ToString() == "Proje Yönetimi")
                        {
                            if (yetkiDurumu == "6")
                                yetkiDurumu = null;
                            yetkiDurumu += "4,";
                            MessageBox.Show("Proje Yönetimi yöneticisi girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (sqlDataReader[0].ToString() == "Departman Yönetimi")
                        {
                            if (yetkiDurumu == "6")
                                yetkiDurumu = null;
                            yetkiDurumu += "5,";
                            MessageBox.Show("Departman Yönetimi yöneticisi girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (yetkiDurumu == null)
                            {
                                yetkiDurumu = "6";
                                MessageBox.Show("Departman yöneticisi girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        if (yetkiDurumu == null)
                        {
                            yetkiDurumu = "7";
                            MessageBox.Show("Personel girişi yapılıyor...", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        sqlDataReader.Close();
                        break;
                    }
                    sqlDataReader.Close();
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Personel bulunamadı! Admin ile iletişime geçiniz.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connString);
            yetkiDurumu = null;
            GetSirketHakkinda();
        }

        private void GetSirketHakkinda()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("GetSirketHakkinda", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                adminID = sqlDataReader[0].ToString();
                sifre = sqlDataReader[1].ToString();
                adminAdSoyad = sqlDataReader[2].ToString();
                kurulusTarihi = sqlDataReader[3].ToString();
                sirketIsmi = sqlDataReader[4].ToString();
                logoYolu = sqlDataReader[5].ToString();
            }
            sqlDataReader.Close();
            sqlConnection.Close();
            labelCompanyName.Text = sirketIsmi;
            if (logoYolu != string.Empty)
                gPictureBoxLogo.ImageLocation = logoYolu;
        }

        private void textBoxUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxUserPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(gPanelPasswords.Visible)
            {
                textBoxTCKimlikNo.Text = string.Empty;
                textBoxTCKimlikNo_Leave(sender, e);
                gPanelPasswords.Visible = false;
            }
            else
            {
                gPanelPasswords.Visible = true;
            }
        }

        private void textBoxTCKimlikNo_Enter(object sender, EventArgs e)
        {
            if (textBoxTCKimlikNo.Text == "T.C. kimlik numarası")
            {
                textBoxTCKimlikNo.Text = string.Empty;
                textBoxTCKimlikNo.ForeColor = Color.Black;
            }
        }

        private void textBoxTCKimlikNo_Leave(object sender, EventArgs e)
        {
            if (textBoxTCKimlikNo.Text == string.Empty)
            {
                textBoxTCKimlikNo.Text = "T.C. kimlik numarası";
                textBoxTCKimlikNo.ForeColor = Color.Silver;
            }
        }

        private void textBoxTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void buttonGönder_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("FindPersonelInfo", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    var fromAddress = new MailAddress("ugurgamecenter@gmail.com", "Admin");
                    var toAddress = new MailAddress(sqlDataReader[4].ToString(), sqlDataReader[2].ToString());
                    const string fromPassword = "xtcpyujqrrdwonjk";
                    const string subject = "Şifre alma isteği";
                    string body = "Senin uygulamaya giriş şifren: " + sqlDataReader[1].ToString();
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = true,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Şifreniz, sitemde kayıtlı email hesabınıza en kısa süre içerisinde atılacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gPanelPasswords.Visible = false;
                }
                else
                {
                    MessageBox.Show("Yanlış T.C. kimlik numarası girdiniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("İstek gönderimi başarısız! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null) { sqlConnection.Close(); }
            }
        }
    }
}
