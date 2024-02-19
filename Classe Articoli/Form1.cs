using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Classe_Articoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Articolo 
        {
            public float _   { get; set; }
            public float __  { get; set; }
            public float ___ { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == true)
            {
                dateTimePicker1.Visible = true;
                label6.Visible = true;
                checkBox3.Visible = true;
                label7.Visible = true;
            }
            if (checkbox.Checked == false)
            {
                dateTimePicker1.Visible = false;
                label6.Visible = false;
                checkBox3.Visible = false;
                label7.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.Visible = true;
                label8.Visible = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox1.Visible = false;
                label8.Visible = false;
            }
        }

        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2.Checked == true)
            {
                textBox2.Visible = true;
                label10.Visible = true;
                checkBox4.Visible = true;
                label9.Visible = true;
            }
            if (checkbox2.Checked == false)
            {
                textBox2.Visible = false;
                label10.Visible = false;
                checkBox4.Visible = false;
                label9.Visible = false;
            }
        }

    }
}
