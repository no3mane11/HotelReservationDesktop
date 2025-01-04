
namespace LoginApp.User_Controll
{
    partial class ControlChambre
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
            tabControlChambre = new TabControl();
            tabPageAjouterTypeChambre = new TabPage();
            buttonAjouterTypeChambre = new Button();
            label4 = new Label();
            textBoxDescriptionChambre = new TextBox();
            textBoxTarifNuit = new TextBox();
            textBoxNomChambre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageAjouterChambre = new TabPage();
            pictureBoxChambre = new PictureBox();
            buttonSelectImage = new Button();
            label12 = new Label();
            textBoxDispChamb = new TextBox();
            comboBoxChargerTypeChambre = new ComboBox();
            label8 = new Label();
            btnAjouterChambre = new Button();
            textBoxNumChambre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabPageSearchChambre = new TabPage();
            dataGridViewSerachChambre = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            buttonSearchChambre = new Button();
            textBoxNumeroChambre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tabPageListesChambres = new TabPage();
            dataGridViewListChambres = new DataGridView();
            buttonAfficherChambres = new Button();
            label11 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            tabControlChambre.SuspendLayout();
            tabPageAjouterTypeChambre.SuspendLayout();
            tabPageAjouterChambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChambre).BeginInit();
            tabPageSearchChambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSerachChambre).BeginInit();
            tabPageListesChambres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListChambres).BeginInit();
            SuspendLayout();
            // 
            // tabControlChambre
            // 
            tabControlChambre.Alignment = TabAlignment.Bottom;
            tabControlChambre.Controls.Add(tabPageAjouterTypeChambre);
            tabControlChambre.Controls.Add(tabPageAjouterChambre);
            tabControlChambre.Controls.Add(tabPageSearchChambre);
            tabControlChambre.Controls.Add(tabPageListesChambres);
            tabControlChambre.Location = new Point(25, 17);
            tabControlChambre.Name = "tabControlChambre";
            tabControlChambre.SelectedIndex = 0;
            tabControlChambre.Size = new Size(869, 362);
            tabControlChambre.TabIndex = 0;
            // 
            // tabPageAjouterTypeChambre
            // 
            tabPageAjouterTypeChambre.Controls.Add(buttonAjouterTypeChambre);
            tabPageAjouterTypeChambre.Controls.Add(label4);
            tabPageAjouterTypeChambre.Controls.Add(textBoxDescriptionChambre);
            tabPageAjouterTypeChambre.Controls.Add(textBoxTarifNuit);
            tabPageAjouterTypeChambre.Controls.Add(textBoxNomChambre);
            tabPageAjouterTypeChambre.Controls.Add(label3);
            tabPageAjouterTypeChambre.Controls.Add(label2);
            tabPageAjouterTypeChambre.Controls.Add(label1);
            tabPageAjouterTypeChambre.Location = new Point(4, 4);
            tabPageAjouterTypeChambre.Name = "tabPageAjouterTypeChambre";
            tabPageAjouterTypeChambre.Padding = new Padding(3);
            tabPageAjouterTypeChambre.Size = new Size(861, 324);
            tabPageAjouterTypeChambre.TabIndex = 0;
            tabPageAjouterTypeChambre.Text = "Ajouter Type Chambre";
            tabPageAjouterTypeChambre.UseVisualStyleBackColor = true;
            tabPageAjouterTypeChambre.Click += tabPageAjouterTypeChambre_Click;
            // 
            // buttonAjouterTypeChambre
            // 
            buttonAjouterTypeChambre.BackColor = Color.FromArgb(0, 192, 0);
            buttonAjouterTypeChambre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouterTypeChambre.ForeColor = Color.White;
            buttonAjouterTypeChambre.Location = new Point(279, 225);
            buttonAjouterTypeChambre.Name = "buttonAjouterTypeChambre";
            buttonAjouterTypeChambre.Size = new Size(150, 51);
            buttonAjouterTypeChambre.TabIndex = 15;
            buttonAjouterTypeChambre.Text = "Ajouter ";
            buttonAjouterTypeChambre.UseVisualStyleBackColor = false;
            buttonAjouterTypeChambre.Click += buttonAjouterTypeChambre_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(235, 28);
            label4.TabIndex = 14;
            label4.Text = "Ajouter Type Chambre :";
            // 
            // textBoxDescriptionChambre
            // 
            textBoxDescriptionChambre.Location = new Point(136, 152);
            textBoxDescriptionChambre.Multiline = true;
            textBoxDescriptionChambre.Name = "textBoxDescriptionChambre";
            textBoxDescriptionChambre.Size = new Size(220, 50);
            textBoxDescriptionChambre.TabIndex = 13;
            // 
            // textBoxTarifNuit
            // 
            textBoxTarifNuit.Location = new Point(503, 78);
            textBoxTarifNuit.Name = "textBoxTarifNuit";
            textBoxTarifNuit.Size = new Size(150, 31);
            textBoxTarifNuit.TabIndex = 12;
            // 
            // textBoxNomChambre
            // 
            textBoxNomChambre.Location = new Point(148, 75);
            textBoxNomChambre.Name = "textBoxNomChambre";
            textBoxNomChambre.Size = new Size(150, 31);
            textBoxNomChambre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(134, 118);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 10;
            label3.Text = "Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(503, 44);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 9;
            label2.Text = "Tarif de Nuit :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(138, 44);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 8;
            label1.Text = "Nom du Chambre :";
            // 
            // tabPageAjouterChambre
            // 
            tabPageAjouterChambre.Controls.Add(pictureBoxChambre);
            tabPageAjouterChambre.Controls.Add(buttonSelectImage);
            tabPageAjouterChambre.Controls.Add(label12);
            tabPageAjouterChambre.Controls.Add(textBoxDispChamb);
            tabPageAjouterChambre.Controls.Add(comboBoxChargerTypeChambre);
            tabPageAjouterChambre.Controls.Add(label8);
            tabPageAjouterChambre.Controls.Add(btnAjouterChambre);
            tabPageAjouterChambre.Controls.Add(textBoxNumChambre);
            tabPageAjouterChambre.Controls.Add(label5);
            tabPageAjouterChambre.Controls.Add(label6);
            tabPageAjouterChambre.Controls.Add(label7);
            tabPageAjouterChambre.Location = new Point(4, 4);
            tabPageAjouterChambre.Name = "tabPageAjouterChambre";
            tabPageAjouterChambre.Padding = new Padding(3);
            tabPageAjouterChambre.Size = new Size(861, 324);
            tabPageAjouterChambre.TabIndex = 1;
            tabPageAjouterChambre.Text = "Ajouter Chambre";
            tabPageAjouterChambre.UseVisualStyleBackColor = true;
            tabPageAjouterChambre.Click += tabPageAjouterChambre_Click;
            // 
            // pictureBoxChambre
            // 
            pictureBoxChambre.Location = new Point(552, 188);
            pictureBoxChambre.Name = "pictureBoxChambre";
            pictureBoxChambre.Size = new Size(150, 75);
            pictureBoxChambre.TabIndex = 28;
            pictureBoxChambre.TabStop = false;
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.Location = new Point(717, 148);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(99, 34);
            buttonSelectImage.TabIndex = 27;
            buttonSelectImage.Text = "Import";
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += buttonSelectImage_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.Location = new Point(509, 150);
            label12.Name = "label12";
            label12.Size = new Size(201, 28);
            label12.TabIndex = 26;
            label12.Text = "Image du Chambre :";
            // 
            // textBoxDispChamb
            // 
            textBoxDispChamb.Location = new Point(524, 97);
            textBoxDispChamb.Name = "textBoxDispChamb";
            textBoxDispChamb.Size = new Size(150, 31);
            textBoxDispChamb.TabIndex = 25;
            // 
            // comboBoxChargerTypeChambre
            // 
            comboBoxChargerTypeChambre.FormattingEnabled = true;
            comboBoxChargerTypeChambre.Location = new Point(108, 173);
            comboBoxChargerTypeChambre.Name = "comboBoxChargerTypeChambre";
            comboBoxChargerTypeChambre.Size = new Size(182, 33);
            comboBoxChargerTypeChambre.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 128);
            label8.Location = new Point(0, 3);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 23;
            label8.Text = "Ajouter Chambre :";
            // 
            // btnAjouterChambre
            // 
            btnAjouterChambre.BackColor = Color.FromArgb(0, 192, 0);
            btnAjouterChambre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouterChambre.ForeColor = Color.White;
            btnAjouterChambre.Location = new Point(333, 239);
            btnAjouterChambre.Name = "btnAjouterChambre";
            btnAjouterChambre.Size = new Size(150, 51);
            btnAjouterChambre.TabIndex = 22;
            btnAjouterChambre.Text = "Ajouter ";
            btnAjouterChambre.UseVisualStyleBackColor = false;
            btnAjouterChambre.Click += btnAjouterChambre_Click;
            // 
            // textBoxNumChambre
            // 
            textBoxNumChambre.Location = new Point(118, 91);
            textBoxNumChambre.Name = "textBoxNumChambre";
            textBoxNumChambre.Size = new Size(150, 31);
            textBoxNumChambre.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(103, 142);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 18;
            label5.Text = "Type de Chambre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(524, 61);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 17;
            label6.Text = "Disponibilte :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(118, 60);
            label7.Name = "label7";
            label7.Size = new Size(220, 28);
            label7.TabIndex = 16;
            label7.Text = "Numero du Chambre :";
            // 
            // tabPageSearchChambre
            // 
            tabPageSearchChambre.Controls.Add(dataGridViewSerachChambre);
            tabPageSearchChambre.Controls.Add(buttonSearchChambre);
            tabPageSearchChambre.Controls.Add(textBoxNumeroChambre);
            tabPageSearchChambre.Controls.Add(label10);
            tabPageSearchChambre.Controls.Add(label9);
            tabPageSearchChambre.Location = new Point(4, 4);
            tabPageSearchChambre.Name = "tabPageSearchChambre";
            tabPageSearchChambre.Padding = new Padding(3);
            tabPageSearchChambre.Size = new Size(861, 324);
            tabPageSearchChambre.TabIndex = 2;
            tabPageSearchChambre.Text = "Search Chambre";
            tabPageSearchChambre.UseVisualStyleBackColor = true;
            tabPageSearchChambre.Click += tabPageSearchChambre_Click;
            // 
            // dataGridViewSerachChambre
            // 
            dataGridViewSerachChambre.AllowUserToAddRows = false;
            dataGridViewSerachChambre.AllowUserToDeleteRows = false;
            dataGridViewSerachChambre.Anchor = AnchorStyles.None;
            dataGridViewSerachChambre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSerachChambre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSerachChambre.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column6 });
            dataGridViewSerachChambre.Location = new Point(20, 83);
            dataGridViewSerachChambre.Name = "dataGridViewSerachChambre";
            dataGridViewSerachChambre.ReadOnly = true;
            dataGridViewSerachChambre.RowHeadersWidth = 62;
            dataGridViewSerachChambre.Size = new Size(814, 224);
            dataGridViewSerachChambre.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "NumeroChambre ";
            Column1.HeaderText = "NumeroChambre ";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "EstDisponible ";
            Column3.HeaderText = "EstDisponible ";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Nom ";
            Column4.HeaderText = "Nom du Chambre";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TarifParNuit ";
            Column5.HeaderText = "TarifParNuit ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Description ";
            Column6.HeaderText = "Description ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // buttonSearchChambre
            // 
            buttonSearchChambre.BackColor = Color.Cyan;
            buttonSearchChambre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearchChambre.Location = new Point(462, 39);
            buttonSearchChambre.Name = "buttonSearchChambre";
            buttonSearchChambre.Size = new Size(112, 38);
            buttonSearchChambre.TabIndex = 3;
            buttonSearchChambre.Text = "Search";
            buttonSearchChambre.UseVisualStyleBackColor = false;
            buttonSearchChambre.Click += buttonSearchChambre_Click;
            // 
            // textBoxNumeroChambre
            // 
            textBoxNumeroChambre.Location = new Point(193, 46);
            textBoxNumeroChambre.Name = "textBoxNumeroChambre";
            textBoxNumeroChambre.Size = new Size(231, 31);
            textBoxNumeroChambre.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(193, 22);
            label10.Name = "label10";
            label10.Size = new Size(203, 25);
            label10.TabIndex = 1;
            label10.Text = "Numero de Chambre  :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 128, 128);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 0;
            label9.Text = "Search Chambre :";
            // 
            // tabPageListesChambres
            // 
            tabPageListesChambres.Controls.Add(dataGridViewListChambres);
            tabPageListesChambres.Controls.Add(buttonAfficherChambres);
            tabPageListesChambres.Controls.Add(label11);
            tabPageListesChambres.Location = new Point(4, 4);
            tabPageListesChambres.Name = "tabPageListesChambres";
            tabPageListesChambres.Padding = new Padding(3);
            tabPageListesChambres.Size = new Size(861, 324);
            tabPageListesChambres.TabIndex = 3;
            tabPageListesChambres.Text = "Listes Chambres";
            tabPageListesChambres.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListChambres
            // 
            dataGridViewListChambres.AllowUserToAddRows = false;
            dataGridViewListChambres.AllowUserToDeleteRows = false;
            dataGridViewListChambres.Anchor = AnchorStyles.None;
            dataGridViewListChambres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListChambres.BorderStyle = BorderStyle.None;
            dataGridViewListChambres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListChambres.Location = new Point(31, 64);
            dataGridViewListChambres.Name = "dataGridViewListChambres";
            dataGridViewListChambres.ReadOnly = true;
            dataGridViewListChambres.RowHeadersWidth = 62;
            dataGridViewListChambres.Size = new Size(801, 239);
            dataGridViewListChambres.TabIndex = 13;
            // 
            // buttonAfficherChambres
            // 
            buttonAfficherChambres.BackColor = Color.Cyan;
            buttonAfficherChambres.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAfficherChambres.Location = new Point(271, 15);
            buttonAfficherChambres.Name = "buttonAfficherChambres";
            buttonAfficherChambres.Size = new Size(331, 43);
            buttonAfficherChambres.TabIndex = 12;
            buttonAfficherChambres.Text = "Afficher Les Chambres";
            buttonAfficherChambres.UseVisualStyleBackColor = false;
            buttonAfficherChambres.Click += buttonAfficherChambres_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 128);
            label11.Location = new Point(2, 3);
            label11.Name = "label11";
            label11.Size = new Size(222, 23);
            label11.TabIndex = 11;
            label11.Text = "Listes Des Chambres :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // ControlChambre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlChambre);
            Name = "ControlChambre";
            Size = new Size(943, 391);
            tabControlChambre.ResumeLayout(false);
            tabPageAjouterTypeChambre.ResumeLayout(false);
            tabPageAjouterTypeChambre.PerformLayout();
            tabPageAjouterChambre.ResumeLayout(false);
            tabPageAjouterChambre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChambre).EndInit();
            tabPageSearchChambre.ResumeLayout(false);
            tabPageSearchChambre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSerachChambre).EndInit();
            tabPageListesChambres.ResumeLayout(false);
            tabPageListesChambres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListChambres).EndInit();
            ResumeLayout(false);
        }

        private void tabPageAjouterTypeChambre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabPageSearchChambre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControlChambre;
        private TabPage tabPageAjouterTypeChambre;
        private TabPage tabPageAjouterChambre;
        private Button buttonAjouterTypeChambre;
        private Label label4;
        private TextBox textBoxDescriptionChambre;
        private TextBox textBoxTarifNuit;
        private TextBox textBoxNomChambre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Button btnAjouterChambre;
        private TextBox textBoxNumChambre;
        private Label label5;
        private Label label6;
        private Label label7;
        private TabPage tabPageSearchChambre;
        private Label label9;
        private DataGridView dataGridViewSerachChambre;
        private Button buttonSearchChambre;
        private TextBox textBoxNumeroChambre;
        private Label label10;
        private ComboBox comboBoxChargerTypeChambre;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBoxDispChamb;
        private TabPage tabPageListesChambres;
        private DataGridView dataGridViewListChambres;
        private Button buttonAfficherChambres;
        private Label label11;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private PictureBox pictureBoxChambre;
        private Button buttonSelectImage;
        private Label label12;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}
