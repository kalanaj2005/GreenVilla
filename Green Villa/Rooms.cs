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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addR = new AddRoom();
            addR.ShowDialog();
            GridViewDataLoad();
            ComboBoxTypesLoad();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // load the room types to the combo box
            ComboBoxTypesLoad();
            // load values to the grid view
            GridViewDataLoad();
        }

        public void ComboBoxTypesLoad()
        {
            var dbcon = new Connection();
            string query = "SELECT DISTINCT type FROM room";
            using (var command = dbcon.CreateCommand(query))
            {
                try
                {
                    dbcon.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        cmbType.Items.Clear();
                        cmbType.Items.Add("All");   // add all options
                        while (reader.Read())
                        {
                            cmbType.Items.Add(reader["type"].ToString());
                        }
                    }
                    dbcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        public void GridViewDataLoad()
        {
            var dbcon = new Connection();
            string query = "SELECT * FROM room";
            using (var command = dbcon.CreateCommand(query))
            {
                try
                {
                    dbcon.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridviewRooms.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        // search values according to the selected type
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString()=="All")  // display all when All is selected
            {
                GridViewDataLoad();
            } else
            {
                var dbcon = new Connection();
                string query = "SELECT * FROM room WHERE type = @type";
                using (var command = dbcon.CreateCommand(query))
                {
                    command.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                    try
                    {
                        dbcon.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        gridviewRooms.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridviewRooms.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = gridviewRooms.SelectedRows[0];
                Variables.roomNum = Convert.ToString(selectedRow.Cells["roomNum"].Value);
                UpdateRoom updateR = new UpdateRoom();
                updateR.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select single a row to edit");
            }
            GridViewDataLoad();
            ComboBoxTypesLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowCount = gridviewRooms.SelectedRows.Count;
            if (rowCount > 0)
            {
                var confirmation = MessageBox.Show("ARE YOU SURE THAT YOU WANT TO DELETE " + Convert.ToString(rowCount) + " RECORDS?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    // checks if there are related reservations
                    bool haveReservations = false;
                    var dbcon = new Connection();
                    string query = "SELECT * FROM reservation WHERE roomNum=@roomNum";

                    for (int i = 0; i < rowCount; i++)
                    {
                        using (var command = dbcon.CreateCommand(query))
                        {
                            try
                            {
                                DataGridViewRow selectedRow = gridviewRooms.SelectedRows[i];
                                int RID = Convert.ToInt32(selectedRow.Cells["roomNum"].Value);
                                command.Parameters.AddWithValue("@roomNum", RID);

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
                    if(haveReservations)
                    {
                        var deleteReservations = MessageBox.Show("The selected rooms have reservations associated with them. Do you want to delete the selected rooms along with the related reservations?", "Delete Reservations", MessageBoxButtons.YesNo);
                        if (deleteReservations == DialogResult.Yes)
                        {
                            deleteReservation(rowCount);
                            deleteRecords(rowCount);
                        }
                    } else
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
            ComboBoxTypesLoad();
        }

        //function to delete rows
        public void deleteRecords(int rowCount)
        {
            var dbcon2 = new Connection();
            string query2 = "DELETE FROM room WHERE roomNum = @roomNum";

            try
            {

                dbcon2.Open();

                for (int i = 0; i < rowCount; i++)
                {
                    using (var command = dbcon2.CreateCommand(query2))
                    {
                        DataGridViewRow selectedRow = gridviewRooms.SelectedRows[i];
                        int RID = Convert.ToInt32(selectedRow.Cells["roomNum"].Value);
                        command.Parameters.AddWithValue("@roomNum", RID);
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
            string query3 = "DELETE FROM reservation WHERE roomNum = @roomNum";

            try
            {

                dbcon3.Open();

                for (int i = 0; i < rowCount; i++)
                {
                    using (var command = dbcon3.CreateCommand(query3))
                    {
                        DataGridViewRow selectedRow = gridviewRooms.SelectedRows[i];
                        int RID = Convert.ToInt32(selectedRow.Cells["roomNum"].Value);
                        command.Parameters.AddWithValue("@roomNum", RID);
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
