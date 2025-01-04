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


namespace LoginApp.User_Controll
{
    public partial class ControlChambre : UserControl
    {
        private readonly SqlConnection _conn;
        private string _chambreId;
        private string imagePath;
        public ControlChambre()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");

            ChargerTypesChambre();
        }

        private void ClearFields()
        {
            textBoxNomChambre.Clear();
            textBoxDescriptionChambre.Clear();
            textBoxTarifNuit.Clear();
            _chambreId = string.Empty;
            tabControlChambre.SelectedTab = tabPageAjouterTypeChambre;
        }

        private void buttonAjouterTypeChambre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomChambre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDescriptionChambre.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTarifNuit.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Requête SQL pour insérer les informations sans gestion d'image
            string query = "INSERT INTO TypeChambre (Nom, Description, TarifParNuit) VALUES (@Nom, @Description, @TarifParNuit)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", textBoxNomChambre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", textBoxDescriptionChambre.Text.Trim());
                    cmd.Parameters.AddWithValue("@TarifParNuit", textBoxTarifNuit.Text.Trim());

                    _conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Type de chambre ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }


        private void ChargerTypesChambre()
        {
            string query = "SELECT TypeChambreID, Nom FROM TypeChambre";

            try
            {
                _conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var dataSource = new System.Collections.Generic.List<KeyValuePair<string, int>>();
                        while (reader.Read())
                        {
                            dataSource.Add(new KeyValuePair<string, int>(
                                reader["Nom"].ToString(),
                                Convert.ToInt32(reader["TypeChambreID"])
                            ));
                        }

                        comboBoxChargerTypeChambre.DataSource = dataSource;
                        comboBoxChargerTypeChambre.DisplayMember = "Key";
                        comboBoxChargerTypeChambre.ValueMember = "Value";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des types de chambre : " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        private bool VerifierNumeroChambreUnique(string numeroChambre)
        {
            string query = "SELECT COUNT(1) FROM Chambre WHERE NumeroChambre = @NumeroChambre";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroChambre", numeroChambre.Trim());
                    _conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; // Retourne true si le numéro de chambre est unique
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la vérification du numéro de chambre : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {

            // Vérifier que les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(textBoxNumChambre.Text) ||
                comboBoxChargerTypeChambre.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxDispChamb.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si le numéro de chambre est unique
            if (!VerifierNumeroChambreUnique(textBoxNumChambre.Text.Trim()))
            {
                MessageBox.Show("Ce numéro de chambre existe déjà. Veuillez en choisir un autre.", "Duplication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérifiez si une image a été sélectionnée
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please select an image for the room.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chemin où vous souhaitez enregistrer l'image (dossier wwwroot/images)
            string destinationFolder = @"C:\Users\ALIENWARE\Desktop\les projets\c#\testProject\TestHotelReservation\TestHotelReservation\wwwroot\images"; // Remplacez par le chemin correct
            string fileName = Path.GetFileName(imagePath);
            string destinationPath = Path.Combine(destinationFolder, fileName);

            try
            {
                // Copier l'image dans le dossier spécifié
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                File.Copy(imagePath, destinationPath, true);  // true pour remplacer si le fichier existe déjà

                // Utiliser un chemin relatif pour l'image
                string relativeImagePath = fileName;  // Stocker un chemin relatif dans la base de données

                // Construire la requête SQL pour insérer la chambre avec le chemin de l'image relatif
                string query = "INSERT INTO Chambre (NumeroChambre, TypeChambreID, EstDisponible, ImageChambre) VALUES (@NumeroChambre, @TypeChambreID, @EstDisponible, @ImageChambre)";

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    // Ajouter les paramètres
                    command.Parameters.AddWithValue("@NumeroChambre", textBoxNumChambre.Text.Trim());

                    // Récupérer la valeur de l'élément sélectionné dans le comboBox
                    if (comboBoxChargerTypeChambre.SelectedItem is KeyValuePair<string, int> selectedItem)
                    {
                        command.Parameters.AddWithValue("@TypeChambreID", selectedItem.Value);
                    }
                    else
                    {
                        MessageBox.Show("Le type de chambre sélectionné est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérifier et ajouter la disponibilité
                    bool estDisponible = false;  // Valeur par défaut

                    if (!bool.TryParse(textBoxDispChamb.Text.Trim(), out estDisponible))
                    {
                        MessageBox.Show("Le champ 'Disponibilité' doit être une valeur booléenne (true/false).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    command.Parameters.AddWithValue("@EstDisponible", estDisponible);
                    command.Parameters.AddWithValue("@ImageChambre", relativeImagePath);  // Utiliser le chemin relatif

                    // Ouvrir la connexion
                    _conn.Open();

                    // Exécuter la commande
                    command.ExecuteNonQuery();
                    MessageBox.Show("Chambre ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Réinitialiser les champs
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la chambre : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

        }


        private void buttonSearchChambre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNumeroChambre.Text))
            {
                MessageBox.Show("Veuillez entrer un numéro de chambre.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        SELECT 
            tc.Nom AS TypeChambre,
            tc.Description,
            tc.TarifParNuit,
            c.NumeroChambre,
            CASE WHEN c.EstDisponible = 1 THEN 'Oui' ELSE 'Non' END AS EstDisponible
        FROM Chambre c
        INNER JOIN TypeChambre tc ON c.TypeChambreID = tc.TypeChambreID
        WHERE c.NumeroChambre = @NumeroChambre";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // Ajouter le paramètre pour le numéro de chambre
                    cmd.Parameters.AddWithValue("@NumeroChambre", textBoxNumeroChambre.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Réinitialiser la source et lier les données
                    dataGridViewSerachChambre.DataSource = null;
                    dataGridViewSerachChambre.Columns.Clear();
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewSerachChambre.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée avec ce numéro.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void tabPageAjouterChambre_Click(object sender, EventArgs e)
        {

        }


        private void buttonAfficherChambres_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT 
            tc.Nom AS TypeChambre,
            tc.Description,
            tc.TarifParNuit,
            c.NumeroChambre,
            CASE WHEN c.EstDisponible = 1 THEN 'Oui' ELSE 'Non' END AS EstDisponible
        FROM Chambre c
        INNER JOIN TypeChambre tc ON c.TypeChambreID = tc.TypeChambreID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Réinitialiser la source et lier les données
                    dataGridViewListChambres.DataSource = null;
                    dataGridViewListChambres.Columns.Clear();

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewListChambres.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée.", "Résultat introuvable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'affichage des chambres : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

       

        private void buttonSelectImage_Click_1(object sender, EventArgs e)
        {

            // Ouvre la boîte de dialogue pour sélectionner une image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Récupère le chemin du fichier sélectionné
                    imagePath = openFileDialog.FileName;

                    // Affiche l'image dans le PictureBox
                    pictureBoxChambre.Image = Image.FromFile(imagePath);
                    pictureBoxChambre.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        
    }
    }
}

    // Méthode pour réinitialiser les champs après ajout


