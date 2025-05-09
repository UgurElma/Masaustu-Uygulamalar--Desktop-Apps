using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserScene
{
    public partial class FormUserScene : Form
    {
        public FormUserScene()
        {
            InitializeComponent();
        }
        string hour, day, month, gg, hh, yy;  
        string machineID;
        string s_connection, s_rcommand, isUserScene, databaseName, name;
        TextBox[] textBoxes;
        Button[] buttons;
        bool isfocus, isOk;
        SqlConnection connection;
        private void FormUserScene_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[] { textBoxID, textBoxIndex, textBoxAmount };
            buttons = new Button[] { buttonZero, buttonOne, buttonTwo, buttonThree, buttonFour, buttonFive, buttonSix, buttonSeven, buttonEight, buttonNine };
            s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=AutomatSystem;Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
            machineID = "11111111";
        }

        private void ReturnDatabase()
        {
            try
            {
                connection.Open();
                s_rcommand = "use "+databaseName+";";
                SqlCommand sqlCommand1 = new SqlCommand(s_rcommand, connection);
                sqlCommand1.ExecuteNonQuery();
                isOk = true;
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
                if(isOk)
                {
                    s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=" + databaseName + ";Integrated Security=True;Encrypt=False";
                    connection = new SqlConnection(s_connection);
                }
            }
        }
        private void SetUpMachine()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("isUserScene", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id",textBoxID.Text);
                sqlCommand.Parameters.AddWithValue("@value", 1);
                SqlDataReader reader = sqlCommand.ExecuteReader();  
                if (reader.Read())
                {
                    labelCompanyName.Text = reader[3].ToString();
                    databaseName = reader[8].ToString();
                    isUserScene = reader[9].ToString();
                    groupBoxBG.Text = "Thank you for choosing us.";
                    textBoxID.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Manager not found!");
                }
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) connection.Close();
                ReturnDatabase();
            }
        }

        private void textBoxID_Enter(object sender, EventArgs e)
        {
            if(textBoxID.Text == "Enter your id...")
            {
                textBoxID.Clear();
                textBoxID.ForeColor = SystemColors.HotTrack;
                isfocus = true;
            }
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if(textBoxID.Text == string.Empty)
            {
                textBoxID.Text = "Enter your id...";
                textBoxID.ForeColor= SystemColors.ActiveCaption;
            }
            if(isfocus)
            {
                textBoxID.Focus();
            }
        }

        private void textBoxAmount_Enter(object sender, EventArgs e)
        {
            if(textBoxAmount.Text == "--")
            {
                textBoxAmount.Clear();
                textBoxAmount.ForeColor = Color.FromArgb(0, 64, 0);
                isfocus = true;
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            if(textBoxAmount.Text == string.Empty)
            {
                textBoxAmount.Text = "--";
                textBoxAmount.ForeColor = Color.DarkSeaGreen;
            }
            if(isfocus)
            {
                textBoxAmount.Focus();
            }
        }

        private void textBoxIndex_Enter(object sender, EventArgs e)
        {
            if(textBoxIndex.Text == "index")
            {
                textBoxIndex.Clear();
                textBoxIndex.ForeColor = Color.FromArgb(64, 0, 0);
                isfocus = true;
            }
        }

        private void textBoxIndex_Leave(object sender, EventArgs e)
        {
            if (textBoxIndex.Text == string.Empty)
            {
                textBoxIndex.Text = "index";
                textBoxIndex.ForeColor = Color.RosyBrown;
            }
            if(isfocus)
            {
                textBoxIndex.Focus();
            }
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIndex.Visible = radioButtonBuy.Checked;
            if (radioButtonBuy.Checked)
            {
                textBoxAmount.Text = string.Empty;
                checkBoxControl.Checked = false;
                groupBoxBG.Text = "Enjoy your meal.";
            }
        }

        private void radioButtonLoadMoney_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAmount.Visible = radioButtonLoadMoney.Checked;
            checkBoxControl.Visible = radioButtonLoadMoney.Checked;
            if (radioButtonLoadMoney.Checked)
            {
                textBoxIndex.Text = string.Empty;
                groupBoxBG.Text = "Thank you for choosing us.";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach(Control control in panelOperation.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    control.Text = string.Empty;
                }
                radioButtonBuy.Checked = false;
                radioButtonLoadMoney.Checked = false;
                checkBoxControl.Checked = false;
                labelBalance.Text = "Bakiye: --- TL";
                radioButtonBuy.Visible = false;
                radioButtonLoadMoney.Visible = false;
                buttonFinish.Visible = false;
                if(isUserScene == "True")
                {
                    groupBoxBG.Text = "Thank you for choosing us.";
                }
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            if(!textBoxID.Focused && textBoxID.Text == string.Empty)
            {
                textBoxID_Leave(sender, e);
            }
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIndex.Focused && textBoxIndex.Text == string.Empty)
            {
                textBoxIndex_Leave(sender, e);
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxAmount.Focused && textBoxAmount.Text == string.Empty)
            {
                textBoxAmount_Leave(sender, e);
            }
        }
        string value;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Focused)
                {
                    for (int j = 0; j < textBoxes[i].TextLength - 1; j++)
                    {
                        value += textBoxes[i].Text[j].ToString();
                    }
                    textBoxes[i].Text = value;
                    value = string.Empty;
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (isUserScene != "True")
            {
                SetUpMachine();
            }
            else
            {
                isfocus = false;
                if(textBoxID.Focused)
                {
                    MusteriBul();
                }
                else if(textBoxIndex.Focused)
                {
                    if(int.Parse(textBoxIndex.Text) >= 1 && int.Parse(textBoxIndex.Text) <= 27)
                    {
                        Buy();
                    }
                    else
                    {
                        MessageBox.Show("Control the index!");
                        textBoxIndex.Text = string.Empty;
                        textBoxIndex.Focus();
                    }
                }
                else if(radioButtonLoadMoney.Checked)
                {
                    if (int.Parse(textBoxAmount.Text) >= 5 && int.Parse(textBoxAmount.Text) <= 300)
                    {
                        if(checkBoxControl.Checked)
                        {
                            LoadMoney();
                            checkBoxControl.Checked = false;
                            textBoxAmount.Text = string.Empty;
                            radioButtonLoadMoney.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Control the checkbox!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can load money between 5 and 300 TL!");
                        textBoxAmount.Text = string.Empty;
                        textBoxAmount.Focus();
                    }
                }
            }
        }
        private void MusteriBul()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("FindCustomer", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@fcid",textBoxID.Text);
                SqlDataReader rdr = sqlCommand.ExecuteReader();
                if (rdr.Read())
                {
                    labelBalance.Text = rdr[1].ToString() + "'s Balance: " + rdr[5].ToString() + " TL";
                    radioButtonBuy.Visible = true;
                    radioButtonLoadMoney.Visible = true;
                    buttonFinish.Visible = true;    
                    name = rdr[1].ToString();
                }
                else
                {
                    groupBoxBG.Text = "Customer not found!";
                    labelBalance.Text = "Bakiye: --- TL";
                    radioButtonBuy.Visible = false;
                    radioButtonLoadMoney.Visible = false;
                    textBoxID.Text = string.Empty;
                    name = string.Empty;
                }
                rdr.Close();
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if(connection != null) { connection.Close(); }
            }
        }
        private void Buy()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("GBI", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", machineID);
                cmd.Parameters.AddWithValue("@index", textBoxIndex.Text);
                cmd.Parameters.AddWithValue("@cid", textBoxID.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[0].ToString() == string.Empty || reader[1].ToString() == string.Empty || reader[2].ToString() == string.Empty)
                    {
                        MessageBox.Show("This id is null!");
                    }
                    else
                    {
                        if (Convert.ToInt32(reader[0]) >= Convert.ToInt32(reader[2]) && Convert.ToInt32(reader[1]) > 0)
                        {
                            reader.Close();
                            SqlCommand sqlCommand1 = new SqlCommand("Buy", connection);
                            sqlCommand1.CommandType = CommandType.StoredProcedure;
                            sqlCommand1.Parameters.AddWithValue("@mid", machineID);
                            sqlCommand1.Parameters.AddWithValue("@index", textBoxIndex.Text);
                            sqlCommand1.Parameters.AddWithValue("@cid", textBoxID.Text);
                            SqlDataReader rdr = sqlCommand1.ExecuteReader();
                            if (rdr.Read())
                            {
                                labelBalance.Text = name + "'s Balance: " + rdr[0].ToString() + " TL";
                                MessageBox.Show("The cover of the product with ID " + textBoxIndex.Text + " has been opened.");
                                rdr.Close();
                                ControlTheDateTime();
                                InsertTheReceipt();
                            }
                        }
                        else if (Convert.ToInt32(reader[0]) >= Convert.ToInt32(reader[2]) && Convert.ToInt32(reader[1]) == 0)
                        {
                            MessageBox.Show("This id is null!");
                            textBoxIndex.Text = string.Empty;
                            textBoxIndex.Focus();
                            reader.Close();
                        }
                        else if (Convert.ToInt32(reader[0]) < Convert.ToInt32(reader[2]) && Convert.ToInt32(reader[1]) > 0)
                        {
                            MessageBox.Show("Insufficient funds!");
                            textBoxIndex.Text = string.Empty;
                            textBoxIndex.Focus();
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Try again later!");
                            textBoxIndex.Text = string.Empty;
                            textBoxIndex.Focus();
                            reader.Close();
                        }
                    }
                }
                textBoxIndex.Text = string.Empty;
                radioButtonBuy.Checked = false;
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if (connection != null) { connection.Close();}
            }
        }
        private void LoadMoney()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("LoadMoney", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@cid", textBoxID.Text);
                sqlCommand.Parameters.AddWithValue("@cbalance", Convert.ToDouble(textBoxAmount.Text));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(textBoxAmount.Text + " TL has been added to your account.");
                    labelBalance.Text = name + "'s Balance: " + reader[0].ToString() + " TL";
                }
            }
            catch
            {
                MessageBox.Show("Warning! An error occurred while connecting.");
            }
            finally
            {
                if(connection != null) { connection.Close();}
            }
        }
        private void ControlTheDateTime() 
        {
            //Zaman dilimi
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 8)
                hour = 1.ToString();
            else if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 12)
                hour = 2.ToString();
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
                hour = 3.ToString();
            else if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 20)
                hour = 4.ToString();
            else if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour < 24)
                hour = 5.ToString();
            //Gün dilimi
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thurday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < days.Length; i++)
            {
                if (DateTime.Now.DayOfWeek.ToString() == days[i])
                    day = (i + 1).ToString();
            }
            //Ay dilimi
            month = DateTime.Now.Month.ToString();
            //Gün verisi
            gg = DateTime.Now.Day.ToString();
            //Hafta verisi
            hh = HaftaNumarasiBul(DateTime.Now).ToString();
            //Yıl verisi
            yy = DateTime.Now.Year.ToString();
        }
        private int HaftaNumarasiBul(DateTime Tarih)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(Tarih);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                Tarih = Tarih.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Tarih, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        private void InsertTheReceipt()
        {
            SqlCommand sqlCommand = new SqlCommand("ITR", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@mID", machineID);
            sqlCommand.Parameters.AddWithValue("@slID", textBoxIndex.Text);
            sqlCommand.Parameters.AddWithValue("@cID", textBoxID.Text);
            sqlCommand.Parameters.AddWithValue("@bdate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@hP", hour);
            sqlCommand.Parameters.AddWithValue("@dP", day);
            sqlCommand.Parameters.AddWithValue("@mP", month);
            sqlCommand.Parameters.AddWithValue("@gg", gg);
            sqlCommand.Parameters.AddWithValue("@hh", hh);
            sqlCommand.Parameters.AddWithValue("@yy", yy);
            sqlCommand.ExecuteNonQuery();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void textBoxIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
           NumLockss(sender);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            NumLockss(sender);
        }
        private void NumLockss(object _sender)
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                if(_sender == buttons[i])
                {
                    for (int j = 0; j < textBoxes.Length; j++)
                    {
                        if (textBoxes[j].Focused)
                        {
                            if(j == 0 && textBoxID.TextLength < 8)
                            {
                                textBoxes[j].Text += i.ToString();
                            }
                            else if (j == 1 && textBoxIndex.TextLength < 2)
                            {
                                textBoxes[j].Text += i.ToString();
                            }
                            else if (j == 2 && textBoxAmount.TextLength < 3)
                            {
                                textBoxes[j].Text += i.ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
