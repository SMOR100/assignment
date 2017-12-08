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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a query to get data from database
            string query = "Select * From UserTable Where USERNAME ='" + textBox1.Text.Trim() + "' and PASSWORD ='" + textBox2.Text.Trim() + "'";

            // Ask data from database
            DataSet dsUserTable = DatabaseConnection.getInstance().getDataSet(query);
            // Ask from table 
            DataTable dtUserTable = new DataTable();
            dtUserTable = dsUserTable.Tables[0];
           
            // if user's input is in rows do this
                if (dtUserTable.Rows.Count == 1)
                {
                    this.Hide(); // hides "login" window
                    Main main = new Main();
                    main.Show(); // shows "main" window
                }
                // if no show message box
                else
                {
                    MessageBox.Show("Your login details are wrong.Please try again!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the program
            Application.Exit();
        }
    }
}
