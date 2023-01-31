namespace TeamProject
{
    partial class ViewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStaff));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StaffDataGrid = new System.Windows.Forms.DataGridView();
            this.idStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workloadStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).BeginInit();
            this.SuspendLayout();
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.OldLace;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ViewStaff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StaffDataGrid);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewStuLabel);
            this.Name = "ViewStaff";
            this.Load += new System.EventHandler(this.ViewStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView StaffDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn workloadStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceStaff;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}