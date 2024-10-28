namespace Green_Villa
{
    partial class AddGuest
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxTP = new System.Windows.Forms.TextBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name   :";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(121, 55);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(259, 20);
            this.txtboxName.TabIndex = 1;
            this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // txtboxNIC
            // 
            this.txtboxNIC.Location = new System.Drawing.Point(121, 88);
            this.txtboxNIC.Name = "txtboxNIC";
            this.txtboxNIC.Size = new System.Drawing.Size(260, 20);
            this.txtboxNIC.TabIndex = 3;
            this.txtboxNIC.TextChanged += new System.EventHandler(this.txtboxNIC_TextChanged);
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(23, 90);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(46, 13);
            this.lblNIC.TabIndex = 2;
            this.lblNIC.Text = "NIC      :";
            this.lblNIC.Click += new System.EventHandler(this.lblNIC_Click);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(121, 131);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(260, 20);
            this.txtboxEmail.TabIndex = 5;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email    :";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtboxTP
            // 
            this.txtboxTP.Location = new System.Drawing.Point(120, 175);
            this.txtboxTP.Name = "txtboxTP";
            this.txtboxTP.Size = new System.Drawing.Size(260, 20);
            this.txtboxTP.TabIndex = 7;
            this.txtboxTP.TextChanged += new System.EventHandler(this.txtboxTP_TextChanged);
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(22, 177);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(47, 13);
            this.lblTP.TabIndex = 6;
            this.lblTP.Text = "Tp no.  :";
            this.lblTP.Click += new System.EventHandler(this.lblTP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(63, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 24);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 324);
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
            this.Name = "AddGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxTP;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}