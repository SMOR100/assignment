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
            string query = "Insert Into Patient ( PatientID, FirstName, LastName, EMail, MobileNumber, DateOfBirth) Values ('" + txtbID.Text + "','" + txtbFirName.Text + "','" + txtbLastName.Text + "', '" + txtbMail.Text + "','" + txtbNumber.Text + "','" + dtbAge.Text + "')"; 
            int affectedRows = DatabaseConnection.getInstance().insert(query);
         
            

            if(affectedRows != 0)
            {
                MessageBox.Show("Patient has been registered successfully!!!");
            }
        
        }
    }
}
