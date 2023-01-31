using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class ViewDepartmentForm : Form
    {
        bool stuOpen = StudentForm.wasOpen;
        bool teachOpen = TeacherForm.wasOpen;
        bool staffOpen = StaffForm.wasOpen;
        int language = Form1.language;


        string viewPath = DepartmentForm.path;
        bool resetCount = false;
        Department dept;
        int tmp;
        bool correctDept = false;
        DataGridViewRow correctDept2 = new DataGridViewRow();
        
        Department generalDept;


        public ViewDepartmentForm()
        {

            InitializeComponent();
            var changeLanguage = new ChangeLanguage();
            if (language == 0)
            {
                changeLanguage.UpdateConfig("language", "en");
            }
            if (language == 1)
            {
                changeLanguage.UpdateConfig("language", "fr-CA");
            }
            if (language == 2)
            {
                changeLanguage.UpdateConfig("language", "es");
            }

        }

        private void ViewDeptForm_Load(object sender, EventArgs e)
        {

            Department.DepartmentList.Clear();
            AddDepartments();

            timer1.Start();
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            DateLB.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void AddDepartments()
        {


            StreamReader stream = new StreamReader(viewPath);
            String str;

            while ((str = stream.ReadLine()) != null)
            {

                String[] deptdentLine = str.Split(',');
                Department dept = new Department(Int32.Parse(deptdentLine[0]), deptdentLine[1]);
                Department.DepartmentList.Add(dept);


            }

            AddDeptList();
            stream.Close();

        }

        public void AddDeptList()
        {

            for (int i = 0; Department.DepartmentList.Count > i; i++)
            {
                DepartmentDataGrid.Rows.Add();
                DepartmentDataGrid.Rows[i].Cells[0].Value = Department.DepartmentList[i].ID;
                DepartmentDataGrid.Rows[i].Cells[1].Value = Department.DepartmentList[i].Description;
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (resetCount)
            {

                MessageBox.Show("You must reset table first");
            }
            else
            {

                int searchCount = 0;

                try
                {
                    for (int i = 0; i < Department.DepartmentList.Count; i++)
                    {
                        if (searchTextBox.Text == Department.DepartmentList[i].ID.ToString())
                        {
                            for (int j = 0; j < DepartmentDataGrid.Rows.Count; j++)
                            {

                                if (Department.DepartmentList[i].ID.ToString() == DepartmentDataGrid.Rows[j].Cells[0].Value.ToString())
                                {


                                    DepartmentDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;

                                    MessageBox.Show(Department.DepartmentList[i].Description + " Department was found in the Database");

                                    searchCount++;


                                    correctDept = true;
                                    correctDept2 = DepartmentDataGrid.Rows[j];
                                    resetCount = true;

                                }
                            }
                        }
                    }

                    if (searchCount == 0)
                    {

                        MessageBox.Show("Department ID not Found");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DepartmentDataGrid.DefaultCellStyle.BackColor = Color.White;
            searchTextBox.Clear();
            DepartmentDataGrid.Rows.Clear();
            AddDeptList();
            resetCount = false;


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (correctDept)
            {

                DepartmentDataGrid.Rows.Remove(correctDept2);
                MessageBox.Show(correctDept2.Cells[1].Value.ToString() + " Department Removed");

            }

            for (int i = 0; Department.DepartmentList.Count > i; i++)

            {
                if (correctDept2.Cells[0].Value.ToString() == Department.DepartmentList[i].ID.ToString())
                {
                    Department.DepartmentList.RemoveAt(i);


                }

            }

            ClearDepartment(viewPath);
            for (int i = 0; Department.DepartmentList.Count > i; i++)
            {
                AppendToDepartment(Department.DepartmentList[i].toString(), viewPath);
            }

        }

        public void ClearDepartment(String fileName)
        {

            System.IO.File.WriteAllText(fileName, string.Empty);

        }

        public void AppendToDepartment(String data, String fileName)
        {

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(data);

            sw.Close();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm menu = new DepartmentForm();
            menu.Show();
        }



        private void updateButton_Click(object sender, EventArgs e)
        {


            if (correctDept)
            {

                for (int j = 0; j < DepartmentDataGrid.Rows.Count; j++)
                {

                    if (correctDept2.Cells[0].Value == DepartmentDataGrid.Rows[j].Cells[0].Value)
                    {
                        DepartmentDataGrid.ReadOnly = false;

                        break;


                    }
                }

                for (int i = 0; DepartmentDataGrid.Rows.Count > i; i++)
                {
                    if (DepartmentDataGrid.Rows[i].Cells[0].Value != correctDept2.Cells[0].Value)
                    {
                        DepartmentDataGrid.Rows[i].ReadOnly = true;

                    }

                    else
                    {
                        DepartmentDataGrid.Rows[i].Cells[0].ReadOnly = true;
                        continue;
                    }

                }
                MessageBox.Show(correctDept2.Cells[1].Value.ToString() + " Department Updated"); ;
            }

            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Department.DepartmentList.Count; i++)
            {
                if (searchTextBox.Text == Department.DepartmentList[i].ID.ToString())
                {
                    for (int j = 0; j < DepartmentDataGrid.Rows.Count; j++)
                    {

                        if (Department.DepartmentList[i].ID.ToString() == DepartmentDataGrid.Rows[j].Cells[0].Value.ToString())
                        {

                            Department.DepartmentList[i].Description = correctDept2.Cells[1].Value.ToString();


                            DepartmentDataGrid.ReadOnly = true;
                            break;

                        }
                    }
                }
            }

            ClearDepartment(viewPath);
            for (int i = 0; Department.DepartmentList.Count > i; i++)
            {
                AppendToDepartment(Department.DepartmentList[i].toString(), viewPath);

            }
        }

        private void checkDetailsButton_Click(object sender, EventArgs e)
        {
            if (stuOpen && staffOpen && teachOpen)
            {
                if (correctDept == true)
                {
                    this.Hide();
                    CheckDetailsForm menu = new CheckDetailsForm(Int32.Parse(correctDept2.Cells[0].Value.ToString()));
                    menu.Show();
                }

                else
                {

                    MessageBox.Show("Must Find department first");
                }
            }

            else {

                MessageBox.Show("You must open all files first");
            }
        }
    }
}
