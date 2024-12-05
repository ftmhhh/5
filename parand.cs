using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] MtxNumber = new int[3, 2] { { 10, 5 }, { 13, 15 }, { 33, 85 } };
            foreach (int item in MtxNumber)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String StrRow = "";
            int[,] MtxNumber = new int[3, 2] { { 10, 5 }, { 13, 15 }, { 33, 85 } };
            for (int i = 0; i <= MtxNumber.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= MtxNumber.GetUpperBound(1); j++)
                {
                    StrRow = StrRow + MtxNumber[i, j].ToString() + "   ";
                }
                listBox1.Items.Add(StrRow);
                StrRow = "";
            }
        }
    }
}