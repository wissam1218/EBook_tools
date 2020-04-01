using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EBook_tools
{
    public partial class MainPageform : Form
    {
        string cdir = Environment.CurrentDirectory;
        string className = null;
        string[] environmentArray = null;
        public MainPageform()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Current Folder: " +cdir);
            cdir = cdir + "\\Classrooms";
            System.IO.Directory.CreateDirectory(cdir);
            editClassTSMI.Visible = false;
            if(System.IO.Directory.GetDirectories(cdir).Length==0)
            {
                existingClassroomTSMI.Enabled = false;
            }
        }


        LessonMaker lm;
        private void editClassTSMI_Click(object sender, EventArgs e)
        {
            lm = new LessonMaker();
            lm.changedir(cdir+"\\"+className+"\\Curriculum");
            lm.Text = "Class: " + className+ " | Total Lessons: ";
            lm.className = this.className;
            lm.Show();
            lm.FormClosed += new FormClosedEventHandler(lm_FormClosed);
            this.Hide();
        }

        private void lm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lm = null;
            this.Show();
        }

        //New code pertaining to the file system
        private void existingClassroomTSMI_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer,
                Description = "Select a folder within Classrooms.",
                SelectedPath = cdir

            };
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            String[] separator = { "\\" };
            environmentArray = folderDlg.SelectedPath.ToString().Split(separator, 32, StringSplitOptions.RemoveEmptyEntries);
            if (environmentArray.Length <= 2)
            {

            }
            else
            {
                className = environmentArray[environmentArray.Length - 1];
                if (className == "Classrooms" || environmentArray[environmentArray.Length - 2] != "Classrooms")
                {
                    className = null;
                }
                else
                {
                    this.Text = "Current Selected Class: " + className;
                    editClassTSMI.Visible = true;
                }
            }
        }

        private void newClassroomTSMI_Click(object sender, EventArgs e)
        {
            String inputvalue = Microsoft.VisualBasic.Interaction.InputBox("Choose a Classroom Name", "", "[Enter Name Here]", -1, -1);
            if (inputvalue != ""&&inputvalue != "[Enter Name Here]")
            {
                String newClassroom = cdir + "\\" + inputvalue;
                if (!System.IO.Directory.Exists(newClassroom))
                {
                    System.IO.Directory.CreateDirectory(newClassroom + "\\Students");
                    System.IO.Directory.CreateDirectory(newClassroom + "\\Curriculum");
                }
            }
            className = inputvalue;
            this.Text = "Current Selected Class: " + className;
            editClassTSMI.Visible = true;
            if (!existingClassroomTSMI.Enabled)
            {
                existingClassroomTSMI.Enabled = true;
            }
        }
    }
}
