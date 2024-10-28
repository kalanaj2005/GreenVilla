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
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this); //apply the theme
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dbcon = new Connection();
            string query = "INSERT INTO guest (name,NIC,email,tp) VALUES (@name,@NIC,@email,@tp)";

            using(var command = dbcon.CreateCommand(query))
            {

                command.Parameters.AddWithValue("@name", txtboxName.Text);
                command.Parameters.AddWithValue("@NIC", txtboxNIC.Text);
                command.Parameters.AddWithValue("@email", txtboxEmail.Text);
                command.Parameters.AddWithValue("@tp", txtboxTP.Text);

                if (NoEmptyFields())
                {
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
                    MessageBox.Show("Please Fill All the Fields!");
                }
                
            }
        }

        private bool NoEmptyFields()
        {
            return (!(string.IsNullOrWhiteSpace(txtboxName.Text)) && !(string.IsNullOrWhiteSpace(txtboxNIC.Text)) && !(string.IsNullOrWhiteSpace(txtboxEmail.Text)) && !(string.IsNullOrWhiteSpace(txtboxTP.Text)));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtboxTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTP_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtboxNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNIC_Click(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        
    }
}
