using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace HDT1
{
    public partial class Form1 : Form
    {
        ArrayList w1 = new ArrayList();
        ArrayList w2 = new ArrayList();
        string t1 = "", t2 = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = t1 + " " + t2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w1.Clear();
            w2.Clear();
            label1.Text = "";
            t1 = textBox1.Text;
            t2 = textBox2.Text;
            foreach (char c in t1)
            {
                w1.Add(c.ToString());
            }
            foreach (char c in t2)
            {
                w2.Add(c.ToString());
            }
            int x = 0, y = 0;
            x= w1.Count;
            y = w2.Count;
            if (x > y)
            {
                for(int i = 0; i < x; i++)
                {
                    label1.Text += w1[i];
                    if (i<y)
                    {
                        label1.Text += w2[i];
                    }
                }
            }else
            {
                for (int i = 0; i < y; i++)
                {
                    if (i < x)
                    {
                        label1.Text += w1[i];
                    }
                    label1.Text += w2[i];
                }
            }
        }
    }
}
