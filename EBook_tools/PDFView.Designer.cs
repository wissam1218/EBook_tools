﻿namespace EBook_tools
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
            this.pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf.Enabled = true;
            this.pdf.Location = new System.Drawing.Point(12, 77);
            this.pdf.Name = "pdf";
            this.pdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf.OcxState")));
            this.pdf.Size = new System.Drawing.Size(434, 370);
            this.pdf.TabIndex = 0;
            this.pdf.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDFView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdf);
            this.Name = "PDFView";
            this.Text = "PDFView";
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdf;
        private System.Windows.Forms.Button button1;
    }
}