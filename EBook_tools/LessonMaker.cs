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
        public LessonMaker()
        {
            InitializeComponent();
        }

        private void OpeningPage_Load(object sender, EventArgs e)
        {
            //??
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
        
    }
}
