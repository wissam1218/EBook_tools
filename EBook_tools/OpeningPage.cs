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
    public partial class OpeningPage : Form
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        private void OpeningPage_Load(object sender, EventArgs e)
        {
            //??
        }

        private void createCurricMI_Click(object sender, EventArgs e)
        {
           //create curriculum
        }

        private void createClassroomMI_Click(object sender, EventArgs e)
        {
            //create classroom
        }

        LessonCreator lc;
        private void createLessonMI_Click(object sender, EventArgs e)
        {
            if (lc == null)
            {
                lc = new LessonCreator();
                lc.MdiParent = this;
                lc.FormClosed += new FormClosedEventHandler(lc_FormClosed);
                lc.Show();
            }
            else
            {
                lc.Activate();
            }
        }
        void lc_FormClosed(object sender, FormClosedEventArgs e)
        {
            lc = null;
        }
    }
}
