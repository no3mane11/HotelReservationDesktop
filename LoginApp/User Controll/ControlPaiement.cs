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
using System.Reflection.Metadata;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace LoginApp.User_Controll
{
    public partial class ControlPaiement : UserControl
    {
        private readonly SqlConnection _conn;
        //private object textBoxSearchPaiUpdate;
        //private object textBoxSearchIdPai;

        public ControlPaiement()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");

            // Charger les ReservationID dans la ComboBox
            string query = "SELECT ReservationID FROM Reservation WHERE EtatReservation != 'Annulée'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    _conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBoxResIdPai.Items.Clear(); // Réinitialiser les items
                        while (reader.Read())
                        {
                            comboBoxResIdPai.Items.Add(reader["ReservationID"].ToString());
                        }
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

            comboBoxModePai.Items.Add("Carte bancaire");
            comboBoxModePai.Items.Add("Espèces");

            // Optionnel : définir une valeur par défaut
            comboBoxModePai.SelectedIndex = 0;

            //
            comboBoxModePai1.Items.Add("Carte bancaire");
            comboBoxModePai1.Items.Add("Espèces");

            // Optionnel : définir une valeur par défaut
            comboBoxModePai1.SelectedIndex = 0;
        }

        private void ClearFields()
        {
            comboBoxResIdPai1.SelectedIndex = -1;
            textBoxMontantPai1.Clear();
            textBoxIdPaiement.Clear();
            comboBoxModePai1.SelectedIndex = -1;
            dateTimePickerDatePai1.Value = DateTime.Today;

        }
        private bool IsReservationIdValid(int reservationId)
        {
            string query = "SELECT COUNT(*) FROM Reservation WHERE ReservationID = @ReservationID AND EtatReservation != 'Annulée'";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    _conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la vérification de la réservation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void buttonAjouterPaiement_Click(object sender, EventArgs e)
        {
            if (comboBoxResIdPai.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une réservation.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = int.Parse(comboBoxResIdPai.SelectedItem.ToString());
            if (!IsReservationIdValid(reservationId))
            {
                MessageBox.Show("La réservation sélectionnée est invalide ou annulée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Vérification des champs
            if (comboBoxResIdPai.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une réservation.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMontantPai.Text) || !decimal.TryParse(textBoxMontantPai.Text, out decimal montant))
            {
                MessageBox.Show("Veuillez entrer un montant valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modePaiement = comboBoxModePai.SelectedItem.ToString();
            int reservationID = int.Parse(comboBoxResIdPai.SelectedItem.ToString());
            DateTime datePaiement = dateTimePickerDatePai.Value;

            // Requête SQL d'insertion
            string query = @"
        INSERT INTO Paiement (ReservationID, Montant, DatePaiement, ModePaiement) 
        VALUES (@ReservationID, @Montant, @DatePaiement, @ModePaiement)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@Montant", montant);
                    cmd.Parameters.AddWithValue("@DatePaiement", datePaiement);
                    cmd.Parameters.AddWithValue("@ModePaiement", modePaiement);

                    _conn.Open();
                    cmd.ExecuteNonQuery();
                    _conn.Close();

                    MessageBox.Show("Paiement ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Réinitialiser les champs après ajout
                    comboBoxResIdPai.SelectedIndex = -1;
                    textBoxMontantPai.Clear();
                    comboBoxModePai.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du paiement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void buttonAfficherPaiement_Click(object sender, EventArgs e)
        {
            string query = @"
SELECT P.PaiementID ,R.ReservationID, Ch.NumeroChambre, C.Nom, C.Prenom, P.Montant, P.ModePaiement, P.DatePaiement 
FROM Paiement P
INNER JOIN Reservation R ON P.ReservationID = R.ReservationID 
INNER JOIN Client C ON R.ClientID = C.ClientID
INNER JOIN Chambre Ch ON R.ChambreID = Ch.ChambreID";

            try
            {
                _conn.Open();
                using (SqlCommand command = new SqlCommand(query, _conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewListPai.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des paiements : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void buttonSearchIdPai_Click_1(object sender, EventArgs e)
        {
            // Vérifier si l'ID de paiement est saisi
            if (string.IsNullOrWhiteSpace(textBoxIdPaiement.Text))
            {
                MessageBox.Show("Veuillez entrer un ID de paiement pour rechercher.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paiementId = textBoxIdPaiement.Text.Trim();

            // Requête SQL pour rechercher les détails du paiement
            string query = @"
SELECT P.PaiementID, P.ReservationID, P.Montant, P.DatePaiement, P.ModePaiement
FROM Paiement P
WHERE P.PaiementID = @PaiementID";

            try
            {
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@PaiementID", paiementId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Charger les données dans les champs correspondants
                            comboBoxResIdPai1.DataSource = null;
                            comboBoxResIdPai1.Items.Clear();
                            comboBoxResIdPai1.Items.Add(reader["ReservationID"].ToString());
                            comboBoxResIdPai1.SelectedIndex = 0;

                            textBoxMontantPai1.Text = reader["Montant"].ToString();
                            dateTimePickerDatePai1.Value = Convert.ToDateTime(reader["DatePaiement"]);
                            comboBoxModePai1.SelectedItem = reader["ModePaiement"].ToString();

                            MessageBox.Show("Paiement trouvé et chargé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun paiement trouvé avec cet ID.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonUpdatePai_Click_1(object sender, EventArgs e)
        {
            // Vérifier si un ID de paiement est fourni
            if (string.IsNullOrWhiteSpace(textBoxIdPaiement.Text))
            {
                MessageBox.Show("Veuillez entrer un ID de paiement pour effectuer la mise à jour.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string paiementId = textBoxIdPaiement.Text.Trim();

            // Requête SQL pour mettre à jour le paiement
            string query = @"
UPDATE Paiement
SET ReservationID = @ReservationID,
    Montant = @Montant,
    DatePaiement = @DatePaiement,
    ModePaiement = @ModePaiement
WHERE PaiementID = @PaiementID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // Ajouter les paramètres pour la requête SQL
                    cmd.Parameters.AddWithValue("@ReservationID", int.Parse(comboBoxResIdPai1.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@Montant", decimal.Parse(textBoxMontantPai1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@DatePaiement", dateTimePickerDatePai1.Value);
                    cmd.Parameters.AddWithValue("@ModePaiement", comboBoxModePai1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PaiementID", int.Parse(paiementId));

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paiement mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();

                    }
                    else
                    {
                        MessageBox.Show("La mise à jour du paiement a échoué.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonDeletePai_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdPaiement.Text) || !int.TryParse(textBoxIdPaiement.Text, out int paiementID))
            {
                MessageBox.Show("Veuillez entrer un ID de paiement valide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Demander une confirmation avant de supprimer
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ce paiement ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return; // L'utilisateur a annulé la suppression
            }

            // Requête SQL pour supprimer le paiement
            string query = "DELETE FROM Paiement WHERE PaiementID = @PaiementID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@PaiementID", paiementID);

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    _conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paiement supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();

                        // Réinitialiser le champ d'entrée
                        textBoxIdPaiement.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Aucun paiement trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du paiement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonImprimerReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewListPai.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un paiement pour générer une facture.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewListPai.SelectedRows[0];
            var paiementId = selectedRow.Cells["PaiementID"].Value.ToString();
            var reservationId = selectedRow.Cells["ReservationID"].Value.ToString();
            var nomClient = selectedRow.Cells["Nom"].Value.ToString();
            var prenomClient = selectedRow.Cells["Prenom"].Value.ToString();
            var montant = selectedRow.Cells["Montant"].Value.ToString();
            var modePaiement = selectedRow.Cells["ModePaiement"].Value.ToString();
            var datePaiement = selectedRow.Cells["DatePaiement"].Value.ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Enregistrer la facture",
                FileName = $"Facture_{paiementId}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    using (iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4))
                    {
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        pdfDoc.Add(new Paragraph("Facture de Paiement", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph($"Paiement ID: {paiementId}"));
                        pdfDoc.Add(new Paragraph($"Reservation ID: {reservationId}"));
                        pdfDoc.Add(new Paragraph($"Nom du client: {nomClient} {prenomClient}"));
                        pdfDoc.Add(new Paragraph($"Montant: {montant} MAD"));
                        pdfDoc.Add(new Paragraph($"Mode de paiement: {modePaiement}"));
                        pdfDoc.Add(new Paragraph($"Date de paiement: {datePaiement}"));
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph("Merci pour votre confiance !"));

                        pdfDoc.Close();
                    }

                    MessageBox.Show("Facture générée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la génération de la facture : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
        
    
    

    
