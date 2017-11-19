using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Main m = new Main();
            m.Show();
        }

        private void btnShowPatientInfo_Click(object sender, EventArgs e)
        {

            // ask from database to get info about patient and prescriptions
            string query = "Select FirstName, LastName, DateOFBirth, Prescription.Medicine, Prescription.PrescriptionPeriod From Patient Inner Join Prescription On Prescription.PatientID=Patient.PatientID Where Prescription.PresID = '" + txtPrescriptionID.Text + "'";
            DataSet ds = DatabaseConnection.getInstance().getDataSet(query);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            //displays patient info on datagrid view
            BindingSource bs = new BindingSource();

            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Extend prescription 
            string query = "Update Prescription Set PrescriptionPeriod = '" + txtExtendPres.Text + "' Where PresID = '" + txtPrescriptionID.Text + "'";
            int ss = DatabaseConnection.getInstance().insert(query);

            // If successfully do this
            try
            {
                MessageBox.Show("Prescription extended successfully");
            }
            // if no do this
            catch(Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // asks from print document method to show printing page
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Represents a print page on window
            Bitmap bt = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bt, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            // place of data grid view on page
            e.Graphics.DrawImage(bt, 180, 200);

            //Title and fonts' of it
            e.Graphics.DrawString("Print Patient Info", new Font("Corbel", 20, FontStyle.Regular), Brushes.Black, new Point(300,30));
        }
    }
}
