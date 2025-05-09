using Guna.UI2.WinForms;
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

namespace AutomatManager
{
    public partial class fdeCustomer : Form
    {
        public fdeCustomer()
        {
            InitializeComponent();
        }
        private string s_connection, e_databaseName, gender;
        SqlConnection connection;

        private void fdeCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            e_databaseName = formEnter.databasename;
            s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=" + e_databaseName + ";Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
            GetTable();
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
        private void GetTable()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("GCT", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewCustomer.DataSource = dt;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i == 0)
                        dataGridViewCustomer.Columns[i].HeaderText = "Customer ID";
                    else if (i == 1)
                        dataGridViewCustomer.Columns[i].HeaderText = "Name";
                    else if (i == 2)
                        dataGridViewCustomer.Columns[i].HeaderText = "Surname";
                    else if (i == 3)
                        dataGridViewCustomer.Columns[i].HeaderText = "Joining Date";
                    else if (i == 4)
                        dataGridViewCustomer.Columns[i].HeaderText = "Phone Number";
                    else if (i == 5)
                        dataGridViewCustomer.Columns[i].HeaderText = "Customer Balance";
                    else if (i == 6)
                        dataGridViewCustomer.Columns[i].HeaderText = "Gender";
                }
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
        private void GenderControl()
        {
            if (radioButtonMan.Checked)
            {
                gender = "Man";
            }
            else if (radioButtonWoman.Checked)
            {
                gender = "Woman";
            }
            else
            {
                MessageBox.Show("Choose a gender!");
                return;
            }
        }

        private void gButtonEdit_Click(object sender, EventArgs e)
        {
            GenderControl();
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("EditCustomer", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ecid", gTextBoxIdFDE.Text);
                sqlCommand.Parameters.AddWithValue("@ecname", gTextBoxNameAdd.Text);
                sqlCommand.Parameters.AddWithValue("@ecsurname", gTextBoxSurnameAdd.Text);
                sqlCommand.Parameters.AddWithValue("@epnumber", gTextBoxPhoneAdd.Text);
                sqlCommand.Parameters.AddWithValue("@ecbalance", Convert.ToDouble(gTextBoxBalanceAdd.Text));
                sqlCommand.Parameters.AddWithValue("@egender", gender);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer data updated!");
                gButtonClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
                GetTable();
            }
        }

        private void gButtonFind_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("FindCustomer", connection);
                sqlCommand.CommandType= CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@fcid", gTextBoxIdFDE.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    gTextBoxNameAdd.Text = reader[1].ToString();
                    gTextBoxSurnameAdd.Text = reader[2].ToString();
                    gTextBoxPhoneAdd.Text = reader[4].ToString();
                    gTextBoxBalanceAdd.Text = reader[5].ToString();
                    gender = reader[6].ToString();
                    if(gender == "Man")
                    {
                        radioButtonMan.Checked = true;
                    }
                    else
                    {
                        radioButtonWoman.Checked = true;    
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        private void gButtonDelete_Click(object sender, EventArgs e)
        {
            if (gTextBoxIdFDE.Text == string.Empty)
            {
                MessageBox.Show("Enter Customer ID!");
                return;
            }
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteCustomer", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@dcid", gTextBoxIdFDE.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer deleted!");
                gButtonClear_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
                GetTable();
            }
        }

        private void gButtonClear_Click(object sender, EventArgs e)
        {
            foreach(Control textBoxs  in this.Controls)
            {
                if(textBoxs.GetType() == typeof(Guna2TextBox))
                {
                    textBoxs.Text = string.Empty; 
                }
                radioButtonWoman.Checked = false;
                radioButtonMan.Checked = false;
            }
        }

        private void gTextBoxIdFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxNameAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void gTextBoxSurnameAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dataGridViewMachine_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            gTextBoxIdFDE.Text = dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString();
            gTextBoxNameAdd.Text = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
            gTextBoxSurnameAdd.Text = dataGridViewCustomer.CurrentRow.Cells[2].Value.ToString();
            gTextBoxPhoneAdd.Text = dataGridViewCustomer.CurrentRow.Cells[4].Value.ToString();
            gTextBoxBalanceAdd.Text = dataGridViewCustomer.CurrentRow.Cells[5].Value.ToString();
            if (dataGridViewCustomer.CurrentRow.Cells[6].Value.ToString() == "Man")
            {
                radioButtonMan.Checked = true;
            }
            else
            {
                radioButtonWoman.Checked = true;
            }
        }

        private void gTextBoxPhoneAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxBalanceAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxBalanceAdd_TextChanged(object sender, EventArgs e)
        {
            if (gTextBoxBalanceAdd.Text != string.Empty && (double.Parse(gTextBoxBalanceAdd.Text) > 300 || double.Parse(gTextBoxBalanceAdd.Text) < 0))
            {
                MessageBox.Show("You can load money between 0 and 300 TL!");
                gTextBoxBalanceAdd.Text = string.Empty;
            }
        }
    }
}
