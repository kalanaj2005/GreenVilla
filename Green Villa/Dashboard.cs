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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "User : "+Variables.username;
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            Guests guests = new Guests();
            guests.Show();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
