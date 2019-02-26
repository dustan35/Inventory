using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMB
{
    public partial class tester : Form
    {
        public tester()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tester_Load(object sender, EventArgs e)
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
            fileStruct go = new fileStruct();
            go.GetData("select COLUMN_name, data_type, character_maximum_length, IS_NULLABLE from INFORMATION_SCHEMA.columns where table_name = 'Inventory'");
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newSearch go = new newSearch();
            this.Hide();
            go.Show();
        }
    }
}
