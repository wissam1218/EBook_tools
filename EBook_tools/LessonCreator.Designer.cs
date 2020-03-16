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
            this.components = new System.ComponentModel.Container();
            this.viewPDFBtn = new System.Windows.Forms.Button();
            this.testsMenuBtn = new System.Windows.Forms.Button();
            this.editPDFBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picButton = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
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
            this.toolTip1.SetToolTip(this.testsMenuBtn, "Create a Pretest or Posttest for your lesson");
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
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(761, 411);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picButton
            // 
            this.picButton.Location = new System.Drawing.Point(65, 359);
            this.picButton.Name = "picButton";
            this.picButton.Size = new System.Drawing.Size(101, 25);
            this.picButton.TabIndex = 7;
            this.picButton.Text = "Upload Image";
            this.picButton.UseVisualStyleBackColor = true;
            this.picButton.Click += new System.EventHandler(this.picButton_Click);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(51, 193);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(129, 122);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 8;
            this.image1.TabStop = false;
            // 
            // LessonCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 446);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.picButton);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.editPDFBtn);
            this.Controls.Add(this.testsMenuBtn);
            this.Controls.Add(this.viewPDFBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LessonCreator";
            this.Text = "Lesson Creator";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewPDFBtn;
        private System.Windows.Forms.Button testsMenuBtn;
        private System.Windows.Forms.Button editPDFBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button picButton;
        private System.Windows.Forms.PictureBox image1;
    }
}

