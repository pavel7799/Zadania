using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_задание
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[24];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 13; i++)
            {
                Mas[i] = rand.Next(-12, 12);
                listBox1.Items.Add("Mas[" + i.ToString() + "]" + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                if (Mas[i] > 0) ;

                listBox2.Items.Add(i);

            }
        }
    }
}
