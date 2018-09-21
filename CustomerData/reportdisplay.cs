using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerData
{
    public partial class reportdisplay : Form
    {
        public reportdisplay()
        {
            InitializeComponent();
        }

        private void reportdisplay_Load(object sender, EventArgs e)
        {


            CrystalReport1  objRpt;
            // Creating object of our report.
            objRpt = new CrystalReport1 ();

            String ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ISAAC\DOCUMENTS\DBDATA.MDF;Integrated Security=True;Connect Timeout=30";

            SqlConnection  myConnection = new SqlConnection (ConnStr);
            
            String Query1 = "SELECT first_name,last_name,max_limit FROM Customers";
            SqlDataAdapter  adapter = new SqlDataAdapter (Query1, ConnStr);
            
            DataSet Ds = new DataSet();

            adapter.Fill(Ds, "Custdata");

            if (Ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No data Found", "report");
                return;
            }

            // Setting data source of our report object
            objRpt.SetDataSource(Ds);

            CrystalDecisions.CrystalReports.Engine.TextObject root;
            root = (CrystalDecisions.CrystalReports.Engine.TextObject)
                 objRpt.ReportDefinition.ReportObjects["txt_header"];
            root.Text = "report!!";

           // Binding the crystalReportViewer with our report object. 
            crystalReportViewer1.ReportSource = objRpt;
           
        }
    }
}
