namespace Green_Villa
{
    partial class AddReservation
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
            this.dateReservation = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.gridviewAvailableRooms = new System.Windows.Forms.DataGridView();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNoRooms = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAvailableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dateReservation
            // 
            this.dateReservation.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateReservation.Location = new System.Drawing.Point(33, 83);
            this.dateReservation.MaxSelectionCount = 14;
            this.dateReservation.MinDate = new System.DateTime(2024, 10, 19, 22, 11, 18, 0);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.TabIndex = 0;
            this.dateReservation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateReservation_DateChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(89, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Select Time Range";
            // 
            // gridviewAvailableRooms
            // 
            this.gridviewAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewAvailableRooms.BackgroundColor = System.Drawing.Color.Silver;
            this.gridviewAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewAvailableRooms.Location = new System.Drawing.Point(294, 65);
            this.gridviewAvailableRooms.MultiSelect = false;
            this.gridviewAvailableRooms.Name = "gridviewAvailableRooms";
            this.gridviewAvailableRooms.ReadOnly = true;
            this.gridviewAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewAvailableRooms.Size = new System.Drawing.Size(412, 188);
            this.gridviewAvailableRooms.TabIndex = 3;
            this.gridviewAvailableRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewAvailableRooms_CellContentClick);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Deluxe Room Triple",
            "Deluxe Room Double",
            "Deluxe Room Single",
            "Standard Room Triple ",
            "Standard Room Double",
            "Standard Room Single"});
            this.cmbType.Location = new System.Drawing.Point(369, 27);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(261, 21);
            this.cmbType.TabIndex = 21;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(277, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 13);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Room Type       :";
            // 
            // lblNoRooms
            // 
            this.lblNoRooms.AutoSize = true;
            this.lblNoRooms.Location = new System.Drawing.Point(317, 83);
            this.lblNoRooms.Name = "lblNoRooms";
            this.lblNoRooms.Size = new System.Drawing.Size(223, 13);
            this.lblNoRooms.TabIndex = 23;
            this.lblNoRooms.Text = "No rooms are available for the selected period";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(555, 307);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 24;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(65, 313);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(88, 13);
            this.lblCost.TabIndex = 25;
            this.lblCost.Text = "Total Cost          :";
            // 
            // txtboxCost
            // 
            this.txtboxCost.Enabled = false;
            this.txtboxCost.Location = new System.Drawing.Point(160, 310);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(154, 20);
            this.txtboxCost.TabIndex = 26;
            this.txtboxCost.TextChanged += new System.EventHandler(this.txtboxCost_TextChanged);
            // 
            // txtboxDays
            // 
            this.txtboxDays.Enabled = false;
            this.txtboxDays.Location = new System.Drawing.Point(160, 284);
            this.txtboxDays.Name = "txtboxDays";
            this.txtboxDays.Size = new System.Drawing.Size(154, 20);
            this.txtboxDays.TabIndex = 28;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(65, 287);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(89, 13);
            this.lblDays.TabIndex = 27;
            this.lblDays.Text = "Number of Days :";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(410, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 24);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblNoRooms);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.gridviewAvailableRooms);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateReservation);
            this.Name = "AddReservation";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.AddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAvailableRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dateReservation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView gridviewAvailableRooms;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNoRooms;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnBack;
    }
}