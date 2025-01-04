namespace LoginApp.User_Controll
{
    partial class ControlReservation
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControlReservation = new TabControl();
            tabPageAjouterReservation = new TabPage();
            comboBoxEtatReservation = new ComboBox();
            label7 = new Label();
            buttonAjouterReservation = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerDebut = new DateTimePicker();
            textBoxTarifRes = new TextBox();
            comboBoxNumChambreRes = new ComboBox();
            comboBoxNomClientRes = new ComboBox();
            tabPageSearchRes = new TabPage();
            dataGridViewSearchRes = new DataGridView();
            NomduClient = new DataGridViewTextBoxColumn();
            prenomClient = new DataGridViewTextBoxColumn();
            nomClient = new DataGridViewTextBoxColumn();
            emailClient = new DataGridViewTextBoxColumn();
            telephone = new DataGridViewTextBoxColumn();
            motDePass = new DataGridViewTextBoxColumn();
            AdresseClient = new DataGridViewTextBoxColumn();
            dateInscriptionClient = new DataGridViewTextBoxColumn();
            buttonSearchRes = new Button();
            textBoxNomCltSearchRes = new TextBox();
            label9 = new Label();
            label8 = new Label();
            tabPageUpdtAndDltRes = new TabPage();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label16 = new Label();
            label17 = new Label();
            dateTimePickerDateFinUpdt = new DateTimePicker();
            dateTimePickerDataDebutUpdt = new DateTimePicker();
            textBoxTarifNuitUpdt = new TextBox();
            comboBoxNumChambResUpdt = new ComboBox();
            comboBoxNomCltResUpdt = new ComboBox();
            buttonSearchResUpdt = new Button();
            buttonDeleteReserv = new Button();
            buttonUpdateReserv = new Button();
            textBoxSearchResUpdate = new TextBox();
            label15 = new Label();
            label14 = new Label();
            tabPageListReservation = new TabPage();
            dataGridViewListReservations = new DataGridView();
            buttonAfficherReservations = new Button();
            label18 = new Label();
            comboBoxEtatResUpdt = new ComboBox();
            tabControlReservation.SuspendLayout();
            tabPageAjouterReservation.SuspendLayout();
            tabPageSearchRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchRes).BeginInit();
            tabPageUpdtAndDltRes.SuspendLayout();
            tabPageListReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListReservations).BeginInit();
            SuspendLayout();
            // 
            // tabControlReservation
            // 
            tabControlReservation.Alignment = TabAlignment.Bottom;
            tabControlReservation.Anchor = AnchorStyles.None;
            tabControlReservation.Controls.Add(tabPageAjouterReservation);
            tabControlReservation.Controls.Add(tabPageSearchRes);
            tabControlReservation.Controls.Add(tabPageUpdtAndDltRes);
            tabControlReservation.Controls.Add(tabPageListReservation);
            tabControlReservation.Location = new Point(3, 41);
            tabControlReservation.Name = "tabControlReservation";
            tabControlReservation.SelectedIndex = 0;
            tabControlReservation.Size = new Size(1036, 398);
            tabControlReservation.TabIndex = 0;
            // 
            // tabPageAjouterReservation
            // 
            tabPageAjouterReservation.Controls.Add(comboBoxEtatReservation);
            tabPageAjouterReservation.Controls.Add(label7);
            tabPageAjouterReservation.Controls.Add(buttonAjouterReservation);
            tabPageAjouterReservation.Controls.Add(label6);
            tabPageAjouterReservation.Controls.Add(label5);
            tabPageAjouterReservation.Controls.Add(label4);
            tabPageAjouterReservation.Controls.Add(label3);
            tabPageAjouterReservation.Controls.Add(label2);
            tabPageAjouterReservation.Controls.Add(label1);
            tabPageAjouterReservation.Controls.Add(dateTimePickerFin);
            tabPageAjouterReservation.Controls.Add(dateTimePickerDebut);
            tabPageAjouterReservation.Controls.Add(textBoxTarifRes);
            tabPageAjouterReservation.Controls.Add(comboBoxNumChambreRes);
            tabPageAjouterReservation.Controls.Add(comboBoxNomClientRes);
            tabPageAjouterReservation.Location = new Point(4, 4);
            tabPageAjouterReservation.Name = "tabPageAjouterReservation";
            tabPageAjouterReservation.Padding = new Padding(3);
            tabPageAjouterReservation.Size = new Size(1028, 360);
            tabPageAjouterReservation.TabIndex = 0;
            tabPageAjouterReservation.Text = "Ajouter Reservation";
            tabPageAjouterReservation.UseVisualStyleBackColor = true;
            // 
            // comboBoxEtatReservation
            // 
            comboBoxEtatReservation.FormattingEnabled = true;
            comboBoxEtatReservation.Location = new Point(37, 232);
            comboBoxEtatReservation.Name = "comboBoxEtatReservation";
            comboBoxEtatReservation.Size = new Size(182, 33);
            comboBoxEtatReservation.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 128);
            label7.Location = new Point(6, 3);
            label7.Name = "label7";
            label7.Size = new Size(213, 28);
            label7.TabIndex = 13;
            label7.Text = "Ajouter Reservation :";
            // 
            // buttonAjouterReservation
            // 
            buttonAjouterReservation.BackColor = Color.Green;
            buttonAjouterReservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouterReservation.ForeColor = SystemColors.ButtonHighlight;
            buttonAjouterReservation.Location = new Point(240, 265);
            buttonAjouterReservation.Name = "buttonAjouterReservation";
            buttonAjouterReservation.Size = new Size(121, 48);
            buttonAjouterReservation.TabIndex = 12;
            buttonAjouterReservation.Text = "Ajouter";
            buttonAjouterReservation.UseVisualStyleBackColor = false;
            buttonAjouterReservation.Click += buttonAjouterReservation_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(391, 202);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 11;
            label6.Text = "Date Fin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(391, 126);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 10;
            label5.Text = "Date  Debut ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(37, 204);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 9;
            label4.Text = "Etat du Reservation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(389, 56);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 8;
            label3.Text = "Tarif Du Nuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 128);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 7;
            label2.Text = "Num du Chambre ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(37, 50);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 6;
            label1.Text = "Nom du Client ";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerFin.Location = new Point(375, 230);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(316, 31);
            dateTimePickerFin.TabIndex = 5;
            // 
            // dateTimePickerDebut
            // 
            dateTimePickerDebut.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerDebut.Location = new Point(375, 156);
            dateTimePickerDebut.Name = "dateTimePickerDebut";
            dateTimePickerDebut.Size = new Size(316, 31);
            dateTimePickerDebut.TabIndex = 4;
            // 
            // textBoxTarifRes
            // 
            textBoxTarifRes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxTarifRes.Location = new Point(375, 84);
            textBoxTarifRes.Name = "textBoxTarifRes";
            textBoxTarifRes.Size = new Size(182, 31);
            textBoxTarifRes.TabIndex = 3;
            // 
            // comboBoxNumChambreRes
            // 
            comboBoxNumChambreRes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxNumChambreRes.FormattingEnabled = true;
            comboBoxNumChambreRes.Location = new Point(37, 156);
            comboBoxNumChambreRes.Name = "comboBoxNumChambreRes";
            comboBoxNumChambreRes.Size = new Size(182, 33);
            comboBoxNumChambreRes.TabIndex = 1;
            // 
            // comboBoxNomClientRes
            // 
            comboBoxNomClientRes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxNomClientRes.FormattingEnabled = true;
            comboBoxNomClientRes.Location = new Point(37, 78);
            comboBoxNomClientRes.Name = "comboBoxNomClientRes";
            comboBoxNomClientRes.Size = new Size(182, 33);
            comboBoxNomClientRes.TabIndex = 0;
            // 
            // tabPageSearchRes
            // 
            tabPageSearchRes.Controls.Add(dataGridViewSearchRes);
            tabPageSearchRes.Controls.Add(buttonSearchRes);
            tabPageSearchRes.Controls.Add(textBoxNomCltSearchRes);
            tabPageSearchRes.Controls.Add(label9);
            tabPageSearchRes.Controls.Add(label8);
            tabPageSearchRes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPageSearchRes.ForeColor = Color.White;
            tabPageSearchRes.Location = new Point(4, 4);
            tabPageSearchRes.Name = "tabPageSearchRes";
            tabPageSearchRes.Padding = new Padding(3);
            tabPageSearchRes.Size = new Size(1028, 360);
            tabPageSearchRes.TabIndex = 1;
            tabPageSearchRes.Text = "Search Reservation ";
            tabPageSearchRes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearchRes
            // 
            dataGridViewSearchRes.AllowUserToAddRows = false;
            dataGridViewSearchRes.AllowUserToDeleteRows = false;
            dataGridViewSearchRes.Anchor = AnchorStyles.None;
            dataGridViewSearchRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSearchRes.BorderStyle = BorderStyle.None;
            dataGridViewSearchRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchRes.Columns.AddRange(new DataGridViewColumn[] { NomduClient, prenomClient, nomClient, emailClient, telephone, motDePass, AdresseClient, dateInscriptionClient });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewSearchRes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSearchRes.Location = new Point(64, 80);
            dataGridViewSearchRes.Name = "dataGridViewSearchRes";
            dataGridViewSearchRes.ReadOnly = true;
            dataGridViewSearchRes.RowHeadersWidth = 62;
            dataGridViewSearchRes.Size = new Size(885, 238);
            dataGridViewSearchRes.TabIndex = 21;
            // 
            // NomduClient
            // 
            NomduClient.DataPropertyName = "Nom";
            NomduClient.HeaderText = "Nom du Client";
            NomduClient.MinimumWidth = 8;
            NomduClient.Name = "NomduClient";
            NomduClient.ReadOnly = true;
            // 
            // prenomClient
            // 
            prenomClient.DataPropertyName = "Prenom ";
            prenomClient.HeaderText = "Prenom Client";
            prenomClient.MinimumWidth = 8;
            prenomClient.Name = "prenomClient";
            prenomClient.ReadOnly = true;
            // 
            // nomClient
            // 
            nomClient.DataPropertyName = "NumeroChambre ";
            nomClient.HeaderText = "Numero Chambre ";
            nomClient.MinimumWidth = 8;
            nomClient.Name = "nomClient";
            nomClient.ReadOnly = true;
            // 
            // emailClient
            // 
            emailClient.DataPropertyName = "DateDebut ";
            emailClient.HeaderText = "Date Debut ";
            emailClient.MinimumWidth = 8;
            emailClient.Name = "emailClient";
            emailClient.ReadOnly = true;
            // 
            // telephone
            // 
            telephone.DataPropertyName = "DateFin ";
            telephone.HeaderText = "DateFin ";
            telephone.MinimumWidth = 8;
            telephone.Name = "telephone";
            telephone.ReadOnly = true;
            // 
            // motDePass
            // 
            motDePass.DataPropertyName = "TarifParNuit ";
            motDePass.HeaderText = "TarifParNuit ";
            motDePass.MinimumWidth = 8;
            motDePass.Name = "motDePass";
            motDePass.ReadOnly = true;
            // 
            // AdresseClient
            // 
            AdresseClient.DataPropertyName = "EtatReservation ";
            AdresseClient.HeaderText = "EtatReservation ";
            AdresseClient.MinimumWidth = 8;
            AdresseClient.Name = "AdresseClient";
            AdresseClient.ReadOnly = true;
            // 
            // dateInscriptionClient
            // 
            dateInscriptionClient.DataPropertyName = "DateCreation ";
            dateInscriptionClient.HeaderText = "DateCreation ";
            dateInscriptionClient.MinimumWidth = 8;
            dateInscriptionClient.Name = "dateInscriptionClient";
            dateInscriptionClient.ReadOnly = true;
            // 
            // buttonSearchRes
            // 
            buttonSearchRes.BackColor = Color.Cyan;
            buttonSearchRes.ForeColor = Color.Black;
            buttonSearchRes.Location = new Point(527, 28);
            buttonSearchRes.Name = "buttonSearchRes";
            buttonSearchRes.Size = new Size(112, 34);
            buttonSearchRes.TabIndex = 20;
            buttonSearchRes.Text = "Search";
            buttonSearchRes.UseVisualStyleBackColor = false;
            buttonSearchRes.Click += buttonSearchRes_Click;
            // 
            // textBoxNomCltSearchRes
            // 
            textBoxNomCltSearchRes.Location = new Point(287, 30);
            textBoxNomCltSearchRes.Name = "textBoxNomCltSearchRes";
            textBoxNomCltSearchRes.Size = new Size(234, 31);
            textBoxNomCltSearchRes.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(137, 33);
            label9.Name = "label9";
            label9.Size = new Size(144, 25);
            label9.TabIndex = 15;
            label9.Text = "Nom du Client :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 128);
            label8.Location = new Point(6, 3);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 14;
            label8.Text = "Search Reservation :";
            // 
            // tabPageUpdtAndDltRes
            // 
            tabPageUpdtAndDltRes.Controls.Add(comboBoxEtatResUpdt);
            tabPageUpdtAndDltRes.Controls.Add(label10);
            tabPageUpdtAndDltRes.Controls.Add(label11);
            tabPageUpdtAndDltRes.Controls.Add(label12);
            tabPageUpdtAndDltRes.Controls.Add(label13);
            tabPageUpdtAndDltRes.Controls.Add(label16);
            tabPageUpdtAndDltRes.Controls.Add(label17);
            tabPageUpdtAndDltRes.Controls.Add(dateTimePickerDateFinUpdt);
            tabPageUpdtAndDltRes.Controls.Add(dateTimePickerDataDebutUpdt);
            tabPageUpdtAndDltRes.Controls.Add(textBoxTarifNuitUpdt);
            tabPageUpdtAndDltRes.Controls.Add(comboBoxNumChambResUpdt);
            tabPageUpdtAndDltRes.Controls.Add(comboBoxNomCltResUpdt);
            tabPageUpdtAndDltRes.Controls.Add(buttonSearchResUpdt);
            tabPageUpdtAndDltRes.Controls.Add(buttonDeleteReserv);
            tabPageUpdtAndDltRes.Controls.Add(buttonUpdateReserv);
            tabPageUpdtAndDltRes.Controls.Add(textBoxSearchResUpdate);
            tabPageUpdtAndDltRes.Controls.Add(label15);
            tabPageUpdtAndDltRes.Controls.Add(label14);
            tabPageUpdtAndDltRes.Location = new Point(4, 4);
            tabPageUpdtAndDltRes.Name = "tabPageUpdtAndDltRes";
            tabPageUpdtAndDltRes.Padding = new Padding(3);
            tabPageUpdtAndDltRes.Size = new Size(1028, 360);
            tabPageUpdtAndDltRes.TabIndex = 2;
            tabPageUpdtAndDltRes.Text = "Updt And Delete Reservation";
            tabPageUpdtAndDltRes.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(541, 225);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 59;
            label10.Text = "Date Fin";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(541, 149);
            label11.Name = "label11";
            label11.Size = new Size(119, 25);
            label11.TabIndex = 58;
            label11.Text = "Date  Debut ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(187, 227);
            label12.Name = "label12";
            label12.Size = new Size(180, 25);
            label12.TabIndex = 57;
            label12.Text = "Etat du Reservation";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(539, 79);
            label13.Name = "label13";
            label13.Size = new Size(121, 25);
            label13.TabIndex = 56;
            label13.Text = "Tarif Du Nuit";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(187, 151);
            label16.Name = "label16";
            label16.Size = new Size(166, 25);
            label16.TabIndex = 55;
            label16.Text = "Num du Chambre ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(187, 73);
            label17.Name = "label17";
            label17.Size = new Size(139, 25);
            label17.TabIndex = 54;
            label17.Text = "Nom du Client ";
            // 
            // dateTimePickerDateFinUpdt
            // 
            dateTimePickerDateFinUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerDateFinUpdt.Location = new Point(525, 253);
            dateTimePickerDateFinUpdt.Name = "dateTimePickerDateFinUpdt";
            dateTimePickerDateFinUpdt.Size = new Size(316, 31);
            dateTimePickerDateFinUpdt.TabIndex = 53;
            // 
            // dateTimePickerDataDebutUpdt
            // 
            dateTimePickerDataDebutUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateTimePickerDataDebutUpdt.Location = new Point(525, 179);
            dateTimePickerDataDebutUpdt.Name = "dateTimePickerDataDebutUpdt";
            dateTimePickerDataDebutUpdt.Size = new Size(316, 31);
            dateTimePickerDataDebutUpdt.TabIndex = 52;
            // 
            // textBoxTarifNuitUpdt
            // 
            textBoxTarifNuitUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxTarifNuitUpdt.Location = new Point(525, 107);
            textBoxTarifNuitUpdt.Name = "textBoxTarifNuitUpdt";
            textBoxTarifNuitUpdt.Size = new Size(182, 31);
            textBoxTarifNuitUpdt.TabIndex = 51;
            // 
            // comboBoxNumChambResUpdt
            // 
            comboBoxNumChambResUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxNumChambResUpdt.FormattingEnabled = true;
            comboBoxNumChambResUpdt.Location = new Point(187, 179);
            comboBoxNumChambResUpdt.Name = "comboBoxNumChambResUpdt";
            comboBoxNumChambResUpdt.Size = new Size(182, 33);
            comboBoxNumChambResUpdt.TabIndex = 49;
            // 
            // comboBoxNomCltResUpdt
            // 
            comboBoxNomCltResUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxNomCltResUpdt.FormattingEnabled = true;
            comboBoxNomCltResUpdt.Location = new Point(187, 101);
            comboBoxNomCltResUpdt.Name = "comboBoxNomCltResUpdt";
            comboBoxNomCltResUpdt.Size = new Size(182, 33);
            comboBoxNomCltResUpdt.TabIndex = 48;
            // 
            // buttonSearchResUpdt
            // 
            buttonSearchResUpdt.BackColor = Color.Cyan;
            buttonSearchResUpdt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchResUpdt.ForeColor = Color.Black;
            buttonSearchResUpdt.Location = new Point(551, 37);
            buttonSearchResUpdt.Name = "buttonSearchResUpdt";
            buttonSearchResUpdt.Size = new Size(145, 32);
            buttonSearchResUpdt.TabIndex = 47;
            buttonSearchResUpdt.Text = "Search";
            buttonSearchResUpdt.UseVisualStyleBackColor = false;
            buttonSearchResUpdt.Click += buttonSearchResUpdt_Click;
            // 
            // buttonDeleteReserv
            // 
            buttonDeleteReserv.BackColor = Color.Red;
            buttonDeleteReserv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDeleteReserv.ForeColor = Color.White;
            buttonDeleteReserv.Location = new Point(494, 310);
            buttonDeleteReserv.Name = "buttonDeleteReserv";
            buttonDeleteReserv.Size = new Size(112, 43);
            buttonDeleteReserv.TabIndex = 46;
            buttonDeleteReserv.Text = "Delete";
            buttonDeleteReserv.UseVisualStyleBackColor = false;
            buttonDeleteReserv.Click += buttonDeleteReserv_Click;
            // 
            // buttonUpdateReserv
            // 
            buttonUpdateReserv.BackColor = Color.FromArgb(0, 192, 0);
            buttonUpdateReserv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdateReserv.ForeColor = Color.White;
            buttonUpdateReserv.Location = new Point(325, 310);
            buttonUpdateReserv.Name = "buttonUpdateReserv";
            buttonUpdateReserv.Size = new Size(112, 43);
            buttonUpdateReserv.TabIndex = 45;
            buttonUpdateReserv.Text = "Update";
            buttonUpdateReserv.UseVisualStyleBackColor = false;
            buttonUpdateReserv.Click += buttonUpdateReserv_Click;
            // 
            // textBoxSearchResUpdate
            // 
            textBoxSearchResUpdate.Location = new Point(265, 37);
            textBoxSearchResUpdate.Name = "textBoxSearchResUpdate";
            textBoxSearchResUpdate.Size = new Size(275, 31);
            textBoxSearchResUpdate.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(122, 37);
            label15.Name = "label15";
            label15.Size = new Size(152, 25);
            label15.TabIndex = 43;
            label15.Text = "ID Reseravtion : ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(255, 128, 128);
            label14.Location = new Point(6, 0);
            label14.Name = "label14";
            label14.Size = new Size(322, 28);
            label14.TabIndex = 42;
            label14.Text = "Update And Delete Reservation :";
            // 
            // tabPageListReservation
            // 
            tabPageListReservation.Controls.Add(dataGridViewListReservations);
            tabPageListReservation.Controls.Add(buttonAfficherReservations);
            tabPageListReservation.Controls.Add(label18);
            tabPageListReservation.Location = new Point(4, 4);
            tabPageListReservation.Name = "tabPageListReservation";
            tabPageListReservation.Padding = new Padding(3);
            tabPageListReservation.Size = new Size(1028, 360);
            tabPageListReservation.TabIndex = 3;
            tabPageListReservation.Text = "Listes Reservations";
            tabPageListReservation.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListReservations
            // 
            dataGridViewListReservations.AllowUserToAddRows = false;
            dataGridViewListReservations.AllowUserToDeleteRows = false;
            dataGridViewListReservations.Anchor = AnchorStyles.None;
            dataGridViewListReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListReservations.BorderStyle = BorderStyle.None;
            dataGridViewListReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListReservations.Location = new Point(6, 70);
            dataGridViewListReservations.Name = "dataGridViewListReservations";
            dataGridViewListReservations.ReadOnly = true;
            dataGridViewListReservations.RowHeadersWidth = 62;
            dataGridViewListReservations.Size = new Size(1016, 284);
            dataGridViewListReservations.TabIndex = 25;
            // 
            // buttonAfficherReservations
            // 
            buttonAfficherReservations.BackColor = Color.Cyan;
            buttonAfficherReservations.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAfficherReservations.Location = new Point(326, 13);
            buttonAfficherReservations.Name = "buttonAfficherReservations";
            buttonAfficherReservations.Size = new Size(331, 51);
            buttonAfficherReservations.TabIndex = 24;
            buttonAfficherReservations.Text = "Afficher Les Resrvations";
            buttonAfficherReservations.UseVisualStyleBackColor = false;
            buttonAfficherReservations.Click += buttonAfficherReservations_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(255, 128, 128);
            label18.Location = new Point(6, 3);
            label18.Name = "label18";
            label18.Size = new Size(233, 28);
            label18.TabIndex = 23;
            label18.Text = "Listes des Reservation :";
            // 
            // comboBoxEtatResUpdt
            // 
            comboBoxEtatResUpdt.FormattingEnabled = true;
            comboBoxEtatResUpdt.Location = new Point(187, 271);
            comboBoxEtatResUpdt.Name = "comboBoxEtatResUpdt";
            comboBoxEtatResUpdt.Size = new Size(182, 33);
            comboBoxEtatResUpdt.TabIndex = 60;
            // 
            // ControlReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlReservation);
            Name = "ControlReservation";
            Size = new Size(1080, 483);
            tabControlReservation.ResumeLayout(false);
            tabPageAjouterReservation.ResumeLayout(false);
            tabPageAjouterReservation.PerformLayout();
            tabPageSearchRes.ResumeLayout(false);
            tabPageSearchRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchRes).EndInit();
            tabPageUpdtAndDltRes.ResumeLayout(false);
            tabPageUpdtAndDltRes.PerformLayout();
            tabPageListReservation.ResumeLayout(false);
            tabPageListReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReservation;
        private TabPage tabPageAjouterReservation;
        private ComboBox comboBoxNumChambreRes;
        private ComboBox comboBoxNomClientRes;
        private TabPage tabPageSearchRes;
        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerDebut;
        private TextBox textBoxTarifRes;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAjouterReservation;
        private Label label7;
        private Label label8;
        private TextBox textBoxNomCltSearchRes;
        private Label label9;
        private Button buttonSearchRes;
        private DataGridView dataGridViewSearchRes;
        private DataGridViewTextBoxColumn NomduClient;
        private DataGridViewTextBoxColumn prenomClient;
        private DataGridViewTextBoxColumn nomClient;
        private DataGridViewTextBoxColumn emailClient;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn motDePass;
        private DataGridViewTextBoxColumn AdresseClient;
        private DataGridViewTextBoxColumn dateInscriptionClient;
        private TabPage tabPageUpdtAndDltRes;
        private Button buttonSearchResUpdt;
        private Button buttonDeleteReserv;
        private Button buttonUpdateReserv;
        private TextBox textBoxSearchResUpdate;
        private Label label15;
        private Label label14;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label16;
        private Label label17;
        private DateTimePicker dateTimePickerDateFinUpdt;
        private DateTimePicker dateTimePickerDataDebutUpdt;
        private TextBox textBoxTarifNuitUpdt;
        private ComboBox comboBoxNumChambResUpdt;
        private ComboBox comboBoxNomCltResUpdt;
        private TabPage tabPageListReservation;
        private Label label18;
        private Button buttonAfficherReservations;
        private ComboBox comboBoxEtatReservation;
        private DataGridView dataGridViewListReservations;
        private ComboBox comboBoxEtatResUpdt;
    }
}
