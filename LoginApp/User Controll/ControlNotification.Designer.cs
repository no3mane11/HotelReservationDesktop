namespace LoginApp.User_Controll
{
    partial class ControlNotification
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
            tabControlNotification = new TabControl();
            tabPageListNotif = new TabPage();
            dataGridViewListNotif = new DataGridView();
            buttonAfficherNotifications = new Button();
            label16 = new Label();
            tabPageReponseNotification = new TabPage();
            tabControlNotification.SuspendLayout();
            tabPageListNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListNotif).BeginInit();
            SuspendLayout();
            // 
            // tabControlNotification
            // 
            tabControlNotification.Alignment = TabAlignment.Bottom;
            tabControlNotification.Controls.Add(tabPageListNotif);
            tabControlNotification.Controls.Add(tabPageReponseNotification);
            tabControlNotification.Cursor = Cursors.Hand;
            tabControlNotification.Location = new Point(20, 19);
            tabControlNotification.Name = "tabControlNotification";
            tabControlNotification.SelectedIndex = 0;
            tabControlNotification.Size = new Size(942, 420);
            tabControlNotification.TabIndex = 0;
            // 
            // tabPageListNotif
            // 
            tabPageListNotif.Controls.Add(dataGridViewListNotif);
            tabPageListNotif.Controls.Add(buttonAfficherNotifications);
            tabPageListNotif.Controls.Add(label16);
            tabPageListNotif.Location = new Point(4, 4);
            tabPageListNotif.Name = "tabPageListNotif";
            tabPageListNotif.Padding = new Padding(3);
            tabPageListNotif.Size = new Size(934, 382);
            tabPageListNotif.TabIndex = 0;
            tabPageListNotif.Text = "Listes des Notifications";
            tabPageListNotif.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListNotif
            // 
            dataGridViewListNotif.AllowUserToAddRows = false;
            dataGridViewListNotif.AllowUserToDeleteRows = false;
            dataGridViewListNotif.Anchor = AnchorStyles.None;
            dataGridViewListNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListNotif.BorderStyle = BorderStyle.None;
            dataGridViewListNotif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListNotif.Location = new Point(41, 78);
            dataGridViewListNotif.Name = "dataGridViewListNotif";
            dataGridViewListNotif.ReadOnly = true;
            dataGridViewListNotif.RowHeadersWidth = 62;
            dataGridViewListNotif.Size = new Size(866, 284);
            dataGridViewListNotif.TabIndex = 17;
            // 
            // buttonAfficherNotifications
            // 
            buttonAfficherNotifications.BackColor = Color.Cyan;
            buttonAfficherNotifications.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAfficherNotifications.Location = new Point(283, 21);
            buttonAfficherNotifications.Name = "buttonAfficherNotifications";
            buttonAfficherNotifications.Size = new Size(331, 51);
            buttonAfficherNotifications.TabIndex = 16;
            buttonAfficherNotifications.Text = "Afficher Les Notifications ";
            buttonAfficherNotifications.UseVisualStyleBackColor = false;
            buttonAfficherNotifications.Click += buttonAfficherNotifications_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(255, 128, 128);
            label16.Location = new Point(0, 13);
            label16.Name = "label16";
            label16.Size = new Size(244, 28);
            label16.TabIndex = 15;
            label16.Text = "Listes des Notifications :";
            // 
            // tabPageReponseNotification
            // 
            tabPageReponseNotification.Location = new Point(4, 4);
            tabPageReponseNotification.Name = "tabPageReponseNotification";
            tabPageReponseNotification.Padding = new Padding(3);
            tabPageReponseNotification.Size = new Size(934, 382);
            tabPageReponseNotification.TabIndex = 1;
            tabPageReponseNotification.Text = "Reponse Notification ";
            tabPageReponseNotification.UseVisualStyleBackColor = true;
            // 
            // ControlNotification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlNotification);
            Name = "ControlNotification";
            Size = new Size(1096, 502);
            tabControlNotification.ResumeLayout(false);
            tabPageListNotif.ResumeLayout(false);
            tabPageListNotif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListNotif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlNotification;
        private TabPage tabPageListNotif;
        private TabPage tabPageReponseNotification;
        private Label label16;
        private DataGridView dataGridViewListNotif;
        private Button buttonAfficherNotifications;
    }
}
