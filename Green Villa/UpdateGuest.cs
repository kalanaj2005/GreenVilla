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
    public partial class UpdateGuest : Form
    {
        public UpdateGuest()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); //apply the theme
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateGuest_Load(object sender, EventArgs e)
        {

            // fill data to text boxes based on the selected guest ID
            var dbcon = new Connection();
            string query = "SELECT * FROM guest WHERE G_ID=@id";
            using (var command = dbcon.CreateCommand(query))
            {
                command.Parameters.AddWithValue("@id", Variables.guestID);
                try
                {
                    dbcon.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtboxGID.Text = reader["G_ID"].ToString();
                            txtboxName.Text = reader["name"].ToString();
                            txtboxNIC.Text = reader["NIC"].ToString();
                            txtboxEmail.Text = reader["email"].ToString();
                            txtboxTP.Text = reader["tp"].ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NoEmptyFields())
            {
                var dbcon = new Connection();
                string query = "UPDATE guest SET name=@name ,NIC=@NIC,email=@email,tp=@tp WHERE G_ID = @GID";

                using (var command = dbcon.CreateCommand(query))
                {
                    command.Parameters.AddWithValue("@name", txtboxName.Text);
                    command.Parameters.AddWithValue("@NIC", txtboxNIC.Text);
                    command.Parameters.AddWithValue("@email", txtboxEmail.Text);
                    command.Parameters.AddWithValue("@tp", txtboxTP.Text);
                    command.Parameters.AddWithValue("@GID", txtboxGID.Text);

                    try
                    {
                        dbcon.Open();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Record Update Sucessfull");
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
            else
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
        }

        private bool NoEmptyFields()
        {
            return (!(string.IsNullOrWhiteSpace(txtboxName.Text)) && !(string.IsNullOrWhiteSpace(txtboxNIC.Text)) && !(string.IsNullOrWhiteSpace(txtboxEmail.Text)) && !(string.IsNullOrWhiteSpace(txtboxTP.Text)));
        }
    }
}
