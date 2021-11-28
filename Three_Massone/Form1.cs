using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Three_Massone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SummMinus(int[,] M)
        {
            int sum = 0;
            bool hasminus = false;
            for (int i = 0; i < M.GetLength(0); ++i)
            {
                for (int j = 0; j < M.GetLength(1); ++j)
                {
                    sum += M[i, j];
                    if (M[i, j] == 0) hasminus = true;
                }
                if (hasminus)
                {
                    textBox2.Clear();
                    textBox2.Text = (i + 1, sum).ToString();
                }

                else
                {
                    hasminus = false;
                    textBox2.Text = "НЕТУ";
                }
    

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string s = textBox1.Text;
            Random r = new Random();
            int[,] M = new int[5, 5];
            for (int i = 0; i < M.GetLength(0); ++i)
            {
                for (int j = 0; j < M.GetLength(1); ++j)
                {
                    M[i, j] = r.Next(-20, 100);
                    textBox1.Text += (M[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
            SummMinus(M);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
