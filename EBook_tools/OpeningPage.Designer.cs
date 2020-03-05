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
            this.CreateClass = new System.Windows.Forms.Button();
            this.CreateCurric = new System.Windows.Forms.Button();
            this.ChooseClassroom = new System.Windows.Forms.ComboBox();
            this.ChooseCurric = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateClass
            // 
            this.CreateClass.Location = new System.Drawing.Point(87, 86);
            this.CreateClass.Name = "CreateClass";
            this.CreateClass.Size = new System.Drawing.Size(108, 23);
            this.CreateClass.TabIndex = 0;
            this.CreateClass.Text = "Create Classroom";
            this.CreateClass.UseVisualStyleBackColor = true;
            this.CreateClass.Click += new System.EventHandler(this.CreateClass_Click);
            // 
            // CreateCurric
            // 
            this.CreateCurric.Location = new System.Drawing.Point(87, 132);
            this.CreateCurric.Name = "CreateCurric";
            this.CreateCurric.Size = new System.Drawing.Size(108, 23);
            this.CreateCurric.TabIndex = 1;
            this.CreateCurric.Text = "Create Curriculum";
            this.CreateCurric.UseVisualStyleBackColor = true;
            this.CreateCurric.Click += new System.EventHandler(this.CreateCurric_Click);
            // 
            // ChooseClassroom
            // 
            this.ChooseClassroom.FormattingEnabled = true;
            this.ChooseClassroom.Location = new System.Drawing.Point(237, 88);
            this.ChooseClassroom.Name = "ChooseClassroom";
            this.ChooseClassroom.Size = new System.Drawing.Size(154, 21);
            this.ChooseClassroom.TabIndex = 2;
            this.ChooseClassroom.Text = "Open Existing Classroom";
            // 
            // ChooseCurric
            // 
            this.ChooseCurric.FormattingEnabled = true;
            this.ChooseCurric.Location = new System.Drawing.Point(237, 134);
            this.ChooseCurric.Name = "ChooseCurric";
            this.ChooseCurric.Size = new System.Drawing.Size(154, 21);
            this.ChooseCurric.TabIndex = 3;
            this.ChooseCurric.Text = "Open Exisiting Curriculum";
            // 
            // OpeningPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ChooseCurric);
            this.Controls.Add(this.ChooseClassroom);
            this.Controls.Add(this.CreateCurric);
            this.Controls.Add(this.CreateClass);
            this.Name = "OpeningPage";
            this.Text = "Welcome!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateClass;
        private System.Windows.Forms.Button CreateCurric;
        private System.Windows.Forms.ComboBox ChooseClassroom;
        private System.Windows.Forms.ComboBox ChooseCurric;
    }
}