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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //create the connection
            var dbcon = new Connection();

            //sql query
            string query = "SELECT * FROM employee WHERE Username = @username AND Passwd = @password";

            //make the sql command from your query
            using (var command = dbcon.CreateCommand(query))
            {
                try
                {
                    // Add parameters with values
                    command.Parameters.AddWithValue("@username", txtboxUsername.Text);
                    command.Parameters.AddWithValue("@password", txtboxPassword.Text);

                    dbcon.Open();
                    // Execute the command
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Variables.username = txtboxUsername.Text;
                            Dashboard db = new Dashboard();
                            db.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect credentials!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }
    }
}
