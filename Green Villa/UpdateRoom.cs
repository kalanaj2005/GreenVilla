using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Villa
{
    public partial class UpdateRoom : Form
    {
        public UpdateRoom()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); //apply the theme
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NoEmptyFields())
            {
                var dbcon = new Connection();
                string query = "SELECT roomNum FROM room WHERE roomNum = @roomNum";

                using (var command = dbcon.CreateCommand(query))
                {
                    try
                    {
                        // Add parameters with values
                        command.Parameters.AddWithValue("@roomNum", txtboxRoomNum.Text);

                        dbcon.Open();
                        // Execute the command
                        using (var reader = command.ExecuteReader())
                        {
                            //checking if the room number is valid if the room number has been changed
                            if (!reader.Read() || (txtboxRoomNum.Text == Variables.roomNum))
                            {

                                dbcon.Close();
                                // add the room to the database
                                query = "UPDATE room SET roomNum=@roomNum,price=@price,type=@type WHERE roomNum = @roomNumPrevious";

                                using (var command1 = dbcon.CreateCommand(query))
                                {
                                    int result;
                                    if (int.TryParse(txtboxPrice.Text, out result))
                                    {
                                        command1.Parameters.AddWithValue("@roomNumPrevious", Variables.roomNum);
                                        command1.Parameters.AddWithValue("@roomNum", txtboxRoomNum.Text);
                                        command1.Parameters.AddWithValue("@price", Convert.ToInt32(txtboxPrice.Text));
                                        command1.Parameters.AddWithValue("@type", cmbType.SelectedItem.ToString());

                                        try
                                        {
                                            dbcon.Open();

                                            if (command1.ExecuteNonQuery() == 1)
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
                                }
                            }
                            else
                            {
                                MessageBox.Show("A room with this room number already exists!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
        }

        private bool NoEmptyFields()
        {
            return (!(string.IsNullOrWhiteSpace(txtboxRoomNum.Text)) && !(string.IsNullOrWhiteSpace(txtboxPrice.Text)) && !(cmbType.SelectedIndex == -1));
        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            // fill data to text boxes based on the selected guest ID
            var dbcon = new Connection();
            string query = "SELECT * FROM room WHERE roomNum=@roomNum";
            using (var command = dbcon.CreateCommand(query))
            {
                command.Parameters.AddWithValue("@roomNum", Variables.roomNum);  // User.roomNum is a public variable in User.cs
                try
                {
                    dbcon.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtboxRoomNum.Text = reader["roomNum"].ToString();
                            cmbType.SelectedItem = reader["type"].ToString();
                            txtboxPrice.Text = reader["price"].ToString();
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
    }
}
