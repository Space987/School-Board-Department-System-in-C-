namespace TeamProject
{
    partial class CheckDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckDetailsForm));
            this.StaffDataGrid = new System.Windows.Forms.DataGridView();
            this.idStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workloadStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDataGrid = new System.Windows.Forms.DataGridView();
            this.idStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffDataGrid
            // 
            resources.ApplyResources(this.StaffDataGrid, "StaffDataGrid");
            this.StaffDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.StaffDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStaff,
            this.nameStaff,
            this.ageStaff,
            this.genderStaff,
            this.dutyStaff,
            this.workloadStaff,
            this.salaryStaff,
            this.deptChoiceStaff});
            this.StaffDataGrid.Name = "StaffDataGrid";
            this.StaffDataGrid.ReadOnly = true;
            this.StaffDataGrid.RowTemplate.Height = 24;
            this.StaffDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idStaff
            // 
            resources.ApplyResources(this.idStaff, "idStaff");
            this.idStaff.Name = "idStaff";
            this.idStaff.ReadOnly = true;
            // 
            // nameStaff
            // 
            resources.ApplyResources(this.nameStaff, "nameStaff");
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.ReadOnly = true;
            // 
            // ageStaff
            // 
            resources.ApplyResources(this.ageStaff, "ageStaff");
            this.ageStaff.Name = "ageStaff";
            this.ageStaff.ReadOnly = true;
            // 
            // genderStaff
            // 
            resources.ApplyResources(this.genderStaff, "genderStaff");
            this.genderStaff.Name = "genderStaff";
            this.genderStaff.ReadOnly = true;
            // 
            // dutyStaff
            // 
            resources.ApplyResources(this.dutyStaff, "dutyStaff");
            this.dutyStaff.Name = "dutyStaff";
            this.dutyStaff.ReadOnly = true;
            // 
            // workloadStaff
            // 
            resources.ApplyResources(this.workloadStaff, "workloadStaff");
            this.workloadStaff.Name = "workloadStaff";
            this.workloadStaff.ReadOnly = true;
            // 
            // salaryStaff
            // 
            resources.ApplyResources(this.salaryStaff, "salaryStaff");
            this.salaryStaff.Name = "salaryStaff";
            this.salaryStaff.ReadOnly = true;
            // 
            // deptChoiceStaff
            // 
            resources.ApplyResources(this.deptChoiceStaff, "deptChoiceStaff");
            this.deptChoiceStaff.Name = "deptChoiceStaff";
            this.deptChoiceStaff.ReadOnly = true;
            // 
            // stuDataGrid
            // 
            resources.ApplyResources(this.stuDataGrid, "stuDataGrid");
            this.stuDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.stuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStu,
            this.nameStu,
            this.ageStu,
            this.genderStu,
            this.courseStu,
            this.semesterStu,
            this.deptChoiceStu});
            this.stuDataGrid.Name = "stuDataGrid";
            this.stuDataGrid.ReadOnly = true;
            this.stuDataGrid.RowTemplate.Height = 24;
            this.stuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // idStu
            // 
            resources.ApplyResources(this.idStu, "idStu");
            this.idStu.Name = "idStu";
            this.idStu.ReadOnly = true;
            // 
            // nameStu
            // 
            resources.ApplyResources(this.nameStu, "nameStu");
            this.nameStu.Name = "nameStu";
            this.nameStu.ReadOnly = true;
            // 
            // ageStu
            // 
            resources.ApplyResources(this.ageStu, "ageStu");
            this.ageStu.Name = "ageStu";
            this.ageStu.ReadOnly = true;
            // 
            // genderStu
            // 
            resources.ApplyResources(this.genderStu, "genderStu");
            this.genderStu.Name = "genderStu";
            this.genderStu.ReadOnly = true;
            // 
            // courseStu
            // 
            resources.ApplyResources(this.courseStu, "courseStu");
            this.courseStu.Name = "courseStu";
            this.courseStu.ReadOnly = true;
            // 
            // semesterStu
            // 
            resources.ApplyResources(this.semesterStu, "semesterStu");
            this.semesterStu.Name = "semesterStu";
            this.semesterStu.ReadOnly = true;
            // 
            // deptChoiceStu
            // 
            resources.ApplyResources(this.deptChoiceStu, "deptChoiceStu");
            this.deptChoiceStu.Name = "deptChoiceStu";
            this.deptChoiceStu.ReadOnly = true;
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
            // viewStuLabel
            // 
            resources.ApplyResources(this.viewStuLabel, "viewStuLabel");
            this.viewStuLabel.Name = "viewStuLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CheckDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewStuLabel);
            this.Controls.Add(this.teachDataGrid);
            this.Controls.Add(this.stuDataGrid);
            this.Controls.Add(this.StaffDataGrid);
            this.Name = "CheckDetailsForm";
            this.Load += new System.EventHandler(this.CheckDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn workloadStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceStaff;
        private System.Windows.Forms.DataGridView stuDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceStu;
        private System.Windows.Forms.DataGridView teachDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceTeach;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDean;
        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}