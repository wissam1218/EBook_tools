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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMGreader));
            this.AddIMG = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.picConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // AddIMG
            // 
            this.AddIMG.Location = new System.Drawing.Point(25, 57);
            this.AddIMG.Name = "AddIMG";
            this.AddIMG.Size = new System.Drawing.Size(105, 29);
            this.AddIMG.TabIndex = 0;
            this.AddIMG.Text = "Add Image";
            this.AddIMG.UseVisualStyleBackColor = true;
            this.AddIMG.Click += new System.EventHandler(this.AddIMG_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Location = new System.Drawing.Point(196, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(376, 337);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // picConfirm
            // 
            this.picConfirm.Location = new System.Drawing.Point(25, 248);
            this.picConfirm.Name = "picConfirm";
            this.picConfirm.Size = new System.Drawing.Size(105, 29);
            this.picConfirm.TabIndex = 2;
            this.picConfirm.Text = "Confirm";
            this.picConfirm.UseVisualStyleBackColor = true;
            this.picConfirm.Click += new System.EventHandler(this.picConfirm_Click);
            // 
            // IMGreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.picConfirm);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.AddIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IMGreader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select an Image";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IMGreader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddIMG;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button picConfirm;
    }
}

