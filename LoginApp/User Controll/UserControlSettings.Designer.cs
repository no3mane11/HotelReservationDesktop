namespace LoginApp.User_Controll
{
    partial class UserControlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            buttonAddUser = new Button();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSerachUser = new TabPage();
            textBoxID = new TextBox();
            label11 = new Label();
            buttonSearchUser = new Button();
            textBoxSearchUpdateUser = new TextBox();
            buttonDeleteUser = new Button();
            buttonUpdateUser = new Button();
            label10 = new Label();
            label9 = new Label();
            textBoxPasswordUpdate = new TextBox();
            textBoxUsernameUpdate = new TextBox();
            dataGridViewUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label4 = new Label();
            tabPageListUsers = new TabPage();
            dataGridViewListUsers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            buttonAfficherUsers = new Button();
            label6 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSerachUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabPageListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUsers).BeginInit();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSerachUser);
            tabControlUser.Controls.Add(tabPageListUsers);
            tabControlUser.Cursor = Cursors.Hand;
            tabControlUser.Location = new Point(17, 43);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(823, 407);
            tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(buttonAddUser);
            tabPageAddUser.Controls.Add(textBoxPass);
            tabPageAddUser.Controls.Add(textBoxUser);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(815, 371);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "AddUser";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Click += tabPageAddUser_Click;
            tabPageAddUser.Leave += tabPageAddUser_Leave;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = Color.FromArgb(255, 128, 128);
            buttonAddUser.ForeColor = Color.White;
            buttonAddUser.Location = new Point(164, 187);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(126, 47);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "Add";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(526, 124);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(226, 32);
            textBoxPass.TabIndex = 4;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(149, 124);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(207, 32);
            textBoxUser.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label3.Location = new Point(149, 87);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 2;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(526, 87);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "AddUser : ";
            label1.Click += label1_Click;
            // 
            // tabPageSerachUser
            // 
            tabPageSerachUser.Controls.Add(textBoxID);
            tabPageSerachUser.Controls.Add(label11);
            tabPageSerachUser.Controls.Add(buttonSearchUser);
            tabPageSerachUser.Controls.Add(textBoxSearchUpdateUser);
            tabPageSerachUser.Controls.Add(buttonDeleteUser);
            tabPageSerachUser.Controls.Add(buttonUpdateUser);
            tabPageSerachUser.Controls.Add(label10);
            tabPageSerachUser.Controls.Add(label9);
            tabPageSerachUser.Controls.Add(textBoxPasswordUpdate);
            tabPageSerachUser.Controls.Add(textBoxUsernameUpdate);
            tabPageSerachUser.Controls.Add(dataGridViewUser);
            tabPageSerachUser.Controls.Add(label5);
            tabPageSerachUser.Controls.Add(label4);
            tabPageSerachUser.Location = new Point(4, 4);
            tabPageSerachUser.Name = "tabPageSerachUser";
            tabPageSerachUser.Padding = new Padding(3);
            tabPageSerachUser.Size = new Size(815, 371);
            tabPageSerachUser.TabIndex = 1;
            tabPageSerachUser.Text = "Serach User";
            tabPageSerachUser.UseVisualStyleBackColor = true;
            tabPageSerachUser.Enter += tabPageSerachUser_Enter;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(97, 305);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(35, 32);
            textBoxID.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(97, 282);
            label11.Name = "label11";
            label11.Size = new Size(29, 23);
            label11.TabIndex = 18;
            label11.Text = "Id";
            // 
            // buttonSearchUser
            // 
            buttonSearchUser.BackColor = Color.FromArgb(255, 128, 128);
            buttonSearchUser.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchUser.ForeColor = Color.White;
            buttonSearchUser.Location = new Point(426, 54);
            buttonSearchUser.Name = "buttonSearchUser";
            buttonSearchUser.Size = new Size(137, 43);
            buttonSearchUser.TabIndex = 17;
            buttonSearchUser.Text = "Search User";
            buttonSearchUser.UseVisualStyleBackColor = false;
            buttonSearchUser.Click += buttonSearchUser_Click;
            // 
            // textBoxSearchUpdateUser
            // 
            textBoxSearchUpdateUser.Location = new Point(167, 61);
            textBoxSearchUpdateUser.Name = "textBoxSearchUpdateUser";
            textBoxSearchUpdateUser.Size = new Size(210, 32);
            textBoxSearchUpdateUser.TabIndex = 16;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.BackColor = Color.Red;
            buttonDeleteUser.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            buttonDeleteUser.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteUser.Location = new Point(659, 297);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(96, 45);
            buttonDeleteUser.TabIndex = 15;
            buttonDeleteUser.Text = "Delete";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonUpdateUser
            // 
            buttonUpdateUser.BackColor = Color.Green;
            buttonUpdateUser.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            buttonUpdateUser.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdateUser.Location = new Point(547, 297);
            buttonUpdateUser.Name = "buttonUpdateUser";
            buttonUpdateUser.Size = new Size(97, 45);
            buttonUpdateUser.TabIndex = 14;
            buttonUpdateUser.Text = "Update";
            buttonUpdateUser.UseVisualStyleBackColor = false;
            buttonUpdateUser.Click += buttonUpdateUser_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 282);
            label10.Name = "label10";
            label10.Size = new Size(116, 23);
            label10.TabIndex = 13;
            label10.Text = "password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(171, 282);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 12;
            label9.Text = "username :";
            label9.Click += label9_Click;
            // 
            // textBoxPasswordUpdate
            // 
            textBoxPasswordUpdate.Location = new Point(359, 308);
            textBoxPasswordUpdate.Name = "textBoxPasswordUpdate";
            textBoxPasswordUpdate.Size = new Size(150, 32);
            textBoxPasswordUpdate.TabIndex = 11;
            // 
            // textBoxUsernameUpdate
            // 
            textBoxUsernameUpdate.Location = new Point(171, 308);
            textBoxUsernameUpdate.Name = "textBoxUsernameUpdate";
            textBoxUsernameUpdate.Size = new Size(150, 32);
            textBoxUsernameUpdate.TabIndex = 10;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.AllowUserToDeleteRows = false;
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewUser.Location = new Point(97, 120);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.RowHeadersWidth = 62;
            dataGridViewUser.Size = new Size(506, 164);
            dataGridViewUser.TabIndex = 9;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            dataGridViewUser.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "username";
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "password";
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label5.Location = new Point(167, 35);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 6;
            label5.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(295, 23);
            label4.TabIndex = 0;
            label4.Text = "Search, Update, Delete User :";
            // 
            // tabPageListUsers
            // 
            tabPageListUsers.Controls.Add(dataGridViewListUsers);
            tabPageListUsers.Controls.Add(buttonAfficherUsers);
            tabPageListUsers.Controls.Add(label6);
            tabPageListUsers.Location = new Point(4, 4);
            tabPageListUsers.Name = "tabPageListUsers";
            tabPageListUsers.Padding = new Padding(3);
            tabPageListUsers.Size = new Size(815, 371);
            tabPageListUsers.TabIndex = 2;
            tabPageListUsers.Text = "Listes Users";
            tabPageListUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListUsers
            // 
            dataGridViewListUsers.AllowUserToAddRows = false;
            dataGridViewListUsers.AllowUserToDeleteRows = false;
            dataGridViewListUsers.Anchor = AnchorStyles.None;
            dataGridViewListUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListUsers.BorderStyle = BorderStyle.None;
            dataGridViewListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListUsers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewListUsers.Location = new Point(6, 76);
            dataGridViewListUsers.Name = "dataGridViewListUsers";
            dataGridViewListUsers.ReadOnly = true;
            dataGridViewListUsers.RowHeadersWidth = 62;
            dataGridViewListUsers.Size = new Size(786, 284);
            dataGridViewListUsers.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "username";
            dataGridViewTextBoxColumn2.HeaderText = "Username";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "password";
            dataGridViewTextBoxColumn3.HeaderText = "Password";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // buttonAfficherUsers
            // 
            buttonAfficherUsers.BackColor = Color.Cyan;
            buttonAfficherUsers.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAfficherUsers.Location = new Point(246, 6);
            buttonAfficherUsers.Name = "buttonAfficherUsers";
            buttonAfficherUsers.Size = new Size(331, 51);
            buttonAfficherUsers.TabIndex = 1;
            buttonAfficherUsers.Text = "Afficher Les Utilisateurs";
            buttonAfficherUsers.UseVisualStyleBackColor = false;
            buttonAfficherUsers.Click += buttonAfficherUsers_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 128);
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 0;
            label6.Text = "Listes Users :";
            // 
            // UserControlSettings
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlUser);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlSettings";
            Size = new Size(1072, 471);
            Load += UserControlSettings_Load;
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSerachUser.ResumeLayout(false);
            tabPageSerachUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabPageListUsers.ResumeLayout(false);
            tabPageListUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private TabPage tabPageSerachUser;
        private Label label1;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Label label3;
        private Label label2;
        private Button buttonAddUser;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewUser;
        private Label label10;
        private Label label9;
        private TextBox textBoxPasswordUpdate;
        private TextBox textBoxUsernameUpdate;
        private Button buttonDeleteUser;
        private Button buttonUpdateUser;
        private TextBox textBoxSearchUpdateUser;
        private Button buttonSearchUser;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBoxID;
        private Label label11;
        private TabPage tabPageListUsers;
        private DataGridView dataGridViewListUsers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button buttonAfficherUsers;
        private Label label6;
    }
}
