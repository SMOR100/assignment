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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Pat_Click(object sender, EventArgs e)
        {
            // Show register patient menu
            RegisterPatient aa = new RegisterPatient();
            aa.Show();
            // hide main menu
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit from program
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageAppoinments ma = new ManageAppoinments();
            ma.Show();
            this.Hide();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            Prescriptions pr = new Prescriptions();
            pr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewStaff vs = new ViewStaff();
            vs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindPatient fp = new FindPatient();
            fp.Show();
            this.Hide();
        }
    }
}
