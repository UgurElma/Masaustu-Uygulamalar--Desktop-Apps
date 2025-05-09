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
    public partial class fdeMachine : Form
    {
        public fdeMachine()
        {
            InitializeComponent();
        }
        private string s_connection, e_databaseName;
        SqlConnection connection;
        string s_command, s_rcommand, s_tcommand;

        private void fdeMachine_Load(object sender, EventArgs e)
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
                SqlCommand sqlCommand = new SqlCommand("GMT", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewMachine.DataSource = dt;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i == 0)
                        dataGridViewMachine.Columns[i].HeaderText = "Machine ID";
                    else if (i == 1)
                        dataGridViewMachine.Columns[i].HeaderText = "Slot ID";
                    else if (i == 2)
                        dataGridViewMachine.Columns[i].HeaderText = "Expiration Date";
                    else if (i == 3)
                        dataGridViewMachine.Columns[i].HeaderText = "Price";
                    else if (i == 4)
                        dataGridViewMachine.Columns[i].HeaderText = "Quantity";
                    else if (i == 5)
                        dataGridViewMachine.Columns[i].HeaderText = "Threshold Value";
                    else if (i == 6)
                        dataGridViewMachine.Columns[i].HeaderText = "Balance";
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

        private void gButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("EditMachine", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@emid", gTextBoxIdFDE.Text);
                sqlCommand.Parameters.AddWithValue("@emname", gTextBoxNameFDE.Text);
                sqlCommand.Parameters.AddWithValue("@eexdate", guna2DateTimePickerFDE.Value);
                sqlCommand.Parameters.AddWithValue("@eprice", Convert.ToDouble(gTextBoxPriceFDE.Text));
                sqlCommand.Parameters.AddWithValue("@ecounts", int.Parse(gTextBoxQuantityFDE.Text));
                sqlCommand.Parameters.AddWithValue("@ethresholdvalue", int.Parse(gTextBoxThresholdValueFDE.Text));
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data updated!");
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
                SqlCommand sqlCommand = new SqlCommand("FindMachine", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@fmid", gTextBoxIdFDE.Text);
                sqlCommand.Parameters.AddWithValue("@fmname", gTextBoxNameFDE.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.Read())
                {
                    gTextBoxNameFDE.Text = reader[1].ToString();
                    guna2DateTimePickerFDE.Value = Convert.ToDateTime(reader[2]);
                    gTextBoxPriceFDE.Text = reader[3].ToString();
                    gTextBoxQuantityFDE.Text = reader[4].ToString();
                    gTextBoxThresholdValueFDE.Text = reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Machine not found!");
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
                MessageBox.Show("Enter Machine ID!");
                return;
            }
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteMachine", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@dmid", gTextBoxIdFDE.Text);
                sqlCommand.Parameters.AddWithValue("@dmname", gTextBoxNameFDE.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Machine deleted!");
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
            foreach(Control textBoxs in this.Controls)
            {
                if(textBoxs.GetType() == typeof(Guna2TextBox))
                {
                    textBoxs.Text = string.Empty;
                }
            }
            guna2DateTimePickerFDE.Value = DateTime.Now;
        }

        private void gTextBoxIdFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxNameFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxPriceFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void dataGridViewMachine_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            gTextBoxIdFDE.Text = dataGridViewMachine.CurrentRow.Cells[0].Value.ToString();
            gTextBoxNameFDE.Text = dataGridViewMachine.CurrentRow.Cells[1].Value.ToString();
            guna2DateTimePickerFDE.Value = Convert.ToDateTime(dataGridViewMachine.CurrentRow.Cells[2].Value);
            gTextBoxPriceFDE.Text = dataGridViewMachine.CurrentRow.Cells[3].Value.ToString();
            gTextBoxQuantityFDE.Text = dataGridViewMachine.CurrentRow.Cells[4].Value.ToString();
            gTextBoxThresholdValueFDE.Text = dataGridViewMachine.CurrentRow.Cells[5].Value.ToString();
        }

        private void gTextBoxQuantityFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxThresholdValueFDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxThresholdValueFDE_TextChanged(object sender, EventArgs e)
        {
            if (gTextBoxThresholdValueFDE.Text == string.Empty) return;
            if (gTextBoxQuantityFDE.Text == string.Empty)
            {
                MessageBox.Show("Enter count of products!");
                gTextBoxThresholdValueFDE.Text = string.Empty;
                gTextBoxQuantityFDE.Focus();
            }
            else if (int.Parse(gTextBoxThresholdValueFDE.Text) >= int.Parse(gTextBoxQuantityFDE.Text))
            {
                MessageBox.Show("The threshold value can't be more than count of product!");
                gTextBoxThresholdValueFDE.Text = string.Empty;
            }
        }
    }
}
