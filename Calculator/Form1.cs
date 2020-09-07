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
    public partial class btn_register : Form
    {
        public btn_register()
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

        private void button2_Click(object sender, EventArgs e)
        {
            //display the selected value in the combo box
            MessageBox.Show($"The selected course is {cb_courses_list.Text}");
            MessageBox.Show($"The selected course is {cb_courses_list.SelectedItem.ToString()}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trainers_list.Items.Clear();
            cb_courses_list.Items.Clear();

            cb_courses_list.Items.Add("C#");
            cb_courses_list.Items.Add("C");
            cb_courses_list.Items.Add("Java");
            cb_courses_list.Items.Add("Python");
            cb_courses_list.Items.Add("VC");
            cb_courses_list.Items.Add("VB");
        }

        private void trainers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cb_courses_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainers_list.Items.Clear();
            if (cb_courses_list.SelectedIndex == 0)
            {
                trainers_list.Items.Add("Trainer 1");
                trainers_list.Items.Add("Trainer 2");
                trainers_list.Items.Add("Trainer 3");
            }
            else if (cb_courses_list.SelectedIndex == 1)
            {
                trainers_list.Items.Add("Trainer 4");
                trainers_list.Items.Add("Trainer 5");
            }
            else
            {
                trainers_list.Items.Add("Trainer 6");
            }
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            ofd_select_file.ShowDialog();
            string fileName = ofd_select_file.FileName;
            MessageBox.Show($"Selected file is : {fileName}");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
