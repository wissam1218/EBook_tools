namespace EBook_tools
{
    partial class PDFView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFView));
            this.pdf = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // pdf
            // 
            this.pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdf.Enabled = true;
            this.pdf.Location = new System.Drawing.Point(0, 0);
            this.pdf.Margin = new System.Windows.Forms.Padding(2);
            this.pdf.Name = "pdf";
            this.pdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf.OcxState")));
            this.pdf.Size = new System.Drawing.Size(584, 361);
            this.pdf.TabIndex = 0;
            this.pdf.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDFView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDFView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " PDF Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdf;
        private System.Windows.Forms.Button button1;
    }
}