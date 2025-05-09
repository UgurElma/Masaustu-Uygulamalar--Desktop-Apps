using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class PersonelProfile : Form
    {
        public PersonelProfile()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        List<string> departmans = new List<string>();
        int _id;

        private void PersonelProfile_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            GetTheDepartments();
            GetPersonelInfo();
            GetPersonelEmails();
            GetMyDepartments();
            GetMyProjects();
        }
        private void GetMyProjects()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetMyProjects", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tckimlikno", Login.tcKimlikNo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView2.DataSource = dt;
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
            if(sqlDataReader.Read())
                count = sqlDataReader.GetInt32(0);
            sqlConnection.Close();
            return count;
        }
        private void GetMyDepartments()
        {
            try
            {
                for(int j = 0; j < departmans.Count; j++)
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
                            comboBoxDepartmanlarim.Items.Add(departmans[j]);
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

        private void GetPersonelEmails()
        {
            comboBoxGonderen.Items.Add(Login.email);
            comboBoxGelenler.Items.Add(Login.email);
            try
            {
                int i = 0;
                while (true)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@row", i);
                    cmd.Parameters.AddWithValue("@tckimlikno", Login.tcKimlikNo);
                    cmd.Parameters.AddWithValue("@column", "YoneticiTC");
                    cmd.Parameters.AddWithValue("@table", "Departman");
                    sqlDataReader = cmd.ExecuteReader();
                    if(sqlDataReader.Read())
                    {
                        comboBoxGonderen.Items.Add(sqlDataReader[2].ToString());
                        comboBoxGelenler.Items.Add(sqlDataReader[2].ToString());
                    }
                    else
                    {
                        break;
                    }
                    sqlConnection.Close(); 
                    i++;
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

        private void GetEmailTable()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetEmailTable", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aliciEmail", comboBoxGelenler.SelectedItem);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
            }
            catch
            {
                MessageBox.Show("Gelen mesajlar alınırken hata oluştu! Sayfayı yenileyiniz.", "Gelen Kutusu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void GetPersonelInfo()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("FindPersonelInfo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TCKimlikNo", Login.tcKimlikNo);
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    Login.sifre = sqlDataReader[1].ToString();
                    Login.adsoyad = sqlDataReader[2].ToString();
                    Login.tlfno = sqlDataReader[3].ToString();
                    Login.email = sqlDataReader[4].ToString();
                    Login.adres = sqlDataReader[5].ToString();
                    Login.cinsiyet = sqlDataReader[6].ToString();
                    Login.dogumtarihi = sqlDataReader[7].ToString();
                    Login.maas = sqlDataReader[8].ToString();
                    textBoxAdSoyad.Text = Login.adsoyad;
                    textBoxTelefonNo.Text = Login.tlfno;
                    textBoxEmail.Text = Login.email;
                    textBoxDogumTarihi.Text = Login.dogumtarihi;
                    textBoxCinsiyet.Text = Login.cinsiyet;
                    textBoxMaasi.Text = Login.maas;
                    textBoxAdresi.Text = Login.adres;
                }
            }
            catch 
            {
                MessageBox.Show("Kişisel bilgilerin alınamadı! Sayfayı yenileyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
        }

        private void guna2CircleButton1_MouseEnter(object sender, EventArgs e)
        {
            textBoxYeniSifre.UseSystemPasswordChar = false;
            textBoxYeniSifreTekrar.UseSystemPasswordChar = false;
        }

        private void guna2CircleButton1_MouseLeave(object sender, EventArgs e)
        {
            textBoxYeniSifre.UseSystemPasswordChar = true;
            textBoxYeniSifreTekrar.UseSystemPasswordChar = true;
        }

        private void textBoxTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxYeniSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxYeniSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if(textBoxYeniSifreTekrar.TextLength == 4 && textBoxYeniSifreTekrar.Text != textBoxYeniSifre.Text)
            {
                MessageBox.Show("Kutucuklara farklı şifre giriniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYeniSifreTekrar.Text = string.Empty;
            }
        }

        private void richTextBoxMetin_Enter(object sender, EventArgs e)
        {
            if(richTextBoxMetin.Text == "Mesajı gir...")
            {
                richTextBoxMetin.Text = string.Empty;
                richTextBoxMetin.ForeColor = Color.Black;
            }
        }

        private void richTextBoxMetin_Leave(object sender, EventArgs e)
        {
            if (richTextBoxMetin.Text == string.Empty)
            {
                richTextBoxMetin.ForeColor = Color.Gray;
                richTextBoxMetin.Text = "Mesajı gir...";
            }
        }

        private void buttonGüncelleSifre_Click(object sender, EventArgs e)
        {
            if (textBoxTCKimlikNo.Text != Login.tcKimlikNo)
            {
                MessageBox.Show("Yanlış T.C. kimlik numarası girdiniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UpdatePersonelInfo", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", Login.adsoyad);
                cmd.Parameters.AddWithValue("@Sifre", textBoxYeniSifre.Text);
                cmd.Parameters.AddWithValue("@TlfNo", Login.tlfno);
                cmd.Parameters.AddWithValue("@Email", Login.email);
                cmd.Parameters.AddWithValue("@Adresi", Login.adres);
                cmd.Parameters.AddWithValue("@Cinsiyeti", Login.cinsiyet);
                cmd.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(Login.dogumtarihi));
                cmd.Parameters.AddWithValue("@Maasi", Login.maas);
                cmd.ExecuteReader();
                MessageBox.Show("Şifren başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTCKimlikNo.Text = string.Empty;
                textBoxYeniSifre.Text = string.Empty;
                textBoxYeniSifreTekrar.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Şifren güncellenemdi!!!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonGüncelleKisisel_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UpdatePersonelInfo", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", Login.tcKimlikNo);
                cmd.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Sifre", Login.sifre);
                cmd.Parameters.AddWithValue("@TlfNo", textBoxTelefonNo.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Adresi", textBoxAdresi.Text);
                cmd.Parameters.AddWithValue("@Cinsiyeti", textBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(textBoxDogumTarihi.Text));
                cmd.Parameters.AddWithValue("@Maasi", textBoxMaasi.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Bilgilerin başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Bilgilerin güncellenemdi!!!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonMesajGönder_Click(object sender, EventArgs e)
        {
            bool isSame = false;
            for (int i = 0; i < comboBoxGonderen.Items.Count; i++)
            {
                if (textBoxKime.Text == comboBoxGonderen.Items[i].ToString())
                {
                    isSame = true;
                    break;
                }
            }
            if (textBoxKime.Text == string.Empty || textBoxBaslik.Text == string.Empty || richTextBoxMetin.Text == string.Empty || comboBoxGonderen.Text == string.Empty)
            {
                MessageBox.Show("Boş kutucuklar var onları doldurmalısın!", "Mesaj Gönderme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (isSame)
            {
                MessageBox.Show("Kendine mesaj gönderemezsin!", "Mesaj Gönderme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxKime.Text = string.Empty;
                return;
            }
            else
            {
                bool isThere = false;
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("EmailKontrol", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int p = 0; p < 2; p++)
                    {
                        if(p == 0)
                        {
                            cmd.Parameters.AddWithValue("@email", textBoxKime.Text);
                            cmd.Parameters.AddWithValue("@table_name", "Personel");
                            cmd.Parameters.AddWithValue("@column", "Email");
                        }
                        else if(p == 1)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@email", textBoxKime.Text);
                            cmd.Parameters.AddWithValue("@table_name", "Departman");
                            cmd.Parameters.AddWithValue("@column", "DepartmanEmail");
                        }
                        sqlDataReader = cmd.ExecuteReader();
                        if (sqlDataReader.Read())
                        {
                            isThere = true;
                            break;
                        }
                        sqlDataReader.Close();
                    }
                    if(!isThere)
                    {
                        MessageBox.Show(textBoxKime.Text + " alıcısı bu şirket üzerinde kayıtlı değildir!", "Alıcı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxKime.Text = string.Empty;
                        sqlConnection.Close();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show(textBoxKime.Text + " alıcısı bu şirket üzerinde kayıtlı değildir!", "Alıcı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlConnection.Close();
                    return;
                }
                finally
                {
                    if(sqlConnection != null)
                        sqlConnection.Close();
                }
            }
            try
            {
                int limit = 2000000;
                for (int i = 1; i <= limit; i++)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@row", 0);
                    cmd.Parameters.AddWithValue("@tckimlikno", i.ToString());
                    cmd.Parameters.AddWithValue("@column", "IslemID");
                    cmd.Parameters.AddWithValue("@table", "Email");
                    sqlDataReader = cmd.ExecuteReader();
                    if(!sqlDataReader.Read())
                    {
                        _id = i;
                        sqlDataReader.Close();
                        sqlConnection.Close();
                        MesajGonder();
                        break;
                    }
                    else
                    {
                        sqlDataReader.Close();
                        sqlConnection.Close();
                    }
                    if (i == limit)
                    {
                        MessageBox.Show("Şirket maximum email gönderim sayısına ulaştı! Lütfen admin ile iletişime geçiniz.", "Mesaj Gönderme Limiti Aşıldı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxBaslik.Text = string.Empty;
                        richTextBoxMetin.Text = string.Empty;
                        richTextBoxMetin_Leave(null, null);
                        textBoxKime.Text = string.Empty;
                        comboBoxGonderen.Text = string.Empty;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Mesaj gönderilirken hata oluştu! Tekrar deneyiniz.", "Mesaj Gönderme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        private void MesajGonder()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SendEmail", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@adSoyad", Login.adsoyad);
                cmd.Parameters.AddWithValue("@gonderen", comboBoxGonderen.SelectedItem);
                cmd.Parameters.AddWithValue("@alici", textBoxKime.Text);
                cmd.Parameters.AddWithValue("@baslik", textBoxBaslik.Text);
                cmd.Parameters.AddWithValue("@mesaj", richTextBoxMetin.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Mesaj başarıyla iletildi.", "Mesaj Gönderme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxBaslik.Text = string.Empty;
                richTextBoxMetin.Text = string.Empty;
                richTextBoxMetin_Leave(null, null);
                textBoxKime.Text = string.Empty;
                comboBoxGonderen.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Mesaj gönderilirken hata oluştu! Tekrar deneyiniz.", "Mesaj Gönderme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonMesajiOku_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("ReadEmail", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", textBoxGelenID.Text);
                sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.Read() && sqlDataReader[3].ToString() == comboBoxGelenler.SelectedItem.ToString())
                {
                    MessageBox.Show(sqlDataReader[1].ToString() + ": '" + sqlDataReader[5] + "'" , sqlDataReader[4].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mesaj bulunamadı! Mesaj id yi kontrol ediniz.", "Mesaj Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Mesaj alınırken hata oluştu! Tekrar deneyiniz.", "Mesaj Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonMesajiSil_Click(object sender, EventArgs e)
        {
            if (textBoxGelenID.Text == string.Empty)
                return;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("ReadEmail", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", textBoxGelenID.Text);
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read() && sqlDataReader[3].ToString() == comboBoxGelenler.SelectedItem.ToString())
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    DeleteEmail();
                }
                else
                {
                    MessageBox.Show("Mesaj bulunamadı! Mesaj id yi kontrol ediniz.", "Mesaj Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Mesaj silinirken hata oluştu! Tekrar deneyiniz.", "Mesaj Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
            }
        }
        private void DeleteEmail()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("DeleteEmail", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", textBoxGelenID.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Mesaj başarıyla silindi.", "Mesaj Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Mesaj silinirken hata oluştu! Tekrar deneyiniz.", "Mesaj Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                textBoxGelenID.Text = string.Empty;
                GetEmailTable();
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxGelenID.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void buttonYanitla_Click(object sender, EventArgs e)
        {
            if (textBoxGelenID.Text == string.Empty) return;
            textBoxBaslik.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxKime.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            textBoxBaslik.Text = string.Empty;
            richTextBoxMetin.Text = string.Empty;
            richTextBoxMetin_Leave(sender, e);
            comboBoxGonderen.Text = string.Empty;
            textBoxKime.Text = string.Empty;
        }

        private void comboBoxGelenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmailTable();
        }

        private void comboBoxGonderen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
