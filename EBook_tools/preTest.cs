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

namespace EBook_tools
{
    public partial class preTest : Form
    {
        public static Document pdoc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
        public static PdfWriter pwriter =
                    PdfWriter.GetInstance
                    (pdoc, new FileStream("C:/Users/Sam_Ham/Desktop/pre.pdf", FileMode.Create));
        public preTest()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pdoc.Open();
            pdoc.Add(new Paragraph(this.qBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.aBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.bBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.cBox.Text.Trim()));
            pdoc.Add(new Paragraph(this.dBox.Text.Trim()));
            pdoc.Add(new Paragraph("~~~~~~~~~~~~~~~~~~~"));
            pdoc.Add(new Paragraph(this.ansBox.Text.Trim()));
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdoc.Close();
        }
    }
}
