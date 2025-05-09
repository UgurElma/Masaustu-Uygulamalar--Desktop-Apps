using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class YoneticiAyarlari : Form
    {
        public YoneticiAyarlari()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pictureBoxLogo.ImageLocation = ofd.FileName;
        }

        private void YoneticiAyarlari_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            textBoxAdminID.Text = Login.adminID;
            textBoxAdSoyad.Text = Login.adminAdSoyad;
            textBoxKurulusTarihi.Text = Login.kurulusTarihi;
            textBoxSirketName.Text = Login.sirketIsmi;
            pictureBoxLogo.ImageLocation = Login.logoYolu;
        }

        private void buttonSirketiGuncelle_Click(object sender, EventArgs e)
        {
            if(textBoxNewAdSoyad.Text == string.Empty && textBoxSirketIsmı.Text == string.Empty)
                return;
            if (textBoxNewAdSoyad.Text == string.Empty)
                textBoxNewAdSoyad.Text = textBoxAdSoyad.Text;
            if (textBoxSirketIsmı.Text == string.Empty)
                textBoxSirketIsmı.Text = textBoxSirketName.Text;
            if(pictureBoxLogo.ImageLocation == string.Empty)
                pictureBoxLogo.ImageLocation = Login.logoYolu;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SetSirketHakkinda", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@adminID", Login.adminID);
                sqlCommand.Parameters.AddWithValue("@adminAdSoyad", textBoxNewAdSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@sirketIsmi", textBoxSirketIsmı.Text);
                sqlCommand.Parameters.AddWithValue("@logoYolu", pictureBoxLogo.ImageLocation);
                sqlCommand.ExecuteReader();
                MessageBox.Show("Güncelleme başarılı oldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login.adminAdSoyad = textBoxNewAdSoyad.Text;
                Login.sirketIsmi = textBoxSirketIsmı.Text;
            }
            catch
            {
                MessageBox.Show("Güncelleme başarısız oldu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void buttonAtama_Click(object sender, EventArgs e)
        {
            if(textBoxPersonelTC.Text == string.Empty)
            {
                MessageBox.Show("Personel T.C. kimlik numarası giriniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                string _index = GetPersonelInfo();
                if (_index == "False")
                {
                    SqlCommand cmd = new SqlCommand("SetYonetici", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxPersonelTC.Text);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    sqlDataReader.Close();
                    MessageBox.Show(textBoxPersonelTC.Text + " numaralı personel, yönetici oldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPersonelTC.Text = string.Empty;
                }
                else if (_index == null)
                {
                    MessageBox.Show("Böyle bir kullanıcı yok! T.C. kimlik numarasını konrol edip tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı zaten yönetici! T.C. kimlik numarasını konrol edip tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı sorunu. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                if (sqlConnection != null) {  sqlConnection.Close(); } 
            }
        }

        private void buttonSilme_Click(object sender, EventArgs e)
        {
            if (textBoxPersonelTC.Text == string.Empty)
            {
                MessageBox.Show("Personel T.C. kimlik numarası giriniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                string _index = GetPersonelInfo();
                if(_index == "True")
                {
                    SqlCommand cmd = new SqlCommand("DeleteYonetici", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxPersonelTC.Text);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    sqlDataReader.Close();
                    MessageBox.Show(textBoxPersonelTC.Text + " numaralı yönetici, personel oldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPersonelTC.Text = string.Empty;
                }
                else if(_index == null)
                {
                    MessageBox.Show("Böyle bir kullanıcı yok! T.C. kimlik numarasını konrol edip tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı zaten personel! T.C. kimlik numarasını konrol edip tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı sorunu. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null) { sqlConnection.Close(); }
            }
        }
        private string GetPersonelInfo()
        {
            string index;
            SqlCommand sqlCommand = new SqlCommand("FindPersonelInfo", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@TCKimlikNo", textBoxPersonelTC.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                index = reader[9].ToString();
            }
            else
            {
                index = null;
            }
            reader.Close();
            return index;
        }
    }
}
