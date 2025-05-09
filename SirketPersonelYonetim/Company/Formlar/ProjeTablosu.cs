using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class ProjeTablosu : Form
    {
        public ProjeTablosu()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;

        private void comboBoxProjeler_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxProjeNumAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxPersonelTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCalismaSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void richTextBoxEkstraBilgi_TextChanged(object sender, EventArgs e)
        {
            labelTextCount.Text = richTextBoxEkstraBilgi.Text.Length + "/60";
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            foreach(Control control in gPanelPersonelOperation.Controls)
            {
                if(control is TextBox || control is RichTextBox)
                {
                    control.Text = string.Empty;
                }
            }
            comboBoxProjeNumAd.Text = string.Empty;
            buttonPersonelEkle.Enabled = true;
            buttonPersonelGüncelle.Enabled = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            labelInfo.Text = "Girilen Karakter Sayısı: " + textBoxSearch.TextLength; 
        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }
        private void buttonPersonelEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxProjeNumAd.Text == string.Empty || textBoxPersonelTCKimlikNo.Text == string.Empty)
            { MessageBox.Show("Proje numarasını veya personel T.C. kimlik numarasını hatalı girdiniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("AddProjePersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", GetProjectID(sender));  
                cmd.Parameters.AddWithValue("@tckimlikno", textBoxPersonelTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@detay", richTextBoxEkstraBilgi.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Numarası " + GetProjectID(sender) + " olan projeye " + textBoxPersonelTCKimlikNo.Text + " personeli eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Proje numarasını ve personel T.C. kimlik numarasını kontrol ediniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            if (comboBoxProjeNumAd.Text == string.Empty || textBoxPersonelTCKimlikNo.Text == string.Empty)
            { MessageBox.Show("Proje numarasını veya personel T.C. kimlik numarasını hatalı girdiniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("FindProjePersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", GetProjectID(sender));
                cmd.Parameters.AddWithValue("@tckimlikno", textBoxPersonelTCKimlikNo.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    textBoxCalismaSaati.Text = reader[2].ToString();
                    richTextBoxEkstraBilgi.Text = reader[3].ToString();
                    buttonPersonelGüncelle.Enabled = true;
                    buttonPersonelEkle.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Proje numarasını ve personel T.C. kimlik numarasını kontrol ediniz!", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Sayfayı yenileyip tekrar deneyiniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonPersonelSil_Click(object sender, EventArgs e)
        {
            if (comboBoxProjeNumAd.Text == string.Empty || textBoxPersonelTCKimlikNo.Text == string.Empty)
            { MessageBox.Show("Proje numarasını veya personel T.C. kimlik numarasını hatalı girdiniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("DeleteProjePersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", GetProjectID(sender));
                cmd.Parameters.AddWithValue("@tckimlikno", textBoxPersonelTCKimlikNo.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.RecordsAffected > 0)
                {
                    MessageBox.Show("Numarası " + GetProjectID(sender) + " olan projeden " + textBoxPersonelTCKimlikNo.Text + " personeli silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Proje numarasını ve personel T.C. kimlik numarasını kontrol ediniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Proje numarasını ve personel T.C. kimlik numarasını kontrol ediniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonPersonelGüncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxProjeNumAd.Text == string.Empty || textBoxPersonelTCKimlikNo.Text == string.Empty)
            { MessageBox.Show("Proje numarasını veya personel T.C. kimlik numarasını hatalı girdiniz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("EditProjePersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@number", GetProjectID(sender));
                cmd.Parameters.AddWithValue("@tckimlikno", textBoxPersonelTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@saat", textBoxCalismaSaati.Text);
                cmd.Parameters.AddWithValue("@detay", richTextBoxEkstraBilgi.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Numarası " + GetProjectID(sender) + " olan projenin " + textBoxPersonelTCKimlikNo.Text + " personelinin verileri güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Sayfayı yenileyip tekrar deneyiniz!!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void ProjeTablosu_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            GetTheProjects();
        }
        private void GetTheProjects()
        {
            bool isAuthorized = false;
            string[] karakterler = Login.yetkiDurumu.Split(',');
            foreach (string s in karakterler)
            {
                if(int.TryParse(s, out int id))
                {
                    if(id == 0 || id == 1 || id == 4 || id == 8)
                    {
                        isAuthorized = true;
                        break;
                    }
                }
            }
            if(isAuthorized)
            {
                try
                {
                    sqlConnection.Open();
                    int i = 0;
                    while (true)
                    {
                        SqlCommand cmd = new SqlCommand("GetProjects", sqlConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@row", i);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            comboBoxProjeler.Items.Add(reader[0].ToString() + ": " + reader[2].ToString());
                            comboBoxProjeNumAd.Items.Add(reader[0].ToString() + ": " + reader[2].ToString());
                        }
                        else
                        {
                            break;
                        }
                        reader.Close();
                        i++;
                    }
                }
                catch
                {
                    MessageBox.Show("Proje tabloları alınırken hata oluştu! Lütfen sayfayı yenileyiniz.", "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    int i = 0;
                    while (true)
                    {
                        SqlCommand cmd = new SqlCommand("GetEmailandDepartman", sqlConnection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@row", i);
                        cmd.Parameters.AddWithValue("@tckimlikno", Login.tcKimlikNo);
                        cmd.Parameters.AddWithValue("@column", "ProjeBaskaniTC");
                        cmd.Parameters.AddWithValue("@table", "Projeler");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            comboBoxProjeler.Items.Add(reader[0].ToString() + ": " + reader[2].ToString());
                            comboBoxProjeNumAd.Items.Add(reader[0].ToString() + ": " + reader[2].ToString());
                        }
                        else
                        {
                            break;
                        }
                        reader.Close();
                        i++;
                    }
                }
                catch
                {
                    MessageBox.Show("Proje tabloları alınırken hata oluştu! Lütfen sayfayı yenileyiniz.", "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }
        }

        private void comboBoxProjeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            string[] karakterler = comboBoxProjeler.Text.Split(':');
            foreach(string s in karakterler)
            {
                if(int.TryParse(s, out int i))
                {
                    id = i;
                }
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetProjectPersonel", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Proje tablosu alınırken hata oluştu! Lütfen tekrar deneyiniz.", "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                EkstraInfo(id);
            }
        }
        private void EkstraInfo(int _id)
        {
            string[] procedures = new string[] { "GetCaptainName", "GetProjectCount" };
            for (int j = 0; j < procedures.Length; j++)
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(procedures[j], sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", _id);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if (j == 0)
                        labelKaptanIsmi.Text = reader[0].ToString();
                    else
                        labelToplamPersonelSayisi.Text = reader[0].ToString();
                }
                else
                {
                    if(j == 0)
                        labelKaptanIsmi.Text = "--";
                    else
                        labelToplamPersonelSayisi.Text = "--";
                }
                reader.Close();
                sqlConnection.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool didfound = false;
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
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

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("T.C. Kimlik No ve Ad-Soyad anahtarları ile personel arayabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxProjeNumAd.Text = GetProjectID(sender).ToString();
            textBoxPersonelTCKimlikNo.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxCalismaSaati.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            richTextBoxEkstraBilgi.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            buttonPersonelEkle.Enabled = false;
            buttonPersonelGüncelle.Enabled = true;
        }
        private int GetProjectID(object _sender)
        {
            int projectID = -1;
            string[] karakterler;
            if (_sender is Button)
            {
                if (comboBoxProjeNumAd.Text.Length != 0)
                {
                    karakterler = comboBoxProjeNumAd.Text.Split(':');
                }
                else
                {
                    karakterler = "-1:".Split(':');
                }
            }
            else
            {
                if (comboBoxProjeler.Text.Length != 0)
                {
                    karakterler = comboBoxProjeler.Text.Split(':');
                }
                else
                {
                    karakterler = "-1:".Split(':');
                }
            }
            foreach (string s in karakterler)
            {
                if (int.TryParse(s, out int i))
                {
                    projectID = i;
                }
            }
            return projectID;
        }
    }
}
