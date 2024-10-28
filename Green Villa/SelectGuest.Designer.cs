namespace Green_Villa
{
    partial class SelectGuest
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.gridviewGuests = new System.Windows.Forms.DataGridView();
            this.btnMakeReservatioin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search   :";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(82, 23);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(258, 20);
            this.txtboxSearch.TabIndex = 9;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // gridviewGuests
            // 
            this.gridviewGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewGuests.BackgroundColor = System.Drawing.Color.Silver;
            this.gridviewGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewGuests.Location = new System.Drawing.Point(26, 69);
            this.gridviewGuests.Name = "gridviewGuests";
            this.gridviewGuests.ReadOnly = true;
            this.gridviewGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewGuests.Size = new System.Drawing.Size(571, 289);
            this.gridviewGuests.TabIndex = 8;
            // 
            // btnMakeReservatioin
            // 
            this.btnMakeReservatioin.Location = new System.Drawing.Point(502, 378);
            this.btnMakeReservatioin.Name = "btnMakeReservatioin";
            this.btnMakeReservatioin.Size = new System.Drawing.Size(95, 23);
            this.btnMakeReservatioin.TabIndex = 12;
            this.btnMakeReservatioin.Text = "Create";
            this.btnMakeReservatioin.UseVisualStyleBackColor = true;
            this.btnMakeReservatioin.Click += new System.EventHandler(this.btnMakeReservatioin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 424);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakeReservatioin);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.gridviewGuests);
            this.Name = "SelectGuest";
            this.Text = "Select Guest";
            this.Load += new System.EventHandler(this.SelectGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.DataGridView gridviewGuests;
        private System.Windows.Forms.Button btnMakeReservatioin;
        private System.Windows.Forms.Button btnCancel;
    }
}