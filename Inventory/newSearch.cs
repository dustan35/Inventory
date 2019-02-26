using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using DGVPrinterHelper;

namespace InventoryMB
{
    public partial class newSearch : Form
    {
        public newSearch()
        {
            InitializeComponent();
        }

        //int currentPage = 1;
        //int pageSize = 4;
      
        private void newSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.

            //this.inventoryTableAdapter1.Fill(this.inventoryDataSet1.Inventory);

            //newSearch go = new newSearch();
            //dataGridView1.DataSource = bindingSource1;

            //GetData("sp_helpindex Inventory, and sp_help Inventory");
            //GetData("sp_help Inventory");
            //GetData("sp_help [[@Inventory=] 'Inventory']");
            //GetData("sp_helpdb Inventory");
            //GetData("sp_helptext Inventory");


            dataGridView2.DataSource = bindingSource1; //don't comment me out!!


            //dataGridView2.Columns.Add("COlUMN_name", "Column Name");
            //dataGridView2.Columns.Add("data_type", "Data Type");
            //dataGridView2.Columns.Add("character_maximum_length", "Max Length");
            //dataGridView2.Columns.Add("IS_NULLABLE", "Nullable");

            //Is there a way to create columns in which the data can automatically fill instead of see the db query name EX. COLUMN_name could be Column insead
            //   
            //

            //dataGridView2.DataSource = bindingSource2; //assign binding source to the particular dataGridView I want to see it in?
            //fileStruct go1 = new fileStruct();
            //go1.
            

                GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where table_name = 'Inventory'");
            //MessageBox.Show("got em!");

            //Doesn't work
            //try
            //{
            //    //GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where table_name = 'Inventory', COLUMN_name = 'Column Name', data_type ='Data Type', maximum_character_length= 'Max Length', and IS_NULLABLE= 'Nullable'");
            //    GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where Column Name='COLUMN_name', Data Type ='data_type', Max Length='maximum_character_length', and = Nullable='IS_NULLABLE'");

            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Incorrect query, recheck the statement and continue");
            //}
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);


            //using (invEntry db = new invEntry())
            //{
            //    IPagedList<invEntry> list = db.invNum1.ToPagedList();
            //}

            //using (i db = new InventoryDataSet())
            //{
            //    currentPage++;
            //    //IPagedList<newSearch> list =(IPagedList<newSearch>)db.Inventory.OrderBy(p => p.invNum).ToPagedList(currentPage, pageSize);
            //    IPagedList<newSearch> list = db.Inventory.OrderBy(p => p.invNum).ToPagedList(currentPage, pageSize);
            //    prev.Enabled = list.IsFirstPage;
            //    next.Enabled = list.IsLastPage;
            //    page.Text = string.Format("Page {0}/{1}", list.PageNumber, list.PageCount);
            //    inventoryBindingSource.DataSource = list.ToList();
            //}


        }
        //private void fileStruct_Load(object sender, EventArgs e)
        //{
        //    fileStruct go = new fileStruct();
        //    // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
        //    this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
        //    // Bind the DataGridView to the BindingSource
        //    // and load the data from the database.
        //    dataGridView1.DataSource = bindingSource1;
        //    //GetData("sp_helpindex Inventory, and sp_help Inventory");
        //    //GetData("sp_help Inventory");
        //    //GetData("sp_help [[@Inventory=] 'Inventory']");
        //    //GetData("sp_helpdb Inventory");
        //    //GetData("sp_helptext Inventory");
        //    go.GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where table_name = 'Inventory'");


        //}

        private void back1_Click(object sender, EventArgs e)
        {
            invEntry go = new invEntry();
            this.Hide();
            go.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            invEntry go = new invEntry();

            //go.del_inv1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//need to figure out how to just send the check box and not the 0/1
            go.invNum1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            go.name1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            go.date1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            go.serialNum1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            go.user1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //go.add_inv1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//need to figure out how  to just send the check box and not the 0/1
            go.ipaddress1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            go.computerName1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            go.type1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            go.price1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "True")
            {
                go.add_inv1.Checked = true;
            }
            else
            {
                go.add_inv1.Checked = false;
            }


            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() == "True")
            {
                go.del_inv1.Checked = true;
            }
            else
            {
                go.del_inv1.Checked = false;
            }

            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //checked values found
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            ////gotta check database to insert checks into invEntry form
            //string query;
            //string connection;
            //SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
            //SqlCommand command = new SqlCommand(); //This is command class which will handle the query and connection object.
            //SqlDataReader reader;
            ////"Data Source=MSBML-710;Initial Catalog=LoginInv;Integrated Security=True";
            //connection = "Data Source=MSBML-710\\MSBML;Initial Catalog=Inventory;Integrated Security=True;";
            ////send login info to database
            //query = "select * from Inventory where add_inv='" + go.add_inv1.Checked + "' and del_inv ='" + go.del_inv1.Checked + "'";
            //con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
            ////MessageBox.Show(con.ToString());
            //con.Open(); //open connection
            //command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
            //reader = command.ExecuteReader();


            this.Hide();
            go.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.inventoryBindingSource.EndEdit();
                this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
                MessageBox.Show("Data Updated....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
            //string goHome = "Go Home!";


        }





        //this is what I tried when using a print button, don't delete just yet
            //printDialog1.Document = printDocument1;
            //printDocument1.Print();







        private void fileSt_Click(object sender, EventArgs e)
        {
            //newSearch go = new newSearch();
            fileStruct go = new fileStruct();
            this.Hide();
            go.Show();
            //newSearch go = new newSearch();
            //go.Show();
            //Console.WriteLine("Doesn't Work!!!!");
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[6].Value.GetType().ToString());
           
            
            ////need to make it print file structure of database
            //string query;
            //string connection;
            //SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
            //SqlCommand command = new SqlCommand(); //This is command class which will handle the query and connection object.
            //SqlDataReader reader;
            ////"Data Source=MSBML-710;Initial Catalog=Inventory;Integrated Security=True";
            //connection = "Data Source=MSBML-710\\MSBML;Initial Catalog=Inventory;Integrated Security=True;";
            ////send login info to database
            //query = "sp_help Inventory";
            //con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
            ////MessageBox.Show(con.ToString());
            //con.Open(); //open connection
            //command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
            //reader = command.ExecuteReader();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //newSearch go = new newSearch();
            //fileStruct go = new fileStruct();
            tester2 go = new tester2();
            this.Hide();
            go.Show();
        }
        // private void print1(object sender, EventArgs e)
        //{
        //printDialog1.Document = printDocument1;
        //if(printDialog1.ShowDialog()==DialogResult.OK)
        //{
        //printDocument1.Print();
        //}
        //}
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = "Data Source=MSBML-710\\MSBML;Initial Catalog=Inventory;Integrated Security=True";

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                //// Resize the DataGridView columns to fit the newly loaded content.
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
            //string goHome = "Go Home!";
            //e.Graphics.DrawString(dataGridView1.Columns.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
            //e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 90, 140);
            Bitmap objBmp = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));

            e.Graphics.DrawImage(objBmp, 1, 1);
        }
        //int printIndex;
        //private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        //{
        //    printIndex = 0;
        //}

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 1, 1);
            //e.Graphics.DrawImage(bmp, 0, 0);
            //int y = 0;

            //while (printIndex < dataGridView1.Rows.Count &&
            //       y + dataGridView1.Rows[printIndex].Height < e.MarginBounds.Height)
            //{

            //    // print your stuff, y is where you are on the page vertically

            //    y += dataGridView1.Rows[printIndex].Height;
            //    ++printIndex;
            //    Bitmap objBmp = new Bitmap(this.dataGridView1.Width, y);
            //    dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, y));
            //    e.Graphics.DrawImage(objBmp, 1, 1);
            //newSearch go = new newSearch();
            //go.printDocument1_BeginPrint();
        //}

        //    e.HasMorePages = printIndex < dataGridView1.Rows.Count;
        }

        //Bitmap bmp;
        private void printData_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
            //int height = dataGridView1.Height;
            //dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            //bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            //dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            //dataGridView1.Height = height;
            //printPreviewDialog2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.inventoryBindingSource.EndEdit();
                this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
                MessageBox.Show("Data Updated....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.inventoryBindingSource.EndEdit();
                this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
                MessageBox.Show("Data Updated....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
        private void page_Click(object sender, EventArgs e)
        {

        }

        //this stuff hopefully allows me to print all of the pages 2/6/2019

private System.Drawing.Printing.PrintDocument docToPrint = 
	new System.Drawing.Printing.PrintDocument();

        private void button1_Click_2(object sender, EventArgs e)
        {
           // Allow the user to choose the page range he or she would
	// like to print.
	printDialog1.AllowSomePages = true;

	// Show the help button.
	printDialog1.ShowHelp = true;

	// Set the Document property to the PrintDocument for 
	// which the PrintPage Event has been handled. To display the
	// dialog, either this property or the PrinterSettings property 
	// must be set 
	printDialog1.Document = docToPrint;

	DialogResult result = printDialog1.ShowDialog();

	// If the result is OK then print the document.
	if (result==DialogResult.OK)
	{
		docToPrint.Print();
	} 
        }
        
        
        private void document_PrintPage(object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {
            //printPreviewDialog2.Document = printDocument2;
            //printPreviewDialog2.ShowDialog();

            //// Insert code to render the page here.  //pulled from other printpage from above, might not work
            //Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            //e.Graphics.DrawImage(objBmp, 1, 1);
            //// This code will be called when the control is drawn.

            //// The following code will render a simple
            //// message on the printed document.
            //string text = "In document_PrintPage method.";
            //System.Drawing.Font printFont = new System.Drawing.Font
            //    ("Arial", 35, System.Drawing.FontStyle.Regular);

            //// Draw the content.
            //e.Graphics.DrawString(text, printFont,
            //    System.Drawing.Brushes.Black, 10, 10);
            
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Inventory Report";

            //printer.SubTitle = "An Easy to Use DataGridView Printing Object";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = true;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "MS Board of Medical Licensure";

            printer.FooterSpacing = 15;



            printer.PrintDataGridView(dataGridView1);
            printer.PrintDataGridView(dataGridView2);
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            ////Here's where some code will go that will search the db and input back into the datagridview information based
            ////on the search box
            ////Connecting using SQLConnection
            //Need to fill datagridview1 with the query results somehow
            DataTable table = new DataTable();

            string query;
            string connection;
            SqlConnection con = new SqlConnection(); //SqlConnection object to pass my connection string.
            SqlCommand command = new SqlCommand(); //This is command class which will handle the query and connection object.
            SqlDataReader reader;
            //"Data Source=MSBML-710;Initial Catalog=Inventory;Integrated Security=True";
            connection = "Data Source=MSBML-710\\MSBML;Initial Catalog=Inventory;Integrated Security=True;";
            //send login info to database

            //string pass1 = pass.Text.Trim();
            //query = "select user, type from Inventory";
            //if(textBox1.Text==1)
            if (userBtn1.Checked)
            {
                query = "select * from Inventory where [user] = '" + this.textBox1.Text + "'";
                con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
                //MessageBox.Show(con.ToString());
                con.Open(); //open connection
                //command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
                //reader = command.ExecuteReader();
                //fill table
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                
                adapter.Fill(table);
                dataGridView1.DataSource = table;


            }
            if (typeBtn1.Checked)
            {
                query = "select * from Inventory where type = '" + this.textBox1.Text + "' ";
                con = new SqlConnection(connection); //SqlConnection object to pass my connection string.
                //MessageBox.Show(con.ToString());
                con.Open(); //open connection
                //command = new SqlCommand(query, con); //This is command class which will handle the query and connection object.  
                //reader = command.ExecuteReader();
                //fill table
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fullResults_Click(object sender, EventArgs e)
        {
            newSearch go = new newSearch();
            this.Hide();
            go.Show();

        }
    }
}
