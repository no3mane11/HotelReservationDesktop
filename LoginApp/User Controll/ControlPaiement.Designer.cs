namespace LoginApp.User_Controll
{
    partial class ControlPaiement
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
            tabControlPaiement = new TabControl();
            tabPageAjtPaiement = new TabPage();
            buttonAjouterPaiement = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerDatePai = new DateTimePicker();
            textBoxMontantPai = new TextBox();
            comboBoxModePai = new ComboBox();
            comboBoxResIdPai = new ComboBox();
            tabPageListesPaiement = new TabPage();
            buttonImprimerReservation = new Button();
            dataGridViewListPai = new DataGridView();
            buttonAfficherPaiement = new Button();
            label18 = new Label();
            tabPage1 = new TabPage();
            label10 = new Label();
            buttonSearchIdPai = new Button();
            textBoxIdPaiement = new TextBox();
            label15 = new Label();
            buttonDeletePai = new Button();
            buttonUpdatePai = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePickerDatePai1 = new DateTimePicker();
            textBoxMontantPai1 = new TextBox();
            comboBoxModePai1 = new ComboBox();
            comboBoxResIdPai1 = new ComboBox();
            tabControlPaiement.SuspendLayout();
            tabPageAjtPaiement.SuspendLayout();
            tabPageListesPaiement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListPai).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPaiement
            // 
            tabControlPaiement.Alignment = TabAlignment.Bottom;
            tabControlPaiement.Controls.Add(tabPageAjtPaiement);
            tabControlPaiement.Controls.Add(tabPageListesPaiement);
            tabControlPaiement.Controls.Add(tabPage1);
            tabControlPaiement.Cursor = Cursors.Hand;
            tabControlPaiement.Location = new Point(19, 3);
            tabControlPaiement.Name = "tabControlPaiement";
            tabControlPaiement.SelectedIndex = 0;
            tabControlPaiement.Size = new Size(1004, 438);
            tabControlPaiement.TabIndex = 0;
            // 
            // tabPageAjtPaiement
            // 
            tabPageAjtPaiement.BackgroundImageLayout = ImageLayout.None;
            tabPageAjtPaiement.Controls.Add(buttonAjouterPaiement);
            tabPageAjtPaiement.Controls.Add(label5);
            tabPageAjtPaiement.Controls.Add(label4);
            tabPageAjtPaiement.Controls.Add(label3);
            tabPageAjtPaiement.Controls.Add(label2);
            tabPageAjtPaiement.Controls.Add(label1);
            tabPageAjtPaiement.Controls.Add(dateTimePickerDatePai);
            tabPageAjtPaiement.Controls.Add(textBoxMontantPai);
            tabPageAjtPaiement.Controls.Add(comboBoxModePai);
            tabPageAjtPaiement.Controls.Add(comboBoxResIdPai);
            tabPageAjtPaiement.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageAjtPaiement.ForeColor = Color.Black;
            tabPageAjtPaiement.Location = new Point(4, 4);
            tabPageAjtPaiement.Name = "tabPageAjtPaiement";
            tabPageAjtPaiement.Padding = new Padding(3);
            tabPageAjtPaiement.Size = new Size(996, 400);
            tabPageAjtPaiement.TabIndex = 0;
            tabPageAjtPaiement.Text = "Ajouter Paiement ";
            tabPageAjtPaiement.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterPaiement
            // 
            buttonAjouterPaiement.BackColor = Color.Teal;
            buttonAjouterPaiement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouterPaiement.ForeColor = Color.White;
            buttonAjouterPaiement.Location = new Point(369, 288);
            buttonAjouterPaiement.Name = "buttonAjouterPaiement";
            buttonAjouterPaiement.Size = new Size(150, 59);
            buttonAjouterPaiement.TabIndex = 16;
            buttonAjouterPaiement.Text = "Ajouter ";
            buttonAjouterPaiement.UseVisualStyleBackColor = false;
            buttonAjouterPaiement.Click += buttonAjouterPaiement_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 128);
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(189, 28);
            label5.TabIndex = 8;
            label5.Text = "Ajouter Paiement :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(546, 65);
            label4.Name = "label4";
            label4.Size = new Size(198, 28);
            label4.TabIndex = 7;
            label4.Text = "Date de Paiement : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(181, 187);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 6;
            label3.Text = "Montant :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(546, 185);
            label2.Name = "label2";
            label2.Size = new Size(207, 28);
            label2.TabIndex = 5;
            label2.Text = "Mode de Paiement : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(173, 65);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 4;
            label1.Text = " ID du Reservation : ";
            // 
            // dateTimePickerDatePai
            // 
            dateTimePickerDatePai.Location = new Point(546, 106);
            dateTimePickerDatePai.Name = "dateTimePickerDatePai";
            dateTimePickerDatePai.Size = new Size(300, 31);
            dateTimePickerDatePai.TabIndex = 3;
            // 
            // textBoxMontantPai
            // 
            textBoxMontantPai.Location = new Point(181, 221);
            textBoxMontantPai.Name = "textBoxMontantPai";
            textBoxMontantPai.Size = new Size(150, 31);
            textBoxMontantPai.TabIndex = 2;
            // 
            // comboBoxModePai
            // 
            comboBoxModePai.FormattingEnabled = true;
            comboBoxModePai.Location = new Point(546, 219);
            comboBoxModePai.Name = "comboBoxModePai";
            comboBoxModePai.Size = new Size(253, 33);
            comboBoxModePai.TabIndex = 1;
            // 
            // comboBoxResIdPai
            // 
            comboBoxResIdPai.FormattingEnabled = true;
            comboBoxResIdPai.Location = new Point(181, 104);
            comboBoxResIdPai.Name = "comboBoxResIdPai";
            comboBoxResIdPai.Size = new Size(163, 33);
            comboBoxResIdPai.TabIndex = 0;
            // 
            // tabPageListesPaiement
            // 
            tabPageListesPaiement.Controls.Add(buttonImprimerReservation);
            tabPageListesPaiement.Controls.Add(dataGridViewListPai);
            tabPageListesPaiement.Controls.Add(buttonAfficherPaiement);
            tabPageListesPaiement.Controls.Add(label18);
            tabPageListesPaiement.Location = new Point(4, 4);
            tabPageListesPaiement.Name = "tabPageListesPaiement";
            tabPageListesPaiement.Padding = new Padding(3);
            tabPageListesPaiement.Size = new Size(996, 400);
            tabPageListesPaiement.TabIndex = 1;
            tabPageListesPaiement.Text = "Listes Paiement";
            tabPageListesPaiement.UseVisualStyleBackColor = true;
            // 
            // buttonImprimerReservation
            // 
            buttonImprimerReservation.BackColor = Color.Black;
            buttonImprimerReservation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImprimerReservation.ForeColor = SystemColors.ButtonHighlight;
            buttonImprimerReservation.Location = new Point(401, 337);
            buttonImprimerReservation.Name = "buttonImprimerReservation";
            buttonImprimerReservation.Size = new Size(124, 57);
            buttonImprimerReservation.TabIndex = 29;
            buttonImprimerReservation.Text = "imprimer";
            buttonImprimerReservation.UseVisualStyleBackColor = false;
            buttonImprimerReservation.Click += buttonImprimerReservation_Click;
            // 
            // dataGridViewListPai
            // 
            dataGridViewListPai.AllowUserToAddRows = false;
            dataGridViewListPai.AllowUserToDeleteRows = false;
            dataGridViewListPai.Anchor = AnchorStyles.None;
            dataGridViewListPai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListPai.BorderStyle = BorderStyle.None;
            dataGridViewListPai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListPai.Location = new Point(6, 89);
            dataGridViewListPai.Name = "dataGridViewListPai";
            dataGridViewListPai.ReadOnly = true;
            dataGridViewListPai.RowHeadersWidth = 62;
            dataGridViewListPai.Size = new Size(984, 242);
            dataGridViewListPai.TabIndex = 28;
            // 
            // buttonAfficherPaiement
            // 
            buttonAfficherPaiement.BackColor = Color.Cyan;
            buttonAfficherPaiement.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAfficherPaiement.Location = new Point(324, 20);
            buttonAfficherPaiement.Name = "buttonAfficherPaiement";
            buttonAfficherPaiement.Size = new Size(331, 51);
            buttonAfficherPaiement.TabIndex = 27;
            buttonAfficherPaiement.Text = "Afficher Les Paiements";
            buttonAfficherPaiement.UseVisualStyleBackColor = false;
            buttonAfficherPaiement.Click += buttonAfficherPaiement_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(255, 128, 128);
            label18.Location = new Point(3, 3);
            label18.Name = "label18";
            label18.Size = new Size(218, 28);
            label18.TabIndex = 26;
            label18.Text = "Listes des Paiements :";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(buttonSearchIdPai);
            tabPage1.Controls.Add(textBoxIdPaiement);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(buttonDeletePai);
            tabPage1.Controls.Add(buttonUpdatePai);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(dateTimePickerDatePai1);
            tabPage1.Controls.Add(textBoxMontantPai1);
            tabPage1.Controls.Add(comboBoxModePai1);
            tabPage1.Controls.Add(comboBoxResIdPai1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(996, 400);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Update and Delete Paiement";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 128);
            label10.Location = new Point(6, 0);
            label10.Name = "label10";
            label10.Size = new Size(295, 28);
            label10.TabIndex = 52;
            label10.Text = "Update and Delete Paiement :";
            // 
            // buttonSearchIdPai
            // 
            buttonSearchIdPai.BackColor = Color.Cyan;
            buttonSearchIdPai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchIdPai.ForeColor = Color.Black;
            buttonSearchIdPai.Location = new Point(554, 56);
            buttonSearchIdPai.Name = "buttonSearchIdPai";
            buttonSearchIdPai.Size = new Size(145, 32);
            buttonSearchIdPai.TabIndex = 51;
            buttonSearchIdPai.Text = "Search";
            buttonSearchIdPai.UseVisualStyleBackColor = false;
            buttonSearchIdPai.Click += buttonSearchIdPai_Click_1;
            // 
            // textBoxIdPaiement
            // 
            textBoxIdPaiement.Location = new Point(354, 56);
            textBoxIdPaiement.Name = "textBoxIdPaiement";
            textBoxIdPaiement.Size = new Size(177, 31);
            textBoxIdPaiement.TabIndex = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(211, 56);
            label15.Name = "label15";
            label15.Size = new Size(131, 25);
            label15.TabIndex = 49;
            label15.Text = "ID Paiement : ";
            // 
            // buttonDeletePai
            // 
            buttonDeletePai.BackColor = Color.Red;
            buttonDeletePai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDeletePai.ForeColor = Color.White;
            buttonDeletePai.Location = new Point(464, 303);
            buttonDeletePai.Name = "buttonDeletePai";
            buttonDeletePai.Size = new Size(112, 43);
            buttonDeletePai.TabIndex = 48;
            buttonDeletePai.Text = "Delete";
            buttonDeletePai.UseVisualStyleBackColor = false;
            buttonDeletePai.Click += buttonDeletePai_Click_1;
            // 
            // buttonUpdatePai
            // 
            buttonUpdatePai.BackColor = Color.FromArgb(0, 192, 0);
            buttonUpdatePai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonUpdatePai.ForeColor = Color.White;
            buttonUpdatePai.Location = new Point(309, 303);
            buttonUpdatePai.Name = "buttonUpdatePai";
            buttonUpdatePai.Size = new Size(112, 43);
            buttonUpdatePai.TabIndex = 47;
            buttonUpdatePai.Text = "Update";
            buttonUpdatePai.UseVisualStyleBackColor = false;
            buttonUpdatePai.Click += buttonUpdatePai_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(535, 108);
            label6.Name = "label6";
            label6.Size = new Size(198, 28);
            label6.TabIndex = 24;
            label6.Text = "Date de Paiement : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(170, 207);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 23;
            label7.Text = "Montant :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(535, 205);
            label8.Name = "label8";
            label8.Size = new Size(207, 28);
            label8.TabIndex = 22;
            label8.Text = "Mode de Paiement : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(162, 108);
            label9.Name = "label9";
            label9.Size = new Size(205, 28);
            label9.TabIndex = 21;
            label9.Text = " ID du Reservation : ";
            // 
            // dateTimePickerDatePai1
            // 
            dateTimePickerDatePai1.Location = new Point(535, 149);
            dateTimePickerDatePai1.Name = "dateTimePickerDatePai1";
            dateTimePickerDatePai1.Size = new Size(300, 31);
            dateTimePickerDatePai1.TabIndex = 20;
            // 
            // textBoxMontantPai1
            // 
            textBoxMontantPai1.Location = new Point(170, 241);
            textBoxMontantPai1.Name = "textBoxMontantPai1";
            textBoxMontantPai1.Size = new Size(150, 31);
            textBoxMontantPai1.TabIndex = 19;
            // 
            // comboBoxModePai1
            // 
            comboBoxModePai1.FormattingEnabled = true;
            comboBoxModePai1.Location = new Point(535, 239);
            comboBoxModePai1.Name = "comboBoxModePai1";
            comboBoxModePai1.Size = new Size(253, 33);
            comboBoxModePai1.TabIndex = 18;
            // 
            // comboBoxResIdPai1
            // 
            comboBoxResIdPai1.FormattingEnabled = true;
            comboBoxResIdPai1.Location = new Point(170, 147);
            comboBoxResIdPai1.Name = "comboBoxResIdPai1";
            comboBoxResIdPai1.Size = new Size(163, 33);
            comboBoxResIdPai1.TabIndex = 17;
            // 
            // ControlPaiement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlPaiement);
            Name = "ControlPaiement";
            Size = new Size(1072, 471);
            tabControlPaiement.ResumeLayout(false);
            tabPageAjtPaiement.ResumeLayout(false);
            tabPageAjtPaiement.PerformLayout();
            tabPageListesPaiement.ResumeLayout(false);
            tabPageListesPaiement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListPai).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPaiement;
        private TabPage tabPageAjtPaiement;
        private TabPage tabPageListesPaiement;
        private DateTimePicker dateTimePickerDatePai;
        private TextBox textBoxMontantPai;
        private ComboBox comboBoxModePai;
        private ComboBox comboBoxResIdPai;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button buttonAjouterPaiement;
        private Button buttonAfficherPaiement;
        private Label label18;
        private DataGridView dataGridViewListPai;
        private TabPage tabPage1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePickerDatePai1;
        private TextBox textBoxMontantPai1;
        private ComboBox comboBoxModePai1;
        private ComboBox comboBoxResIdPai1;
        private Button buttonDeletePai;
        private Button buttonUpdatePai;
        private Label label10;
        private Button buttonSearchIdPai;
        private Label label15;
        private TextBox textBoxIdPaiement;
        private Button buttonImprimerReservation;
    }
}
