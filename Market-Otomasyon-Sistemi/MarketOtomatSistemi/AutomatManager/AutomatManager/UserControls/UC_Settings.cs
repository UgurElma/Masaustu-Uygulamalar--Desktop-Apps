using AutomatManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatManager.UserControls
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }
        OpenFileDialog dlg = new OpenFileDialog();
        private string s_connection, _id, _password;
        SqlConnection connection;
        formMenu _formMenu = new formMenu();

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            s_connection = formEnter.baglanti;
            connection = new SqlConnection(s_connection);
            GetValues();
        }

        private void GetValues()
        {
            _id = formEnter.id;
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetManager", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", _id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    gLabelID.Text = "ID: " + reader[0].ToString();
                    _password = reader[1].ToString();
                    gTextBoxMail.Text = reader[2].ToString();
                    gTextBoxCompanyName.Text = reader[3].ToString();
                    gTextBoxManagerName.Text = reader[4].ToString();
                    gPictureBoxCompany.ImageLocation = reader[5].ToString();
                    gPictureBoxManager.ImageLocation = reader[6].ToString();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while retrieving data!");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
        }

        private void gPictureBoxCompany_Click(object sender, EventArgs e)
        {
            string loc = gPictureBoxCompany.ImageLocation;
            dlg.ShowDialog();
            gPictureBoxCompany.ImageLocation = dlg.FileName;
            dlg.FileName = string.Empty;
            if(gPictureBoxCompany.ImageLocation == string.Empty)
            {
                if (loc == string.Empty)
                    gPictureBoxCompany.Image = Resources.app_icon;
                else
                    gPictureBoxCompany.ImageLocation = loc;
            }
        }

        private void gPictureBoxManager_Click(object sender, EventArgs e)
        {
            string loc = gPictureBoxManager.ImageLocation;
            dlg.ShowDialog();
            gPictureBoxManager.ImageLocation = dlg.FileName;
            dlg.FileName = string.Empty;
            if (gPictureBoxManager.ImageLocation == string.Empty)
            {
                if(loc == string.Empty)
                    gPictureBoxManager.Image = Resources.user;
                else
                    gPictureBoxManager.ImageLocation = loc;
            }
        }

        private void gButtonSave_Click(object sender, EventArgs e)
        {
            SaveNamesandLogos();
            GetValues();
            _formMenu.Activate();
        }

        private void SaveNamesandLogos()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SetManager", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", gTextBoxMail.Text);
                cmd.Parameters.AddWithValue("companyName", gTextBoxCompanyName.Text);
                cmd.Parameters.AddWithValue("managerName", gTextBoxManagerName.Text);
                cmd.Parameters.AddWithValue("companyLogo", gPictureBoxCompany.ImageLocation);
                cmd.Parameters.AddWithValue("managerLogo", gPictureBoxManager.ImageLocation);
                cmd.Parameters.AddWithValue("@ID", _id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information saved!");
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

        private void gButtonChange_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("ChangePasswordManager", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", _id);
                sqlCommand.Parameters.AddWithValue("@pin", gTextBoxNewPassword.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Password changed!");
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

        private void gTextBoxCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void gTextBoxManagerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void gTextBoxOldPassord_TextChanged(object sender, EventArgs e)
        {
            if(_password == gTextBoxOldPassord.Text)
            {
                gButtonChange.Enabled = true;
            }
            else
            {
                gButtonChange.Enabled = false;
            }
        }

        private void gTextBoxOldPassord_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gTextBoxNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
