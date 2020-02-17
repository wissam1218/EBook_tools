using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class postTest : Form
    {
        public static int count = 1;
        TextWriter tw = new StreamWriter("C:/Users/Sam_Ham/Desktop/postTest.txt", true);

        public postTest()
        {
            InitializeComponent();
            tw.WriteLine("POST-TEST\r\n");
            qBox.Text = "what is question #: " + count.ToString();
            aBox.Text = "answer 1";
            bBox.Text = "answer 2";
            cBox.Text = "answer 3";
            dBox.Text = "answer 4";
            ansBox.Text = "actual answer";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public void addBtn_Click(object sender, EventArgs e)
        {
            tw.WriteLine("Question #" + count);
            tw.WriteLine(this.qBox.Text);
            tw.WriteLine(this.aBox.Text);
            tw.WriteLine(this.bBox.Text);
            tw.WriteLine(this.cBox.Text);
            tw.WriteLine(this.dBox.Text);
            tw.WriteLine("ANSWER: " + this.ansBox.Text);
            tw.WriteLine("~~~~~~~~~~~~~~~");
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            
            qBox.Text = "what is question #: " + count.ToString();
            aBox.Text = "answer 1";
            bBox.Text = "answer 2";
            cBox.Text = "answer 3";
            dBox.Text = "answer 4";
            ansBox.Text = "actual answer";
            count++;
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
           
            
            tw.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
