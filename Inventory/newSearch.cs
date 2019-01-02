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

namespace Inventory
{
    public partial class newSearch : Form
    {
        public newSearch()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet1);

        }

        private void newSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet1.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet1.inventory);
            // TODO: This line of code loads data into the 'inventoryDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet1.inventory);

        }

        private void inventoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet1);

        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            invEntry go = new invEntry();
            go.Show();
        }

        private void goToRecord_Click(object sender, EventArgs e)
        {
            invEntry dataFill = new invEntry();
            dataFill.name1.Text = inventoryDataGridView.CurrentRow.Cells[2].Value.ToString();
            dataFill.date1.Text = inventoryDataGridView.CurrentRow.Cells[3].Value.ToString();
            dataFill.user1.Text = inventoryDataGridView.CurrentRow.Cells[5].Value.ToString();
            dataFill.computerName1.Text = inventoryDataGridView.CurrentRow.Cells[8].Value.ToString();
            dataFill.type1.Text = inventoryDataGridView.CurrentRow.Cells[9].Value.ToString();
            dataFill.ipaddress1.Text = inventoryDataGridView.CurrentRow.Cells[7].Value.ToString();
            dataFill.invNum1.Text = inventoryDataGridView.CurrentRow.Cells[1].Value.ToString();
            dataFill.serialNum1.Text = inventoryDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataFill.price1.Text = inventoryDataGridView.CurrentRow.Cells[10].Value.ToString();
            
            
            this.Hide();
            dataFill.ShowDialog();
            
            //whatever cursor is focused on, pull up the record
            // //searches given information by user and fills boxes with information
             //SqlConnection olcn = new SqlConnection("Data Source=MSBML-710;Initial Catalog=Inventory;Integrated Security=True");


             //fix query or restructure to make work
             //string query = "SELECT * FROM inventory where item= '" + this.searchBox.Text + "' or date='" + this.searchBox.Text + "' or price='" + this.searchBox.Text + "' or dept='" + this.searchBox.Text + "' or serial='" + this.searchBox.Text + "' or user='" + this.searchBox.Text + "' or ipaddy='" + this.searchBox.Text + "'";
             //string query = "SELECT * FROM inventory where item= '" + this.searchBox.Text + "' and price='" + this.searchBox.Text + "' and dept='" + this.searchBox.Text + "' and serial='" + this.searchBox.Text + "' and user='" + this.searchBox.Text + "' and ipaddy='" + this.searchBox.Text + "'";
             //string query="select * from inventroy where ANY = '" +this.searchBox.Text+"'";
             //string query = "select * from inventory where item ='" + this.searchBox.Text + "'";// + "' or user = '"+ this.searchBox.Text+"'";
             //string query = "select * from inventory where item='" + this.name1.Text + "' and date='" + this.date1.Text + "' and price ='"+this.price1.Text+"'";
             //string query = "SELECT * FROM inventory where item= '" + this.searchBox.Text + "'";
             //figure out how to make a query that will take in any value in the database and return all values within that column

           

          }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //I need to take whatever the cursor is focused on and send that row's information back to the user
            
        }
    }
}
