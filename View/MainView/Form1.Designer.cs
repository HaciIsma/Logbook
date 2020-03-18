namespace Logbook.View
{
    partial class Form1
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
            this.headControl1 = new Logbook.View.HeadControl();
            this.studentControl1 = new Logbook.View.StudentControl();
            this.SuspendLayout();
            // 
            // headControl1
            // 
            this.headControl1.BackColor = System.Drawing.Color.White;
            this.headControl1.Location = new System.Drawing.Point(0, 23);
            this.headControl1.Name = "headControl1";
            this.headControl1.Size = new System.Drawing.Size(900, 50);
            this.headControl1.TabIndex = 0;
            // 
            // studentControl1
            // 
            this.studentControl1.BackColor = System.Drawing.Color.White;
            this.studentControl1.Location = new System.Drawing.Point(0, 79);
            this.studentControl1.Name = "studentControl1";
            this.studentControl1.Size = new System.Drawing.Size(900, 75);
            this.studentControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 655);
            this.Controls.Add(this.studentControl1);
            this.Controls.Add(this.headControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.ResumeLayout(false);

        }

        #endregion

        private HeadControl headControl1;
        private StudentControl studentControl1;
    }
}