namespace Inventory
{
    partial class invMngmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invMngmt));
            this.login = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.login.Location = new System.Drawing.Point(311, 368);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(124, 34);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // newUser
            // 
            this.newUser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.newUser.Location = new System.Drawing.Point(502, 368);
            this.newUser.Margin = new System.Windows.Forms.Padding(4);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(124, 34);
            this.newUser.TabIndex = 4;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.name.Location = new System.Drawing.Point(329, 190);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 23);
            this.name.TabIndex = 2;
            this.name.Text = "User Name";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.BackColor = System.Drawing.Color.Transparent;
            this.passwd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwd.Location = new System.Drawing.Point(329, 297);
            this.passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(95, 23);
            this.passwd.TabIndex = 3;
            this.passwd.Text = "Password";
            // 
            // userName
            // 
            this.userName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userName.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.userName.Location = new System.Drawing.Point(461, 187);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(164, 30);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pass.Location = new System.Drawing.Point(461, 297);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(164, 26);
            this.pass.TabIndex = 2;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox1.Location = new System.Drawing.Point(644, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 27);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // invMngmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 621);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.name);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "invMngmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System Login";
            this.Load += new System.EventHandler(this.invMngmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}