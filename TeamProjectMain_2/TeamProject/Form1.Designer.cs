namespace TeamProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.stuBtn = new System.Windows.Forms.Button();
            this.teachBtn = new System.Windows.Forms.Button();
            this.deptBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LanguagecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DepartmentLabel
            // 
            resources.ApplyResources(this.DepartmentLabel, "DepartmentLabel");
            this.DepartmentLabel.Name = "DepartmentLabel";
            // 
            // stuBtn
            // 
            resources.ApplyResources(this.stuBtn, "stuBtn");
            this.stuBtn.BackColor = System.Drawing.Color.OldLace;
            this.stuBtn.Name = "stuBtn";
            this.stuBtn.UseVisualStyleBackColor = false;
            this.stuBtn.Click += new System.EventHandler(this.stuBtn_Click);
            // 
            // teachBtn
            // 
            resources.ApplyResources(this.teachBtn, "teachBtn");
            this.teachBtn.BackColor = System.Drawing.Color.OldLace;
            this.teachBtn.Name = "teachBtn";
            this.teachBtn.UseVisualStyleBackColor = false;
            this.teachBtn.Click += new System.EventHandler(this.teachBtn_Click);
            // 
            // deptBtn
            // 
            resources.ApplyResources(this.deptBtn, "deptBtn");
            this.deptBtn.BackColor = System.Drawing.Color.OldLace;
            this.deptBtn.Name = "deptBtn";
            this.deptBtn.UseVisualStyleBackColor = false;
            this.deptBtn.Click += new System.EventHandler(this.deptBtn_Click);
            // 
            // staffBtn
            // 
            resources.ApplyResources(this.staffBtn, "staffBtn");
            this.staffBtn.BackColor = System.Drawing.Color.OldLace;
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.OldLace;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LanguagecomboBox
            // 
            resources.ApplyResources(this.LanguagecomboBox, "LanguagecomboBox");
            this.LanguagecomboBox.FormattingEnabled = true;
            this.LanguagecomboBox.Items.AddRange(new object[] {
            resources.GetString("LanguagecomboBox.Items"),
            resources.GetString("LanguagecomboBox.Items1"),
            resources.GetString("LanguagecomboBox.Items2")});
            this.LanguagecomboBox.Name = "LanguagecomboBox";
            this.LanguagecomboBox.SelectedIndexChanged += new System.EventHandler(this.LanguagecomboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.LanguagecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.deptBtn);
            this.Controls.Add(this.teachBtn);
            this.Controls.Add(this.stuBtn);
            this.Controls.Add(this.DepartmentLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Button stuBtn;
        private System.Windows.Forms.Button teachBtn;
        private System.Windows.Forms.Button deptBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LanguagecomboBox;
    }
}

