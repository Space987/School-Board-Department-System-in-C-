namespace TeamProject
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.addDeanBtn = new System.Windows.Forms.Button();
            this.viewDeptBtn = new System.Windows.Forms.Button();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDeanBtn
            // 
            resources.ApplyResources(this.addDeanBtn, "addDeanBtn");
            this.addDeanBtn.Name = "addDeanBtn";
            this.addDeanBtn.UseVisualStyleBackColor = true;
            this.addDeanBtn.Click += new System.EventHandler(this.addDeanBtn_Click);
            // 
            // viewDeptBtn
            // 
            resources.ApplyResources(this.viewDeptBtn, "viewDeptBtn");
            this.viewDeptBtn.Name = "viewDeptBtn";
            this.viewDeptBtn.UseVisualStyleBackColor = true;
            this.viewDeptBtn.Click += new System.EventHandler(this.viewDeptBtn_Click);
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
            // DepartmentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.addDeanBtn);
            this.Controls.Add(this.viewDeptBtn);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.backBtn);
            this.Name = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDeanBtn;
        private System.Windows.Forms.Button viewDeptBtn;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button openButton;
    }
}