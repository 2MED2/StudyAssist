using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudyAssist
{
    public partial class Notes : Form
    {
        string connectionString = "server=localhost;user id=root;password=prsw.1D;database=study_assist;";


        DataTable notes = new DataTable();
        bool editing = false;
        public Notes()
        {
            InitializeComponent();

            if (notes.Columns.Count == 0)
            {
                notes.Columns.Add("ID");
                notes.Columns.Add("Subject");
                notes.Columns.Add("Note");
            }

            prevNotes.DataSource = notes;
            notes.Rows.Clear();

        }

        private void Notes_Load(object sender, EventArgs e)
        {

            notes.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id, subject, note FROM notes", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    notes.Rows.Add(reader["id"], reader["subject"], reader["note"]);
                }
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectBox.Text) || string.IsNullOrWhiteSpace(noteBox.Text))
            {
                MessageBox.Show("Please fill in both Subject and Note before saving.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                if (editing && prevNotes.CurrentCell != null && prevNotes.CurrentCell.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(notes.Rows[prevNotes.CurrentCell.RowIndex]["ID"]);
                    MySqlCommand updateCmd = new MySqlCommand("UPDATE notes SET subject=@subject, note=@note WHERE id=@id", conn);
                    updateCmd.Parameters.AddWithValue("@subject", subjectBox.Text);
                    updateCmd.Parameters.AddWithValue("@note", noteBox.Text);
                    updateCmd.Parameters.AddWithValue("@id", id);
                    updateCmd.ExecuteNonQuery();

                    notes.Rows[prevNotes.CurrentCell.RowIndex]["Subject"] = subjectBox.Text;
                    notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;

                    MessageBox.Show("Note updated in database.");
                }
                else
                {
                    MySqlCommand insertCmd = new MySqlCommand("INSERT INTO notes (subject, note) VALUES (@subject, @note)", conn);
                    insertCmd.Parameters.AddWithValue("@subject", subjectBox.Text);
                    insertCmd.Parameters.AddWithValue("@note", noteBox.Text);
                    insertCmd.ExecuteNonQuery();

                    int newId = (int)insertCmd.LastInsertedId;
                    notes.Rows.Add(newId, subjectBox.Text, noteBox.Text);

                }
            }

            subjectBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = prevNotes.CurrentCell.RowIndex;
                int id = Convert.ToInt32(notes.Rows[rowIndex]["ID"]);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM notes WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                notes.Rows[rowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting note: " + ex.Message);
            }
        }

        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                subjectBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex]["Subject"].ToString();
                noteBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"].ToString();
                editing = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            notes.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id, subject, note FROM notes", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    notes.Rows.Add(reader["id"], reader["subject"], reader["note"]);
                }
            }

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            subjectBox.Text = "";
            noteBox.Text = "";
            editing = false;
            prevNotes.ClearSelection();
        }
    }
}
