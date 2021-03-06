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
        //Current directory location
        string cdir;
        //Name of the lesson at the current directory
        string lesson;
        public static int numOfFiles = 1;
        public static int count = 1;

        TextWriter tw;
        public preTest()

        {
            InitializeComponent();
           // tw.WriteLine("PRE-TEST\r\n");
           // qLbl.Text = "Question #" + count;
            qBox.Text = "Enter question #"+count+" here";
            aBox.Text = "Choice";
            bBox.Text = "Choice";
            cBox.Text = "Choice";
            dBox.Text = "Answer";
            ansBox.Text = "Answer";
        }
        public void addBtn_Click(object sender, EventArgs e)
        {
            tw = new StreamWriter(cdir + "\\preTest" + numOfFiles + ".txt", true);
            // tw.WriteLine("Question #" + count);
            tw.WriteLine("$"+this.qBox.Text+">");
            tw.WriteLine("&"+this.aBox.Text);
            tw.WriteLine("!"+this.bBox.Text);
            tw.WriteLine("*"+this.cBox.Text);
            tw.WriteLine("@"+this.dBox.Text);
            tw.WriteLine("." + this.ansBox.Text);
          //  tw.WriteLine("~~~~~~~~~~~~~~~");
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            
            qBox.Text = "What is question #: " + (count+1).ToString();
            aBox.Text = "Choice";
            bBox.Text = "Choice";
            cBox.Text = "Choice";
            dBox.Text = "Choice";
            ansBox.Text = "Answer";
            count++;
            // qLbl.Text = "Question #" + count;
            tw.Close();
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void preTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 1;
            numOfFiles++;
        }
        public void changeDir(string newDir, string newLesson)
        {
            cdir = newDir;
            lesson = newLesson;
        }

        private void qBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
