using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace AutomatManager.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        private string s_connection, e_databaseName;
        SqlConnection connection;
        string s_command1, s_command2, s_command3, s_command4, s_command5, s_command6, s_command7;
        string[] databases;
        Guna2HtmlLabel[] labels;

        private void UC_Home_Load(object sender, EventArgs e)
        {
            gLabelTodayDate.Text = DateTime.Now.ToString();
            e_databaseName = formEnter.databasename;
            s_connection = "Data Source=UGUR\\SQLEXPRESS;Initial Catalog=" + e_databaseName + ";Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(s_connection);
            GetInfo();
            GetWarningTable();
            GetHourPeriod();
            GetDayPeriod();
            GetMonthPeriod();
        }
        private void GetHourPeriod()
        {
            try
            {
                connection.Open();
                for(int i = 1; i <= 5; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand("GHP", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@hp", i.ToString());
                    sqlCommand.Parameters.AddWithValue("@gg", DateTime.Now.Day.ToString());
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if(reader.Read())
                    {
                        int value = Convert.ToInt32(reader[0]);
                        chart1.Series[0].Points.Add(value);
                        if(value > 0)
                            chart1.Series[0].Points[i-1].AxisLabel = i + ". Period(" + value + ")";
                    }
                    reader.Close();
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
        private void GetDayPeriod()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thurday", "Friday", "Saturday", "Sunday" };
            try
            {
                connection.Open();
                for (int i = 1; i <= 7; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand("GDP", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@dp", i.ToString());
                    sqlCommand.Parameters.AddWithValue("@hh", HaftaNumarasiBul(DateTime.Now).ToString());
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        int value = Convert.ToInt32(reader[0]);
                        chart2.Series[0].Points.Add(value);
                        chart2.Series[0].Points[i - 1].AxisLabel = days[i-1];
                    }
                    reader.Close();
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
        private int HaftaNumarasiBul(DateTime Tarih)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(Tarih);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                Tarih = Tarih.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(Tarih, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        private void GetMonthPeriod()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            try
            {
                connection.Open();
                for (int i = 1; i <= 12; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand("GMP", connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@mp", i.ToString());
                    sqlCommand.Parameters.AddWithValue("@yy", DateTime.Now.Year.ToString());
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        int value = Convert.ToInt32(reader[0]);
                        chart3.Series[0].Points.Add(value);
                        chart3.Series[0].Points[i - 1].AxisLabel = months[i - 1];
                    }
                    reader.Close();
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
        private void GetWarningTable()
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("GetWarningTable", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                dt.Columns.Add("Type");
                adapter.Fill(dt);
                gDataGridViewWTable.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string a = gDataGridViewWTable.Rows[i].Cells[5].Value.ToString();
                    string b = gDataGridViewWTable.Rows[i].Cells[6].Value.ToString();
                    string c = gDataGridViewWTable.Rows[i].Cells[3].Value.ToString();
                    if(Convert.ToDateTime(c) < DateTime.Now)
                    {
                        gDataGridViewWTable.Rows[i].Cells[0].Value = "Date Warning";
                    }
                    else if (int.Parse(a) < int.Parse(b))
                    {
                        gDataGridViewWTable.Rows[i].Cells[0].Value = "Quantity Warning";
                    }
                }
                for (int i = 0;i < dt.Columns.Count;i++)
                {
                    if(i == 0)
                        gDataGridViewWTable.Columns[i].HeaderText = "Warning Type";
                    else if (i == 1)
                        gDataGridViewWTable.Columns[i].HeaderText = "Machine ID";
                    else if (i == 2)
                        gDataGridViewWTable.Columns[i].HeaderText = "Slot ID";
                    else if (i == 3)
                        gDataGridViewWTable.Columns[i].HeaderText = "Expretion Date";
                    else if (i == 4)
                        gDataGridViewWTable.Columns[i].HeaderText = "Price";
                    else if (i == 5)
                        gDataGridViewWTable.Columns[i].HeaderText = "Quantity";
                    else if (i == 6)
                        gDataGridViewWTable.Columns[i].HeaderText = "Threshold Value";
                    else if (i == 7)
                        gDataGridViewWTable.Columns[i].HeaderText = "Balance";
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
        private void GetInfo()
        {
            try
            {
                connection.Open();
                s_command1 = "GetBalanceManager";
                s_command2 = "GetCustomerCount";
                s_command3 = "GetManCustomerCount";
                s_command4 = "GetWomanCustomerCount";
                s_command5 = "GetMachineCount";
                s_command6 = "GetEMachineCount";
                s_command7 = "GetTMachineCount";
                databases = new string[] { s_command1, s_command2, s_command3, s_command4, s_command5, s_command6, s_command7};
                labels = new Guna2HtmlLabel[] { gLabelBalance, gLabelCustomersCount, gLabelManCustomers, gLabelWomanCustomers, gLabelMachineCounts, gLabelEWarningCounts, gLabelTWarningCounts };
                for(int i = 0 ; i < databases.Length; i++)
                {
                    SqlCommand sqlCommand = new SqlCommand(databases[i], connection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if(i == 0)
                    {
                        if (reader.Read())
                            labels[i].Text = reader[0].ToString() + " TL";
                        if (reader[0].ToString() == string.Empty)
                            labels[i].Text = "0 TL";
                        reader.Close();
                    }
                    else if(i == 1 || i == 2 || i == 3)
                    {
                        if (reader.Read())
                            labels[i].Text = reader[0].ToString() + " Person";
                        if (reader[0].ToString() == string.Empty)
                            labels[i].Text = "0 Person";
                        reader.Close();
                    }
                    else if(i == 4 || i == 5 || i == 6)
                    {
                        if (reader.Read())
                            labels[i].Text = reader[0].ToString() + " Machine";
                        if (reader[0].ToString() == string.Empty)
                            labels[i].Text = "0 Machine";
                        reader.Close();
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
    }
}
