using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            static void array()
            {
                string[] subject = new string[6];

                subject[0] = "Physics";
                subject[1] = "c";
                subject[2] = "b";
                subject[3] = "cal";
                subject[4] = "com";
                subject[5] = "al";

                int[] marks = new int[6];
                marks[0] = 67;
                marks[0] = 90;
                marks[0] = 80;
                marks[0] = 55;
                marks[0] = 71;
                marks[0] = 92;

                Console.WriteLine("Marks of kamal:");
                int total = 0;
                for (int i = 0; i < 6; i++)
                {
                    total += marks[i];
                    Console.WriteLine(subject[i] + " = " + marks[i]);
                }
                Console.WriteLine("Total = " + total + "/600 = " + (total * 100 / 600) + "percent");
            }
        }
    }
}
