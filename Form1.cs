using Microsoft.Data.SqlClient;

namespace Noteapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string noteTitle = Titlebox.Text;
            string noteContent = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(noteTitle) || string.IsNullOrWhiteSpace(noteContent))
            {
                MessageBox.Show("Please enter a title and content for the note.");
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=julianotedb; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO savednotes (Title, Contents, Time_of_creation) VALUES (@Title, @Contents, @Time_of_creation)";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@Title", noteTitle);
                    command.Parameters.AddWithValue("@Contents", noteContent);
                    command.Parameters.AddWithValue("@Time_of_creation", DateTime.Now);
                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note saved successfully.");
                        Titlebox.Clear();
                        richTextBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save note.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}