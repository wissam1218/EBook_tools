using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBook_tools
{
    public partial class PDFView : Form
    {
        public PDFView()
        {
            

            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // set a filter
            open.Filter = "(*.pdf) |*.pdf;";
            open.ShowDialog();
            if (open.FileName != null)
            {
                // load
                pdf.LoadFile(open.FileName);
            }

        }
    }
}
