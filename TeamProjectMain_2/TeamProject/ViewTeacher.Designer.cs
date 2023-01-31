namespace TeamProject
{
    partial class ViewTeacher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTeacher));
            this.teachDataGrid = new System.Windows.Forms.DataGridView();
            this.idTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceTeach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enterButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teachDataGrid
            // 
            resources.ApplyResources(this.teachDataGrid, "teachDataGrid");
            this.teachDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.teachDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeach,
            this.nameTeach,
            this.ageTeach,
            this.genderTeach,
            this.courseTeach,
            this.specialtyTeach,
            this.salaryTeach,
            this.deptChoiceTeach,
            this.isDean});
            this.teachDataGrid.Name = "teachDataGrid";
            this.teachDataGrid.ReadOnly = true;
            this.teachDataGrid.RowTemplate.Height = 24;
            this.teachDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idTeach
            // 
            resources.ApplyResources(this.idTeach, "idTeach");
            this.idTeach.Name = "idTeach";
            this.idTeach.ReadOnly = true;
            // 
            // nameTeach
            // 
            resources.ApplyResources(this.nameTeach, "nameTeach");
            this.nameTeach.Name = "nameTeach";
            this.nameTeach.ReadOnly = true;
            // 
            // ageTeach
            // 
            resources.ApplyResources(this.ageTeach, "ageTeach");
            this.ageTeach.Name = "ageTeach";
            this.ageTeach.ReadOnly = true;
            // 
            // genderTeach
            // 
            resources.ApplyResources(this.genderTeach, "genderTeach");
            this.genderTeach.Name = "genderTeach";
            this.genderTeach.ReadOnly = true;
            // 
            // courseTeach
            // 
            resources.ApplyResources(this.courseTeach, "courseTeach");
            this.courseTeach.Name = "courseTeach";
            this.courseTeach.ReadOnly = true;
            // 
            // specialtyTeach
            // 
            resources.ApplyResources(this.specialtyTeach, "specialtyTeach");
            this.specialtyTeach.Name = "specialtyTeach";
            this.specialtyTeach.ReadOnly = true;
            // 
            // salaryTeach
            // 
            resources.ApplyResources(this.salaryTeach, "salaryTeach");
            this.salaryTeach.Name = "salaryTeach";
            this.salaryTeach.ReadOnly = true;
            // 
            // deptChoiceTeach
            // 
            resources.ApplyResources(this.deptChoiceTeach, "deptChoiceTeach");
            this.deptChoiceTeach.Name = "deptChoiceTeach";
            this.deptChoiceTeach.ReadOnly = true;
            // 
            // isDean
            // 
            resources.ApplyResources(this.isDean, "isDean");
            this.isDean.Name = "isDean";
            this.isDean.ReadOnly = true;
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.BackColor = System.Drawing.Color.OldLace;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // viewStuLabel
            // 
            resources.ApplyResources(this.viewStuLabel, "viewStuLabel");
            this.viewStuLabel.Name = "viewStuLabel";
            // 
            // DateLB
            // 
            resources.ApplyResources(this.DateLB, "DateLB");
            this.DateLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateLB.Name = "DateLB";
            // 
            // TimeLB
            // 
            resources.ApplyResources(this.TimeLB, "TimeLB");
            this.TimeLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLB.Name = "TimeLB";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.BackColor = System.Drawing.Color.OldLace;
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click_1);
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.BackColor = System.Drawing.Color.OldLace;
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.OldLace;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.BackColor = System.Drawing.Color.OldLace;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.BackColor = System.Drawing.Color.OldLace;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ViewTeacher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.teachDataGrid);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewStuLabel);
            this.Name = "ViewTeacher";
            this.Load += new System.EventHandler(this.ViewTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView teachDataGrid;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceTeach;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDean;
    }
}