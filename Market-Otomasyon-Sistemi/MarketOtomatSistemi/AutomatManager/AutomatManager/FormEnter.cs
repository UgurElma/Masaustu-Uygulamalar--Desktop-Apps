using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AutomatManager
{
    public partial class formEnter : Form
    {
        public static string baglanti, id, databasename;
        string s_connection, e_id, e_password, e_databaseName, e_isBe;
        SqlConnection connection;
        string s_command;
        private string s_command1, s_command2, s_command3, s_command4, s_command5, s_command6, s_command7, s_command8, s_command9, s_command10, s_command11, s_command12, s_command13, s_command14, s_command15, s_command16, s_command17, s_command18, s_command19, s_command20, s_command21, s_command22, s_command23, s_command24, s_command25;
        private string[] s_commands;

        public formEnter()
        {
            InitializeComponent();
        }

        private void formEnter_Load(object sender, EventArgs e)
        {
            s_connection = "Data Source=.\\SQLEXPRESS;Initial Catalog=AutomatSystem;Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
            baglanti = s_connection;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxPassword.Clear();
            if (textBoxID.Text == string.Empty)
            {
                textBoxID.Text = "Enter id...";
                textBoxID.ForeColor = Color.LightSteelBlue;
            }
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.Text = "Enter password...";
                textBoxPassword.ForeColor = Color.LightSteelBlue;
                textBoxPassword.PasswordChar = default;
            }
            textBoxID.Focus();
            if (textBoxID.Text == "Enter id...")
            {
                textBoxID.Clear();
                textBoxID.ForeColor = Color.FromArgb(0, 117, 214);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetManager", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", textBoxID.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    e_id = reader[0].ToString();
                    e_password = reader[1].ToString();
                    e_isBe = reader[7].ToString();
                    e_databaseName = reader[8].ToString();
                }
                else
                {
                    MessageBox.Show("Check your id or password!");
                }
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
                if(e_isBe == "False")
                {
                    NewDatabase();
                }
                if (textBoxID.Text == e_id && textBoxPassword.Text == e_password)
                {
                    id = e_id;
                    databasename = e_databaseName;
                    formMenu formMenu = new formMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check your id or password!");
                }
            }
        }
        private void NewDatabase()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Database " + e_databaseName + ";", connection); 
                SqlCommand sqlCommand = new SqlCommand("updateIsBe", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@iBe", 1);
                sqlCommand.Parameters.AddWithValue("@id", e_id);
                cmd.ExecuteNonQuery();
                sqlCommand.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally 
            { 
                if(connection != null) connection.Close();
                Others();
            }
        }
        private void Others()
        {
            try
            {
                s_command = "use " + e_databaseName + ";";
                s_command += "Create Table MT(mid char(8), mname varchar(2), exdate smalldatetime, price float, counts int, thresholdvalue int, mbalance float);";
                s_command += "Create Table CT(cid char(8) primary key, cname nvarchar(20), csurname nvarchar(20), jdate smalldatetime, pnumber char(10), cbalance float, gender varchar(5));";
                s_command += "Create Table IAT(oID int IDENTITY(1,1) Primary Key, mID char(8), slID varchar(2), cID char(8), bdate smalldatetime, hP char(1), dP char(1), mP varchar(2), gg varchar(2), hh varchar(2), yy varchar(4));";
                s_command1 = "Create Procedure AddMachine(@amid char(8), @amname nvarchar(20), @aexdate smalldatetime, @aprice float, @acounts int, @athresholdvalue int, @ambalance float) as Insert into MT values(@amid, @amname, @aexdate, @aprice, @acounts, @athresholdvalue, @ambalance);";
                s_command2 = "Create Procedure EditMachine(@emid char(8), @emname nvarchar(20), @eexdate smalldatetime, @eprice float, @ecounts int, @ethresholdvalue int) as Update MT set exdate = @eexdate, price = @eprice, counts = @ecounts, thresholdvalue = @ethresholdvalue where mid = @emid and mname = @emname;";
                s_command3 = "Create Procedure FindMachine(@fmid char(8), @fmname nvarchar(20)) as Select * from MT where mid = @fmid and mname = @fmname;";
                s_command4 = "Create Procedure DeleteMachine(@dmid char(8), @dmname nvarchar(20)) as Delete from MT where mid = @dmid and mname = @dmname;";
                s_command5 = "Create Procedure AddCustomer(@acid char(8) , @acname nvarchar(20), @acsurname nvarchar(20), @ajdate smalldatetime, @apnumber char(10), @acbalance float, @agender varchar(5)) as Insert into CT values (@acid, @acname, @acsurname, @ajdate, @apnumber, @acbalance, @agender);";
                s_command6 = "Create Procedure EditCustomer(@ecid char(8) , @ecname nvarchar(20), @ecsurname nvarchar(20), @epnumber char(10), @ecbalance float, @egender varchar(5)) as Update CT set cid = @ecid, cname = @ecname, csurname = @ecsurname, pnumber = @epnumber, cbalance = @ecbalance, gender = @egender where cid = @ecid;";
                s_command7 = "Create Procedure FindCustomer(@fcid char(8)) as Select * from CT where cid = @fcid;";
                s_command8 = "Create Procedure DeleteCustomer(@dcid char(8)) as Delete from CT where cid = @dcid;";
                s_command9 = "Create Procedure GBI(@mid char(8),@index varchar(2),@cid char(8)) as Select cbalance, (Select counts from MT where mname = @index and mid = @mid), (Select price from MT where mname = @index and mid = @mid) from CT where cid = @cid;";
                s_command10 = "Create Procedure Buy(@mid char(8),@index varchar(2),@cid char(8)) as Update MT set mbalance += price, counts -= 1 where mname = @index and mid = @mid; Update CT set cbalance -= (Select price from MT where mname = @index and mid = @mid) where cid = @cid; Select cbalance from CT where cid = @cid;";
                s_command11 = "Create Procedure LoadMoney(@cid char(8),@cbalance float) as Update CT set cbalance += @cbalance where cid = @cid; Select cbalance from CT where cid = @cid;";
                s_command12 = "Create Procedure GCT as Select * from CT;";
                s_command13 = "Create Procedure GMT as Select * from MT;";
                s_command14 = "Create Procedure GetBalanceManager as Select sum(mbalance) from MT;";
                s_command15 = "Create Procedure GetCustomerCount as Select count(cid) from CT;";
                s_command16 = "Create Procedure GetManCustomerCount as Select count(cid) from CT where gender = 'Man';";
                s_command17 = "Create Procedure GetWomanCustomerCount as Select count(cid) from CT where gender = 'Woman';";
                s_command18 = "Create Procedure GetMachineCount as Select count(mid) from MT;";
                s_command19 = "Create Procedure GetEMachineCount as Select count(mid) from MT where exdate < GETDATE();";
                s_command20 = "Create Procedure GetTMachineCount as Select count(mid) from MT where thresholdvalue > counts;";
                s_command21 = "Create Procedure GetWarningTable as Select * from MT where exdate < GETDATE() or thresholdvalue > counts;";
                s_command22 = "Create Procedure ITR(@mID char(8), @slID varchar(2), @cID char(8), @bdate smalldatetime, @hP char(1), @dP char(1), @mP varchar(2), @gg varchar(2), @hh varchar(2), @yy varchar(4)) as Insert into IAT values(@mID, @slID, @cID, @bdate, @hP, @dP, @mP, @gg, @hh, @yy);";
                s_command23 = "Create Procedure GHP(@hp char(1), @gg varchar(2)) as Select Count(oID) from IAT where hP = @hp and gg = @gg;";
                s_command24 = "Create Procedure GDP(@dp char(1), @hh varchar(2)) as Select Count(oID) from IAT where dP = @dp and hh = @hh;";
                s_command25 = "Create Procedure GMP(@mp varchar(2), @yy varchar(4)) as Select Count(oID) from IAT where mP = @mp and yy = @yy;";
                s_commands = new string[] { s_command1, s_command2, s_command3, s_command4, s_command5, s_command6, s_command7, s_command8, s_command9, s_command10, s_command11, s_command12, s_command13, s_command14, s_command15, s_command16, s_command17, s_command18, s_command19, s_command20, s_command21, s_command22, s_command23, s_command24, s_command25 };
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(s_command, connection);
                sqlCommand.ExecuteNonQuery();
                for (int i = 0; i < s_commands.Length; i++)
                {
                    SqlCommand sqlCommand1 = new SqlCommand(s_commands[i], connection);
                    sqlCommand1.ExecuteNonQuery();
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxID_Enter(object sender, EventArgs e)
        {
            if(textBoxID.Text == "Enter id...")
            {
                textBoxID.Clear();
                textBoxID.ForeColor = Color.FromArgb(0, 117, 214);
            }
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if(textBoxID.Text == string.Empty)
            {
                textBoxID.Text = "Enter id...";
                textBoxID.ForeColor = Color.LightSteelBlue;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.Text = "Enter password...";
                textBoxPassword.ForeColor = Color.LightSteelBlue;
                textBoxPassword.PasswordChar = default;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Enter password...")
            {
                textBoxPassword.Clear();
                textBoxPassword.ForeColor = Color.FromArgb(0, 117, 214);
                textBoxPassword.PasswordChar = '*';
            }
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
