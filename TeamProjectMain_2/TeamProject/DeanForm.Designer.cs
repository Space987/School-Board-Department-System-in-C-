namespace TeamProject
{
    partial class DeanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeanForm));
            this.addDeanBtn = new System.Windows.Forms.Button();
            this.viewDeanBtn = new System.Windows.Forms.Button();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDeanBtn
            // 
            resources.ApplyResources(this.addDeanBtn, "addDeanBtn");
            this.addDeanBtn.Name = "addDeanBtn";
            this.addDeanBtn.UseVisualStyleBackColor = true;
            this.addDeanBtn.Click += new System.EventHandler(this.addDeanBtn_Click);
            // 
            // viewDeanBtn
            // 
            resources.ApplyResources(this.viewDeanBtn, "viewDeanBtn");
            this.viewDeanBtn.Name = "viewDeanBtn";
            this.viewDeanBtn.UseVisualStyleBackColor = true;
            this.viewDeanBtn.Click += new System.EventHandler(this.viewDeanBtn_Click);
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
            // DeanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.addDeanBtn);
            this.Controls.Add(this.viewDeanBtn);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.backBtn);
            this.Name = "DeanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDeanBtn;
        private System.Windows.Forms.Button viewDeanBtn;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Button backBtn;
    }
}