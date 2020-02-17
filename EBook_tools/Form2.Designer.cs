namespace EBook_tools
{
    partial class Form2
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
            this.button1.Location = new System.Drawing.Point(195, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a pre-test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pstBtn
            // 
            this.pstBtn.Location = new System.Drawing.Point(396, 204);
            this.pstBtn.Name = "pstBtn";
            this.pstBtn.Size = new System.Drawing.Size(195, 41);
            this.pstBtn.TabIndex = 1;
            this.pstBtn.Text = "Create a post-test";
            this.pstBtn.UseVisualStyleBackColor = true;
            this.pstBtn.Click += new System.EventHandler(this.pstBtn_Click);
            // 
            // txtButton
            // 
            this.txtButton.Location = new System.Drawing.Point(305, 397);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(195, 41);
            this.txtButton.TabIndex = 2;
            this.txtButton.Text = "&Open a TXT file";
            this.txtButton.UseVisualStyleBackColor = true;
            this.txtButton.Click += new System.EventHandler(this.txtButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtButton);
            this.Controls.Add(this.pstBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pstBtn;
        private System.Windows.Forms.Button txtButton;
    }
}