using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace project_3
{
    public partial class Form1 : Form
    {
       
            public static string meetingaim;
        

      

        public static Button aimbutton;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("First name required");
            }
            else
            {
                listBox1.Items.Add("First Name " + textBox1.Text);
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Last name required");
            }
            else
            {
                listBox1.Items.Add("Last Name " + textBox2.Text);
            }


            Regex r = new Regex(@"^[0-9]+$");
            if (r.IsMatch(textBox3.Text))
            {
                listBox1.Items.Add("Phone number " + textBox3.Text);
            }
            else
            {
                MessageBox.Show("Invalid number");
            }


            if (textBox4.Text == "")
            {
                MessageBox.Show("Email required");
            }
            else
            {
                listBox1.Items.Add("Email " + textBox4.Text);
            }

            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("date required");
            }
            else
            {
                string date = dateTimePicker1.Text;
                listBox1.Items.Add("date " + date);

            }

            if (button2.Text == "")
            {
                MessageBox.Show("meeting aim required");
            }
            else
            {
                listBox1.Items.Add("Meeting aim " + button2.Text);
            }
            if (numericUpDown1 + numericUpDown2.Text == "")
            {
                MessageBox.Show("time required");
            }
            else
            {
                listBox1.Items.Add("Time " + numericUpDown1 + numericUpDown2.Text);
            }

            listBox1.Items.Add("aim of meeting " + meetingaim);
            meetingaim = "";

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aimbutton = button2;
            Form2 aim = new Form2();
            aim.Show();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
