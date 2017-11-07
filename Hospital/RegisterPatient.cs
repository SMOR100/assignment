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
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert Into Patient ( PatientID, FirstName, LastName, EMail, MobileNumber) Values ('" + txtbID.Text.Trim() + "','" + txtbFirName.Text.Trim() + "','" + txtbLastName.Text.Trim() + "', '" + txtbMail.Text.Trim() + "','" + txtbNumber.Text.Trim() + "')"; 
            DataSet dsPatientTable = DatabaseConnection.getInstance().getDataSet(query);
            DataTable dtPatientTable = new DataTable();
            dtPatientTable = dsPatientTable.Load(query);
            

            if(dtPatientTable.Rows.Count != 0)
            {
                MessageBox.Show("Patient has been registered successfully!!!");
            }
        
        }
    }
}
