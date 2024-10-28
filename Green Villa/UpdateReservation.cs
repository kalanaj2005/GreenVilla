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
    public partial class UpdateReservation : Form
    {
        public UpdateReservation()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); //apply the theme
        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {
           
            dateReservation.SelectionRange = new SelectionRange(Variables.startDate, Variables.endDate);
            
            GridViewDataLoad();
            gridviewAvailableRooms.ClearSelection();
            foreach (DataGridViewRow row in gridviewAvailableRooms.Rows)
            {
                if (row.Cells["roomNum"].Value != null && row.Cells["roomNum"].Value.ToString() == Variables.updateRoomNum)
                {
                    row.Selected= true;
                    break;
                }
            }
            lblNoRooms.Visible = false;
            
            CalculateCost();
        }

        private void dateReservation_DateChanged(object sender, DateRangeEventArgs e)
        {
            GridViewDataLoad();
            CalculateCost();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewDataLoad();
            CalculateCost();
        }

        // function for showing the available rooms
        public void GridViewDataLoad()
        {
            var dbcon = new Connection();
            //open a seperate connection to database for inner query
            var dbcon2 = new Connection();

            //get the start and end dates from the calander
            DateTime StartDate = dateReservation.SelectionStart;
            DateTime EndDate = dateReservation.SelectionEnd;

            //selecting room numbers of reservations that overlaps with the selected time period
            string query1 = "SELECT roomNum FROM reservation WHERE NOT (startDate > @endDate OR endDate < @startDate) AND NOT reservationID = @reservationID";
            using (var command1 = dbcon.CreateCommand(query1))
            {
                try
                {
                    // Add parameters with values
                    command1.Parameters.AddWithValue("@startDate", StartDate);
                    command1.Parameters.AddWithValue("@endDate", EndDate);
                    command1.Parameters.AddWithValue("@reservationID", Variables.reservationID);
                    dbcon.Open();
                    // Execute the command
                    using (var reader = command1.ExecuteReader())
                    {
                        bool reservationsAvailable = false;
                        while (reader.Read())
                        {
                            reservationsAvailable = true;
                            // select the room details for the available rooms
                            string query2 = "SELECT * FROM room WHERE NOT roomNum=@ReservedRoomNum";

                            // checks if a type is selected from the type combo box
                            if (cmbType.SelectedIndex > -1)
                            {
                                query2 = "SELECT * FROM room WHERE NOT roomNum=@ReservedRoomNum AND type=@type";
                            }

                            using (var command2 = dbcon2.CreateCommand(query2))
                            {
                                command2.Parameters.AddWithValue("@ReservedRoomNum", reader["roomNum"].ToString());
                                // if a type is selected add that value as a parameter
                                if (cmbType.SelectedIndex > -1)
                                {

                                    command2.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                                }

                                try
                                {
                                    dbcon2.Open();
                                    MySqlDataAdapter adapter = new MySqlDataAdapter(command2);
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    gridviewAvailableRooms.DataSource = dataTable;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error : " + ex.Message);
                                }
                            }
                            dbcon2.Close();
                        }
                        if (!reservationsAvailable)
                        {
                            // if there are no reservatios in the reservations table details of all the rooms are shown
                            string query2 = "SELECT * FROM room";

                            // checks if a type is selected from the type combo box
                            if (cmbType.SelectedIndex > -1)
                            {
                                query2 = "SELECT * FROM room WHERE type=@type";
                            }

                            using (var command2 = dbcon2.CreateCommand(query2))
                            {
                                // if a type is selected add that value as a parameter
                                if (cmbType.SelectedIndex > -1)
                                {
                                    command2.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());
                                }

                                try
                                {
                                    dbcon2.Open();
                                    MySqlDataAdapter adapter = new MySqlDataAdapter(command2);
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    gridviewAvailableRooms.DataSource = dataTable;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error : " + ex.Message);
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }

            // display a message if no rooms are available
            if (gridviewAvailableRooms.Rows.Count == 1)
            {
                gridviewAvailableRooms.Visible = false;
                lblNoRooms.Visible = true;
            }
            else
            {
                gridviewAvailableRooms.Visible = true;
                lblNoRooms.Visible = false;
            }

        }

        // function to calculate the cost
        public void CalculateCost()
        {
            if (gridviewAvailableRooms.SelectedRows.Count == 1)
            {
                Variables.startDate = dateReservation.SelectionStart;
                Variables.endDate = dateReservation.SelectionEnd;
                Variables.NumOfDays = (Variables.endDate - Variables.startDate).Days + 1;
                Variables.roomNum = gridviewAvailableRooms.Rows[gridviewAvailableRooms.SelectedCells[0].RowIndex].Cells["roomNum"].Value.ToString();

                //calculate the cost for the selected room for the selected time period
                Variables.Cost = Convert.ToInt32(gridviewAvailableRooms.Rows[gridviewAvailableRooms.SelectedCells[0].RowIndex].Cells["price"].Value.ToString()) * Variables.NumOfDays;

                txtboxDays.Text = Convert.ToString(Variables.NumOfDays);
                txtboxCost.Text = Convert.ToString(Variables.Cost);
            }
        }

        private void gridviewAvailableRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateCost();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (gridviewAvailableRooms.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = gridviewAvailableRooms.SelectedRows[0];
                Variables.AddReservationRoom = Convert.ToString(selectedRow.Cells["roomNum"].Value);
                UpdateSelectGuest sg = new UpdateSelectGuest();
                
                this.Hide();
                sg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a room first!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
