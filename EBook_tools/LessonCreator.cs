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
    public partial class LessonCreator : Form
    {
        public LessonCreator()
        {
            
            InitializeComponent();
        }

        private void viewPDFBtn_Click(object sender, EventArgs e)
        {
            PDFView pdf = new PDFView();
            pdf.Show();
        }
        private void testBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateTest testform = new CreateTest();
            testform.Show();

        }

        private void editPDFBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            OpeningPage page = new OpeningPage();
            page.Show();

        }

        private void LessonCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
