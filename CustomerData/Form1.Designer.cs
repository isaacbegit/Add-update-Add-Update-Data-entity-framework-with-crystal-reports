namespace CustomerData
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.xVisualTheme1 = new CustomerData.xVisualTheme();
            this.btnCancel = new System.Windows.Forms.Button();
            this.redemptionControlBox1 = new CustomerData.RedemptionControlBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labstate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.xVisualTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // xVisualTheme1
            // 
            this.xVisualTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.xVisualTheme1.Controls.Add(this.btnCancel);
            this.xVisualTheme1.Controls.Add(this.redemptionControlBox1);
            this.xVisualTheme1.Controls.Add(this.btn_print);
            this.xVisualTheme1.Controls.Add(this.btnAdd);
            this.xVisualTheme1.Controls.Add(this.label2);
            this.xVisualTheme1.Controls.Add(this.txtMaxLimit);
            this.xVisualTheme1.Controls.Add(this.label3);
            this.xVisualTheme1.Controls.Add(this.txtLastName);
            this.xVisualTheme1.Controls.Add(this.labstate);
            this.xVisualTheme1.Controls.Add(this.label4);
            this.xVisualTheme1.Controls.Add(this.txtFirstname);
            this.xVisualTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xVisualTheme1.Location = new System.Drawing.Point(0, 0);
            this.xVisualTheme1.Name = "xVisualTheme1";
            this.xVisualTheme1.Size = new System.Drawing.Size(468, 288);
            this.xVisualTheme1.TabIndex = 3;
            this.xVisualTheme1.Text = "Customer Data";
            this.xVisualTheme1.Click += new System.EventHandler(this.xVisualTheme1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnCancel.ForeColor = System.Drawing.Color.Lime;
            this.btnCancel.Location = new System.Drawing.Point(326, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // redemptionControlBox1
            // 
            this.redemptionControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redemptionControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.redemptionControlBox1.ForeColor = System.Drawing.Color.White;
            this.redemptionControlBox1.Location = new System.Drawing.Point(399, 9);
            this.redemptionControlBox1.Name = "redemptionControlBox1";
            this.redemptionControlBox1.Size = new System.Drawing.Size(60, 25);
            this.redemptionControlBox1.TabIndex = 4;
            this.redemptionControlBox1.Text = "redemptionControlBox1";
            // 
            // btn_print
            // 
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btn_print.ForeColor = System.Drawing.Color.Lime;
            this.btn_print.Location = new System.Drawing.Point(210, 213);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(110, 34);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAdd.ForeColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(63, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaxLimit
            // 
            this.txtMaxLimit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtMaxLimit.Location = new System.Drawing.Point(124, 139);
            this.txtMaxLimit.Name = "txtMaxLimit";
            this.txtMaxLimit.Size = new System.Drawing.Size(112, 27);
            this.txtMaxLimit.TabIndex = 2;
            this.txtMaxLimit.TextChanged += new System.EventHandler(this.txtMaxLimit_TextChanged);
            this.txtMaxLimit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxLimit_KeyDown);
            this.txtMaxLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxLimit_KeyPress);
            this.txtMaxLimit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtMaxLimit_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLastName.Location = new System.Drawing.Point(124, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(271, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // labstate
            // 
            this.labstate.BackColor = System.Drawing.Color.Transparent;
            this.labstate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labstate.ForeColor = System.Drawing.Color.White;
            this.labstate.Location = new System.Drawing.Point(12, 180);
            this.labstate.Name = "labstate";
            this.labstate.Size = new System.Drawing.Size(430, 19);
            this.labstate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Limit";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFirstname.Location = new System.Drawing.Point(124, 73);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(271, 27);
            this.txtFirstname.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(468, 288);
            this.Controls.Add(this.xVisualTheme1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.xVisualTheme1.ResumeLayout(false);
            this.xVisualTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMaxLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_print;
        private xVisualTheme xVisualTheme1;
        private RedemptionControlBox redemptionControlBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labstate;
    }
}

