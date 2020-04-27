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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonMaker));
            this.lessonMI = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.existingLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPreTestToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPostTestToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPDFToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addTextFileToLessonTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonMI
            // 
            this.lessonMI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lessonMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseLessonTSMI,
            this.addToLessonTSMI});
            this.lessonMI.Name = "lessonMI";
            this.lessonMI.Size = new System.Drawing.Size(55, 22);
            this.lessonMI.Text = "Lesson";
            // 
            // chooseLessonTSMI
            // 
            this.chooseLessonTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLessonTSMI,
            this.existingLessonTSMI});
            this.chooseLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("chooseLessonTSMI.Image")));
            this.chooseLessonTSMI.Name = "chooseLessonTSMI";
            this.chooseLessonTSMI.Size = new System.Drawing.Size(114, 22);
            this.chooseLessonTSMI.Text = "Choose";
            // 
            // newLessonTSMI
            // 
            this.newLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("newLessonTSMI.Image")));
            this.newLessonTSMI.Name = "newLessonTSMI";
            this.newLessonTSMI.Size = new System.Drawing.Size(115, 22);
            this.newLessonTSMI.Text = "New";
            this.newLessonTSMI.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // existingLessonTSMI
            // 
            this.existingLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("existingLessonTSMI.Image")));
            this.existingLessonTSMI.Name = "existingLessonTSMI";
            this.existingLessonTSMI.Size = new System.Drawing.Size(115, 22);
            this.existingLessonTSMI.Text = "Existing";
            this.existingLessonTSMI.Click += new System.EventHandler(this.existingToolStripMenuItem_Click);
            // 
            // addToLessonTSMI
            // 
            this.addToLessonTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPreTestToLessonTSMI,
            this.addPostTestToLessonTSMI,
            this.addPDFToLessonTSMI,
            this.addImageToLessonTSMI,
            this.addVideoToLessonTSMI,
            this.addTextFileToLessonTSMI});
            this.addToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addToLessonTSMI.Image")));
            this.addToLessonTSMI.Name = "addToLessonTSMI";
            this.addToLessonTSMI.Size = new System.Drawing.Size(114, 22);
            this.addToLessonTSMI.Text = "Add";
            // 
            // addPreTestToLessonTSMI
            // 
            this.addPreTestToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addPreTestToLessonTSMI.Image")));
            this.addPreTestToLessonTSMI.Name = "addPreTestToLessonTSMI";
            this.addPreTestToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addPreTestToLessonTSMI.Text = "Pre-Test";
            this.addPreTestToLessonTSMI.Click += new System.EventHandler(this.addPreTestToLesson_Click);
            // 
            // addPostTestToLessonTSMI
            // 
            this.addPostTestToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addPostTestToLessonTSMI.Image")));
            this.addPostTestToLessonTSMI.Name = "addPostTestToLessonTSMI";
            this.addPostTestToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addPostTestToLessonTSMI.Text = "Post- Test";
            this.addPostTestToLessonTSMI.Click += new System.EventHandler(this.addPostTestToLesson_Click);
            // 
            // addPDFToLessonTSMI
            // 
            this.addPDFToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addPDFToLessonTSMI.Image")));
            this.addPDFToLessonTSMI.Name = "addPDFToLessonTSMI";
            this.addPDFToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addPDFToLessonTSMI.Text = "PDF";
            this.addPDFToLessonTSMI.Click += new System.EventHandler(this.addPDFToLesson_Click);
            // 
            // addImageToLessonTSMI
            // 
            this.addImageToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addImageToLessonTSMI.Image")));
            this.addImageToLessonTSMI.Name = "addImageToLessonTSMI";
            this.addImageToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addImageToLessonTSMI.Text = "Image";
            this.addImageToLessonTSMI.Click += new System.EventHandler(this.addImageToLesson_Click);
            // 
            // addVideoToLessonTSMI
            // 
            this.addVideoToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addVideoToLessonTSMI.Image")));
            this.addVideoToLessonTSMI.Name = "addVideoToLessonTSMI";
            this.addVideoToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addVideoToLessonTSMI.Text = "Video";
            this.addVideoToLessonTSMI.Click += new System.EventHandler(this.addVideoToLesson_Click);
            // 
            // addTextFileToLessonTSMI
            // 
            this.addTextFileToLessonTSMI.Image = ((System.Drawing.Image)(resources.GetObject("addTextFileToLessonTSMI.Image")));
            this.addTextFileToLessonTSMI.Name = "addTextFileToLessonTSMI";
            this.addTextFileToLessonTSMI.Size = new System.Drawing.Size(125, 22);
            this.addTextFileToLessonTSMI.Text = "Text";
            this.addTextFileToLessonTSMI.Click += new System.EventHandler(this.addTextFileToLesson_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.MidnightBlue;
            this.mainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lessonMI});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mainMenuStrip.Size = new System.Drawing.Size(604, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenuStrip_ItemClicked);
            // 
            // LessonMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem addToLessonTSMI;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addPreTestToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem addPostTestToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem addPDFToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem addImageToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem addVideoToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem addTextFileToLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem chooseLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem newLessonTSMI;
        private System.Windows.Forms.ToolStripMenuItem existingLessonTSMI;
    }
}