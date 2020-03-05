namespace EBook_tools
{
    partial class CreateTest
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
            this.PreTestBtn = new System.Windows.Forms.Button();
            this.PostTestBtn = new System.Windows.Forms.Button();
            this.OpenTXTBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreTestBtn
            // 
            this.PreTestBtn.Location = new System.Drawing.Point(130, 133);
            this.PreTestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PreTestBtn.Name = "PreTestBtn";
            this.PreTestBtn.Size = new System.Drawing.Size(130, 27);
            this.PreTestBtn.TabIndex = 0;
            this.PreTestBtn.Text = "Create A Pre Test";
            this.PreTestBtn.UseVisualStyleBackColor = true;
            this.PreTestBtn.Click += new System.EventHandler(this.PreTestBtn_Click);
            // 
            // PostTestBtn
            // 
            this.PostTestBtn.Location = new System.Drawing.Point(264, 133);
            this.PostTestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PostTestBtn.Name = "PostTestBtn";
            this.PostTestBtn.Size = new System.Drawing.Size(130, 27);
            this.PostTestBtn.TabIndex = 1;
            this.PostTestBtn.Text = "Create A Post Test";
            this.PostTestBtn.UseVisualStyleBackColor = true;
            this.PostTestBtn.Click += new System.EventHandler(this.PostTestBtn_Click);
            // 
            // OpenTXTBtn
            // 
            this.OpenTXTBtn.Location = new System.Drawing.Point(203, 258);
            this.OpenTXTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OpenTXTBtn.Name = "OpenTXTBtn";
            this.OpenTXTBtn.Size = new System.Drawing.Size(130, 27);
            this.OpenTXTBtn.TabIndex = 2;
            this.OpenTXTBtn.Text = "&Open a TXT file";
            this.OpenTXTBtn.UseVisualStyleBackColor = true;
            this.OpenTXTBtn.Click += new System.EventHandler(this.OpenTXTBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(446, 257);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OpenTXTBtn);
            this.Controls.Add(this.PostTestBtn);
            this.Controls.Add(this.PreTestBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTest";
            this.Text = "Create Test";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PreTestBtn;
        private System.Windows.Forms.Button PostTestBtn;
        private System.Windows.Forms.Button OpenTXTBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}