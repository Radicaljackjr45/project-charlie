using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1.meetingaim = radioButton1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.meetingaim = "";
            Form1.aimbutton.Text = "aim of meeting";
            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Form1.aimbutton.Text = Form1.meetingaim;
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form1.meetingaim = radioButton2.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form1.meetingaim = radioButton4.Text;
        }
    }
}
