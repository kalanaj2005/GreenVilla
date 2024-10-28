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

namespace Green_Villa
{
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuest addG = new AddGuest();
            addG.ShowDialog();   //disable this form while adding new guest
            GridViewDataLoad();
        }

        private void Guests_Load(object sender, EventArgs e)
        { 
            GridViewDataLoad();
        }

        public void GridViewDataLoad()
        {
            var dbcon = new Connection();
            string query = "SELECT * FROM guest";
            using (var command = dbcon.CreateCommand(query))
            {
                try
                {
                    dbcon.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridviewGuests.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            var dbcon = new Connection();
            // query to search all the columns
            string query = "SELECT * FROM guest WHERE name LIKE CONCAT('%',@text,'%') or NIC LIKE CONCAT('%',@text,'%') or email LIKE CONCAT('%',@text,'%') or tp LIKE CONCAT('%',@text,'%');";
            using (var command = dbcon.CreateCommand(query))
            {
                command.Parameters.AddWithValue("@text", txtboxSearch.Text);
                try
                {
                    dbcon.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridviewGuests.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridviewGuests.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = gridviewGuests.SelectedRows[0];
                Variables.guestID = Convert.ToInt32(selectedRow.Cells["G_ID"].Value);
                UpdateGuest updateG = new UpdateGuest();
                updateG.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select single a row to edit");
            }
            GridViewDataLoad();
        }

        //delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowCount = gridviewGuests.SelectedRows.Count;
            if (rowCount > 0)
            {
                var confirmation = MessageBox.Show("ARE YOU SURE THAT YOU WANT TO DELETE " + Convert.ToString(rowCount) + " RECORDS?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    // checks if there are related reservations
                    bool haveReservations = false;
                    var dbcon = new Connection();
                    string query = "SELECT * FROM reservation WHERE GID=@GID";

                    for (int i = 0; i < rowCount; i++)
                    {
                        using (var command = dbcon.CreateCommand(query))
                        {
                            try
                            {
                                DataGridViewRow selectedRow = gridviewGuests.SelectedRows[i];
                                int GID = Convert.ToInt32(selectedRow.Cells["G_ID"].Value);
                                command.Parameters.AddWithValue("@GID", GID);

                                dbcon.Open();
                                command.ExecuteNonQuery();


                                // Execute the command
                                using (var reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        haveReservations = true;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error : " + ex.Message);
                            }
                        }
                    }

                    // display a message if associated reservations are present
                    if (haveReservations)
                    {
                        var deleteReservations = MessageBox.Show("The selected guests have reservations associated with them. Do you want to delete the selected guests along with the related reservations?", "Delete Reservations", MessageBoxButtons.YesNo);
                        if (deleteReservations == DialogResult.Yes)
                        {
                            deleteReservation(rowCount);
                            deleteRecords(rowCount);
                        }
                    }
                    else
                    {
                        deleteRecords(rowCount);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one or more rows to delete");
            }

            GridViewDataLoad();
        }

        //function to delete record
        public void deleteRecords(int rowCount)
        {
            var dbcon2 = new Connection();
            string query2 = "DELETE FROM guest WHERE G_ID = @id";

            try
            {

                dbcon2.Open();

                for (int i = 0; i < rowCount; i++)
                {
                    using (var command = dbcon2.CreateCommand(query2))
                    {
                        DataGridViewRow selectedRow = gridviewGuests.SelectedRows[i];
                        int GID = Convert.ToInt32(selectedRow.Cells["G_ID"].Value);
                        command.Parameters.AddWithValue("@id", GID);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Item(s) Deleted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            } //delete from database
        }

        //function to delete reservations
        public void deleteReservation(int rowCount)
        {
            var dbcon3 = new Connection();
            string query3 = "DELETE FROM reservation WHERE GID = @id";

            try
            {

                dbcon3.Open();

                for (int i = 0; i < rowCount; i++)
                {
                    using (var command = dbcon3.CreateCommand(query3))
                    {
                        DataGridViewRow selectedRow = gridviewGuests.SelectedRows[i];
                        int GID = Convert.ToInt32(selectedRow.Cells["G_ID"].Value);
                        command.Parameters.AddWithValue("@id", GID);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            } //delete from database
        }
    }
}
