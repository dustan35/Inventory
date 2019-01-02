using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Net;
using System.Text.RegularExpressions;

namespace Inventory
{

    public partial class invEntry : Form
    {

        public invEntry()
        {
            InitializeComponent();
        }


        private void bkBtn_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void sbtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //String to connect to database  
                string connection = "Data Source=MSBML-710;Initial Catalog=Inventory;Integrated Security=True";
                //query to insert the data from the forms  
                string query = "insert into Inventory(name, date, cost, serialNum, [user], ipaddress, invNum, add_inv, del_inv, type, computerName) values('" + this.name1.Text + "','" + this.date1.Text + "','" + this.price1.Text + "','" + this.serialNum1.Text + "','" + this.user1.Text + "','" + this.ipaddress1.Text + "','" + this.invNum1.Text + "','" + this.add_inv1.Text + "','" + this.del_inv1.Text + "','" + this.type1.Text + "','" + this.computerName1.Text + "')";
                string value = ipaddress1.Text;
                IPAddress address;
                bool result = IPAddress.TryParse(value, out address);
                string ipaddress = ipaddress1.Text;
                string input = ipaddress1.Text;
                string pattern = @"[1-9](\d*\.?\d{1}?){3}";
                Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

                MatchCollection matches = rgx.Matches(input);
                if (ipaddress1.Text != "")
                {
                    if (matches.Count > 0)
                    {

                        if (ipaddress.ToString() != "")
                        {
                            if (result) //IP ADDRESS
                            {
                                //MessageBox.Show("Correct input");
                            }
                            else
                            {
                                MessageBox.Show("Incorrect value for IP Address, must be in xxx.xxx.xxx.xxx format");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect value for IP Address, must be in xxx.xxx.xxx.xxx format");
                        return;
                    }
                }
                string dateString = date1.Text;
                DateTime dateValue;
                bool resultDate = DateTime.TryParse(dateString, out dateValue); //Convert user input to DATE FORMAT
                //REQUIRED FIELDS

                //NAME

                string name = name1.Text;

                if (name == "")
                {
                    MessageBox.Show("Name is a required field");
                    return;
                }

                //USER
                string user = user1.Text;
                if (user == "")
                {
                    MessageBox.Show("User is a required field");
                    return;
                }
                //TYPE
                string type = type1.Text;
                if (type == "")
                {
                    MessageBox.Show("Type is a required field");
                    return;
                }
                //INVENTORY NUMBER
                string inv = invNum1.Text;
                string pattern1 = @"[0-9]";
                Regex rgx1 = new Regex(pattern1, RegexOptions.IgnoreCase);
                MatchCollection matches1 = rgx1.Matches(inv);

                if (inv == "")
                {
                    MessageBox.Show("Inventory is a required field");
                    return;

                }
                if (!(matches1.Count > 0))
                {
                    MessageBox.Show("Please enter numbers only for inventory!");
                    return;
                }


                SqlConnection con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
                SqlCommand command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
                SqlDataReader reader;//,reader2;
                con.Open(); //open connection
                reader = command.ExecuteReader();     // query executed and data saved into database.  
                MessageBox.Show("Record Saved");
                this.Hide();
                invEntry go = new invEntry();
                go.Show();
                while (reader.Read())
                {
                }
                con.Close(); //close connection


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newEntry_Click(object sender, EventArgs e)
        {
            invEntry new1 = new invEntry();
            new1.Show();

        }

        private void search1_Click(object sender, EventArgs e)
        {
            newSearch go = new newSearch();
            this.Hide();
            go.Show();
        }
        public void searchValues(string input)
        { //method to accept whatever focus the cursor has in the newSearch page

            //searches given information by user and fills boxes with information
            //SqlConnection olcn = new SqlConnection("Data Source=MSBML-710;Initial Catalog=Inventory;Integrated Security=True");
            //string input1 = input;
            ////input1 = name1.Text;
            //// //string query = "SELECT * FROM inventory where item= '" + this.searchBox.Text + "' or date='" + this.searchBox.Text + "' or price='" + this.searchBox.Text + "' or dept='" + this.searchBox.Text + "' or serial='" + this.searchBox.Text + "' or user='" + this.searchBox.Text + "' or ipaddy='" + this.searchBox.Text + "'";
            //// //string query = "SELECT * FROM inventory where item= '" + this.searchBox.Text + "' and price='" + this.searchBox.Text + "' and dept='" + this.searchBox.Text + "' and serial='" + this.searchBox.Text + "' and user='" + this.searchBox.Text + "' and ipaddy='" + this.searchBox.Text + "'";
            //string query = "select * from inventory where name='" + input1 + "'";// + "', date='" + this.date1.Text + "' , user='" + this.user1.Text + "' , computerName='" + this.computerName1.Text + "', item='" + this.type1.Text + "',ipaddress='" + this.ipaddress1.Text + "', invNum='" + this.invNum1.Text + "', serialNum='" + this.serialNum1.Text + "', and price='"+this.price1.Text+"'";


            //DataTable dt = new DataTable();
            //SqlDataAdapter oda = new SqlDataAdapter(query, olcn);
            //DataGridView newSearch1 = new DataGridView();
            //newSearch1.DataSource = dt;
            //oda.Fill(dt);
            //name1.Text = dt.Rows[0][0].ToString();
            //date1.Text = dt.Rows[0][1].ToString();
            //user1.Text = dt.Rows[0][2].ToString();
            //computerName1.Text = dt.Rows[0][3].ToString();
            //type1.Text = dt.Rows[0][4].ToString();
            //user1.Text = dt.Rows[0][5].ToString();
            //ipaddress1.Text = dt.Rows[0][6].ToString();
            //invNum1.Text = dt.Rows[0][7].ToString();
            //serialNum1.Text = dt.Rows[0][8].ToString();
            //price1.Text = dt.Rows[0][9].ToString();


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bkbutton_Click(object sender, EventArgs e)
        {
            invMngmt changeUser = new invMngmt();
            this.Hide();
            changeUser.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void type1_TextChanged(object sender, EventArgs e)
        {

        }

        private void date1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            invMngmt go = new invMngmt();
            MessageBox.Show("Logged out");
            this.Hide();
            go.Show();
        }

        internal void search1_Click()
        {
            throw new NotImplementedException();
        }

        private void invEntry_Load(object sender, EventArgs e)
        {

        }
    }
}