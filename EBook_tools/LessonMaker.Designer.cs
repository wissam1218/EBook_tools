namespace EBook_tools
{
    partial class LessonMaker
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
            this.lessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addToLessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPreTestToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.addPostTestToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.addPDFToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.addTextFileToLesson = new System.Windows.Forms.ToolStripMenuItem();
            this.openLessonFileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonMI
            // 
            this.lessonMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToLessonMI,
            this.openLessonFileMI});
            this.lessonMI.Name = "lessonMI";
            this.lessonMI.Size = new System.Drawing.Size(55, 20);
            this.lessonMI.Text = "Lesson";
            // 
            // addToLessonMI
            // 
            this.addToLessonMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPreTestToLesson,
            this.addPostTestToLesson,
            this.addPDFToLesson,
            this.addImageToLesson,
            this.addVideoToLesson,
            this.addTextFileToLesson});
            this.addToLessonMI.Name = "addToLessonMI";
            this.addToLessonMI.Size = new System.Drawing.Size(103, 22);
            this.addToLessonMI.Text = "Add";
            // 
            // addPreTestToLesson
            // 
            this.addPreTestToLesson.Name = "addPreTestToLesson";
            this.addPreTestToLesson.Size = new System.Drawing.Size(125, 22);
            this.addPreTestToLesson.Text = "Pre-Test";
            this.addPreTestToLesson.Click += new System.EventHandler(this.addPreTestToLesson_Click);
            // 
            // addPostTestToLesson
            // 
            this.addPostTestToLesson.Name = "addPostTestToLesson";
            this.addPostTestToLesson.Size = new System.Drawing.Size(125, 22);
            this.addPostTestToLesson.Text = "Post- Test";
            this.addPostTestToLesson.Click += new System.EventHandler(this.addPostTestToLesson_Click);
            // 
            // addPDFToLesson
            // 
            this.addPDFToLesson.Name = "addPDFToLesson";
            this.addPDFToLesson.Size = new System.Drawing.Size(125, 22);
            this.addPDFToLesson.Text = "PDF";
            this.addPDFToLesson.Click += new System.EventHandler(this.addPDFToLesson_Click);
            // 
            // addImageToLesson
            // 
            this.addImageToLesson.Name = "addImageToLesson";
            this.addImageToLesson.Size = new System.Drawing.Size(125, 22);
            this.addImageToLesson.Text = "Image";
            this.addImageToLesson.Click += new System.EventHandler(this.addImageToLesson_Click);
            // 
            // addVideoToLesson
            // 
            this.addVideoToLesson.Name = "addVideoToLesson";
            this.addVideoToLesson.Size = new System.Drawing.Size(125, 22);
            this.addVideoToLesson.Text = "Video";
            this.addVideoToLesson.Click += new System.EventHandler(this.addVideoToLesson_Click);
            // 
            // addTextFileToLesson
            // 
            this.addTextFileToLesson.Name = "addTextFileToLesson";
            this.addTextFileToLesson.Size = new System.Drawing.Size(125, 22);
            this.addTextFileToLesson.Text = "Text";
            this.addTextFileToLesson.Click += new System.EventHandler(this.addTextFileToLesson_Click);
            // 
            // openLessonFileMI
            // 
            this.openLessonFileMI.Name = "openLessonFileMI";
            this.openLessonFileMI.Size = new System.Drawing.Size(103, 22);
            this.openLessonFileMI.Text = "Open";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessonMI});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(604, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // LessonMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create and Add to a Lesson";
            this.Load += new System.EventHandler(this.OpeningPage_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonMI;
        private System.Windows.Forms.ToolStripMenuItem addToLessonMI;
        private System.Windows.Forms.ToolStripMenuItem openLessonFileMI;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addPreTestToLesson;
        private System.Windows.Forms.ToolStripMenuItem addPostTestToLesson;
        private System.Windows.Forms.ToolStripMenuItem addPDFToLesson;
        private System.Windows.Forms.ToolStripMenuItem addImageToLesson;
        private System.Windows.Forms.ToolStripMenuItem addVideoToLesson;
        private System.Windows.Forms.ToolStripMenuItem addTextFileToLesson;
    }
}