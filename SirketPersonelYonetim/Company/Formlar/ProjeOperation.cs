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
    public partial class ProjeOperation : Form
    {
        public ProjeOperation()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        private void labelClear_Click(object sender, EventArgs e)
        {
            foreach(Control control in gPanelOperations.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }
            buttonProjectGüncelle.Enabled = false;
            buttonProjectEkle.Enabled = true;
        }

        private void textBoxProjectNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProjeCaptain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProjectPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProjectButce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxProjectMaliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProjeOperation_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Login.connString);
            FillTheTable();
        }

        private void FillTheTable()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SelectProjectTable", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Proje tablosu alınamadı! Sayfayı yenileyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private bool TextBoxController()
        {
            bool isEmpty = false;
            foreach(Control control in gPanelOperations.Controls)
            {
                if(control is TextBox)
                {
                    TextBox txtbox = (TextBox)control;
                    if(txtbox.Text == string.Empty)
                        isEmpty = true;
                    else
                        isEmpty = false;
                }
            }
            return isEmpty;
        }

        private void buttonProjectEkle_Click(object sender, EventArgs e)
        {
            if(TextBoxController())
            {
                MessageBox.Show("Bütün kutuları uygun bilgilerle doldurunuz.", "Girilmeyen Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("AddProject", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjeID", textBoxProjectNumber.Text);
                cmd.Parameters.AddWithValue("@ProjeBaskaniTC", textBoxProjeCaptain.Text);
                cmd.Parameters.AddWithValue("@ProjeIsmi", textBoxProjectName.Text);
                cmd.Parameters.AddWithValue("@ProjeTlfNo", textBoxProjectPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@ProjeEmail", textBoxProjectEmail.Text);
                cmd.Parameters.AddWithValue("@ProjeButce", textBoxProjectButce.Text);
                cmd.Parameters.AddWithValue("@ProjeMaliyet", textBoxProjectMaliyet.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Proje başarıyla eklendi.", "İşlem Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Proje eklenemedi! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlConnection != null)
                    sqlConnection.Close();
                FillTheTable();
            }
        }

        private void buttonProjectBul_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("FindProject", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjeID", textBoxProjectNumber.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    textBoxProjeCaptain.Text = sqlDataReader[1].ToString();
                    textBoxProjectName.Text = sqlDataReader[2].ToString();
                    textBoxProjectPhoneNumber.Text = sqlDataReader[3].ToString();
                    textBoxProjectEmail.Text = sqlDataReader[4].ToString();
                    textBoxProjectButce.Text = sqlDataReader[5].ToString();
                    textBoxProjectMaliyet.Text = sqlDataReader[6].ToString();
                    buttonProjectEkle.Enabled = false;
                    buttonProjectGüncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Proje bulunamadı! Proje numarasını kontrol ediniz.", "İşlem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Proje bulunamadı! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
            }
        }

        private void buttonProjectGüncelle_Click(object sender, EventArgs e)
        {
            if (TextBoxController())
            {
                MessageBox.Show("Bütün kutuları uygun bilgilerle doldurunuz.", "Girilmeyen Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("EditProject", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjeID", textBoxProjectNumber.Text);
                cmd.Parameters.AddWithValue("@ProjeBaskaniTC", textBoxProjeCaptain.Text);
                cmd.Parameters.AddWithValue("@ProjeIsmi", textBoxProjectName.Text);
                cmd.Parameters.AddWithValue("@ProjeTlfNo", textBoxProjectPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@ProjeEmail", textBoxProjectEmail.Text);
                cmd.Parameters.AddWithValue("@ProjeButce", textBoxProjectButce.Text);
                cmd.Parameters.AddWithValue("@ProjeMaliyet", textBoxProjectMaliyet.Text);
                cmd.ExecuteReader();
                MessageBox.Show("Proje başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Proje güncellenemedi! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                FillTheTable();
            }
        }

        private void buttonProjectSil_Click(object sender, EventArgs e)
        {
            if(textBoxProjectNumber.Text == string.Empty)
            {
                MessageBox.Show("Proje numarasını giriniz.", "Eksik Bilgi Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("DeleteProject", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProjeID", textBoxProjectNumber.Text);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if(sqlDataReader.RecordsAffected > 0)
                {
                    MessageBox.Show("Proje başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Bu proje zaten kayıtlı değil! Proje numarasını kontrol edip tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Proje silinemedi! Tekrar deneyiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection != null)
                    sqlConnection.Close();
                FillTheTable();
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProjectNumber.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxProjeCaptain.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProjectName.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxProjectPhoneNumber.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProjectEmail.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxProjectButce.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxProjectMaliyet.Text = guna2DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            buttonProjectEkle.Enabled = false;
            buttonProjectGüncelle.Enabled = true;
        }
    }
}
