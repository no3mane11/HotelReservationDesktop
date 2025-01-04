using System;
using System.Windows.Forms;
using LoginApp.User_Controll;

namespace LoginApp
{
    public partial class FormDash : Form
    {
        // Champ encapsulé pour Username
        private string _username;
        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public FormDash()
        {
            InitializeComponent();
        }

        // Timer pour afficher l'heure actuelle
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        // Chargement du formulaire
        private void FormDash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username ?? "Guest"; // Valeur par défaut si Username est null
        }

        // Méthode pour déplacer le panneau d'indicateur actif
        private void MovePanel(Control btn)
        {
            if (btn == null) return; // Validation pour éviter les erreurs
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        // Événement pour bouton Dashboard
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSettings1.Hide();
            controlClient1.Hide();
            controlChambre1.Hide();
            controlReservation1.Hide();
            controlPaiement1.Hide();
            dashboardControl2.Show();

        }

        // Événement pour bouton Client
        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSettings1.Hide();
            controlClient1.Show();
            controlChambre1.Hide();
            controlReservation1.Hide();
            controlPaiement1.Hide();
            controlNotification1.Hide();
            dashboardControl2.Hide();



        }

        // Événement pour bouton Room
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);

            controlChambre1.Show();
            userControlSettings1.Hide();
            controlClient1.Hide();
            controlReservation1.Hide();
            controlPaiement1.Hide();
            controlNotification1.Hide();
        }

        // Événement pour bouton Reservation
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSettings1.Hide();
            controlClient1.Hide();
            controlChambre1.Hide();
            controlPaiement1.Hide();
            controlReservation1.Show();
            controlNotification1.Hide();
        }

        // Événement pour bouton Payment
        private void buttonPayment_Click(object sender, EventArgs e)
        {
            MovePanel(buttonPayement);
            controlPaiement1.Show();
            userControlSettings1.Hide();
            controlClient1.Hide();
            controlChambre1.Hide();
            controlReservation1.Hide();
            controlNotification1.Hide();
            dashboardControl2.Hide();
        }

        // Événement pour bouton Settings
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlSettings1.Clear();
            userControlSettings1.Show();
            controlClient1.Hide();
            controlChambre1.Hide();
            controlReservation1.Hide();
            controlPaiement1.Hide();
            dashboardControl2.Hide();


        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            MovePanel(buttonNotification);
            controlChambre1.Hide();
            controlClient1.Hide();
            userControlSettings1.Hide();
            controlReservation1.Hide();
            controlPaiement1.Hide();
            controlNotification1.Show();
            dashboardControl2.Hide();
        }

        // Événement pour bouton Employer
        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            controlChambre1.Hide();
            controlClient1.Hide();
            userControlSettings1.Hide();
            controlReservation1.Hide();
            controlNotification1.Hide();
            dashboardControl2.Hide();
        }


        // Déconnexion et fermeture de l'application
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Are you to log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    timer1.Stop();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void userControlSettings2_Load(object sender, EventArgs e)
        {

        }

        private void clientControl1_Load(object sender, EventArgs e)
        {

        }

        private void ClientControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void controlClient1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlNotification1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
