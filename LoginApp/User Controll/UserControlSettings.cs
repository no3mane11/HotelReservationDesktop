using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginApp.User_Controll
{
    public partial class UserControlSettings : UserControl
    {
        private string ID;
        private SqlConnection conn;

        public UserControlSettings()
        {
            InitializeComponent();
            // Initialiser la connexion ici
            conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");
            dataGridViewUser.MultiSelect = false;
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;

        }

        public void Clear()
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        private void Clear1()
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
            ID = "";
        }

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {
            // Cet événement est vide, considérez de le supprimer si non utilisé.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Cet événement est vide, considérez de le supprimer si non utilisé.
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                textBoxUsernameUpdate.Text = row.Cells["Column2"].Value.ToString();
                textBoxPasswordUpdate.Text = row.Cells["Column3"].Value.ToString();
                ID = row.Cells["Column1"].Value.ToString(); // Sauvegarder l'ID pour la mise à jour ou suppression
            }
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSerachUser_Enter(object sender, EventArgs e)
        {
            // textBoxSerachUser.Clear(); // Décommentez si nécessaire
        }


        private void tabUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            // Événement de chargement
        }

        private void UpdateAndDeleteUser_Click(object sender, EventArgs e)
        {
            // Implémentez la logique de mise à jour et suppression ici
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Exemple d'insertion dans la base de données
                string query = "INSERT INTO Employe (username, password) VALUES (@Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", textBoxUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBoxPass.Text.Trim());

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }




        private void textBoxSerachUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            string searchUsername = textBoxSearchUpdateUser.Text.Trim();

            if (string.IsNullOrEmpty(searchUsername))
            {
                MessageBox.Show("Please enter a username to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string query = "SELECT ID, username, password FROM Employe WHERE username LIKE @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", "%" + searchUsername + "%");
                    conn.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dataGridViewUser.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            // Vérifier si le champ textBoxID est vide
            string ID = textBoxID.Text.Trim(); // Récupérer l'ID depuis textBoxID
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a user to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer les nouvelles valeurs pour le nom d'utilisateur et le mot de passe
            string updatedUsername = textBoxUsernameUpdate.Text.Trim();
            string updatedPassword = textBoxPasswordUpdate.Text.Trim();

            // Vérifier si les champs de mise à jour sont remplis
            if (string.IsNullOrEmpty(updatedUsername) || string.IsNullOrEmpty(updatedPassword))
            {
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Essayez d'effectuer la mise à jour
            try
            {
                // La requête SQL pour mettre à jour les données
                string query = "UPDATE Employe  SET username = @username, password = @password WHERE ID = @id";

                // Préparer la commande SQL
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", updatedUsername);
                    cmd.Parameters.AddWithValue("@password", updatedPassword);
                    cmd.Parameters.AddWithValue("@id", ID);

                    // Ouvrir la connexion
                    conn.Open();

                    // Exécuter la requête
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Fermer la connexion
                    conn.Close();

                    // Vérifier le résultat
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearUpdateFields(); // Méthode pour effacer les champs après mise à jour
                        RefreshDataGridView(); // Méthode pour rafraîchir le DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No user was updated. Please check the ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void ClearUpdateFields()
        {
            textBoxUsernameUpdate.Clear();  // Clears the username update textbox
            textBoxPasswordUpdate.Clear(); // Clears the password update textbox
            ID = null;                     // Resets the ID for the selected user
        }
        private void RefreshDataGridView()
        {
            buttonSearchUser.PerformClick(); // Simulates a click on the search button to reload data
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            // Vérifier si le champ textBoxID est vide
            string ID = textBoxID.Text.Trim(); // Récupérer l'ID depuis textBoxID
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmer la suppression
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return; // Annuler si l'utilisateur choisit "No"
            }

            // Essayer de supprimer l'utilisateur
            try
            {
                // Requête SQL pour supprimer l'utilisateur
                string query = "DELETE FROM Employe WHERE ID = @id";

                // Préparer la commande SQL
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);

                    // Ouvrir la connexion
                    conn.Open();

                    // Exécuter la requête
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Fermer la connexion
                    conn.Close();

                    // Vérifier le résultat
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearUpdateFields(); // Méthode pour réinitialiser les champs
                        RefreshDataGridView(); // Méthode pour rafraîchir le DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No user was deleted. Please check the ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }




        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez si l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];

                // Récupérez les valeurs des cellules "ID", "Username" et "Password"
                string selectedID = row.Cells["Column1"].Value.ToString();
                string selectedUsername = row.Cells["Column2"].Value.ToString();
                string selectedPassword = row.Cells["Column3"].Value.ToString();

                // Affichez les valeurs dans des TextBox ou effectuez une autre action
                textBoxID.Text = selectedID;
                textBoxUsernameUpdate.Text = selectedUsername;
                textBoxPasswordUpdate.Text = selectedPassword;
            }
        }

        
            private void buttonAfficherUsers_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ID, username, password FROM Employe";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    dataGridViewListUsers.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

    }
}

