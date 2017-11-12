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
    public partial class ManageAppoinments : Form
    {
        public ManageAppoinments()
        {
            InitializeComponent();
        }

        private void ManageAppoinments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query1 = "Select * From Patient Where PatientID ='" + txtbPatID + "'";
            DataSet dts = DatabaseConnection.getInstance().getDataSet(query1);
            DataTable dtt = new DataTable();
            dtt = dts.Tables[0];

            if (dtt.Rows.Count == 1)
            {
                string query = "Insert Into Appoinment (AppID, PatientID, StaffID, AppDate) Values ('" + txtbAppID + "','" + txtbPatID + "','" + txtbStaffID + "', '" + dtpAppDate + "')";
                int rows = DatabaseConnection.getInstance().insert(query);

                if(rows != 0)
                {
                    MessageBox.Show("Appoinment booked");
                }
            }
            else
            {
                MessageBox.Show("Patient does not exist, Please try again");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Appoinment Menu
            this.Close();

            //Show Main Menu
            Main m = new Main();
            m.Show();
        }
    }
}
