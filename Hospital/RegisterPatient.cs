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
            string query = "Select isnull(max(cast(PatientID as int)),0)+1 From Patient";

            int id = DatabaseConnection.getInstance().UniqueID(query);

            txtbID.Text = (id).ToString();
            this.ActiveControl = txtbFirName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close Register Patient menu
            this.Close();

            // Show main menu
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // query to add user input to database
            string query = "Insert Into Patient ( PatientID, FirstName, LastName, EMail, Address, DateOfBirth) Values ('" + txtbID.Text + "','" + txtbFirName.Text + "','" + txtbLastName.Text + "', '" + txtbMail.Text + "','" + txtbAddress.Text + "','" + dtbAge.Text + "')";
            // adds user input to database
            int affectedRows = DatabaseConnection.getInstance().insert(query);
         
            
            // if there are data in row show message box
            if(affectedRows == 1)
            {
                MessageBox.Show("Patient has been registered successfully!!!");
            }
        
        }
    }
}
