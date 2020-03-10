namespace EBook_tools
{
    partial class LessonCreator
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
            this.viewPDFBtn = new System.Windows.Forms.Button();
            this.testsMenuBtn = new System.Windows.Forms.Button();
            this.editPDFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewPDFBtn
            // 
            this.viewPDFBtn.Location = new System.Drawing.Point(387, 126);
            this.viewPDFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewPDFBtn.Name = "viewPDFBtn";
            this.viewPDFBtn.Size = new System.Drawing.Size(101, 25);
            this.viewPDFBtn.TabIndex = 1;
            this.viewPDFBtn.Text = "View a pdf";
            this.viewPDFBtn.UseVisualStyleBackColor = true;
            this.viewPDFBtn.Click += new System.EventHandler(this.viewPDFBtn_Click);
            // 
            // testsMenuBtn
            // 
            this.testsMenuBtn.Location = new System.Drawing.Point(65, 126);
            this.testsMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.testsMenuBtn.Name = "testsMenuBtn";
            this.testsMenuBtn.Size = new System.Drawing.Size(101, 25);
            this.testsMenuBtn.TabIndex = 2;
            this.testsMenuBtn.Text = "Pre/Post tests";
            this.testsMenuBtn.UseVisualStyleBackColor = true;
            this.testsMenuBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // editPDFBtn
            // 
            this.editPDFBtn.Location = new System.Drawing.Point(228, 126);
            this.editPDFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editPDFBtn.Name = "editPDFBtn";
            this.editPDFBtn.Size = new System.Drawing.Size(101, 25);
            this.editPDFBtn.TabIndex = 4;
            this.editPDFBtn.Text = "Edit PDF";
            this.editPDFBtn.UseVisualStyleBackColor = true;
            this.editPDFBtn.Click += new System.EventHandler(this.editPDFBtn_Click);
            // 
            // LessonCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.ControlBox = false;
            this.Controls.Add(this.editPDFBtn);
            this.Controls.Add(this.testsMenuBtn);
            this.Controls.Add(this.viewPDFBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lesson Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewPDFBtn;
        private System.Windows.Forms.Button testsMenuBtn;
        private System.Windows.Forms.Button editPDFBtn;
    }
}

