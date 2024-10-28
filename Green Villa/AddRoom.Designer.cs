namespace Green_Villa
{
    partial class AddRoom
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtboxRoomNum = new System.Windows.Forms.TextBox();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(59, 181);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 24);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 24);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(130, 122);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(260, 20);
            this.txtboxPrice.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(32, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price (Rs.)         :";
            // 
            // txtboxRoomNum
            // 
            this.txtboxRoomNum.Location = new System.Drawing.Point(130, 34);
            this.txtboxRoomNum.Name = "txtboxRoomNum";
            this.txtboxRoomNum.Size = new System.Drawing.Size(92, 20);
            this.txtboxRoomNum.TabIndex = 13;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Location = new System.Drawing.Point(33, 41);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(87, 13);
            this.lblRoomNum.TabIndex = 12;
            this.lblRoomNum.Text = "Room Number   :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(32, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 13);
            this.lblType.TabIndex = 10;
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
            this.cmbType.Location = new System.Drawing.Point(129, 72);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(261, 21);
            this.cmbType.TabIndex = 20;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 243);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtboxRoomNum);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.lblType);
            this.Name = "AddRoom";
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtboxRoomNum;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
    }
}