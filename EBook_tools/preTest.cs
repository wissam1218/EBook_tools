using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading;

namespace EBook_tools
{
    public partial class preTest : Form
    {
        string strPath = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);

        public static int count = 1;
        public static Document pdoc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
        public static PdfWriter pwriter =
                    PdfWriter.GetInstance
                    (pdoc, new FileStream("C:/Users/Sam_Ham/Desktop/pre.pdf", FileMode.Create));
        // path: 
        public preTest()
        {
            InitializeComponent();
            pdoc.Open();
            Paragraph p = new Paragraph("PRE-TEST\r\n");
            p.Alignment = 1;  //aligns to center
            pdoc.Add(p);
            // pdoc.Add(new Paragraph("PRETEST\r\n"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pdoc.Open();
            pdoc.Add(new Paragraph("Question #" + count));
            pdoc.Add(new Paragraph(this.qBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.aBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.bBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.cBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.dBox.Text.Trim()));
 
            pdoc.Add(new Paragraph("ANSWER: " + this.ansBox.Text.Trim()));
            pdoc.Add(new Paragraph("~~~~~~~~~~~~~~~~~~~"));
            if (count < 5)
            {
                pdoc.NewPage();
            }
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdoc.Close();
        }
    }
}
