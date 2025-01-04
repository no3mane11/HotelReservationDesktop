using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-TGRJ1NJ\\SQLEXPRESS;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM Employe WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Login sucess", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDash form = new FormDash();
                form.Username = txtUser.Text;
                txtUser.Clear();
                txtPass.Clear();
                form.Show();
                

            }
            else
            {
                MessageBox.Show("error in login");
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
