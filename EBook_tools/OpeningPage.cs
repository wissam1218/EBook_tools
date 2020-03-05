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

        }
        private void chooseClassBtn_Click(object sender, EventArgs e)
        {

        }

        private void chooseCurricBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LessonCreator newCurric = new LessonCreator();
            newCurric.Show();
        }

    }
}
