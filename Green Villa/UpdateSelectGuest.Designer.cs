namespace Green_Villa
{
    partial class UpdateSelectGuest
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
            this.btnUpdateReservatioin = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.gridviewGuests = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateReservatioin
            // 
            this.btnUpdateReservatioin.Location = new System.Drawing.Point(469, 405);
            this.btnUpdateReservatioin.Name = "btnUpdateReservatioin";
            this.btnUpdateReservatioin.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateReservatioin.TabIndex = 16;
            this.btnUpdateReservatioin.Text = "Update";
            this.btnUpdateReservatioin.UseVisualStyleBackColor = true;
            this.btnUpdateReservatioin.Click += new System.EventHandler(this.btnUpdateReservatioin_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search   :";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(77, 18);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(258, 20);
            this.txtboxSearch.TabIndex = 14;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // gridviewGuests
            // 
            this.gridviewGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewGuests.BackgroundColor = System.Drawing.Color.Silver;
            this.gridviewGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewGuests.Location = new System.Drawing.Point(21, 64);
            this.gridviewGuests.Name = "gridviewGuests";
            this.gridviewGuests.ReadOnly = true;
            this.gridviewGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewGuests.Size = new System.Drawing.Size(542, 316);
            this.gridviewGuests.TabIndex = 13;
            this.gridviewGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGuests_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateSelectGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateReservatioin);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.gridviewGuests);
            this.Name = "UpdateSelectGuest";
            this.Text = "Select Guest";
            this.Load += new System.EventHandler(this.UpdateSelectGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateReservatioin;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.DataGridView gridviewGuests;
        private System.Windows.Forms.Button btnCancel;
    }
}