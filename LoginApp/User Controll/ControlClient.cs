using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Borders;
using System.IO;
using iText.Kernel.Pdf.Canvas.Draw;

namespace LoginApp.User_Controll
{
    public partial class ControlClient : UserControl
    {
        private readonly SqlConnection _conn;
        private string _clientId;

        public ControlClient()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");
        }

        private void ClearFields()
        {
            textBoxNomClient1.Clear();
            textBoxPrenomClient1.Clear();
            textBoxEmailClient1.Clear();
            textBoxMotDePassClient1.Clear();
            textBoxTeleClient1.Clear();
            textBoxAdresseClient1.Clear();
            _clientId = string.Empty;
            tabControlClient.SelectedTab = tabPageAjtClient;
        }



        private void ExportToExcel(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListClients.Rows.Count == 0)
                {
                    MessageBox.Show("Aucun client à exporter.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ouvrir une boîte de dialogue pour choisir le chemin du fichier
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichiers Excel (*.xlsx)|*.xlsx",
                    Title = "Enregistrer le fichier Excel",
                    FileName = "Clients.xlsx"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = saveFileDialog.FileName;

                // Configurer la licence EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets.Add("Clients");

                    // Ajouter les en-têtes
                    for (int col = 0; col < dataGridViewListClients.Columns.Count; col++)
                    {
                        sheet.Cells[1, col + 1].Value = dataGridViewListClients.Columns[col].HeaderText;
                        sheet.Cells[1, col + 1].Style.Font.Bold = true;
                    }

                    // Ajouter les données
                    for (int row = 0; row < dataGridViewListClients.Rows.Count; row++)
                    {
                        if (!dataGridViewListClients.Rows[row].IsNewRow) // Exclure la ligne "nouvelle ligne"
                        {
                            for (int col = 0; col < dataGridViewListClients.Columns.Count; col++)
                            {
                                sheet.Cells[row + 2, col + 1].Value = dataGridViewListClients.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                            }
                        }
                    }

                    // Ajuster les colonnes
                    sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                    // Sauvegarder le fichier
                    File.WriteAllBytes(filePath, package.GetAsByteArray());
                }

                MessageBox.Show($"Fichier Excel exporté avec succès :\n{filePath}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ButtonExportExcel_Click_1(object sender, EventArgs e)
        {
            ExportToExcel(sender, e);
        }


        private void buttonAjtClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomClient1.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrenomClient1.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailClient1.Text) ||
                string.IsNullOrWhiteSpace(textBoxMotDePassClient1.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresseClient1.Text) ||
                string.IsNullOrWhiteSpace(textBoxTeleClient1.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Client (Nom, Prenom, Email, MotDePasse, Telephone, Adresse) VALUES (@Nom, @Prenom, @Email, @MotDePasse, @Telephone, @Adresse)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", textBoxNomClient1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenom", textBoxPrenomClient1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textBoxEmailClient1.Text.Trim());
                    cmd.Parameters.AddWithValue("@MotDePasse", textBoxMotDePassClient1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telephone", textBoxTeleClient1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Adresse", textBoxAdresseClient1.Text.Trim());

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchNom = textBoxNomClientSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchNom))
            {
                MessageBox.Show("Please enter a Name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT ClientID, Nom, Prenom, Email, Telephone, MotDePasse, Adresse, DateInscription " +
                           "FROM Client WHERE Nom LIKE @Nom";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", "%" + searchNom + "%");

                    _conn.Open();
                    DataTable dt = new DataTable();

                    // Assurez-vous que les colonnes ne se dupliquent pas
                    if (dataGridViewClient1.Columns.Count > 0)
                    {
                        dataGridViewClient1.DataSource = null; // Réinitialise le DataSource
                        dataGridViewClient1.Columns.Clear();   // Supprime les colonnes
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    dataGridViewClient1.DataSource = dt; // Attribue les nouvelles données au DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonSearchClientUpdt_Click(object sender, EventArgs e)
        {
            string clientId = textBoxSearchClientUpdate.Text.Trim();

            if (string.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("Please enter a Client ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT ClientID, Nom, Prenom, Email, MotDePasse, Telephone, Adresse FROM Client WHERE ClientID = @ClientID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientId);

                    _conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Remplir les TextBox avec les données du client trouvé
                        textBoxNomClientUpdt.Text = reader["Nom"].ToString();
                        textBoxPrenomClientUpdt.Text = reader["Prenom"].ToString();
                        textBoxEmailClientUpdt.Text = reader["Email"].ToString();
                        textBoxMDPassClientUpdt.Text = reader["MotDePasse"].ToString();
                        textBoxTeleClientUpdt.Text = reader["Telephone"].ToString();
                        textBoxAdrClientUpdt.Text = reader["Adresse"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Client not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            string clientId = textBoxSearchClientUpdate.Text.Trim();

            if (string.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("Please enter a Client ID to update.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "UPDATE Client SET Nom = @Nom, Prenom = @Prenom, Email = @Email, MotDePasse = @MotDePasse, Telephone = @Telephone, Adresse = @Adresse WHERE ClientID = @ClientID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", textBoxNomClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Prenom", textBoxPrenomClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textBoxEmailClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@MotDePasse", textBoxMDPassClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telephone", textBoxTeleClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Adresse", textBoxAdrClientUpdt.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClientID", clientId);

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Optionnellement, vous pouvez vider les champs après la mise à jour
                    }
                    else
                    {
                        MessageBox.Show("Client update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            string clientId = textBoxSearchClientUpdate.Text.Trim();

            if (string.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("Please enter a Client ID to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "DELETE FROM Client WHERE ClientID = @ClientID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@ClientID", clientId);

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Optionnellement, vous pouvez vider les champs après la suppression
                    }
                    else
                    {
                        MessageBox.Show("Client deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void tabPageSerachClient_Click(object sender, EventArgs e)
        {

        }


        private void buttonAfficherClients_Click(object sender, EventArgs e)
        {
            // Requête SQL pour récupérer tous les clients
            string query = "SELECT ClientID, Nom, Prenom, Email, Telephone, MotDePasse, Adresse, DateInscription FROM Client";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    _conn.Open();
                    DataTable dt = new DataTable();

                    // Réinitialise la DataGridView pour éviter des conflits
                    if (dataGridViewListClients.Columns.Count > 0)
                    {
                        dataGridViewListClients.DataSource = null; // Réinitialise la source de données
                        dataGridViewListClients.Columns.Clear();   // Supprime les colonnes
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    // Assigne les nouvelles données au DataGridView
                    dataGridViewListClients.DataSource = dt;

                    // Vérifie s'il y a des résultats
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Aucun client trouvé.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche une erreur en cas de problème
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ferme la connexion
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


       
        private void tabPageAjtClient_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewListClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
    


