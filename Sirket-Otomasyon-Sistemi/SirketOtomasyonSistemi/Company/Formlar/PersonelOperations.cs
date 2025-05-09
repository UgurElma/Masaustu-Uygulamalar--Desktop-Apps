using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class PersonelOperations : Form
    {
        public PersonelOperations()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;

        private void PersonelOperations_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            TabloyuDoldur();
        }

        private void TabloyuDoldur()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetPersonelInfos", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Kişisel bilgilerin alınamadı! Sayfayı yenileyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                    GetPersonelIstatistik();
                }
            }
        }
        private void GetPersonelIstatistik()
        {
            foreach(Control control in gPanelInfo.Controls)
            {
                if(control is Label)
                {
                    Label label = (Label) control;
                    for (int i = 0; i <= 9; i++)
                    {
                        label.Text = label.Text.Replace(i.ToString(), "");
                    }
                }
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetPersonelIstatistik", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    labelTopPersonel.Text += sqlDataReader[0].ToString();
                    labelTopErkek.Text += sqlDataReader[1].ToString();
                    labelTopKadin.Text += sqlDataReader[2].ToString();
                    labelTopMaas.Text += sqlDataReader[3].ToString();
                    labelErkekMaas.Text += sqlDataReader[4].ToString();
                    labelKadinMaas.Text += sqlDataReader[5].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void textBoxTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMaasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonPersonelAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTCKimlikNo.TextLength != 11)
            {
                MessageBox.Show("Eksik T.C. kimlik numarası girdiniz!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SetPersonelInfo", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);
                cmd.Parameters.AddWithValue("@TlfNo", textBoxTelefonNo.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Adresi", textBoxAdresi.Text);
                cmd.Parameters.AddWithValue("@Cinsiyeti", comboBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(dateTimePickerDogumTarihi.Text));
                cmd.Parameters.AddWithValue("@Maasi", textBoxMaasi.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Personel başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel eklenemedi!!!" + ex.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                    TabloyuDoldur();
                }
            }
        }

        private void buttonPersonelGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UpdatePersonelInfo", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);
                cmd.Parameters.AddWithValue("@TlfNo", textBoxTelefonNo.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Adresi", textBoxAdresi.Text);
                cmd.Parameters.AddWithValue("@Cinsiyeti", comboBoxCinsiyet.Text);
                cmd.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(dateTimePickerDogumTarihi.Text));
                cmd.Parameters.AddWithValue("@Maasi", textBoxMaasi.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Personel bilgileri başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
                buttonPersonelGüncelle.Enabled = false;
                buttonSil.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Personel bilgileri güncellenemdi!!!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                    TabloyuDoldur();
                }
            }
        }

        private void buttonPersonelBul_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("FindPersonelInfo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    textBoxSifre.Text = sqlDataReader[1].ToString();
                    textBoxAdSoyad.Text = sqlDataReader[2].ToString();
                    textBoxTelefonNo.Text = sqlDataReader[3].ToString();
                    textBoxEmail.Text = sqlDataReader[4].ToString();
                    textBoxAdresi.Text = sqlDataReader[5].ToString();
                    comboBoxCinsiyet.Text = sqlDataReader[6].ToString();
                    dateTimePickerDogumTarihi.Text = sqlDataReader[7].ToString();
                    textBoxMaasi.Text = sqlDataReader[8].ToString();
                    buttonSil.Enabled = true;
                    buttonPersonelGüncelle.Enabled = true;
                    buttonPersonelAdd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bu T.C. kimlik numarasına ait personel bulunamadı!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeletePersonelInfo", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TCKimlikNo", textBoxTCKimlikNo.Text);
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.RecordsAffected != 0)
                {
                    if (textBoxTCKimlikNo.Text == Login.tcKimlikNo)
                    {
                        MessageBox.Show("Kendin tarafından başarıyla silindin.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Personel başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bu personel zaten kayıtlı değil! T.C. kimlik numarasını kontrol edip tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                labelClear_Click(sender, e);
                buttonPersonelGüncelle.Enabled = false;
                buttonSil.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Personel silinemedi! Sayfayı yenileyip tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                    TabloyuDoldur();
                }
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }
            comboBoxCinsiyet.Text = string.Empty;
            dateTimePickerDogumTarihi.Text = string.Empty;
            buttonPersonelGüncelle.Enabled = false;
            buttonSil.Enabled = false;
            buttonPersonelAdd.Enabled = true;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonPersonelAdd.Enabled = false;
            buttonPersonelGüncelle.Enabled = true;
            buttonSil.Enabled = true;
            textBoxTCKimlikNo.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxAdSoyad.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxSifre.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxTelefonNo.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxEmail.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxMaasi.Text = guna2DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBoxCinsiyet.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dateTimePickerDogumTarihi.Text = guna2DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxAdresi.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool isRead = false;
            for(int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                if (guna2DataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxSearch.Text || guna2DataGridView1.Rows[i].Cells[2].Value.ToString() == textBoxSearch.Text || guna2DataGridView1.Rows[i].Cells[4].Value.ToString() == textBoxSearch.Text)
                {
                    guna2DataGridView1.Rows[i].Selected = true;
                    isRead = true;
                    break;
                }
            }
            if(isRead)
                guna2DataGridView1_CellClick(guna2DataGridView1, null);
        }

        private void labelTemizle_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            labelInfo.Text = "Girilen Karakter Sayısı: " + textBoxSearch.TextLength;
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                MessageBox.Show("T.C. Kimlik No, Ad-Soyad ve Email Adresi anahtarları ile personel arayabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePickerDogumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
