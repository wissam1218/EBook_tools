namespace EBook_tools
{
    partial class OpeningPage
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
            this.chooseClassBtn = new System.Windows.Forms.Button();
            this.chooseCurricBtn = new System.Windows.Forms.Button();
            this.chooseClassCBox = new System.Windows.Forms.ComboBox();
            this.chooseCurricCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseClassBtn
            // 
            this.chooseClassBtn.Location = new System.Drawing.Point(87, 86);
            this.chooseClassBtn.Name = "chooseClassBtn";
            this.chooseClassBtn.Size = new System.Drawing.Size(108, 23);
            this.chooseClassBtn.TabIndex = 0;
            this.chooseClassBtn.Text = "Create Classroom";
            this.chooseClassBtn.UseVisualStyleBackColor = true;
            this.chooseClassBtn.Click += new System.EventHandler(this.chooseClassBtn_Click);
            // 
            // chooseCurricBtn
            // 
            this.chooseCurricBtn.Location = new System.Drawing.Point(87, 132);
            this.chooseCurricBtn.Name = "chooseCurricBtn";
            this.chooseCurricBtn.Size = new System.Drawing.Size(108, 23);
            this.chooseCurricBtn.TabIndex = 1;
            this.chooseCurricBtn.Text = "Create Curriculum";
            this.chooseCurricBtn.UseVisualStyleBackColor = true;
            this.chooseCurricBtn.Click += new System.EventHandler(this.chooseCurricBtn_Click);
            // 
            // chooseClassCBox
            // 
            this.chooseClassCBox.FormattingEnabled = true;
            this.chooseClassCBox.Location = new System.Drawing.Point(237, 88);
            this.chooseClassCBox.Name = "chooseClassCBox";
            this.chooseClassCBox.Size = new System.Drawing.Size(154, 21);
            this.chooseClassCBox.TabIndex = 2;
            this.chooseClassCBox.Text = "Open Existing Classroom";
            // 
            // chooseCurricCBox
            // 
            this.chooseCurricCBox.FormattingEnabled = true;
            this.chooseCurricCBox.Location = new System.Drawing.Point(237, 134);
            this.chooseCurricCBox.Name = "chooseCurricCBox";
            this.chooseCurricCBox.Size = new System.Drawing.Size(154, 21);
            this.chooseCurricCBox.TabIndex = 3;
            this.chooseCurricCBox.Text = "Open Exisiting Curriculum";
            // 
            // OpeningPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.chooseCurricCBox);
            this.Controls.Add(this.chooseClassCBox);
            this.Controls.Add(this.chooseCurricBtn);
            this.Controls.Add(this.chooseClassBtn);
            this.Name = "OpeningPage";
            this.Text = "Welcome!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseClassBtn;
        private System.Windows.Forms.Button chooseCurricBtn;
        private System.Windows.Forms.ComboBox chooseClassCBox;
        private System.Windows.Forms.ComboBox chooseCurricCBox;
    }
}