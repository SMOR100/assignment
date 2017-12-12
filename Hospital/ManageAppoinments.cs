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
           
            string query = "Select isnull(max(cast(AppID as int)),0)+1 From Appoinment";

            int id = DatabaseConnection.getInstance().UniqueID(query);

            txtbAppID.Text = (id).ToString();
            this.ActiveControl = txtbPatID;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // These lines of code will check
            // if patient exist or 
            string query1 = "Select * From Patient Where PatientID ='" + txtbPatID.Text + "'";
            DataSet dts = DatabaseConnection.getInstance().getDataSet(query1);
            DataTable dtt = new DataTable();
            dtt = dts.Tables[0];

            // if patient exist do this
            if (dtt.Rows.Count == 1)
            {
                // query for adding data to database
                string query = "Insert Into Appoinment (AppID, PatientID, StaffID, AppDate) Values ('"+ txtbAppID.Text + "','" + txtbPatID.Text + "','" + txtbStaffID.Text + "', '" + dtpAppDate.Text + "')";
                int rows = DatabaseConnection.getInstance().insert(query);

                try 
                {
                    MessageBox.Show("Appoinment booked");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            // if patient does not exist do this
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if appoinment exists or not
            string query1 = "Select * From Appoinment Where AppID='" + txtAppID.Text + "'";
            DataSet mm = DatabaseConnection.getInstance().getDataSet(query1);
            DataTable nn = new DataTable();
            nn = mm.Tables[0];

            // if exist 
            if(nn.Rows.Count == 1)
            {
                // Edit appoinment details 
                string query = "Update Appoinment Set StaffID = '" + txtStID.Text + "', AppDate = '" + dtpNewDate.Text + "' Where AppID = '" + txtAppID.Text + "'";
                int data = DatabaseConnection.getInstance().insert(query);

                try
                {
                    MessageBox.Show("Appoinment successfully edited");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            // if doesn't exist
            else
            {
                MessageBox.Show("Appoinment does not exist");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check if appoinment exists or not
            string query1 = "Select * From Appoinment Where AppID='" + txtAppID.Text + "'";
            DataSet mm = DatabaseConnection.getInstance().getDataSet(query1);
            DataTable nn = new DataTable();
            nn = mm.Tables[0];

            // if exist 
            if (nn.Rows.Count == 1)
            {
                string query = "Delete From Appoinment Where AppID='" + txtDelAppID.Text + "'";
                int aa = DatabaseConnection.getInstance().insert(query);

                try
                {
                    MessageBox.Show("Appoinment deleted");
                }
                catch(Exception bb)
                {
                    MessageBox.Show(bb.Message);
                }
            }

        }
    }
}
