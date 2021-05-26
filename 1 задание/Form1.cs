using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uravnenie1
{

    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(textBox1.Text);
            Double n = Convert.ToDouble(textBox2.Text);
            Double y;
            
            y = ((x * n)/(n+1)) * (1/4);
            textBox3.Text += "y = " + y.ToString();


        }
    }
}
