namespace Green_Villa
{
    partial class UpdateGuest
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
            this.txtboxTP = new System.Windows.Forms.TextBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGID = new System.Windows.Forms.Label();
            this.txtboxGID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(75, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 24);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 24);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxTP
            // 
            this.txtboxTP.Location = new System.Drawing.Point(139, 220);
            this.txtboxTP.Name = "txtboxTP";
            this.txtboxTP.Size = new System.Drawing.Size(260, 20);
            this.txtboxTP.TabIndex = 17;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(41, 222);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(47, 13);
            this.lblTP.TabIndex = 16;
            this.lblTP.Text = "Tp no.  :";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(140, 176);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(260, 20);
            this.txtboxEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(42, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email    :";
            // 
            // txtboxNIC
            // 
            this.txtboxNIC.Location = new System.Drawing.Point(140, 133);
            this.txtboxNIC.Name = "txtboxNIC";
            this.txtboxNIC.Size = new System.Drawing.Size(260, 20);
            this.txtboxNIC.TabIndex = 13;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(42, 135);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(46, 13);
            this.lblNIC.TabIndex = 12;
            this.lblNIC.Text = "NIC      :";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(140, 100);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(259, 20);
            this.txtboxName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name   :";
            // 
            // lblGID
            // 
            this.lblGID.AutoSize = true;
            this.lblGID.Location = new System.Drawing.Point(44, 65);
            this.lblGID.Name = "lblGID";
            this.lblGID.Size = new System.Drawing.Size(55, 13);
            this.lblGID.TabIndex = 20;
            this.lblGID.Text = "Guest ID :";
            // 
            // txtboxGID
            // 
            this.txtboxGID.Location = new System.Drawing.Point(105, 62);
            this.txtboxGID.Name = "txtboxGID";
            this.txtboxGID.ReadOnly = true;
            this.txtboxGID.Size = new System.Drawing.Size(100, 20);
            this.txtboxGID.TabIndex = 21;
            // 
            // UpdateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 342);
            this.Controls.Add(this.txtboxGID);
            this.Controls.Add(this.lblGID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtboxTP);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxNIC);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Name = "UpdateGuest";
            this.Text = "Update Guest";
            this.Load += new System.EventHandler(this.UpdateGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtboxTP;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGID;
        private System.Windows.Forms.TextBox txtboxGID;
    }
}