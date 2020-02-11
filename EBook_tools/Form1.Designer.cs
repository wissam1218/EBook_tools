namespace EBook_tools
{
    partial class Form1
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
            this.ViewBtn = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(12, 56);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(152, 39);
            this.ViewBtn.TabIndex = 1;
            this.ViewBtn.Text = "View a pdf";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(12, 124);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(152, 39);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Pre/Post tests";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit PDF";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ViewBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button button5;
    }
}

