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
    public partial class CreateTest : Form
    {
        public CreateTest()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void PreTestBtn_Click(object sender, EventArgs e)
        {
            preTest pre = new preTest();
            pre.Show();
        }

        private void PostTestBtn_Click(object sender, EventArgs e)
        {
            postTest post = new postTest();
            post.Show();
        }

        private void OpenTXTBtn_Click(object sender, EventArgs e)
        {
            TXTreader txt = new TXTreader();
            txt.Show();

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LessonCreator lc = new LessonCreator();
            lc.Show();

        }
    }
}
