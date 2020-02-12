using iTextSharp.text;
using iTextSharp.text.pdf;
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
        public static Document pdoc = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
        public static PdfWriter pwriter =
                    PdfWriter.GetInstance
                    (pdoc, new FileStream("C:/Users/Sam_Ham/Desktop/post.pdf", FileMode.Create));

        public postTest()
        {
            InitializeComponent();
           
            pdoc.Open();
            Paragraph p = new Paragraph("POST-TEST\r\n");
            p.Alignment = 1;  
            pdoc.Add(p);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
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
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            count++;
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            pdoc.Close();
        }
    }
}
