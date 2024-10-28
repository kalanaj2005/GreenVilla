namespace Green_Villa
{
    partial class UpdateReservation
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
            this.txtboxDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblNoRooms = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.gridviewAvailableRooms = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateReservation = new System.Windows.Forms.MonthCalendar();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAvailableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxDays
            // 
            this.txtboxDays.Enabled = false;
            this.txtboxDays.Location = new System.Drawing.Point(161, 287);
            this.txtboxDays.Name = "txtboxDays";
            this.txtboxDays.Size = new System.Drawing.Size(154, 20);
            this.txtboxDays.TabIndex = 39;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(66, 290);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(89, 13);
            this.lblDays.TabIndex = 38;
            this.lblDays.Text = "Number of Days :";
            // 
            // txtboxCost
            // 
            this.txtboxCost.Enabled = false;
            this.txtboxCost.Location = new System.Drawing.Point(161, 313);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(154, 20);
            this.txtboxCost.TabIndex = 37;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(66, 316);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(88, 13);
            this.lblCost.TabIndex = 36;
            this.lblCost.Text = "Total Cost          :";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(556, 310);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 35;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblNoRooms
            // 
            this.lblNoRooms.AutoSize = true;
            this.lblNoRooms.Location = new System.Drawing.Point(318, 86);
            this.lblNoRooms.Name = "lblNoRooms";
            this.lblNoRooms.Size = new System.Drawing.Size(223, 13);
            this.lblNoRooms.TabIndex = 34;
            this.lblNoRooms.Text = "No rooms are available for the selected period";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(278, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 13);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "Room Type       :";
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
            this.cmbType.Location = new System.Drawing.Point(370, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(261, 21);
            this.cmbType.TabIndex = 32;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // gridviewAvailableRooms
            // 
            this.gridviewAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewAvailableRooms.BackgroundColor = System.Drawing.Color.Silver;
            this.gridviewAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewAvailableRooms.Location = new System.Drawing.Point(295, 68);
            this.gridviewAvailableRooms.MultiSelect = false;
            this.gridviewAvailableRooms.Name = "gridviewAvailableRooms";
            this.gridviewAvailableRooms.ReadOnly = true;
            this.gridviewAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewAvailableRooms.Size = new System.Drawing.Size(412, 188);
            this.gridviewAvailableRooms.TabIndex = 31;
            this.gridviewAvailableRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewAvailableRooms_CellContentClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(90, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 13);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Select Time Range";
            // 
            // dateReservation
            // 
            this.dateReservation.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateReservation.Location = new System.Drawing.Point(34, 86);
            this.dateReservation.MaxSelectionCount = 14;
            this.dateReservation.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateReservation.Name = "dateReservation";
            this.dateReservation.TabIndex = 29;
            this.dateReservation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateReservation_DateChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(422, 309);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 24);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 355);
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
            this.Name = "UpdateReservation";
            this.Text = "Update Reservation";
            this.Load += new System.EventHandler(this.UpdateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAvailableRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblNoRooms;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridView gridviewAvailableRooms;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar dateReservation;
        private System.Windows.Forms.Button btnBack;
    }
}