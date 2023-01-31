﻿namespace TeamProject
{
    partial class ViewDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDepartmentForm));
            this.enterButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.DateLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.DepartmentDataGrid = new System.Windows.Forms.DataGridView();
            this.idStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.viewStuLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGrid)).BeginInit();
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
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.BackColor = System.Drawing.Color.OldLace;
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
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
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.BackColor = System.Drawing.Color.OldLace;
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            // DepartmentDataGrid
            // 
            resources.ApplyResources(this.DepartmentDataGrid, "DepartmentDataGrid");
            this.DepartmentDataGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.DepartmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStu,
            this.nameStu});
            this.DepartmentDataGrid.Name = "DepartmentDataGrid";
            this.DepartmentDataGrid.ReadOnly = true;
            this.DepartmentDataGrid.RowTemplate.Height = 24;
            this.DepartmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkDetailsButton
            // 
            resources.ApplyResources(this.checkDetailsButton, "checkDetailsButton");
            this.checkDetailsButton.BackColor = System.Drawing.Color.OldLace;
            this.checkDetailsButton.Name = "checkDetailsButton";
            this.checkDetailsButton.UseVisualStyleBackColor = false;
            this.checkDetailsButton.Click += new System.EventHandler(this.checkDetailsButton_Click);
            // 
            // ViewDepartmentForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.checkDetailsButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.DepartmentDataGrid);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.viewStuLabel);
            this.Name = "ViewDepartmentForm";
            this.Load += new System.EventHandler(this.ViewDeptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView DepartmentDataGrid;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label viewStuLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStu;
        private System.Windows.Forms.Button checkDetailsButton;
    }
}