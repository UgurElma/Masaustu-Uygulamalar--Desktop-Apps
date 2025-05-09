using AutomatManager.Properties;
using AutomatManager.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatManager
{
    public partial class formMenu : Form
    {
        public static Panel panel;
        private string s_connection, _id;
        SqlConnection connection;
        public formMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home, Resources.home);
            panel = panelController;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void formMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addUserControl(UserControl userControl, Image image)
        {
            pictureBox2.Image = image;
            panelController.BackColor = Color.DarkSlateGray;
            userControl.Dock = DockStyle.Fill;
            panelConteiner.Controls.Clear();
            panelConteiner.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void gbuttonHome_Click(object sender, EventArgs e)
        {
            UC_Home uC_Home = new UC_Home();
            addUserControl(uC_Home, Resources.home);
        }

        private void gbuttonMachineOperations_Click(object sender, EventArgs e)
        {
            UC_Machine uC_Machine = new UC_Machine();
            addUserControl(uC_Machine, Resources.cabinetvendingmachine);
        }

        private void gbuttonCustomerOperations_Click(object sender, EventArgs e)
        {
            UC_Customer uC_Customer = new UC_Customer();
            addUserControl(uC_Customer, Resources.customers);
        }

        private void gbuttonSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uC_Settings = new UC_Settings();
            addUserControl(uC_Settings, Resources.settings1);
        }

        private void gbuttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbuttonMaximized_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                gbuttonMaximized.Image = Resources.minimize__1_;
            }
            else
            {
                WindowState= FormWindowState.Normal;
                gbuttonMaximized.Image = Resources.maximazed;
            }
        }

        private void gbuttonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void formMenu_Activated(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void GetSettings()
        {
            _id = formEnter.id;
            try
            {
                s_connection = formEnter.baglanti;
                connection = new SqlConnection(s_connection);
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetManager", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", _id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[3].ToString() != string.Empty)
                    {
                        labelCompanyName.Text = reader[3].ToString();
                        labelManagerName.Text = reader[4].ToString();
                    }
                    gPictureBoxCompanyLogo.ImageLocation = reader[5].ToString();
                    gPictureBoxManagerLogo.ImageLocation = reader[6].ToString();
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
    }
}
