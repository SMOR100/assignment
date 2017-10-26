using System;
using System.IO;
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
    public partial class Login : Form
    {
        public string username, password;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new StreamReader(@"C:\Users\Samir\Desktop\Hospital\login.txt");
                username = sr.ReadLine();
                password = sr.ReadLine();

                if (username == textBox1.Text && password == textBox2.Text)
                {
                    this.Hide(); // hides "login" window
                    Main main = new Main();
                    main.Show(); // shows "main" window
                }
                else
                {
                    MessageBox.Show("Your login details are wrong.Please try again!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (FileNotFoundException a)
            {
                MessageBox.Show("The user does not exist");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
