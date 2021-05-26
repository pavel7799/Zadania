using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [STAThread]

        static void Main() { }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

                using (OpenFileDialog dlg = new OpenFileDialog())

                {

                    dlg.ShowDialog();

                    var file = new StreamReader(dlg.OpenFile()).ReadToEnd();

                    int CtNum = 0, CtRus = 0;

                    for (int i = 0; i < file.Length; i++)

                        if (file[i] >= 'А' && file[i] <= 'я') CtRus++;

                        else if (file[i] >= '0' && file[i] <= '9') CtNum++;

                    Console.WriteLine(

                    CtNum > CtRus ? "More nums" : CtNum < CtRus ? "More Rus letters" :

                    "Equal number of Rus letters and nums");

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
