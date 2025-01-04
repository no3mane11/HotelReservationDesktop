namespace LoginApp.User_Controll
{
    partial class DashboardControl
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
            panel1 = new Panel();
            labelTotalClient = new Label();
            label1 = new Label();
            panel2 = new Panel();
            labelTotalReservations = new Label();
            label2 = new Label();
            panel3 = new Panel();
            labelTotalPaiements = new Label();
            label3 = new Label();
            panel4 = new Panel();
            labelTotalRevenu = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.BackgroundImage = Properties.Resources.icons8_clients_96;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(labelTotalClient);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(65, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 193);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelTotalClient
            // 
            labelTotalClient.AutoSize = true;
            labelTotalClient.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTotalClient.Location = new Point(138, 142);
            labelTotalClient.Name = "labelTotalClient";
            labelTotalClient.Size = new Size(23, 30);
            labelTotalClient.TabIndex = 1;
            labelTotalClient.Text = "?";
            labelTotalClient.Click += labelTotalClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 0;
            label1.Text = "Total Clients :";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 64, 0);
            panel2.BackgroundImage = Properties.Resources.icons8_reservation_96;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(labelTotalReservations);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(444, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 193);
            panel2.TabIndex = 1;
            // 
            // labelTotalReservations
            // 
            labelTotalReservations.AutoSize = true;
            labelTotalReservations.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTotalReservations.Location = new Point(139, 142);
            labelTotalReservations.Name = "labelTotalReservations";
            labelTotalReservations.Size = new Size(23, 30);
            labelTotalReservations.TabIndex = 2;
            labelTotalReservations.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(57, 10);
            label2.Name = "label2";
            label2.Size = new Size(214, 30);
            label2.TabIndex = 1;
            label2.Text = "Total Reservations :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.BackgroundImage = Properties.Resources.icons8_paid_96;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(labelTotalPaiements);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(64, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 180);
            panel3.TabIndex = 2;
            // 
            // labelTotalPaiements
            // 
            labelTotalPaiements.AutoSize = true;
            labelTotalPaiements.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTotalPaiements.Location = new Point(129, 132);
            labelTotalPaiements.Name = "labelTotalPaiements";
            labelTotalPaiements.Size = new Size(23, 30);
            labelTotalPaiements.TabIndex = 3;
            labelTotalPaiements.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(48, 13);
            label3.Name = "label3";
            label3.Size = new Size(189, 30);
            label3.TabIndex = 1;
            label3.Text = "Total Paiements :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.BackgroundImage = Properties.Resources.icons8_money_96;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(labelTotalRevenu);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(444, 212);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 180);
            panel4.TabIndex = 3;
            // 
            // labelTotalRevenu
            // 
            labelTotalRevenu.AutoSize = true;
            labelTotalRevenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelTotalRevenu.Location = new Point(139, 132);
            labelTotalRevenu.Name = "labelTotalRevenu";
            labelTotalRevenu.Size = new Size(23, 30);
            labelTotalRevenu.TabIndex = 3;
            labelTotalRevenu.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(70, 13);
            label4.Name = "label4";
            label4.Size = new Size(167, 30);
            label4.TabIndex = 1;
            label4.Text = "Total Revenus :";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardControl";
            Size = new Size(848, 496);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTotalClient;
        private Label labelTotalReservations;
        private Label labelTotalPaiements;
        private Label labelTotalRevenu;
    }
}
