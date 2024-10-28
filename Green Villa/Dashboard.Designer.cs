namespace Green_Villa
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelBack1 = new System.Windows.Forms.Panel();
            this.labelSubTopic = new System.Windows.Forms.Label();
            this.picReservation = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.picGuest = new System.Windows.Forms.PictureBox();
            this.panelBack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsername.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(781, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User :";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.ForestGreen;
            this.lblName.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(319, 80);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Green Villa";
            // 
            // panelBack1
            // 
            this.panelBack1.BackColor = System.Drawing.Color.ForestGreen;
            this.panelBack1.Controls.Add(this.labelSubTopic);
            this.panelBack1.Controls.Add(this.lblName);
            this.panelBack1.Controls.Add(this.lblUsername);
            this.panelBack1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack1.Location = new System.Drawing.Point(0, 0);
            this.panelBack1.Name = "panelBack1";
            this.panelBack1.Size = new System.Drawing.Size(834, 150);
            this.panelBack1.TabIndex = 10;
            // 
            // labelSubTopic
            // 
            this.labelSubTopic.AutoSize = true;
            this.labelSubTopic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTopic.Location = new System.Drawing.Point(32, 105);
            this.labelSubTopic.Name = "labelSubTopic";
            this.labelSubTopic.Size = new System.Drawing.Size(278, 24);
            this.labelSubTopic.TabIndex = 10;
            this.labelSubTopic.Text = "Hotel Management System";
            // 
            // picReservation
            // 
            this.picReservation.BackColor = System.Drawing.Color.Transparent;
            this.picReservation.Image = global::Green_Villa.Properties.Resources.reservation;
            this.picReservation.Location = new System.Drawing.Point(608, 172);
            this.picReservation.Name = "picReservation";
            this.picReservation.Size = new System.Drawing.Size(179, 184);
            this.picReservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReservation.TabIndex = 6;
            this.picReservation.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Green_Villa.Properties.Resources.red2;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Green_Villa.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(695, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 64);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picRoom
            // 
            this.picRoom.BackColor = System.Drawing.Color.Transparent;
            this.picRoom.Image = global::Green_Villa.Properties.Resources.room;
            this.picRoom.Location = new System.Drawing.Point(313, 172);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(185, 184);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoom.TabIndex = 5;
            this.picRoom.TabStop = false;
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnReservations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReservations.BackgroundImage")));
            this.btnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(608, 362);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(179, 82);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.Transparent;
            this.btnRooms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRooms.BackgroundImage")));
            this.btnRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRooms.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Location = new System.Drawing.Point(319, 362);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(179, 82);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.BackColor = System.Drawing.Color.Transparent;
            this.btnGuests.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuests.BackgroundImage")));
            this.btnGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuests.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuests.FlatAppearance.BorderSize = 0;
            this.btnGuests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuests.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuests.ForeColor = System.Drawing.Color.White;
            this.btnGuests.Location = new System.Drawing.Point(36, 362);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(179, 82);
            this.btnGuests.TabIndex = 1;
            this.btnGuests.Text = "Guests";
            this.btnGuests.UseVisualStyleBackColor = false;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // picGuest
            // 
            this.picGuest.BackColor = System.Drawing.Color.Transparent;
            this.picGuest.Image = global::Green_Villa.Properties.Resources.guest;
            this.picGuest.Location = new System.Drawing.Point(27, 172);
            this.picGuest.Name = "picGuest";
            this.picGuest.Size = new System.Drawing.Size(188, 184);
            this.picGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuest.TabIndex = 4;
            this.picGuest.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.picReservation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picRoom);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.picGuest);
            this.Controls.Add(this.panelBack1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelBack1.ResumeLayout(false);
            this.panelBack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.PictureBox picGuest;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.PictureBox picReservation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelBack1;
        private System.Windows.Forms.Label labelSubTopic;
    }
}