﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace EBook_tools
{
    public partial class preTest : Form
    {
        public static int numOfFiles = 1;
        public static int count = 1;
       TextWriter tw = new StreamWriter("preTest"+numOfFiles+".txt", true);
        
public preTest()
        {
       
            InitializeComponent();
           // tw.WriteLine("PRE-TEST\r\n");
            qLbl.Text = "Question #" + count;
            qBox.Text = "Enter question here";
            aBox.Text = "Enter an answer here";
            bBox.Text = "Enter an answer here";
            cBox.Text = "Enter an answer here";
            dBox.Text = "Enter an answer here";
            ansBox.Text = "Enter the correct answer here";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // tw.WriteLine("Question #"+count);
            tw.WriteLine("$" + this.qBox.Text + ">");
            tw.WriteLine("&" + this.aBox.Text);
            tw.WriteLine("!" + this.bBox.Text);
            tw.WriteLine("*" + this.cBox.Text);
            tw.WriteLine("@" + this.dBox.Text);
            tw.WriteLine("." + this.ansBox.Text);
            // tw.WriteLine("~~~~~~~~~~~~~~~");
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
            qLbl.Text = "Question #" + count;
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            tw.Close();
            this.Close();
        }
        private void preTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 1;
            numOfFiles++;
            tw.Close();
        }
    }
}
