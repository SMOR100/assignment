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

        private void label2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            CheckAvailability cv = new CheckAvailability();
            cv.Show();
            this.Hide();
        }
    }
}
