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
        public static int numOfFiles = 1;
        public static int count = 1;
        


        
        TextWriter tw = new StreamWriter("C:/tests/postTests/postTest" + numOfFiles+".txt", true);

        // Initialize the text boxes
        public postTest()
        {
            InitializeComponent();
            qBox.Text = "Enter question #"+count+" here";
            aBox.Text = "Choice";
            bBox.Text = "Choice";
            cBox.Text = "Choice";
            dBox.Text = "Answer";
            ansBox.Text = "Answer";
            
        }
        // adds the queestion set to the file aand clear for new text
        public void addBtn_Click(object sender, EventArgs e)
        {
            tw.WriteLine("$"+this.qBox.Text+">");
            tw.WriteLine("&"+this.aBox.Text);
            tw.WriteLine("!"+this.bBox.Text);
            tw.WriteLine("*"+this.cBox.Text);
            tw.WriteLine("@"+this.dBox.Text);
            tw.WriteLine("." + this.ansBox.Text);
            qBox.Clear();
            aBox.Clear();
            bBox.Clear();
            cBox.Clear();
            dBox.Clear();
            ansBox.Clear();
            qBox.Text = "What is question #: " + (count+1).ToString();
            aBox.Text = "Choice";
            bBox.Text = "Choice";
            cBox.Text = "Choice";
            dBox.Text = "Answer";
            ansBox.Text = "Answer";
            count++;
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            tw.Close();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void postTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 1;
            numOfFiles++;
            tw.Close();
        }

    
    }
}
