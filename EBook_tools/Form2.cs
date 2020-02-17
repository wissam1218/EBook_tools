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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preTest pre = new preTest();
            pre.Show();
        }

        private void pstBtn_Click(object sender, EventArgs e)
        {
            postTest post = new postTest();
            post.Show();
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            TXTreader txt = new TXTreader();
            txt.Show();

        }
    }
}
