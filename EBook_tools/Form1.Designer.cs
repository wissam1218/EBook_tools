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
            this.ViewPDFBtn = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.EditPDFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewPDFBtn
            // 
            this.ViewPDFBtn.Location = new System.Drawing.Point(387, 126);
            this.ViewPDFBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewPDFBtn.Name = "ViewPDFBtn";
            this.ViewPDFBtn.Size = new System.Drawing.Size(101, 25);
            this.ViewPDFBtn.TabIndex = 1;
            this.ViewPDFBtn.Text = "View a pdf";
            this.ViewPDFBtn.UseVisualStyleBackColor = true;
            this.ViewPDFBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(83, 126);
            this.TestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(101, 25);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Pre/Post tests";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditPDFBtn
            // 
            this.EditPDFBtn.Location = new System.Drawing.Point(240, 126);
            this.EditPDFBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPDFBtn.Name = "EditPDFBtn";
            this.EditPDFBtn.Size = new System.Drawing.Size(101, 25);
            this.EditPDFBtn.TabIndex = 4;
            this.EditPDFBtn.Text = "Edit PDF";
            this.EditPDFBtn.UseVisualStyleBackColor = true;
            // 
            // LessonCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.EditPDFBtn);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ViewPDFBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LessonCreator";
            this.Text = "Lesson Creator";
            this.Load += new System.EventHandler(this.LessonCreator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewPDFBtn;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button EditPDFBtn;
    }
}

