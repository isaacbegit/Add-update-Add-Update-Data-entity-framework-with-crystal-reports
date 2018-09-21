namespace CustomerData
{
    partial class Form2
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
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.las_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.first_name,
            this.las_name,
            this.max_limit});
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCustomers.Location = new System.Drawing.Point(0, 44);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(403, 177);
            this.dgCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click Row to edit into from 1 and then click update button";
            // 
            // CustID
            // 
            this.CustID.DataPropertyName = "ID";
            this.CustID.HeaderText = "ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Visible = false;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // las_name
            // 
            this.las_name.DataPropertyName = "last_name";
            this.las_name.HeaderText = "Last Name";
            this.las_name.Name = "las_name";
            this.las_name.ReadOnly = true;
            // 
            // max_limit
            // 
            this.max_limit.DataPropertyName = "max_limit";
            this.max_limit.HeaderText = "Max Limit";
            this.max_limit.Name = "max_limit";
            this.max_limit.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCustomers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn las_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_limit;
    }
}