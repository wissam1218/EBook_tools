﻿using iTextSharp.text.pdf.parser;
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
    public partial class PDFView : Form
    {
        string cdir;
        string lesson;
        private StreamWriter tw;

        public PDFView()
        {

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.AddExtension = true;
            ofd.Multiselect = true;
            ofd.Filter = "PDF files (*.pdf)|*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = ofd.FileName;
                String pdfFile = ofd.FileName;
                try
                {
                    File.Copy(pdfFile, cdir + "\\pdf_for_lesson.pdf");
                }
                catch
                {
                    File.Delete(cdir + "\\pdf_for_lesson.pdf");
                    File.Copy(pdfFile, cdir + "\\pdf_for_lesson.pdf");
                }
                //Code below is to use multiple pdfs with their original names
                //String[] filePath = pdfFile.Split('\\');
                //File.Copy(pdfFile, cdir + "\\" + filePath[filePath.Length-1]);


            }
        }
        public void changeDir(string newDir, string newLesson)
        {
            cdir = newDir;
            lesson = newLesson;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void PDFView_Load(object sender, EventArgs e)
        {
            
        }

    }
}
