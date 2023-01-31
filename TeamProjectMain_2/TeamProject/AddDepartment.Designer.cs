namespace TeamProject
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.enterButton = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.deptDescriptiontb = new System.Windows.Forms.TextBox();
            this.deptIDtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backbtn
            // 
            resources.ApplyResources(this.backbtn, "backbtn");
            this.backbtn.Name = "backbtn";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // deptDescriptiontb
            // 
            resources.ApplyResources(this.deptDescriptiontb, "deptDescriptiontb");
            this.deptDescriptiontb.Name = "deptDescriptiontb";
            // 
            // deptIDtb
            // 
            resources.ApplyResources(this.deptIDtb, "deptIDtb");
            this.deptIDtb.Name = "deptIDtb";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // viewStuLabel
            // 
            resources.ApplyResources(this.viewStuLabel, "viewStuLabel");
            this.viewStuLabel.Name = "viewStuLabel";
            // 
            // AddDepartment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.viewStuLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deptDescriptiontb);
            this.Controls.Add(this.deptIDtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox deptDescriptiontb;
        private System.Windows.Forms.TextBox deptIDtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label viewStuLabel;
    }
}