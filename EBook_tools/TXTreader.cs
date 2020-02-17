﻿using System;
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
    public partial class TXTreader : Form
    {
        
        public TXTreader()
        {
            InitializeComponent();
        }

        private void TXTreader_Load(object sender, EventArgs e)
        {

        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            string line = "";
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(op.FileName);
                    while (line != null)
                {
                    line = read.ReadLine();
                    if (line != null)
                    {
                        listBox1.Items.Add(line);

                    }
                     
                }
                read.Close();
            }


        }
    }
}
