using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }   

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string password = Password.Text;

            if (name.Equals("Gaurav") && password.Equals("Test123"))
            {
                string greeting = $"Welcome, { userName.Text } you have successfully logged in";

                //display message to the user like a alert
                MessageBox.Show(greeting);
            }
            else
            {
                string error_message = "Incorrect username and password. Try Again";
                MessageBox.Show(error_message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }
    }
}
