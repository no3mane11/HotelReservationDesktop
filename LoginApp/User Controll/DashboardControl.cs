using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginApp.User_Controll
{
    public partial class DashboardControl : UserControl
    {
        private readonly SqlConnection _conn;

        public DashboardControl()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                _conn.Open();

                // Obtenir le total des clients
                string queryTotalClients = "SELECT COUNT(*) FROM Client";
                SqlCommand cmdTotalClients = new SqlCommand(queryTotalClients, _conn);
                int totalClients = Convert.ToInt32(cmdTotalClients.ExecuteScalar());
                labelTotalClient.Text = totalClients.ToString();

                // Obtenir le total des réservations
                string queryTotalReservations = "SELECT COUNT(*) FROM Reservation";
                SqlCommand cmdTotalReservations = new SqlCommand(queryTotalReservations, _conn);
                int totalReservations = Convert.ToInt32(cmdTotalReservations.ExecuteScalar());
                labelTotalReservations.Text = totalReservations.ToString();

                // Obtenir le total des paiements
                string queryTotalPaiements = "SELECT COUNT(*) FROM Paiement";
                SqlCommand cmdTotalPaiements = new SqlCommand(queryTotalPaiements, _conn);
                int totalPaiements = Convert.ToInt32(cmdTotalPaiements.ExecuteScalar());
                labelTotalPaiements.Text = totalPaiements.ToString();

                // Obtenir le montant total des paiements
                string queryTotalMontant = "SELECT ISNULL(SUM(Montant), 0) FROM Paiement";
                SqlCommand cmdTotalMontant = new SqlCommand(queryTotalMontant, _conn);
                decimal totalMontant = Convert.ToDecimal(cmdTotalMontant.ExecuteScalar());
                labelTotalRevenu.Text = $"{totalMontant:C}"; // Formate en monnaie locale
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void labelTotalClient_Click(object sender, EventArgs e)
        {
        }
    }
}
