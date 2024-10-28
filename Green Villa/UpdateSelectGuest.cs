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
    public partial class UpdateSelectGuest : Form
    {
        public UpdateSelectGuest()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); //apply the theme
        }

        private void gridviewGuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void UpdateSelectGuest_Load(object sender, EventArgs e)
        {
            GridViewDataLoad();
            gridviewGuests.ClearSelection();
            foreach (DataGridViewRow row in gridviewGuests.Rows)
            {
                if (row.Cells["G_ID"].Value != null && Convert.ToInt32(row.Cells["G_ID"].Value) == Variables.updateGID)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        // fill the grid
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

        private void btnUpdateReservatioin_Click(object sender, EventArgs e)
        {
            var dbcon = new Connection();
            string query = "UPDATE reservation SET GID=@GID,startDate=@startDate,endDate=@endDate,numberOfDays=@numberOfDays,roomNum=@roomNum,cost=@cost WHERE reservationID=@reservationID";

            using (var command = dbcon.CreateCommand(query))
            {


                if (gridviewGuests.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = gridviewGuests.SelectedRows[0];
                    Variables.guestID = Convert.ToInt32(selectedRow.Cells["G_ID"].Value);

                    command.Parameters.AddWithValue("@GID", Variables.guestID);
                    command.Parameters.AddWithValue("@startDate", Variables.startDate);
                    command.Parameters.AddWithValue("@endDate", Variables.endDate);
                    command.Parameters.AddWithValue("@numberOfDays", Variables.NumOfDays);
                    command.Parameters.AddWithValue("@roomNum", Variables.AddReservationRoom);
                    command.Parameters.AddWithValue("@cost", Variables.Cost);
                    command.Parameters.AddWithValue("@reservationID", Variables.reservationID);

                    

                    try
                    {
                        dbcon.Open();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Record Inserted Sucessfull");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error in Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Please select single a row to edit");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
