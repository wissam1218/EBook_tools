namespace EBook_tools
{
    partial class AddToLesson
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
            this.button1 = new System.Windows.Forms.Button();
            this.pstBtn = new System.Windows.Forms.Button();
            this.txtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a pre-test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pstBtn
            // 
            this.pstBtn.Location = new System.Drawing.Point(264, 133);
            this.pstBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pstBtn.Name = "pstBtn";
            this.pstBtn.Size = new System.Drawing.Size(130, 27);
            this.pstBtn.TabIndex = 1;
            this.pstBtn.Text = "Create a post-test";
            this.pstBtn.UseVisualStyleBackColor = true;
            this.pstBtn.Click += new System.EventHandler(this.pstBtn_Click);
            // 
            // txtButton
            // 
            this.txtButton.Location = new System.Drawing.Point(203, 258);
            this.txtButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(130, 27);
            this.txtButton.TabIndex = 2;
            this.txtButton.Text = "&Open a TXT file";
            this.txtButton.UseVisualStyleBackColor = true;
            this.txtButton.Click += new System.EventHandler(this.txtButton_Click);
            // 
            // AddToLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txtButton);
            this.Controls.Add(this.pstBtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddToLesson";
            this.Text = "Add To Your Lesson";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pstBtn;
        private System.Windows.Forms.Button txtButton;
    }
}