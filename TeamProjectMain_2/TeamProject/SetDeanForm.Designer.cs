namespace TeamProject
{
    partial class SetDeanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetDeanForm));
            this.enterButton = new System.Windows.Forms.Button();
            this.DateLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.teachDataGrid = new System.Windows.Forms.DataGridView();
            this.idStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptChoiceStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.BackColor = System.Drawing.Color.OldLace;
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
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
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.BackColor = System.Drawing.Color.OldLace;
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // teachDataGrid
            // 
            resources.ApplyResources(this.teachDataGrid, "teachDataGrid");
            this.teachDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.teachDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStu,
            this.nameStu,
            this.ageStu,
            this.genderStu,
            this.courseStu,
            this.courseStu1,
            this.teachSalary,
            this.deptChoiceStu,
            this.Dean});
            this.teachDataGrid.Name = "teachDataGrid";
            this.teachDataGrid.ReadOnly = true;
            this.teachDataGrid.RowTemplate.Height = 24;
            this.teachDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // courseStu1
            // 
            resources.ApplyResources(this.courseStu1, "courseStu1");
            this.courseStu1.Name = "courseStu1";
            this.courseStu1.ReadOnly = true;
            // 
            // teachSalary
            // 
            resources.ApplyResources(this.teachSalary, "teachSalary");
            this.teachSalary.Name = "teachSalary";
            this.teachSalary.ReadOnly = true;
            // 
            // deptChoiceStu
            // 
            resources.ApplyResources(this.deptChoiceStu, "deptChoiceStu");
            this.deptChoiceStu.Name = "deptChoiceStu";
            this.deptChoiceStu.ReadOnly = true;
            // 
            // Dean
            // 
            resources.ApplyResources(this.Dean, "Dean");
            this.Dean.Name = "Dean";
            this.Dean.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.BackColor = System.Drawing.Color.OldLace;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SetDeanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.teachDataGrid);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewStuLabel);
            this.Name = "SetDeanForm";
            this.Load += new System.EventHandler(this.SetDeanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView teachDataGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseStu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptChoiceStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dean;
        private System.Windows.Forms.Button deleteButton;
    }
}