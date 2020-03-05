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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            // 
            // CreateCurric
            // 
            this.CreateCurric.Location = new System.Drawing.Point(87, 132);
            this.CreateCurric.Name = "CreateCurric";
            this.CreateCurric.Size = new System.Drawing.Size(108, 23);
            this.CreateCurric.TabIndex = 1;
            this.CreateCurric.Text = "Create Curriculum";
            this.CreateCurric.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(237, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Open Exisiting Curriculum";
            // 
            // OpeningPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 265);
            this.Controls.Add(this.comboBox2);
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
        private System.Windows.Forms.ComboBox comboBox2;
    }
}