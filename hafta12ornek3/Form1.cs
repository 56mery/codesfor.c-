using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta12ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thresold=0;
            thresold = int.Parse(txt_trh.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int thresold = 0;
            thresold = int.Parse(txt_trh.Text);

            int grade=int.Parse(txt_grd.Text);
            if (grade >= 90 && thresold<=grade)
            {
                MessageBox.Show("A", "Geçtin");
            }
            else if (grade >= 80 && thresold<=grade)
            {
                MessageBox.Show("B", "Geçtin");
            }
            else if(grade >= 70 && thresold <= grade)
            {
                MessageBox.Show("C", "Geçtin");
            }
            else if(grade >= 60 && thresold <= grade)
            {
                MessageBox.Show("D", "Geçtin");
            }
            else if(grade >=50 && thresold <= grade)
            {
                MessageBox.Show("E", "Geçtin");
            }
            else
            {
                MessageBox.Show("F", "Kaldın");
            }
        }
    }
}
