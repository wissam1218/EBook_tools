namespace EBook_tools
{
    partial class MainPageform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseClassTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newClassroomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.existingClassroomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editClassTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurriculumTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classTSMI
            // 

            this.classTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseClassTSMI,
            this.editClassTSMI});
            this.classTSMI.Name = "classTSMI";
            this.classTSMI.Size = new System.Drawing.Size(75, 20);
            this.classTSMI.Text = "Classroom";

            // 
            // chooseClassTSMI
            // 

            this.chooseClassTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClassroomTSMI,
            this.existingClassroomTSMI});
            this.chooseClassTSMI.Name = "chooseClassTSMI";
            this.chooseClassTSMI.Size = new System.Drawing.Size(114, 22);
            this.chooseClassTSMI.Text = "Choose";
            // 
            // newClassroomTSMI
            // 

            this.newClassroomTSMI.Name = "newClassroomTSMI";
            this.newClassroomTSMI.Size = new System.Drawing.Size(115, 22);
            this.newClassroomTSMI.Text = "New";
            this.newClassroomTSMI.Click += new System.EventHandler(this.newClassroomTSMI_Click);

            // 
            // existingClassroomTSMI
            // 

            this.existingClassroomTSMI.Name = "existingClassroomTSMI";
            this.existingClassroomTSMI.Size = new System.Drawing.Size(115, 22);
            this.existingClassroomTSMI.Text = "Existing";
            this.existingClassroomTSMI.Click += new System.EventHandler(this.existingClassroomTSMI_Click);

            // 
            // editClassTSMI
            // 

            this.editClassTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStudentTSMI,
            this.editCurriculumTSMI});
            this.editClassTSMI.Name = "editClassTSMI";
            this.editClassTSMI.Size = new System.Drawing.Size(114, 22);
            this.editClassTSMI.Text = "Edit";

            // 
            // editStudentTSMI
            // 
            this.editStudentTSMI.Name = "editStudentTSMI";
            this.editStudentTSMI.Size = new System.Drawing.Size(134, 22);
            this.editStudentTSMI.Text = "Student";
            // 
            // editCurriculumTSMI
            // 
            this.editCurriculumTSMI.Name = "editCurriculumTSMI";
            this.editCurriculumTSMI.Size = new System.Drawing.Size(134, 22);
            this.editCurriculumTSMI.Text = "Curriculum";
            this.editCurriculumTSMI.Click += new System.EventHandler(this.editClassTSMI_Click);
            // 
            // MainPageform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 568);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;

            this.Name = "MainPageform";
            this.Text = "Welcome! Current Selected Class: None";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classTSMI;
        private System.Windows.Forms.ToolStripMenuItem chooseClassTSMI;
        private System.Windows.Forms.ToolStripMenuItem editClassTSMI;
        private System.Windows.Forms.ToolStripMenuItem editStudentTSMI;
        private System.Windows.Forms.ToolStripMenuItem editCurriculumTSMI;
        private System.Windows.Forms.ToolStripMenuItem existingClassroomTSMI;
        private System.Windows.Forms.ToolStripMenuItem newClassroomTSMI;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}