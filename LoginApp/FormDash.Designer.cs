using LoginApp.User_Controll;

namespace LoginApp
{
    partial class FormDash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDash));
            panel1 = new Panel();
            buttonNotification = new Button();
            panelSlide = new Panel();
            buttonSettings = new Button();
            buttonPayement = new Button();
            buttonRoom = new Button();
            buttonReservation = new Button();
            buttonClient = new Button();
            buttonDashboard = new Button();
            panel2 = new Panel();
            dashboardControl1 = new DashboardControl();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            labelUsername = new Label();
            label2 = new Label();
            panel4 = new Panel();
            labelDateTime = new Label();
            linkLabelLogOut = new LinkLabel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            userControlSettings1 = new UserControlSettings();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            controlClient1 = new ControlClient();
            controlChambre1 = new ControlChambre();
            controlReservation1 = new ControlReservation();
            controlPaiement1 = new ControlPaiement();
            controlNotification1 = new ControlNotification();
            dashboardControl2 = new DashboardControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(buttonNotification);
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(buttonSettings);
            panel1.Controls.Add(buttonPayement);
            panel1.Controls.Add(buttonRoom);
            panel1.Controls.Add(buttonReservation);
            panel1.Controls.Add(buttonClient);
            panel1.Controls.Add(buttonDashboard);
            panel1.Location = new Point(0, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 471);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonNotification
            // 
            buttonNotification.Cursor = Cursors.Hand;
            buttonNotification.FlatStyle = FlatStyle.Flat;
            buttonNotification.Image = (Image)resources.GetObject("buttonNotification.Image");
            buttonNotification.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNotification.Location = new Point(21, 121);
            buttonNotification.Name = "buttonNotification";
            buttonNotification.Size = new Size(276, 43);
            buttonNotification.TabIndex = 7;
            buttonNotification.Text = "Notification";
            buttonNotification.UseVisualStyleBackColor = true;
            buttonNotification.Click += buttonNotification_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 24);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(15, 43);
            panelSlide.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Image = (Image)resources.GetObject("buttonSettings.Image");
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(21, 317);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(276, 43);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonPayement
            // 
            buttonPayement.Cursor = Cursors.Hand;
            buttonPayement.FlatStyle = FlatStyle.Flat;
            buttonPayement.Image = (Image)resources.GetObject("buttonPayement.Image");
            buttonPayement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPayement.Location = new Point(21, 268);
            buttonPayement.Name = "buttonPayement";
            buttonPayement.Size = new Size(276, 43);
            buttonPayement.TabIndex = 5;
            buttonPayement.Text = "Payement";
            buttonPayement.UseVisualStyleBackColor = true;
            buttonPayement.Click += buttonPayment_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.Cursor = Cursors.Hand;
            buttonRoom.FlatStyle = FlatStyle.Flat;
            buttonRoom.Image = (Image)resources.GetObject("buttonRoom.Image");
            buttonRoom.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRoom.Location = new Point(21, 170);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(276, 43);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "Room";
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonReservation
            // 
            buttonReservation.Cursor = Cursors.Hand;
            buttonReservation.FlatStyle = FlatStyle.Flat;
            buttonReservation.Image = Properties.Resources.icons8_reservation_32;
            buttonReservation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReservation.Location = new Point(21, 219);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Size = new Size(276, 43);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "Reservation";
            buttonReservation.UseVisualStyleBackColor = true;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonClient
            // 
            buttonClient.Cursor = Cursors.Hand;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Image = (Image)resources.GetObject("buttonClient.Image");
            buttonClient.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClient.Location = new Point(21, 72);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(276, 43);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(21, 24);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(276, 44);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(dashboardControl1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 627);
            panel2.Name = "panel2";
            panel2.Size = new Size(1746, 54);
            panel2.TabIndex = 0;
            // 
            // dashboardControl1
            // 
            dashboardControl1.BackColor = Color.White;
            dashboardControl1.Location = new Point(298, -435);
            dashboardControl1.Name = "dashboardControl1";
            dashboardControl1.Size = new Size(1399, 507);
            dashboardControl1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(416, 21);
            label1.TabIndex = 0;
            label1.Text = "Copyright © 2024 Hotel KS. All Rights Reserved.";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(0, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 156);
            panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Black_and_Gold_Vintage_Luxury_Hotel_Logo1;
            pictureBox3.Location = new Point(39, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(213, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 128);
            panel5.Controls.Add(labelUsername);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(298, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(1441, 66);
            panel5.TabIndex = 3;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(167, 14);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(25, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 14);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 0;
            label2.Text = "Welcome :";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelDateTime);
            panel4.Controls.Add(linkLabelLogOut);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(298, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1441, 81);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateTime.Location = new Point(21, 34);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(27, 30);
            labelDateTime.TabIndex = 0;
            labelDateTime.Text = "?";
            // 
            // linkLabelLogOut
            // 
            linkLabelLogOut.ActiveLinkColor = Color.FromArgb(0, 192, 192);
            linkLabelLogOut.AutoSize = true;
            linkLabelLogOut.Cursor = Cursors.Hand;
            linkLabelLogOut.DisabledLinkColor = Color.FromArgb(0, 192, 192);
            linkLabelLogOut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogOut.LinkColor = Color.FromArgb(0, 192, 192);
            linkLabelLogOut.Location = new Point(1313, 28);
            linkLabelLogOut.Name = "linkLabelLogOut";
            linkLabelLogOut.Size = new Size(78, 22);
            linkLabelLogOut.TabIndex = 1;
            linkLabelLogOut.TabStop = true;
            linkLabelLogOut.Text = "Log Out";
            linkLabelLogOut.VisitedLinkColor = Color.FromArgb(0, 192, 192);
            linkLabelLogOut.LinkClicked += linkLabelLogOut_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1215, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // userControlSettings1
            // 
            userControlSettings1.BackColor = Color.White;
            userControlSettings1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userControlSettings1.Location = new Point(465, 192);
            userControlSettings1.Margin = new Padding(4, 3, 4, 3);
            userControlSettings1.Name = "userControlSettings1";
            userControlSettings1.Size = new Size(1096, 429);
            userControlSettings1.TabIndex = 4;
            userControlSettings1.Visible = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // controlClient1
            // 
            controlClient1.BackColor = Color.White;
            controlClient1.Location = new Point(306, 192);
            controlClient1.Name = "controlClient1";
            controlClient1.Size = new Size(1173, 422);
            controlClient1.TabIndex = 5;
            controlClient1.Visible = false;
            controlClient1.Load += controlClient1_Load;
            // 
            // controlChambre1
            // 
            controlChambre1.Location = new Point(298, 163);
            controlChambre1.Name = "controlChambre1";
            controlChambre1.Size = new Size(1102, 464);
            controlChambre1.TabIndex = 6;
            controlChambre1.Visible = false;
            // 
            // controlReservation1
            // 
            controlReservation1.Anchor = AnchorStyles.None;
            controlReservation1.Location = new Point(301, 156);
            controlReservation1.Name = "controlReservation1";
            controlReservation1.Size = new Size(1317, 437);
            controlReservation1.TabIndex = 7;
            controlReservation1.Visible = false;
            // 
            // controlPaiement1
            // 
            controlPaiement1.BackColor = Color.White;
            controlPaiement1.Location = new Point(306, 163);
            controlPaiement1.Name = "controlPaiement1";
            controlPaiement1.Size = new Size(1053, 446);
            controlPaiement1.TabIndex = 8;
            // 
            // controlNotification1
            // 
            controlNotification1.Location = new Point(298, 156);
            controlNotification1.Name = "controlNotification1";
            controlNotification1.Size = new Size(1644, 753);
            controlNotification1.TabIndex = 9;
            controlNotification1.Visible = false;
            controlNotification1.Load += controlNotification1_Load;
            // 
            // dashboardControl2
            // 
            dashboardControl2.BackColor = Color.White;
            dashboardControl2.Location = new Point(540, 192);
            dashboardControl2.Name = "dashboardControl2";
            dashboardControl2.Size = new Size(893, 376);
            dashboardControl2.TabIndex = 10;
            dashboardControl2.Visible = false;
            // 
            // FormDash
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1746, 681);
            Controls.Add(dashboardControl2);
            Controls.Add(controlNotification1);
            Controls.Add(controlPaiement1);
            Controls.Add(controlReservation1);
            Controls.Add(controlChambre1);
            Controls.Add(controlClient1);
            Controls.Add(panel5);
            Controls.Add(userControlSettings1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel_Management_Hotel";
            WindowState = FormWindowState.Maximized;
            Load += FormDash_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelLogOut;
        private PictureBox pictureBox3;
        private Label labelDateTime;
        private Label label2;
        private Button buttonDashboard;
        private Label labelUsername;
        private Button buttonPayement;
        private Button buttonRoom;
        private Button buttonReservation;
        private Button buttonClient;
        private Button buttonSettings;
        private Panel panelSlide;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button buttonNotification;
        private User_Controll.UserControlSettings userControlSettings1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ControlClient controlClient1;
        private ControlChambre controlChambre1;
        private ControlReservation controlReservation1;
        private ControlPaiement controlPaiement1;
        private ControlNotification controlNotification1;
        private DashboardControl dashboardControl1;
        private DashboardControl dashboardControl2;
    }
}