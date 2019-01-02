using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void newSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            invEntry go = new invEntry();
            this.Hide();
            go.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            invEntry go = new invEntry();
            this.Hide();
            go.Show();
        }
    }
}
