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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void curriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LessonMaker lm = new LessonMaker();
            lm.Show();
            this.Hide();
        }
    }
}
