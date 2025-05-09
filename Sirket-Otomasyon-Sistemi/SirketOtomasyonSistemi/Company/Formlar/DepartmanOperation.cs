using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Company.Formlar
{
    public partial class DepartmanOperation : Form
    {
        public DepartmanOperation()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;
        bool isCreate, isDelete;
        string newName;

        private void textBoxDepartmanIsmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }

        private void textBoxDepartmanTelefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxYoneticiTCKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in gPanelYonetim.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }   
            }
            dateTimePickerBaslamaTarihi.Text = string.Empty;
            buttonDepartmanGüncelle.Enabled = false;
            buttonDepartmanAdd.Enabled = true;
        }

        private void DepartmanOperation_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            TabloyuDoldur();
        }

        private void TabloyuDoldur()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetDepartmanTable", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                guna2DataGridView1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                guna2DataGridView1.Columns[0].HeaderText = "Departman İsmi";
                guna2DataGridView1.Columns[1].HeaderText = "Telefonu";
                guna2DataGridView1.Columns[2].HeaderText = "Email Adresi";
                guna2DataGridView1.Columns[3].HeaderText = "Yöneticisi";
                guna2DataGridView1.Columns[4].HeaderText = "Baslama Tarihi";
            }
            catch
            {
                MessageBox.Show("Departman tablosundaki veriler alınamadı! Sayfayı yenileyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonDepartmanAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDepartmanIsmi.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SetDepartman", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmanIsmi", textBoxDepartmanIsmi.Text);
                cmd.Parameters.AddWithValue("@DepartmanTlf", textBoxDepartmanTelefonNo.Text);
                cmd.Parameters.AddWithValue("@DepartmanEmail", textBoxDepartmanEmail.Text);
                cmd.Parameters.AddWithValue("@YoneticiTC", textBoxYoneticiTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@BaslamaTarihi", dateTimePickerBaslamaTarihi.Value);
                cmd.ExecuteReader();
                MessageBox.Show(textBoxDepartmanIsmi.Text + " departmanı başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isCreate = true;
                newName = textBoxDepartmanIsmi.Text.Replace(" ", "");
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Departmanı eklerken hata oluştu! Bilgileri kontrol edip tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
                if(isCreate)
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("AddDepartman", sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@table_name", newName);
                        sqlCommand.ExecuteReader();
                        isCreate = false;
                    }
                    catch
                    {
                        MessageBox.Show("Departmanın tablosu oluşturulamadı! Departmanı silin ve bilgileri kontrol edip tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    { 
                        if (sqlConnection != null)
                            sqlConnection.Close();
                        TabloyuDoldur();
                    }
                }
            }
        }

        private void buttonDepartmanGüncelle_Click(object sender, EventArgs e)
        {
            if (textBoxDepartmanIsmi.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("UpdateDepartman", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmanIsmi", textBoxDepartmanIsmi.Text);
                cmd.Parameters.AddWithValue("@DepartmanTlf", textBoxDepartmanTelefonNo.Text);
                cmd.Parameters.AddWithValue("@DepartmanEmail", textBoxDepartmanEmail.Text);
                cmd.Parameters.AddWithValue("@YoneticiTC", textBoxYoneticiTCKimlikNo.Text);
                cmd.Parameters.AddWithValue("@BaslamaTarihi", dateTimePickerBaslamaTarihi.Value);
                cmd.ExecuteReader();
                MessageBox.Show(textBoxDepartmanIsmi.Text + " departmanı başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Departmanı güncellerken hata oluştu! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                TabloyuDoldur();
            }
        }

        private void buttonDepartmanBul_Click(object sender, EventArgs e)
        {
            if (textBoxDepartmanIsmi.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("GetDepartman", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmanIsmi", textBoxDepartmanIsmi.Text);
                sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.Read())
                {
                    textBoxDepartmanTelefonNo.Text = sqlDataReader[1].ToString();
                    textBoxDepartmanEmail.Text = sqlDataReader[2].ToString();
                    textBoxYoneticiTCKimlikNo.Text = sqlDataReader[3].ToString();
                    dateTimePickerBaslamaTarihi.Text = sqlDataReader[4].ToString();
                    buttonDepartmanAdd.Enabled = false;
                    buttonDepartmanGüncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Departman bulunamadı!", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Departmanı ararken hata oluştu! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonDepartmanSil_Click(object sender, EventArgs e)
        {
            if(textBoxDepartmanIsmi.Text == string.Empty)
            { MessageBox.Show("Bütün bilgileri doldurunuz!", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("DeleteDepartman", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmanIsmi", textBoxDepartmanIsmi.Text);
                sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.RecordsAffected > 0)
                {
                    MessageBox.Show(textBoxDepartmanIsmi.Text + " departmanı başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isDelete = true;
                    newName = textBoxDepartmanIsmi.Text.Replace(" ", "");
                    labelClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(textBoxDepartmanIsmi.Text + " departmanı zaten kayıtlı değil.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isDelete = false;
                }
            }
            catch
            {
                MessageBox.Show("Departmanı silerken hata oluştu! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                if (isDelete)
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("DestroyDepartman", sqlConnection);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@table_name", newName);
                        sqlCommand.ExecuteReader();
                        isDelete = false;
                    }
                    catch
                    {
                        MessageBox.Show("Departmanın tablosu silinemedi! Admin ile iletişime geçin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sqlConnection != null)
                            sqlConnection.Close();
                        TabloyuDoldur();
                    }
                }
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxDepartmanIsmi.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxDepartmanTelefonNo.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxDepartmanEmail.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxYoneticiTCKimlikNo.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePickerBaslamaTarihi.Value = Convert.ToDateTime(guna2DataGridView1.SelectedRows[0].Cells[4].Value);
            buttonDepartmanAdd.Enabled = false;
            buttonDepartmanGüncelle.Enabled = true;
        }
    }
}
