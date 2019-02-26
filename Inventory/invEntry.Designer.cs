namespace InventoryMB
{
    partial class invEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invEntry));
            this.sbtBtn = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.TextBox();
            this.price1 = new System.Windows.Forms.TextBox();
            this.serialNum1 = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.TextBox();
            this.ipaddress1 = new System.Windows.Forms.TextBox();
            this.ipaddy = new System.Windows.Forms.Label();
            this.search1 = new System.Windows.Forms.Button();
            this.inventoryNum = new System.Windows.Forms.Label();
            this.invNum1 = new System.Windows.Forms.TextBox();
            this.computerName1 = new System.Windows.Forms.TextBox();
            this.type1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new InventoryMB.InventoryDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.inventoryTableAdapter = new InventoryMB.InventoryDataSetTableAdapters.InventoryTableAdapter();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.add_inv1 = new System.Windows.Forms.CheckBox();
            this.del_inv1 = new System.Windows.Forms.CheckBox();
            this.clear1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtBtn
            // 
            this.sbtBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sbtBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sbtBtn.Location = new System.Drawing.Point(548, 539);
            this.sbtBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sbtBtn.Name = "sbtBtn";
            this.sbtBtn.Size = new System.Drawing.Size(121, 34);
            this.sbtBtn.TabIndex = 12;
            this.sbtBtn.Text = "Submit";
            this.sbtBtn.UseVisualStyleBackColor = false;
            this.sbtBtn.Click += new System.EventHandler(this.sbtBtn_Click);
            // 
            // name1
            // 
            this.name1.BackColor = System.Drawing.SystemColors.Control;
            this.name1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.name1.Location = new System.Drawing.Point(195, 142);
            this.name1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.name1.Multiline = true;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(194, 27);
            this.name1.TabIndex = 1;
            this.name1.TextChanged += new System.EventHandler(this.name1_TextChanged);
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.item.Location = new System.Drawing.Point(43, 150);
            this.item.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(76, 23);
            this.item.TabIndex = 5;
            this.item.Text = "Item Name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.date.Location = new System.Drawing.Point(43, 236);
            this.date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(38, 23);
            this.date.TabIndex = 6;
            this.date.Text = "Date";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.price.Location = new System.Drawing.Point(529, 318);
            this.price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(42, 23);
            this.price.TabIndex = 7;
            this.price.Text = "Price";
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.BackColor = System.Drawing.Color.Transparent;
            this.serial.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.serial.Location = new System.Drawing.Point(529, 236);
            this.serial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(59, 23);
            this.serial.TabIndex = 8;
            this.serial.Text = "Serial #";
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.SystemColors.Control;
            this.date1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.date1.Location = new System.Drawing.Point(195, 233);
            this.date1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(194, 30);
            this.date1.TabIndex = 2;
            this.date1.TextChanged += new System.EventHandler(this.date1_TextChanged);
            // 
            // price1
            // 
            this.price1.BackColor = System.Drawing.SystemColors.Control;
            this.price1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.price1.Location = new System.Drawing.Point(668, 315);
            this.price1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(194, 30);
            this.price1.TabIndex = 9;
            this.price1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // serialNum1
            // 
            this.serialNum1.BackColor = System.Drawing.SystemColors.Control;
            this.serialNum1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.serialNum1.Location = new System.Drawing.Point(668, 233);
            this.serialNum1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.serialNum1.Name = "serialNum1";
            this.serialNum1.Size = new System.Drawing.Size(194, 30);
            this.serialNum1.TabIndex = 8;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Control;
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.close.Location = new System.Drawing.Point(668, 539);
            this.close.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 34);
            this.close.TabIndex = 15;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user.Location = new System.Drawing.Point(43, 318);
            this.user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(38, 23);
            this.user.TabIndex = 18;
            this.user.Text = "User";
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.SystemColors.Control;
            this.user1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user1.Location = new System.Drawing.Point(195, 315);
            this.user1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(194, 30);
            this.user1.TabIndex = 3;
            // 
            // ipaddress1
            // 
            this.ipaddress1.BackColor = System.Drawing.SystemColors.Control;
            this.ipaddress1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddress1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ipaddress1.Location = new System.Drawing.Point(195, 539);
            this.ipaddress1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ipaddress1.Name = "ipaddress1";
            this.ipaddress1.Size = new System.Drawing.Size(194, 30);
            this.ipaddress1.TabIndex = 6;
            // 
            // ipaddy
            // 
            this.ipaddy.AutoSize = true;
            this.ipaddy.BackColor = System.Drawing.Color.Transparent;
            this.ipaddy.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ipaddy.Location = new System.Drawing.Point(43, 542);
            this.ipaddy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ipaddy.Name = "ipaddy";
            this.ipaddy.Size = new System.Drawing.Size(76, 23);
            this.ipaddy.TabIndex = 21;
            this.ipaddy.Text = "IP Address";
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.SystemColors.Control;
            this.search1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.search1.Location = new System.Drawing.Point(756, 13);
            this.search1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(122, 34);
            this.search1.TabIndex = 14;
            this.search1.Text = "Search/Browse";
            this.search1.UseVisualStyleBackColor = false;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // inventoryNum
            // 
            this.inventoryNum.AutoSize = true;
            this.inventoryNum.BackColor = System.Drawing.Color.Transparent;
            this.inventoryNum.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryNum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.inventoryNum.Location = new System.Drawing.Point(529, 150);
            this.inventoryNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryNum.Name = "inventoryNum";
            this.inventoryNum.Size = new System.Drawing.Size(81, 23);
            this.inventoryNum.TabIndex = 27;
            this.inventoryNum.Text = "Inventory #";
            // 
            // invNum1
            // 
            this.invNum1.BackColor = System.Drawing.SystemColors.Control;
            this.invNum1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.invNum1.Location = new System.Drawing.Point(668, 142);
            this.invNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.invNum1.Name = "invNum1";
            this.invNum1.Size = new System.Drawing.Size(194, 30);
            this.invNum1.TabIndex = 7;
            this.invNum1.TextChanged += new System.EventHandler(this.invNum1_TextChanged);
            // 
            // computerName1
            // 
            this.computerName1.BackColor = System.Drawing.SystemColors.Control;
            this.computerName1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerName1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.computerName1.Location = new System.Drawing.Point(195, 390);
            this.computerName1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.computerName1.Name = "computerName1";
            this.computerName1.Size = new System.Drawing.Size(194, 30);
            this.computerName1.TabIndex = 4;
            // 
            // type1
            // 
            this.type1.BackColor = System.Drawing.SystemColors.Control;
            this.type1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.type1.Location = new System.Drawing.Point(195, 461);
            this.type1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(194, 30);
            this.type1.TabIndex = 5;
            this.type1.TextChanged += new System.EventHandler(this.type1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(43, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Computer Name";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.type.Location = new System.Drawing.Point(43, 464);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(69, 23);
            this.type.TabIndex = 32;
            this.type.Text = "Item Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(529, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Add to Inv";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(529, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Delete from Inv";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(642, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(20, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(21, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(32, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "* denotes required field";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(507, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(195, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "Use mm/dd/yyyy format";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(341, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 23);
            this.label12.TabIndex = 47;
            this.label12.Text = "Make A New Entry or Search/Browse the Inventory";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(195, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 48;
            this.label13.Text = "ex: printer";
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.SystemColors.Control;
            this.logOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logOut.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logOut.Location = new System.Drawing.Point(646, 13);
            this.logOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(111, 34);
            this.logOut.TabIndex = 49;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.inventoryDataSet;
            // 
            // add_inv1
            // 
            this.add_inv1.AutoSize = true;
            this.add_inv1.Location = new System.Drawing.Point(668, 400);
            this.add_inv1.Name = "add_inv1";
            this.add_inv1.Size = new System.Drawing.Size(15, 14);
            this.add_inv1.TabIndex = 50;
            this.add_inv1.UseVisualStyleBackColor = true;
            this.add_inv1.CheckedChanged += new System.EventHandler(this.add_inv1_CheckedChanged_1);
            // 
            // del_inv1
            // 
            this.del_inv1.AutoSize = true;
            this.del_inv1.Location = new System.Drawing.Point(668, 471);
            this.del_inv1.Name = "del_inv1";
            this.del_inv1.Size = new System.Drawing.Size(15, 14);
            this.del_inv1.TabIndex = 51;
            this.del_inv1.UseVisualStyleBackColor = true;
            // 
            // clear1
            // 
            this.clear1.BackColor = System.Drawing.SystemColors.Control;
            this.clear1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clear1.Location = new System.Drawing.Point(548, 13);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(99, 34);
            this.clear1.TabIndex = 52;
            this.clear1.Text = "Clear";
            this.clear1.UseVisualStyleBackColor = false;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // invEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(934, 621);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.del_inv1);
            this.Controls.Add(this.add_inv1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.computerName1);
            this.Controls.Add(this.invNum1);
            this.Controls.Add(this.inventoryNum);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.ipaddy);
            this.Controls.Add(this.ipaddress1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.close);
            this.Controls.Add(this.serialNum1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.price);
            this.Controls.Add(this.date);
            this.Controls.Add(this.item);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.sbtBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "invEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.invEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sbtBtn;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label serial;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label ipaddy;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Label inventoryNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button logOut;
        public System.Windows.Forms.TextBox name1;
        public System.Windows.Forms.TextBox date1;
        public System.Windows.Forms.TextBox price1;
        public System.Windows.Forms.TextBox serialNum1;
        public System.Windows.Forms.TextBox user1;
        public System.Windows.Forms.TextBox ipaddress1;
        public System.Windows.Forms.TextBox invNum1;
        public System.Windows.Forms.TextBox computerName1;
        public System.Windows.Forms.TextBox type1;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        public System.Windows.Forms.CheckBox add_inv1;
        public System.Windows.Forms.CheckBox del_inv1;
        private System.Windows.Forms.Button clear1;
    }
}

