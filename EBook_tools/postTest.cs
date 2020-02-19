﻿
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

namespace EBook_tools
{
    public partial class postTest : Form
    {
        
        public static int count = 1;
        TextWriter tw = new StreamWriter("C:/Users/Sam_Ham/Desktop/postTest.txt", true);

        public postTest()
        {
            InitializeComponent();
            tw.WriteLine("POST-TEST\r\n");
            qBox.Text = "Enter question here";
            aBox.Text = "Enter an answer here";
            bBox.Text = "Enter an answer here";
            cBox.Text = "Enter an answer here";
            dBox.Text = "Enter an answer here";
            ansBox.Text = "Enter the correct answer here";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void addBtn_Click(object sender, EventArgs e)
        {
            tw.WriteLine("Question #" + count);
            tw.WriteLine(this.qBox.Text);
            tw.WriteLine(this.aBox.Text);
            tw.WriteLine(this.bBox.Text);
            tw.WriteLine(this.cBox.Text);
            tw.WriteLine(this.dBox.Text);
            tw.WriteLine("ANSWER: " + this.ansBox.Text);
            tw.WriteLine("~~~~~~~~~~~~~~~");
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            
            qBox.Text = "What is question #: " + (count+1).ToString();
            aBox.Text = "Answer 1";
            bBox.Text = "Answer 2";
            cBox.Text = "Answer 3";
            dBox.Text = "Answer 4";
            ansBox.Text = "Actual answer";
            count++;
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {

           
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void postTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            tw.Close();

        }

        private void postTest_Load(object sender, EventArgs e)
        {

        }
    }
}
