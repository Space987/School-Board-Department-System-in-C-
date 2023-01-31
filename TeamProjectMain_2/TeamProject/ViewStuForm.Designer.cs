namespace TeamProject
{
    partial class ViewStuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStuForm));
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.stuDataGrid = new System.Windows.Forms.DataGridView();
            this.idStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.TimeLB = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stuDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewStuLabel
            // 
            resources.ApplyResources(this.viewStuLabel, "viewStuLabel");
            this.viewStuLabel.Name = "viewStuLabel";
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.BackColor = System.Drawing.Color.OldLace;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
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
            // resetButton
            // 
            resources.ApplyResources(this.resetButton, "resetButton");
            this.resetButton.BackColor = System.Drawing.Color.OldLace;
            this.resetButton.Name = "resetButton";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.BackColor = System.Drawing.Color.OldLace;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.BackColor = System.Drawing.Color.OldLace;
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TimeLB
            // 
            resources.ApplyResources(this.TimeLB, "TimeLB");
            this.TimeLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLB.Name = "TimeLB";
            // 
            // DateLB
            // 
            resources.ApplyResources(this.DateLB, "DateLB");
            this.DateLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateLB.Name = "DateLB";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.BackColor = System.Drawing.Color.OldLace;
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.BackColor = System.Drawing.Color.OldLace;
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // ViewStuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stuDataGrid);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewStuLabel);
            this.Name = "ViewStuForm";
            this.Load += new System.EventHandler(this.ViewStuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView stuDataGrid;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceStu;
    }
}