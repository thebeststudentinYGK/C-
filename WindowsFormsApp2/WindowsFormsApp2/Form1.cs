﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int max = Mas[0], temp=0, count = 0;
            for (int i = 0; i < 20; i++)
            {
                if (Mas[i] > max)
                {
                    max = Mas[i];
                    count = i;
                }    
            }
            temp = Mas[0];
            Mas[0] = max;
            Mas[count] = temp;
            for (int i = 0; i < 20; i++)
            { 
                listBox2.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }
    }
}
