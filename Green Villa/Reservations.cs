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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation();
            addReservation.ShowDialog();
            GridViewDataLoad();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void gridviewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservations_Load(object sender, EventArgs e)
        {
            GridViewDataLoad();
        }

        public void GridViewDataLoad()
        {
            var dbcon = new Connection();
            string query = "SELECT * FROM reservation";
            using (var command = dbcon.CreateCommand(query))
            {
                try
                {
                    dbcon.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridviewReservations.DataSource = dataTable;
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
            string query = "SELECT * FROM reservation WHERE roomNum LIKE CONCAT('%',@text,'%') or GID LIKE CONCAT('%',@text,'%')";
            using (var command = dbcon.CreateCommand(query))
            {
                command.Parameters.AddWithValue("@text", txtboxSearch.Text);
                try
                {
                    dbcon.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridviewReservations.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowCount = gridviewReservations.SelectedRows.Count;
            if (rowCount > 0)
            {
                var confirmation = MessageBox.Show("ARE YOU SURE THAT YOU WANT TO DELETE " + Convert.ToString(rowCount) + " RESERVATIONS?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {

                    var dbcon = new Connection();
                    string query = "DELETE FROM reservation WHERE reservationID = @id";

                    try
                    {

                        dbcon.Open();

                        for (int i = 0; i < rowCount; i++)
                        {
                            using (var command = dbcon.CreateCommand(query))
                            {
                                DataGridViewRow selectedRow = gridviewReservations.SelectedRows[i];
                                int RID = Convert.ToInt32(selectedRow.Cells["reservationID"].Value);
                                command.Parameters.AddWithValue("@id", RID);
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
            }
            else
            {
                MessageBox.Show("Please select one or more rows to delete");
            }

            GridViewDataLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridviewReservations.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = gridviewReservations.SelectedRows[0];
                Variables.reservationID = Convert.ToInt32(selectedRow.Cells["reservationID"].Value);
                Variables.startDate = Convert.ToDateTime(selectedRow.Cells["startDate"].Value);
                Variables.endDate = Convert.ToDateTime(selectedRow.Cells["endDate"].Value);
                Variables.updateRoomNum = Convert.ToString(selectedRow.Cells["roomNum"].Value);
                Variables.updateGID = Convert.ToInt32(selectedRow.Cells["GID"].Value);
                UpdateReservation updateR = new UpdateReservation();
                updateR.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select single a row to edit");
            }
            GridViewDataLoad();
        }
    }
}
