using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noteapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=julianotedb; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM savednotes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a note to delete.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int noteID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["NoteID"].Value);

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=julianotedb; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "DELETE FROM savednotes WHERE NoteID = @NoteID";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@NoteID", noteID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note deleted successfully.");
                        search_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete note.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchTitle = searchbyname.Text;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=julianotedb; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM savednotes WHERE Title LIKE @Title";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    adapter.SelectCommand.Parameters.AddWithValue("@Title", "%" + searchTitle + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void searchbyname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
