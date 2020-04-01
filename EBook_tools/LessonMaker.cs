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
    public partial class LessonMaker : Form
    {
        string cdir = null;
        public string className = null;
        string lesson = null;
        int count = 0;
        String[] environmentArray;
        public LessonMaker()
        {
            InitializeComponent();
        }

        private void OpeningPage_Load(object sender, EventArgs e)
        {
            count = System.IO.Directory.GetDirectories(cdir).Length;
            this.Text += count;
            addToLessonTSMI.Visible = false;
            if(count == 0)
            {
                existingLessonTSMI.Enabled = false;
            }
        }

        preTest pret;
        private void addPreTestToLesson_Click(object sender, EventArgs e)
        {
            if (pret == null)
            {
                pret = new preTest();
                pret.MdiParent = this;
                pret.FormClosed += new FormClosedEventHandler(pret_FormClosed);
                pret.Show();
                //Passes the directory with changes so the form can correctly save to a folder
                pret.changeDir(cdir + "\\" + lesson,lesson);
            }
            else
            {
                pret.Activate();
            }
        }

        void pret_FormClosed(object sender, FormClosedEventArgs e)
        {
            pret = null;
        }

        postTest post;
        private void addPostTestToLesson_Click(object sender, EventArgs e)
        {
            if (post == null)
            {
                post = new postTest();
                post.MdiParent = this;
                post.FormClosed += new FormClosedEventHandler(post_FormClosed);
                post.Show();
                post.changeDir(cdir + "\\" + lesson,lesson);
            }
            else
            {
                post.Activate();
            }
        }

        void post_FormClosed(object sender, FormClosedEventArgs e)
        {
            post = null;
        }

        PDFView pdfv;
        private void addPDFToLesson_Click(object sender, EventArgs e)
        {
            if (pdfv == null)
            {
                pdfv = new PDFView();
                pdfv.MdiParent = this;
                pdfv.FormClosed += new FormClosedEventHandler(pdfv_FormClosed);
                pdfv.Show();
                pdfv.changeDir(cdir+"\\"+lesson,lesson);
            }
            else
            {
                pdfv.Activate();
            }
        }

        void pdfv_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfv = null;
        }

        IMGreader img;
        private void addImageToLesson_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                img = new IMGreader();
                img.MdiParent = this;
                img.FormClosed += new FormClosedEventHandler(img_FormClosed);
                img.Show();
                img.changeDir(cdir + "\\" + lesson,lesson);
            }
            else
            {
                img.Activate();
            }
        }

        void img_FormClosed(object sender, FormClosedEventArgs e)
        {
            img = null;
        }

        VIDreader vr;
        private void addVideoToLesson_Click(object sender, EventArgs e)
        {
            if (vr == null)
            {
                vr = new VIDreader();
                vr.MdiParent = this;
                vr.FormClosed += new FormClosedEventHandler(vr_FormClosed);
                vr.Show();
                vr.changeDir(cdir + "\\" + lesson, lesson);
            }
            else
            {
                vr.Activate();
            }
        }

        void vr_FormClosed(object sender, FormClosedEventArgs e)
        {
            vr = null;
        }

        TXTreader tr;
        private void addTextFileToLesson_Click(object sender, EventArgs e)
        {
            if (tr == null)
            {
                tr = new TXTreader();
                tr.MdiParent = this;
                tr.FormClosed += new FormClosedEventHandler(tr_FormClosed);
                tr.Show();
                tr.changeDir(cdir + "\\" + lesson, lesson);
            }
            else
            {
                tr.Activate();
            }
        }

        void tr_FormClosed(object sender, FormClosedEventArgs e)
        {
            tr = null;
        }


        //New code pertaining to the file system
        public void changedir(string newdir)
        {
            cdir = newdir;
        }

        private void existingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                SelectedPath = cdir
            };
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            String[] separator = { "\\" };
            environmentArray = folderDlg.SelectedPath.ToString().Split(separator, 32, StringSplitOptions.RemoveEmptyEntries);
            if (environmentArray.Length <= 2)
            {

            }
            else
            {
                lesson = environmentArray[environmentArray.Length - 1];
                if (environmentArray[environmentArray.Length - 2] == "Curriculum"&& environmentArray[environmentArray.Length - 3]== className)
                { 
                    this.Text = "Class: " + className + " | Total Lessons: " + count + " | Chosen Lesson: " + lesson;
                    addToLessonTSMI.Visible = true;
                }
                else
                {
                    lesson = null;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count++;
            System.IO.Directory.CreateDirectory(cdir + "\\Lesson "+count);
            lesson = "Lesson " + count;
            this.Text = "Class: " + className + " | Total Lessons: " + count+" | Chosen Lesson: " + lesson;
            addToLessonTSMI.Visible = true;
            if (!existingLessonTSMI.Enabled)
            {
                existingLessonTSMI.Enabled = true;
            }
        }
    }
}
