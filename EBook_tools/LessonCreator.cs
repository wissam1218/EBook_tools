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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void picButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }

            }
            catch (Exception){
                MessageBox.Show("An Error Ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
