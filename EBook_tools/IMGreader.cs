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
    public partial class IMGreader : Form
    {
        string cdir;
        string lesson;
        public IMGreader()
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
            VIDreader testform = new VIDreader();
            testform.Show();

        }

        private void editPDFBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddIMG_Click(object sender, EventArgs e)
        {
            //this is our local variable being used to store  our file path for the image
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                //this dialog filter will have us initially looking for jpg files, however the user can use the options on the file search
                //to pic png or all files if they have a different file type that they're looking for
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = dialog.FileName;

                    picPreview.ImageLocation = imageLocation;
                }

            }
            catch (Exception) {
                //if an image is not selected but some other file then they'll recieve an error message instead.
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IMGreader_Load(object sender, EventArgs e)
        {

        }

        private void picConfirm_Click(object sender, EventArgs e)
        {
            //to be implemented later, this will close the image selection and add the img file to our export files
        }

        private void picPreview_Click(object sender, EventArgs e)
        {
            //this picture box is where the image gets loaded, it remains empty as an image is going to take place here
            //if we wanted we could add some events inside this picture box if someone were to click inside it for example
        }
        public void changeDir(string newDir, string newLesson)
        {
            cdir = newDir;
            lesson = newLesson;
        }
    }
}
