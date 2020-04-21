namespace EBook_tools
{
    partial class VIDreader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIDreader));
            this.buttonGroup = new System.Windows.Forms.GroupBox();
            this.vidConfirm = new System.Windows.Forms.Button();
            this.vidPause = new System.Windows.Forms.Button();
            this.vidStop = new System.Windows.Forms.Button();
            this.vidPlay = new System.Windows.Forms.Button();
            this.vidChooseFile = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroup
            // 
            this.buttonGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGroup.BackColor = System.Drawing.Color.Lavender;
            this.buttonGroup.Controls.Add(this.vidConfirm);
            this.buttonGroup.Controls.Add(this.vidPause);
            this.buttonGroup.Controls.Add(this.vidStop);
            this.buttonGroup.Controls.Add(this.vidPlay);
            this.buttonGroup.Controls.Add(this.vidChooseFile);
            this.buttonGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGroup.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(82, 361);
            this.buttonGroup.TabIndex = 3;
            this.buttonGroup.TabStop = false;
            // 
            // vidConfirm
            // 
            this.vidConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.vidConfirm.Location = new System.Drawing.Point(3, 284);
            this.vidConfirm.Name = "vidConfirm";
            this.vidConfirm.Size = new System.Drawing.Size(76, 67);
            this.vidConfirm.TabIndex = 4;
            this.vidConfirm.Text = "Confirm";
            this.vidConfirm.UseVisualStyleBackColor = true;
            this.vidConfirm.Click += new System.EventHandler(this.vidConfirm_Click);
            // 
            // vidPause
            // 
            this.vidPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.vidPause.Location = new System.Drawing.Point(3, 217);
            this.vidPause.Name = "vidPause";
            this.vidPause.Size = new System.Drawing.Size(76, 67);
            this.vidPause.TabIndex = 3;
            this.vidPause.Text = "Pause";
            this.vidPause.UseVisualStyleBackColor = true;
            this.vidPause.Click += new System.EventHandler(this.vidPause_Click);
            // 
            // vidStop
            // 
            this.vidStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.vidStop.Location = new System.Drawing.Point(3, 150);
            this.vidStop.Name = "vidStop";
            this.vidStop.Size = new System.Drawing.Size(76, 67);
            this.vidStop.TabIndex = 2;
            this.vidStop.Text = "Stop";
            this.vidStop.UseVisualStyleBackColor = true;
            this.vidStop.Click += new System.EventHandler(this.vidStop_Click);
            // 
            // vidPlay
            // 
            this.vidPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vidPlay.BackgroundImage")));
            this.vidPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vidPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.vidPlay.Location = new System.Drawing.Point(3, 83);
            this.vidPlay.Name = "vidPlay";
            this.vidPlay.Size = new System.Drawing.Size(76, 67);
            this.vidPlay.TabIndex = 1;
            this.vidPlay.Text = "Play";
            this.vidPlay.UseVisualStyleBackColor = true;
            this.vidPlay.Click += new System.EventHandler(this.vidPlay_Click);
            // 
            // vidChooseFile
            // 
            this.vidChooseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidChooseFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.vidChooseFile.Location = new System.Drawing.Point(3, 16);
            this.vidChooseFile.Name = "vidChooseFile";
            this.vidChooseFile.Size = new System.Drawing.Size(76, 67);
            this.vidChooseFile.TabIndex = 0;
            this.vidChooseFile.Text = "Choose File";
            this.vidChooseFile.UseVisualStyleBackColor = true;
            this.vidChooseFile.Click += new System.EventHandler(this.vidChooseFile_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(88, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(484, 339);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // VIDreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VIDreader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open Video File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.buttonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox buttonGroup;
        private System.Windows.Forms.Button vidPause;
        private System.Windows.Forms.Button vidStop;
        private System.Windows.Forms.Button vidPlay;
        private System.Windows.Forms.Button vidChooseFile;
        private System.Windows.Forms.Button vidConfirm;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}