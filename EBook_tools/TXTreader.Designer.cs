namespace EBook_tools
{
    partial class TXTreader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TXTreader));
            this.openBtn = new System.Windows.Forms.Button();
            this.textLBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openBtn.Location = new System.Drawing.Point(8, 8);
            this.openBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(127, 27);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "&Open File";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // textLBox
            // 
            this.textLBox.FormattingEnabled = true;
            this.textLBox.Location = new System.Drawing.Point(8, 49);
            this.textLBox.Margin = new System.Windows.Forms.Padding(2);
            this.textLBox.Name = "textLBox";
            this.textLBox.ScrollAlwaysVisible = true;
            this.textLBox.Size = new System.Drawing.Size(565, 303);
            this.textLBox.TabIndex = 4;
            // 
            // TXTreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.textLBox);
            this.Controls.Add(this.openBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TXTreader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open or Create TXT File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TXTreader_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.ListBox textLBox;
    }
}