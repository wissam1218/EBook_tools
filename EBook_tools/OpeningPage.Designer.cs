namespace EBook_tools
{
    partial class OpeningPage
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.classroomMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createClassroomMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editClassroomMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassroomMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAssignedCurricMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cirriculumMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createCurricMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurricMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurricMI = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createLessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editLessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classroomMI,
            this.cirriculumMI,
            this.lessonMI});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(533, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // classroomMI
            // 
            this.classroomMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createClassroomMI,
            this.editClassroomMI,
            this.viewClassroomMI});
            this.classroomMI.Name = "classroomMI";
            this.classroomMI.Size = new System.Drawing.Size(75, 20);
            this.classroomMI.Text = "Classroom";
            // 
            // createClassroomMI
            // 
            this.createClassroomMI.Name = "createClassroomMI";
            this.createClassroomMI.Size = new System.Drawing.Size(108, 22);
            this.createClassroomMI.Text = "Create";
            this.createClassroomMI.Click += new System.EventHandler(this.createClassroomMI_Click);
            // 
            // editClassroomMI
            // 
            this.editClassroomMI.Name = "editClassroomMI";
            this.editClassroomMI.Size = new System.Drawing.Size(108, 22);
            this.editClassroomMI.Text = "Edit";
            // 
            // viewClassroomMI
            // 
            this.viewClassroomMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsMI,
            this.viewAssignedCurricMI});
            this.viewClassroomMI.Name = "viewClassroomMI";
            this.viewClassroomMI.Size = new System.Drawing.Size(108, 22);
            this.viewClassroomMI.Text = "View";
            // 
            // viewStudentsMI
            // 
            this.viewStudentsMI.Name = "viewStudentsMI";
            this.viewStudentsMI.Size = new System.Drawing.Size(173, 22);
            this.viewStudentsMI.Text = "Students";
            // 
            // viewAssignedCurricMI
            // 
            this.viewAssignedCurricMI.Name = "viewAssignedCurricMI";
            this.viewAssignedCurricMI.Size = new System.Drawing.Size(173, 22);
            this.viewAssignedCurricMI.Text = "Assigned Curricula";
            // 
            // cirriculumMI
            // 
            this.cirriculumMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCurricMI,
            this.editCurricMI,
            this.viewCurricMI});
            this.cirriculumMI.Name = "cirriculumMI";
            this.cirriculumMI.Size = new System.Drawing.Size(79, 20);
            this.cirriculumMI.Text = "Curriculum";
            // 
            // createCurricMI
            // 
            this.createCurricMI.Name = "createCurricMI";
            this.createCurricMI.Size = new System.Drawing.Size(180, 22);
            this.createCurricMI.Text = "Create";
            this.createCurricMI.Click += new System.EventHandler(this.createCurricMI_Click);
            // 
            // editCurricMI
            // 
            this.editCurricMI.Name = "editCurricMI";
            this.editCurricMI.Size = new System.Drawing.Size(180, 22);
            this.editCurricMI.Text = "Edit";
            // 
            // viewCurricMI
            // 
            this.viewCurricMI.Name = "viewCurricMI";
            this.viewCurricMI.Size = new System.Drawing.Size(180, 22);
            this.viewCurricMI.Text = "View";
            // 
            // lessonMI
            // 
            this.lessonMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLessonMI,
            this.editLessonMI,
            this.viewLessonMI});
            this.lessonMI.Name = "lessonMI";
            this.lessonMI.Size = new System.Drawing.Size(55, 20);
            this.lessonMI.Text = "Lesson";
            // 
            // createLessonMI
            // 
            this.createLessonMI.Name = "createLessonMI";
            this.createLessonMI.Size = new System.Drawing.Size(180, 22);
            this.createLessonMI.Text = "Create";
            this.createLessonMI.Click += new System.EventHandler(this.createLessonMI_Click);
            // 
            // editLessonMI
            // 
            this.editLessonMI.Name = "editLessonMI";
            this.editLessonMI.Size = new System.Drawing.Size(180, 22);
            this.editLessonMI.Text = "Edit";
            // 
            // viewLessonMI
            // 
            this.viewLessonMI.Name = "viewLessonMI";
            this.viewLessonMI.Size = new System.Drawing.Size(180, 22);
            this.viewLessonMI.Text = "View";
            // 
            // OpeningPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "OpeningPage";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.OpeningPage_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem classroomMI;
        private System.Windows.Forms.ToolStripMenuItem createClassroomMI;
        private System.Windows.Forms.ToolStripMenuItem editClassroomMI;
        private System.Windows.Forms.ToolStripMenuItem viewClassroomMI;
        private System.Windows.Forms.ToolStripMenuItem cirriculumMI;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsMI;
        private System.Windows.Forms.ToolStripMenuItem viewAssignedCurricMI;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCurricMI;
        private System.Windows.Forms.ToolStripMenuItem editCurricMI;
        private System.Windows.Forms.ToolStripMenuItem viewCurricMI;
        private System.Windows.Forms.ToolStripMenuItem lessonMI;
        private System.Windows.Forms.ToolStripMenuItem createLessonMI;
        private System.Windows.Forms.ToolStripMenuItem editLessonMI;
        private System.Windows.Forms.ToolStripMenuItem viewLessonMI;
    }
}