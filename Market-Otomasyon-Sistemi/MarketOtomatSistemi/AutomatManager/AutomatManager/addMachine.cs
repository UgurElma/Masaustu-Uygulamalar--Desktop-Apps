using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutomatManager
{
    public partial class addMachine : Form
    {
        public addMachine()
        {
            InitializeComponent();
        }
        private string s_connection, e_databaseName;
        SqlConnection connection;
        bool isThere;

        private void addMachine_Load(object sender, EventArgs e)
        {
            LoadTheme();
            e_databaseName = formEnter.databasename;
            s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=" + e_databaseName + ";Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Guna2HtmlLabel))
                {
                    btns.ForeColor = ThemeColor.SecondaryColor;
                }
                if (btns.GetType() == typeof(Guna2TextBox))
                {
                    btns.ForeColor = ThemeColor.SecondaryColor;
                }
                if (btns.GetType() == typeof(Guna2Button) && btns != gButtonClear)
                {
                    btns.BackColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void ControlMachineName()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("FindMachine", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@fmid", gTextBoxIdAdd.Text);
            sqlCommand.Parameters.AddWithValue("@fmname", gTextBoxNameProducts.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                if (sqlDataReader[1].ToString() == gTextBoxNameProducts.Text)
                {
                    MessageBox.Show("This id is not empty!");
                    isThere = true;
                }
            }
            connection.Close();
        }
        private void gButtonAdd_Click(object sender, EventArgs e)
        {
            ControlMachineName();
            if (isThere == true)
            {
                isThere = false;
                return;
            }
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("AddMachine", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@amid", gTextBoxIdAdd.Text);
                sqlCommand.Parameters.AddWithValue("@amname", gTextBoxNameProducts.Text);
                sqlCommand.Parameters.AddWithValue("@aexdate", guna2DateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@aprice", Convert.ToDouble(gTextBoxPrice.Text));
                sqlCommand.Parameters.AddWithValue("@acounts", int.Parse(gTextBoxQuantity.Text));
                sqlCommand.Parameters.AddWithValue("@athresholdvalue", int.Parse(gTextBoxThresholdValue.Text));
                sqlCommand.Parameters.AddWithValue("@ambalance", 0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Machine added!");
                gButtonClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if(connection != null) connection.Close();  
            }
        }

        private void gButtonClear_Click(object sender, EventArgs e)
        {
            foreach(Control textBoxs in this.Controls)
            {
                if(textBoxs.GetType() == typeof(Guna2TextBox))
                {
                    textBoxs.Text = string.Empty;
                }
            }
            guna2DateTimePicker1.Value = DateTime.Now;
        }

        private void gTextBoxNameProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxIdAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void gTextBoxThresholdValue_TextChanged(object sender, EventArgs e)
        {
            if (gTextBoxThresholdValue.Text == string.Empty) return;
            if(gTextBoxQuantity.Text == string.Empty)
            {
                MessageBox.Show("Enter count of products!");
                gTextBoxThresholdValue.Text = string.Empty;
                gTextBoxQuantity.Focus();
            }
            else if(int.Parse(gTextBoxThresholdValue.Text) >= int.Parse(gTextBoxQuantity.Text))
            {
                MessageBox.Show("The threshold value can't be more than count of product!");
                gTextBoxThresholdValue.Text = string.Empty;
            }
        }

        private void gTextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxThresholdValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
