using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{
    public partial class Form1 : Form
    {
        Customer CustObj = new Customer();
        Form2 frm = new Form2();
       

       

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm.dgCustomers.Click  += new EventHandler(dgCustomer_Click);
            
           
            Clearall();
            PopulateData();
        }

        private void dgCustomer_Click(object sender, EventArgs e)
        {
            labstate.Text = "";
            if (frm.dgCustomers.CurrentRow.Index != -1)
            {

                CustObj.ID = Convert.ToInt32(frm.dgCustomers.CurrentRow.Cells["CustID"].Value);
                using (DBEntities db = new DBEntities())
                {
                    CustObj = db.Customers.Where(x => x.ID == CustObj.ID).FirstOrDefault();
                    txtFirstname.Text = CustObj.first_name;
                    txtLastName.Text = CustObj.last_name;
                    txtMaxLimit.Text = CustObj.max_limit.ToString();
                    btnAdd.Text = "Update";
                }
            }
           
        }

        // Adding new  Customer data
        private void addNewCustomer()
        {
            CustObj.first_name = txtFirstname.Text.Trim();
            CustObj.last_name = txtLastName.Text.Trim();
           // CustObj.ID = 0;
            CustObj.max_limit =double.Parse ( txtMaxLimit.Text.Trim());

            
            
            using (DBEntities db = new DBEntities ())
            {
                if (CustObj.ID == 0)
                {
                    db.Customers.Add(CustObj);
                    labstate.Text = "Data added!";
                    labstate.ForeColor = Color.Lime;
                }


                else
                {
                    db.Entry(CustObj).State = System.Data.Entity.EntityState.Modified;
                    labstate.Text = "Record Updated!";
                    labstate.ForeColor = Color.Lime;
                   
                }
                db.SaveChanges();
            }
            Clearall();
            
            PopulateData();

        }


        private void Clearall()
        {
            txtFirstname.Text = txtLastName.Text = "";
            txtMaxLimit.Text = "0.0";
            CustObj.ID = 0;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewCustomer();
        }


        private  bool FloatValu(string text)
        {
            Regex regex = new Regex(@"^\d*\.?\d?$");
            return !regex.IsMatch(text);
        }

        private void PopulateData()
        {
            using (DBEntities db = new DBEntities())
            {
                frm.dgCustomers.DataSource = db.Customers.ToList<Customer>();
            }


            

        }

        private void txtMaxLimit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void txtMaxLimit_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaxLimit_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Clearall();
            btnAdd.Text = "Add";
            CustObj.ID = 0;
            labstate.Text = "";
           
        }

        private void txtMaxLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back
          & e.KeyChar != '.')
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        public void ShowSecondFrm()
        {
            frm.Height = this.Height;
            frm.Width = this.Width;
            frm.Left = this.Left + this.Width;
            frm.Top = this.Top;
            frm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowSecondFrm();
            timer1.Enabled = false;
        }

        private void xVisualTheme1_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            reportdisplay rdisply = new reportdisplay();
            rdisply.Show();
        }
    }
}
