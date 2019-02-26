using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMB
{
    public partial class invMngmt : Form
    {
        
        public invMngmt()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            //Connecting using SQLConnection

            string query;
            string connection;
            SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
            SqlCommand command = new SqlCommand(); //This is command class which will handle the query and connection object.
            SqlDataReader reader;
            //"Data Source=MSBML-710;Initial Catalog=LoginInv;Integrated Security=True";
            connection = "Data Source=MSBML-710\\MSBML;Initial Catalog=LoginInv;Integrated Security=True;";
            //send login info to database

            //string pass1 = pass.Text.Trim();
            query = "select * from loginInv where [user]='" + this.userName.Text + "' and pass='" + this.pass.Text + "'";
            con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
            //MessageBox.Show(con.ToString());
            con.Open(); //open connection
            command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
            reader = command.ExecuteReader();
            
            //DataSet ds = new DataSet();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = command;
            //sda.Fill(ds, "pass1");
            //int i = 0;
            //if (ds.Tables[i].Rows.Count < 0)
            //{
            //    if (pass1 == ds.Tables[i].Rows[i]["password"].ToString())
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("Try again, information is duplicated");
            //    }
            //}
            //Connecting using OleDbConnection(MS Access)/ Not full functionality at the moment
            //string query;
            //string connection;
            //OleDbConnection con = new OleDbConnection(); //SqlConnection object to pass my connection string.
            //OleDbCommand command;// = new OleDbCommand(); //This is command class which will handle the query and connection object.
            //OleDbDataReader reader;
            ////"Data Source=MSBML-710;Initial Catalog=LoginInv;Integrated Security=True";
            //connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\mmoore\\source\\repos\\Inventory\\Inventory\\Inventory.accdb;";
            ////send login info to database
            //query = "select * from loginInv where [user]='" + this.userName.Text + "' and pass='" + this.pass.Text + "'";
            //con = new OleDbConnection(connection); //OleDbConnection object to pass my connection string.
            ////MessageBox.Show(con.ToString());
            //con.Open(); //open connection
            //command = new OleDbCommand(query, con); //This is command class which will handle the query and connection object.  
            //reader = command.ExecuteReader();
            string check;
            check = reader.Read().ToString();
            //check = reader[0].ToString();
            if (check == "True" && ((userName.Text != "") || (pass.Text != "")))
            {
                invEntry go = new invEntry();
                this.Hide();

                go.Show();
                MessageBox.Show("Logged in successfully");
                // MessageBox.Show(check); just checking actual value
                
                //StreamWriter w = File.AppendText("C:\\Users\\mmoore\\sourse\\repos\\Inventory\\log.txt");
                
            }
            else if (userName.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Invalid entry. Can't be blank. Try again");
                invMngmt go = new invMngmt();
                this.Hide();
                go.Show();
            }
            //else if(!userName.Text.Equals())
            else
            {
                MessageBox.Show("Invalid entry. Identical match. Try again");
                invMngmt go = new invMngmt();
                this.Hide();
                go.Show();
            }

        }
        
            
        

        invEntry go = new invEntry();
        string output;
        string connection;
        string checkValues;
        SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
        SqlCommand command, command1 = new SqlCommand(); //This is command class which will handle the query and connection object.
        SqlDataReader reader, reader1;

        //implement this into code eventually, have to work out issues with opening and closing of the connection first
        public void connect()
        {
           connection = "Data Source=MSBML-710;Initial Catalog=LoginInv;Integrated Security=True";
            //con.Open(); //open connection
        
            con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
            con.Open(); //open connection
        }

        private void selectFromUsers()
        {

            checkValues = "select * from loginInv where [user]= '" + this.userName.Text + "' and pass='" + this.pass.Text + "'";//check values to see if exist
            command = new SqlCommand(checkValues, con); //This is command class which will handle the query and connection object.
            reader = command.ExecuteReader();
            output = reader.Read().ToString();
            con.Close();
        }

        private void insertIntoUsers()
        {

            string newUser = "insert into loginInv([user],pass) values('" + this.userName.Text + "','" + this.pass.Text + "');"; //insert into database if don't exist                
            command1 = new SqlCommand(newUser, con); //This is command class which will handle the query and connection object.
            reader1 = command1.ExecuteReader();  // query executed
            output = reader1.Read().ToString();
            con.Close();
        }



        //     private void newUser_Click(object sender, EventArgs e)
        //{
        //    //ALLOWS YOU TO JUST HIT NEW USER AND GO TO INVENTORY!!!!
        //    //FIX ASAP!!
        //    invMngmt run = new invMngmt();

        //    //newUser1.newUsers();
        //    run.connect();
        //    run.selectFromUsers();
        //    string a=output;
        //    MessageBox.Show(a.ToString());
        //    if (output == "True")
        //    {
        //        MessageBox.Show("Enter another user name/password combination");
        //       // run.selectFromUsers();
        //        //this.Hide();
        //        //go.Show();

        //    }
        //    else if (output == "False") //SHOULD I DO THE VALIDATION HERE?
        //    { //insert info into database and send to next screen
        //        //MessageBox.Show("Checking to see if it makes it here");
        //        run.connect();

        //        if ((this.userName.Text == "") || (this.userName.Text == ""))
        //        {
        //            MessageBox.Show("Please enter a valid username/pass");
        //            run.selectFromUsers();
        //        }
        //        else
        //        {
        //            MessageBox.Show("User/pass accepted"); //doesn't allow user to re-enter password like before
        //            run.insertIntoUsers();

        //            this.Hide();
        //            go.Show();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("I guess it's neither?");
        //    }

        //    }


        private void userName_TextChanged(object sender, EventArgs e)
        {
            userName.Focus();
        }

        private void invMngmt_Load(object sender, EventArgs e)
        {

        }
        private void newUser_Click(object sender, EventArgs e)
        {

            //FIX ASAP!!
            //invMngmt newUser1 = new invMngmt();
            //newUser1.newUsers();
            //Validation of some form goes here!

            invEntry go = new invEntry();
            string output;
            string connection;
            //string newUser;
            SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
            string checkValues;

            SqlCommand command = new SqlCommand(); //This is command class which will handle the query and connection object.
            SqlDataReader reader;
            connection ="Data Source=MSBML-710\\MSBML;Initial Catalog=LoginInv;Integrated Security=True";
            con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
            
            con.Open(); //open connection

            //checkValues = "select * from loginInv;";  //where [user]= '" + this.userName.Text + "' and pass='" + this.pass.Text + "'";//check values to see if exist
            //string query= "select * from loginInv where [user] = '"+ this.userName.Text+"'";
            checkValues = "select * from loginInv where [user] = '" + this.userName.Text + "'";
            //if query finds something ask user to enter another name.



            command = new SqlCommand(checkValues, con); //This is command class which will handle the query and connection object.

            //MessageBox.Show(checkValues);//equals select statement with the text that came from the boxes
            reader = command.ExecuteReader();  // query executed

            output = reader.Read().ToString();
            //MessageBox.Show(reader.Read().ToString());
            con.Close();
            invMngmt run = new invMngmt();
            //run.connect();
            //run.selectFromUsers();
            //if ("select * from loginInv where [user] = this.userName.Text")
            
            //{
                //MessageBox.Show(output); //= true or false
                if (output == "True")
                {

                    MessageBox.Show("Enter another user name/password combination");
                    this.Hide();
                    run.Show();
                }
                else if (output == "False")  //SHOULD I DO THE VALIDATION HERE?
                { //insert info into database and send to next screen
                  //MessageBox.Show("Checking to see if it makes it here");
                    string newUser = "insert into loginInv([user],pass) values('" + this.userName.Text + "','" + this.pass.Text + "');"; //insert into database if don't exist                
                    connection = "Data Source=MSBML-710\\MSBML;Initial Catalog=LoginInv;Integrated Security=True";
                    con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
                    con.Open(); //open connection
                    command = new SqlCommand(newUser, con); //This is command class which will handle the query and connection object.

                    reader = command.ExecuteReader();  // query executed
                    output = reader.Read().ToString();
                    if ((userName.Text == "") || pass.Text == "")
                    {

                        run.connect();
                        run.selectFromUsers();
                    }
                    this.Hide();

                    go.Show();
                    MessageBox.Show("New user added successfully");
                }
            }

        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = true;
            }
            else
            {
                pass.UseSystemPasswordChar = false;


            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}