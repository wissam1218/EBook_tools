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
    public partial class MainPage : Form
    {
        // this is how the current file structur is designed 
        public static String root = "C:/EBook_tools";
        public static String pdf = "C:/EBook_tools/pdf";
        public static String test = "C:/EBook_tools/tests";
        public static String prePath = "C:/EBook_tools/tests/preTests";
        public static String postPath = "C:/EBook_tools/tests/postTests";
        public MainPage() 
        {
            InitializeComponent();
            // if the various folders are not found on the c drive then create it
            if (!Directory.Exists(pdf))
            {
                Directory.CreateDirectory(pdf);
            }
            if (!Directory.Exists(test))
            {
                Directory.CreateDirectory(test);
            }
            if (!Directory.Exists(prePath))
            {
                Directory.CreateDirectory(prePath);
            }
            if (!Directory.Exists(postPath)){
                Directory.CreateDirectory(postPath);
            }
        }

        private void curriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonMaker lm = new LessonMaker();
            lm.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
