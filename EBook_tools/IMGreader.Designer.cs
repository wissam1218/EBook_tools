namespace EBook_tools
{
    partial class IMGreader
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
            this.AddIMG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddIMG
            // 
            this.AddIMG.Location = new System.Drawing.Point(67, 129);
            this.AddIMG.Name = "AddIMG";
            this.AddIMG.Size = new System.Drawing.Size(75, 23);
            this.AddIMG.TabIndex = 0;
            this.AddIMG.Text = "Add Image";
            this.AddIMG.UseVisualStyleBackColor = true;
            // 
            // IMGreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.AddIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IMGreader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select an Image";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddIMG;
    }
}

