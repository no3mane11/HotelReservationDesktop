using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace LoginApp.User_Controll
{
    public partial class ControlNotification : UserControl
    {
        private readonly SqlConnection _conn;

        public ControlNotification()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");

            // Ajouter une colonne bouton dans le DataGridView
            AddButtonColumn();
        }

        // Ajouter la colonne de bouton au DataGridView
        private void AddButtonColumn()
        {
            if (!dataGridViewListNotif.Columns.Contains("MarkAsReadButton"))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "MarkAsReadButton",
                    HeaderText = "Marquer comme lu",
                    Text = "Lire",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewListNotif.Columns.Add(buttonColumn);

                // Associer l'événement CellClick
                dataGridViewListNotif.CellClick += dataGridViewListNotif_CellClick;
            }
        }

        // Récupérer les notifications depuis la base de données
        private void buttonAfficherNotifications_Click(object sender, EventArgs e)
        {
            try
            {
                var notifications = GetNotifications();

                if (notifications != null && notifications.Rows.Count > 0)
                {
                    dataGridViewListNotif.DataSource = notifications;
                }
                else
                {
                    MessageBox.Show("Aucune notification trouvée.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des notifications : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetNotifications()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();

            try
            {
                string query = @"
                SELECT 
                    Notification.NotificationID, 
                    Notification.Message, 
                    Notification.DateEnvoi, 
                    'Client' AS TypeUtilisateur,
                    Notification.UtilisateurID, 
                    Client.Email
                FROM Notification
                JOIN Client ON Notification.UtilisateurID = Client.ClientID
                WHERE EstLu = 0
                ORDER BY Notification.DateEnvoi DESC";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'exécution de la requête SQL : " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }

        // Mettre à jour la notification comme lue
        private void MarkNotificationAsRead(int notificationId)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string query = "UPDATE Notification SET EstLu = 1 WHERE NotificationID = @NotificationID";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@NotificationID", notificationId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de la notification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }

        // Événement CellClick pour le bouton "Lire"
        private void dataGridViewListNotif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridViewListNotif.Columns[e.ColumnIndex].Name == "MarkAsReadButton")
                {
                    // Récupérer l'ID de la notification
                    if (dataGridViewListNotif.Rows[e.RowIndex].Cells["NotificationID"].Value is int notificationId)
                    {
                        var emailClient = dataGridViewListNotif.Rows[e.RowIndex].Cells["Email"].Value?.ToString();

                        if (string.IsNullOrEmpty(emailClient))
                        {
                            MessageBox.Show("L'email du client est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Marquer comme lu et envoyer l'e-mail
                        MarkNotificationAsRead(notificationId);
                        EnvoyerEmailConfirmation(emailClient, "Votre notification a été lue avec succès.");

                        MessageBox.Show("Notification marquée comme lue et e-mail envoyé.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir les notifications
                        buttonAfficherNotifications_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("ID de notification non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du traitement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Service d'envoi d'e-mail
        public class EmailService
        {
            private readonly string _smtpHost = "smtp.gmail.com";
            private readonly int _smtpPort = 587;
            private readonly string _smtpUser = "noamanehaimoudi79@gmail.com";
            private readonly string _smtpPass = "pqgq gbve xhku prxf";
            private readonly string _fromEmail = "noamanehaimoudi79@gmail.com";

            public void SendEmail(string toEmail, string subject, string body)
            {
                try
                {
                    using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort))
                    {
                        smtpClient.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                        smtpClient.EnableSsl = true;

                        var mailMessage = new MailMessage
                        {
                            From = new MailAddress(_fromEmail),
                            Subject = subject,
                            Body = body,
                            IsBodyHtml = true
                        };

                        mailMessage.To.Add(toEmail);
                        smtpClient.Send(mailMessage);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de l'envoi de l'e-mail : " + ex.Message);
                }
            }
        }

        private void EnvoyerEmailConfirmation(string emailClient, string message)
        {
            try
            {
                var emailService = new EmailService();
                emailService.SendEmail(emailClient, "Confirmation de notification", message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi de l'e-mail : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
