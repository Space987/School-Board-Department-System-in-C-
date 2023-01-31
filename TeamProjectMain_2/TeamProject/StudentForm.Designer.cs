namespace TeamProject
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.addStuBtn = new System.Windows.Forms.Button();
            this.viewStuBtn = new System.Windows.Forms.Button();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStuBtn
            // 
            resources.ApplyResources(this.addStuBtn, "addStuBtn");
            this.addStuBtn.Name = "addStuBtn";
            this.addStuBtn.UseVisualStyleBackColor = true;
            this.addStuBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // viewStuBtn
            // 
            resources.ApplyResources(this.viewStuBtn, "viewStuBtn");
            this.viewStuBtn.Name = "viewStuBtn";
            this.viewStuBtn.UseVisualStyleBackColor = true;
            this.viewStuBtn.Click += new System.EventHandler(this.viewStuBtn_Click);
            // 
            // StudentLabel
            // 
            resources.ApplyResources(this.StudentLabel, "StudentLabel");
            this.StudentLabel.Name = "StudentLabel";
            // 
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // openButton
            // 
            resources.ApplyResources(this.openButton, "openButton");
            this.openButton.Name = "openButton";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // StudentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addStuBtn);
            this.Controls.Add(this.viewStuBtn);
            this.Controls.Add(this.StudentLabel);
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addStuBtn;
        private System.Windows.Forms.Button viewStuBtn;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button openButton;
    }
}