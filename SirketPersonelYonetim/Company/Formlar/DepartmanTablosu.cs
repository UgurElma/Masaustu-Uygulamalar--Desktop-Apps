using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class DepartmanTablosu : Form
    {
        public DepartmanTablosu()
        {
            InitializeComponent();
        }
        
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;

        private void DepartmanTablosu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            GetTheDepartments();
        }
        private void DepartmanYoneticileri()
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
                if (sqlDataReader.Read())
                {
                    comboBoxDepartmanlar.Items.Add(sqlDataReader[0].ToString());
                    comboBox1.Items.Add(sqlDataReader[0].ToString());
                }
                else
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    break;
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                i++;
            }
        }
        private void GenelYoneticiler()
        {
            int i = 0;
            while (true)
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetDepartmanName", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@row", i);
                cmd.Parameters.AddWithValue("@column", "DepartmanIsmi");
                cmd.Parameters.AddWithValue("@table", "Departman");
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    comboBoxDepartmanlar.Items.Add(sqlDataReader[0].ToString());
                    comboBox1.Items.Add(sqlDataReader[0].ToString());
                }
                else
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    break;
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                i++;
            }
        }
        private void GetTheDepartments()
        {
            try
            {
                if(Login.yetkiDurumu == "0" || Login.yetkiDurumu == "1")
                {
                    GenelYoneticiler();
                }
                else
                {
                    if(Login.yetkiDurumu.Length > 1)
                    {
                        string[] karakterler = Login.yetkiDurumu.Split(',');
                        foreach(string s in karakterler)
                        {
                            if(int.TryParse(s, out int num))
                            {
                                if(num == 5)
                                {
                                    GenelYoneticiler();
                                    break;
                                }
                                else
                                {
                                    DepartmanYoneticileri();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Login.yetkiDurumu == "5")
                            GenelYoneticiler();
                        else
                            DepartmanYoneticileri();
                    }
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
        private void GetExtraInfos()
        {
            try
            {
                string name = comboBoxDepartmanlar.SelectedItem.ToString();
                string[] sqls = new string[] { "GetPersonelCount", "GetManagerName" };
                for(int i = 0; i < 2; i++)
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(sqls[i], sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (i == 0)
                    {
                        cmd.Parameters.AddWithValue("@table_name", name.Replace(" ", ""));
                        sqlDataReader = cmd.ExecuteReader();
                        if (sqlDataReader.Read())
                            labelToplamPersonelSayisi.Text = sqlDataReader[0].ToString();
                        else
                            labelToplamPersonelSayisi.Text = "--";
                    }
                    else if (i == 1)
                    {
                        cmd.Parameters.AddWithValue("@table_name", name);
                        sqlDataReader = cmd.ExecuteReader();
                        if (sqlDataReader.Read())
                            labelYoneticiIsmi.Text = sqlDataReader[0].ToString();
                        else
                            labelYoneticiIsmi.Text = "--";
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Departmanın ekstra bilgileri alınamadı! Tekrar seçin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        private void comboBoxDepartmanlar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartmanlar.SelectedItem.ToString() == string.Empty)
                return;
            try
            {
                sqlConnection.Open();
                string name = comboBoxDepartmanlar.SelectedItem.ToString().Replace(" ","");
                SqlCommand cmd = new SqlCommand("GetDepartmanPersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@table_name", name);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Departman personel verileri alınamadı! Sayfayı yenileyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
                GetExtraInfos();
            }
        }

        private void buttonPersonelEkle_Click(object sender, EventArgs e)
        {
            if(textBoxPersonelTCKimlikNo.Text == string.Empty || comboBox1.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                string name = comboBox1.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("SetDepartmanPersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tc_kimlik_no", textBoxPersonelTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@table_name", name.Replace(" ", ""));
                cmd.ExecuteReader();
                MessageBox.Show("Personel " + comboBox1.SelectedItem.ToString() + " departmanına eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPersonelTCKimlikNo.Text = string.Empty;
                comboBox1.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Departmana personel eklenemedi!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if ((sqlConnection != null))
                    sqlConnection.Close();
            }
        }

        private void buttonPersonelSil_Click(object sender, EventArgs e)
        {
            if (textBoxPersonelTCKimlikNo.Text == string.Empty || comboBox1.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                string name = comboBox1.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("DeleteDepartmanPersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tc_kimlik_no", textBoxPersonelTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@table_name", name.Replace(" ", ""));
                sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.RecordsAffected > 0)
                {
                    MessageBox.Show("Personel " + comboBox1.SelectedItem.ToString() + " departmanından silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPersonelTCKimlikNo.Text = string.Empty;
                    comboBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Bu personel zaten kayıtlı değil!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Departmandan personel silinemedi!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if ((sqlConnection != null))
                    sqlConnection.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool didfound = false;
            for(int i = 0;  i < guna2DataGridView1.RowCount; i++)
            {
                if (guna2DataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxSearch.Text || guna2DataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxSearch.Text))
                {
                    didfound = true;
                    MessageBox.Show(guna2DataGridView1.Rows[i].Cells[0].Value + ", " + guna2DataGridView1.Rows[i].Cells[1].Value + ", " + guna2DataGridView1.Rows[i].Cells[2].Value + ", " + guna2DataGridView1.Rows[i].Cells[3].Value + ", " + guna2DataGridView1.Rows[i].Cells[4].Value + ", " + guna2DataGridView1.Rows[i].Cells[5].Value, "Personel Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (didfound == false)
            {
                MessageBox.Show("Personel bulunamadı! Aramaya çalıştığınız personelin anahtar bilgisini kontrol ediniz.", "Hatalı Anahtar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            labelInfo.Text = "Girilen karakter sayısı: " + textBoxSearch.TextLength.ToString();
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("T.C. Kimlik No ve Ad-Soyad anahtarları ile personel arayabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxPersonelTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
