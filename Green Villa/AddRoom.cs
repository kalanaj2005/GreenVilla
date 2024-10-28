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
    public partial class AddRoom : Form
    {
        public AddRoom()
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
                            //checking if the room number is valid
                            if (reader.Read())
                            {
                                MessageBox.Show("A room with this room number already exists!");
                            }
                            else
                            {
                                dbcon.Close();
                                // add the room to the database
                                query = "INSERT INTO room (roomNum,price,type) VALUES (@roomNum,@price,@type)";

                                using (var command1 = dbcon.CreateCommand(query))
                                {
                                    //checks if the value is an integer
                                    int result;
                                    if (int.TryParse(txtboxPrice.Text, out result))
                                    {
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
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid price.");
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
    }
}
