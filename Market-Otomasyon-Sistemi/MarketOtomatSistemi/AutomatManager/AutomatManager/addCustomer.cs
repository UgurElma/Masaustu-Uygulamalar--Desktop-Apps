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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }
        private string s_connection, e_databaseName, gender;
        SqlConnection connection;
        Random random = new Random();
        int randomID;
        bool isSame = true;

        private void addCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            e_databaseName = formEnter.databasename;
            s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=" + e_databaseName + ";Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
        }
        private void SetRandomID()
        {
            try
            {
                connection.Open();
                while(isSame)
                {
                    randomID = random.Next(10000000, 100000000);
                    SqlCommand _command = new SqlCommand("FindCustomer", connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@fcid", randomID);
                    SqlDataReader _reader = _command.ExecuteReader();
                    if (!_reader.Read())
                    {
                        isSame = false;
                    }
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

        private void GenderControl()
        {
            if(radioButtonMan.Checked)
            {
                gender = "Man";
            }
            else if(radioButtonWoman.Checked)
            {
                gender = "Woman";
            }
            else
            {
                MessageBox.Show("Choose a gender!");
                return;
            }
        }
        private void gButtonAdd_Click(object sender, EventArgs e)
        {
            SetRandomID();
            GenderControl();
            gTextBoxIdAdd.Text = randomID.ToString();
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("AddCustomer", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@acid",randomID);
                sqlCommand.Parameters.AddWithValue("@acname", gTextBoxNameAdd.Text);
                sqlCommand.Parameters.AddWithValue("@acsurname", gTextBoxSurnameAdd.Text);
                sqlCommand.Parameters.AddWithValue("@ajdate", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@apnumber", gTextBoxPhoneAdd.Text);
                sqlCommand.Parameters.AddWithValue("@acbalance", Convert.ToDouble(gTextBoxBalanceAdd.Text));
                sqlCommand.Parameters.AddWithValue("@agender", gender);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Customer added!");
                isSame = true;
                gButtonClear_Click(sender, e);
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

        private void gButtonClear_Click(object sender, EventArgs e)
        {
            foreach(Control textBoxs in this.Controls)
            {
                if (textBoxs.GetType() == typeof(Guna2TextBox))
                {
                    textBoxs.Text = string.Empty;
                }
                radioButtonWoman.Checked = false;
                radioButtonMan.Checked = false;
            }
        }

        private void gTextBoxIdAdd_KeyPress(object sender, KeyPressEventArgs e)
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
            if(gTextBoxBalanceAdd.Text != string.Empty && (double.Parse(gTextBoxBalanceAdd.Text) > 300 || double.Parse(gTextBoxBalanceAdd.Text) < 0))
            {
                MessageBox.Show("You can load money between 0 and 300 TL!");
                gTextBoxBalanceAdd.Text = string.Empty;
            }
        }
    }
}
