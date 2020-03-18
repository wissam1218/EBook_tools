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
    public partial class VIDreader : Form
    {
        public VIDreader()
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
            IMGreader lc = new IMGreader();
            lc.Show();

        }
        //this is our video container, the method name must match the name on the container or you will get a catastophic failure.
        //this empty method is attached to the media player object and acts as an empty container for the actual video.
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        //we choose our video file with this method and open that file for our media player.
        private void vidChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openVideoFile = new OpenFileDialog();

            if (openVideoFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                axWindowsMediaPlayer1.URL = openVideoFile.FileName;
            }
        }
        //this is to play the video
        private void vidPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //this is to stop the video
        private void vidStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        //this will pause our video
        private void vidPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void vidConfirm_Click(object sender, EventArgs e)
        {
            //to be implemented later to add to our export file.
        }
    }
}
