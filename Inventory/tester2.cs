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

namespace InventoryMB
{
    public partial class tester2 : Form
    {
        public tester2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newSearch go = new newSearch();
            this.Hide();
            go.Show();

        }
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
        //dataGridView1.AutoResizeColumns( 
        //    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
    }
    catch (SqlException)
    {
        MessageBox.Show("To run this example, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system.");
    }
}
        private void tester2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.

            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            //GetData("sp_helpindex Inventory, and sp_help Inventory");
            //GetData("sp_help Inventory");
            //GetData("sp_help [[@Inventory=] 'Inventory']");
            //GetData("sp_helpdb Inventory");
            //GetData("sp_helptext Inventory");
            GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where table_name = 'Inventory'");
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
        }
    }
}
