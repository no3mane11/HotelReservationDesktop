using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LoginApp.User_Controll
{
    public partial class ControlReservation : UserControl
    {
        private readonly SqlConnection _conn;
        private string _ClientID;
        public ControlReservation()
        {
            InitializeComponent();

            // Initialiser la connexion à la base de données
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");

            // Initialiser comboBoxEtatReservation
            comboBoxEtatReservation.Items.Clear();
            comboBoxEtatReservation.Items.Add("En attente");
            comboBoxEtatReservation.Items.Add("Confirmée");
            comboBoxEtatReservation.Items.Add("Annulée");
            comboBoxEtatReservation.SelectedIndex = 0; // Option par défaut

            // Initialiser comboBoxEtatResUpdt
            InitializeComboBoxEtatResUpdt();

            // Charger les données des chambres et des clients
            ChargerChambres();
            ChargerClients();
        }

       
        private void InitializeComboBoxEtatResUpdt()
        {
            comboBoxEtatResUpdt.Items.Clear();
            comboBoxEtatResUpdt.Items.Add("En attente");
            comboBoxEtatResUpdt.Items.Add("Confirmée");
            comboBoxEtatResUpdt.Items.Add("Annulée");
            comboBoxEtatResUpdt.SelectedIndex = 0; // Option par défaut
        }

        private void ClearFields()
        {
            comboBoxEtatReservation.SelectedIndex = -1;
            textBoxTarifRes.Clear();
            comboBoxNomClientRes.SelectedIndex = -1;
            comboBoxNumChambreRes.SelectedIndex = -1;
            dateTimePickerDebut.Value = DateTime.Today;
            dateTimePickerFin.Value = DateTime.Today;
            _ClientID = string.Empty;
            tabControlReservation.SelectedTab = tabPageAjouterReservation;
        }

        
        private void ChargerClients()
        {
            string query = "SELECT ClientID, Nom + ' ' + Prenom AS NomComplet FROM Client";

            try
            {
                _conn.Open(); // Ouvre la connexion à la base de données
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Liste pour stocker les clients sous forme de paires clé-valeur
                        var dataSource = new System.Collections.Generic.List<KeyValuePair<string, int>>();

                        while (reader.Read())
                        {
                            dataSource.Add(new KeyValuePair<string, int>(
                                reader["NomComplet"].ToString(),   // Clé : Nom complet (Nom + Prénom)
                                Convert.ToInt32(reader["ClientID"]) // Valeur : ID du client
                            ));
                        }

                        // Configuration de la ComboBox
                        comboBoxNomClientRes.DataSource = dataSource;
                        comboBoxNomClientRes.DisplayMember = "Key"; // Nom affiché
                        comboBoxNomClientRes.ValueMember = "Value"; // ID interne
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas de problème
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message);
            }
            finally
            {
                // Ferme la connexion même en cas d'erreur
                _conn.Close();
            }
        }

        private void ChargerChambres()
        {
            string query = "SELECT c.ChambreID, c.NumeroChambre, tc.Nom AS TypeChambre FROM Chambre c JOIN TypeChambre tc ON c.TypeChambreID = tc.TypeChambreID WHERE c.EstDisponible = 1;";

            try
            {
                // Ouvre la connexion à la base de données
                _conn.Open();

                // Liste pour stocker les chambres sous forme de paires clé-valeur
                var chambres = new System.Collections.Generic.List<KeyValuePair<string, int>>();

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chambres.Add(new KeyValuePair<string, int>(
                                reader["NumeroChambre"].ToString(),  // Clé : Numéro de chambre
                                Convert.ToInt32(reader["ChambreID"]) // Valeur : ID de la chambre
                            ));
                        }
                    }
                }

                // Configuration de la ComboBox
                comboBoxNumChambreRes.DataSource = chambres;
                comboBoxNumChambreRes.DisplayMember = "Key"; // Nom affiché : Numéro de chambre
                comboBoxNumChambreRes.ValueMember = "Value"; // ID interne : ChambreID
            }
            catch (SqlException ex)
            {
                // Affiche un message d'erreur spécifique aux erreurs SQL
                MessageBox.Show("Erreur SQL lors du chargement des chambres : " + ex.Message);
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur générique
                MessageBox.Show("Erreur lors du chargement des chambres : " + ex.Message);
            }
            finally
            {
                // Ferme la connexion même en cas d'erreur
                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }



        private void buttonAjouterReservation_Click(object sender, EventArgs e)
        {
            // Vérifier que les champs obligatoires sont remplis
            if (comboBoxEtatReservation.SelectedIndex == null ||
                comboBoxNomClientRes.SelectedItem == null ||
                comboBoxNumChambreRes.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxTarifRes.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que la date de début est antérieure à la date de fin
            if (dateTimePickerDebut.Value >= dateTimePickerFin.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier que le tarif est un nombre valide
            if (!decimal.TryParse(textBoxTarifRes.Text.Trim(), out decimal tarifParNuit))
            {
                MessageBox.Show("Le tarif doit être un nombre valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construire la requête SQL pour insérer une réservation
            string query = "INSERT INTO Reservation (ClientID, ChambreID, DateDebut, DateFin, TarifParNuit, EtatReservation) " +
                           "VALUES (@ClientID, @ChambreID, @DateDebut, @DateFin, @TarifParNuit, @EtatReservation)";

            try
            {
                // Ouvrir la connexion
                _conn.Open();

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    // Ajouter les paramètres à la commande
                    command.Parameters.AddWithValue("@ClientID", ((KeyValuePair<string, int>)comboBoxNomClientRes.SelectedItem).Value);
                    command.Parameters.AddWithValue("@ChambreID", ((KeyValuePair<string, int>)comboBoxNumChambreRes.SelectedItem).Value);
                    command.Parameters.AddWithValue("@DateDebut", dateTimePickerDebut.Value);
                    command.Parameters.AddWithValue("@DateFin", dateTimePickerFin.Value);
                    command.Parameters.AddWithValue("@TarifParNuit", tarifParNuit);
                    command.Parameters.AddWithValue("@EtatReservation", comboBoxEtatReservation.SelectedItem);

                    // Exécuter la commande SQL
                    command.ExecuteNonQuery();

                    // Afficher un message de succès
                    MessageBox.Show("Réservation ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Réinitialiser les champs
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur en cas de problème
                MessageBox.Show($"Erreur lors de l'ajout de la réservation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion à la base de données
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonSearchRes_Click(object sender, EventArgs e)
        {
            // Vérifier si le champ de recherche est rempli
            if (string.IsNullOrWhiteSpace(textBoxNomCltSearchRes.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de client pour effectuer la recherche.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Requête SQL pour rechercher les réservations par nom du client
            string query = @"
    SELECT R.ReservationID,Ch.NumeroChambre, C.ClientID,R.DateDebut, R.DateFin, R.TarifParNuit, R.EtatReservation
    FROM Reservation R
    INNER JOIN Client C ON R.ClientID = C.ClientID
    INNER JOIN Chambre Ch ON R.ChambreID = Ch.ChambreID
    WHERE C.Nom LIKE @NomClient";

            try
            {
                // Ouvrir la connexion
                _conn.Open();

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    // Ajouter le paramètre pour la recherche par nom
                    command.Parameters.AddWithValue("@NomClient", "%" + textBoxNomCltSearchRes.Text.Trim() + "%");

                    // Remplir un DataTable avec les résultats
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Réinitialiser la source de données et vider les colonnes existantes
                        dataGridViewSearchRes.DataSource = null;
                        dataGridViewSearchRes.Columns.Clear();

                        // Vérifier si des résultats sont présents
                        if (dataTable.Rows.Count > 0)
                        {
                            // Lier les données à la DataGridView
                            dataGridViewSearchRes.DataSource = dataTable;


                        }
                        else
                        {
                            MessageBox.Show("Aucune réservation trouvée pour ce client.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void LoadReservations()
        {
            string query = @"
        SELECT R.ReservationID, R.DateDebut, R.DateFin, R.TarifParNuit, R.EtatReservation, 
               C.Nom AS NomClient, C.Prenom AS PrenomClient, Ch.NomChambre, Ch.DescriptionChambre 
        FROM Reservation R
        INNER JOIN Client C ON R.ClientID = C.ClientID
        INNER JOIN Chambre Ch ON R.ChambreID = Ch.ChambreID";

            try
            {
                _conn.Open();

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewSearchRes.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des réservations : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonSearchResUpdt_Click(object sender, EventArgs e)
        {
            // Vérifier si l'ID de réservation est saisi
            if (string.IsNullOrWhiteSpace(textBoxSearchResUpdate.Text))
            {
                MessageBox.Show("Veuillez entrer un ID de réservation pour rechercher.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reservationId = textBoxSearchResUpdate.Text.Trim();

            // Requête SQL pour rechercher les détails de la réservation
            string query = @"
        SELECT R.ReservationID, R.DateDebut, R.DateFin, R.TarifParNuit, R.EtatReservation,
               C.ClientID, C.Nom + ' ' + C.Prenom AS NomComplet,
               Ch.ChambreID, Ch.NumeroChambre
        FROM Reservation R
        INNER JOIN Client C ON R.ClientID = C.ClientID
        INNER JOIN Chambre Ch ON R.ChambreID = Ch.ChambreID
        WHERE R.ReservationID = @ReservationID";

            try
            {
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Charger les données dans les champs correspondants
                            comboBoxNomCltResUpdt.DataSource = null;
                            comboBoxNomCltResUpdt.Items.Clear();
                            comboBoxNomCltResUpdt.Items.Add(new KeyValuePair<string, int>(
                                reader["NomComplet"].ToString(),
                                Convert.ToInt32(reader["ClientID"])
                            ));
                            comboBoxNomCltResUpdt.SelectedIndex = 0;

                            comboBoxNumChambResUpdt.DataSource = null;
                            comboBoxNumChambResUpdt.Items.Clear();
                            comboBoxNumChambResUpdt.Items.Add(new KeyValuePair<string, int>(
                                reader["NumeroChambre"].ToString(),
                                Convert.ToInt32(reader["ChambreID"])
                            ));
                            comboBoxNumChambResUpdt.SelectedIndex = 0;

                            comboBoxEtatResUpdt.SelectedItem = reader["EtatReservation"].ToString();
                            textBoxTarifNuitUpdt.Text = reader["TarifParNuit"].ToString();
                            dateTimePickerDataDebutUpdt.Value = Convert.ToDateTime(reader["DateDebut"]);
                            dateTimePickerDateFinUpdt.Value = Convert.ToDateTime(reader["DateFin"]);
                        }
                        else
                        {
                            MessageBox.Show("Aucune réservation trouvée avec cet ID.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }





        private void buttonUpdateReserv_Click(object sender, EventArgs e)
        {
            // Charger les clients et les chambres avant de procéder à la mise à jour
            ChargerClients(); // Appelle la méthode pour charger les clients
            ChargerChambres(); // Appelle la méthode pour charger les chambres

            string reservationId = textBoxSearchResUpdate.Text.Trim();

            if (string.IsNullOrEmpty(reservationId))
            {
                MessageBox.Show("Veuillez entrer un ID de réservation pour effectuer la mise à jour.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = @"
UPDATE Reservation
SET ClientID = @ClientID,
    ChambreID = @ChambreID,
    DateDebut = @DateDebut,
    DateFin = @DateFin,
    TarifParNuit = @TarifParNuit,
    EtatReservation = @EtatReservation
WHERE ReservationID = @ReservationID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // Ajouter les paramètres pour la requête SQL
                    cmd.Parameters.AddWithValue("@ClientID", ((KeyValuePair<string, int>)comboBoxNomCltResUpdt.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@ChambreID", ((KeyValuePair<string, int>)comboBoxNumChambResUpdt.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@DateDebut", dateTimePickerDataDebutUpdt.Value);
                    cmd.Parameters.AddWithValue("@DateFin", dateTimePickerDateFinUpdt.Value);
                    cmd.Parameters.AddWithValue("@TarifParNuit", decimal.Parse(textBoxTarifNuitUpdt.Text.Trim()));
                    cmd.Parameters.AddWithValue("@EtatReservation", comboBoxEtatResUpdt.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@ReservationID", int.Parse(reservationId));

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Réservation mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Optionnellement, réinitialiser les champs
                        LoadReservations(); // Recharger les données du DataGridView
                    }
                    else
                    {
                        MessageBox.Show("La mise à jour de la réservation a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void buttonDeleteReserv_Click(object sender, EventArgs e)
        {
            string reservationId = textBoxSearchResUpdate.Text.Trim();

            // Vérification si le champ est vide
            if (string.IsNullOrEmpty(reservationId))
            {
                MessageBox.Show("Veuillez entrer un ID de réservation à supprimer.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demander confirmation avant de supprimer
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette réservation ?",
                                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // L'utilisateur a annulé
            }

            string query = "DELETE FROM Reservation WHERE ReservationID = @ReservationID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", int.Parse(reservationId));

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Réservation supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Réinitialiser les champs si nécessaire
                        LoadReservations(); // Recharger les données si vous utilisez un DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Aucune réservation trouvée avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonAfficherReservations_Click(object sender, EventArgs e)
        {
            // Requête SQL pour récupérer toutes les réservations
            string query = @"
SELECT R.ReservationID, Ch.NumeroChambre, C.ClientID,C.Nom,C.Prenom, R.DateDebut, R.DateFin, R.TarifParNuit, R.EtatReservation
FROM Reservation R
INNER JOIN Client C ON R.ClientID = C.ClientID
INNER JOIN Chambre Ch ON R.ChambreID = Ch.ChambreID";

            try
            {
                // Ouvrir la connexion
                _conn.Open();

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    // Remplir un DataTable avec les résultats
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Réinitialiser la source de données et vider les colonnes existantes
                        dataGridViewListReservations.DataSource = null;
                        dataGridViewListReservations.Columns.Clear();

                        // Vérifier si des résultats sont présents
                        if (dataTable.Rows.Count > 0)
                        {
                            // Lier les données à la DataGridView
                            dataGridViewListReservations.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Aucune réservation trouvée.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur
                MessageBox.Show($"Erreur lors de la récupération des réservations : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void dataGridViewListReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

