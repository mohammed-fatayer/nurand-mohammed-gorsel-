﻿using System;
using System.Windows.Forms;

namespace project00
{
    public partial class messageform : Form
    {
        public static string passingtext;
        public messageform()
        {
            InitializeComponent();
            TextBox textBox1 = new TextBox();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                return;
            }
            passingtext = textBox1.Text;
            textBox2.Text = textBox2.Text + passingtext + Environment.NewLine;
            textBox1.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}