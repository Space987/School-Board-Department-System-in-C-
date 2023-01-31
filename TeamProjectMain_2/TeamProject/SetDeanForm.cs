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
    public partial class SetDeanForm : Form
    {
        int language = Form1.language;

        int deleteDeanCheckCounter = 0;
        int addDeanCheckCounter = 0;
        int addDeanCheckCounter2 = 0;

        string viewTeachPath = TeacherForm.path;
        string viewDeptPath = DepartmentForm.path;
        bool resetCount = false;
        bool correctTeacher = false;
        DataGridViewRow correctTeacher2;
        Teacher generalTeacher;
        Decimal teachPay;
        public bool notOpen = false;

        public SetDeanForm()
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

        private void SetDeanForm_Load(object sender, EventArgs e)
        {
            Department.TeacherList.Clear();
            AddDean();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm menu = new TeacherForm();
            menu.Show();
        }

        public void AddDean()
        {

            StreamReader stream = new StreamReader(viewTeachPath);
            String str;


            while ((str = stream.ReadLine()) != null)
            {

                String[] teachLine = str.Split(',');
                Teacher teach2 = new Teacher(teachLine[4]);
                Teacher teach = new Teacher(Int32.Parse(teachLine[0]), teachLine[1],
                        Int32.Parse(teachLine[2]), teachLine[3], teachLine[4], teachLine[5], teach2.getSalary(), Int32.Parse(teachLine[6]));
                generalTeacher = teach;
                Department.TeacherList.Add(teach);
                teachPay = teach.computePayRoll();


            }

            AddDeanList();
            stream.Close();

        }

        public void AddDepartments()
        {


            StreamReader stream = new StreamReader(viewDeptPath);
            String str;

            while ((str = stream.ReadLine()) != null)
            {

                String[] deptdentLine = str.Split(',');
                Department dept = new Department(Int32.Parse(deptdentLine[0]), deptdentLine[1]);
                Department.DepartmentList.Add(dept);


            }
            stream.Close();

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
                    for (int i = 0; i < Department.TeacherList.Count; i++)
                    {
                        if (searchTextBox.Text == Department.TeacherList[i].ID.ToString())
                        {
                            for (int j = 0; j < teachDataGrid.Rows.Count; j++)
                            {

                                if (Department.TeacherList[i].ID.ToString() == teachDataGrid.Rows[j].Cells[0].Value.ToString())
                                {


                                    teachDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;

                                    MessageBox.Show(Department.TeacherList[i].Name + " was found in the Database");

                                    searchCount++;


                                    correctTeacher = true;
                                    correctTeacher2 = teachDataGrid.Rows[j];
                                    resetCount = true;

                                }
                            }
                        }
                    }

                    if (searchCount == 0)
                    {

                        MessageBox.Show("Teacher ID not Found");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void AddDeanList()
        {

            for (int i = 0; Department.TeacherList.Count > i; i++)
            {

                teachDataGrid.Rows.Add();
                teachDataGrid.Rows[i].Cells[0].Value = Department.TeacherList[i].ID;
                teachDataGrid.Rows[i].Cells[1].Value = Department.TeacherList[i].Name;
                teachDataGrid.Rows[i].Cells[2].Value = Department.TeacherList[i].Age;
                teachDataGrid.Rows[i].Cells[3].Value = Department.TeacherList[i].Gender;
                teachDataGrid.Rows[i].Cells[4].Value = Department.TeacherList[i].Degree;
                teachDataGrid.Rows[i].Cells[5].Value = Department.TeacherList[i].Specialty;
                teachDataGrid.Rows[i].Cells[6].Value = String.Format("{0:C}", Department.TeacherList[i].getSalary());
                teachDataGrid.Rows[i].Cells[7].Value = Department.TeacherList[i].DeptID;
                teachDataGrid.Rows[i].Cells[8].Value = Department.TeacherList[i].isDean();
            }


        }


        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            teachDataGrid.DefaultCellStyle.BackColor = Color.White;
            searchTextBox.Clear();
            teachDataGrid.Rows.Clear();
            AddDeanList();
            resetCount = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {


            //Counters
            addDeanCheckCounter = 0;
            addDeanCheckCounter2 = 0;

            try
            {

                for (int i = 0; Department.TeacherList.Count > i; i++)
                {
                    addDeanCheckCounter++;
                    //checks if Teacher Id entered by user matches with one in the arrayList.
                    if (Department.TeacherList[i].ID == Int32.Parse(searchTextBox.Text))
                    {


                        addDeanCheckCounter = 0;
                        for (int j = 0; Department.DepartmentList.Count > j; j++)
                        {

                            addDeanCheckCounter2++;
                            //checks if the teacher's current department ID matches with a department ID in the department arrayList
                            if (Department.DepartmentList[j].ID == Department.TeacherList[i].DeptID)
                            {

                                //checks if that department doesn't have a dean
                                if (Department.DepartmentList[j].getDean() == null)
                                {
                                    MessageBox.Show("Dean has been set!");
                                    Department.DepartmentList[j].setDean(Department.TeacherList[i]);
                                    resetButton_Click(sender, e);

                                    break;
                                    //if the department already has dean set.
                                }
                                else
                                {
                                    MessageBox.Show("There can only be one Dean in a Department");
                                    break;
                                }
                            }
                        }

                    }
                }

                //if the teacher ID entered by the user doesn't match with one in the arrayList
                if (addDeanCheckCounter == Department.TeacherList.Count)
                {
                    MessageBox.Show("no matching teacher ID found!!");

                }
                //if the user attempts to add dean to department that does not exist.
                if (addDeanCheckCounter2 == Department.TeacherList.Count)
                {
                    MessageBox.Show("teacher can only be dean of their current Department!");
                }

                //if user doesn't entered a valid Teacher Id and it throws NumberFormatException
            }
            catch (Exception ex)
            {
               
            }
        }




        private void deleteButton_Click(object sender, EventArgs e)
        {


            //Counters
            deleteDeanCheckCounter = 0;

            try
            {

                for (int i = 0; Department.TeacherList.Count > i; i++)
                {
                    deleteDeanCheckCounter++;
                    //checks if Teacher Id entered by user matches with one in the arrayList.
                    if (Department.TeacherList[i].ID == Int32.Parse(searchTextBox.Text))
                    {
                        deleteDeanCheckCounter = 0;
                        for (int j = 0; Department.DepartmentList.Count > j; j++)
                        {
                            //checks if the teacher's current department ID matches with a department ID in the department arrayList
                            if (Department.DepartmentList[j].ID == Department.TeacherList[i].DeptID)
                            {
                                //checks if that department already has a dean
                                if (Department.DepartmentList[j].getDean() != null)
                                {
                                    Department.DepartmentList[j].setDean(null);
                                    MessageBox.Show("Dean has been removed!");
                                    resetButton_Click(sender, e);
                                    break;
                                    //if the department doesn't have a dean set.
                                }
                                else
                                {
                                    MessageBox.Show("this teacher is not dean!");
                                    break;
                                }

                            }
                        }
                    }
                }

                //if the teacher ID entered by the user doesn't match with one in the arrayList
                if (deleteDeanCheckCounter == Department.TeacherList.Count)
                {
                    MessageBox.Show("no matching teacher ID found!!");
                }

                //if user doesn't entered a valid Teacher Id and it throws NumberFormatException
            }
            catch (Exception ex)
            {
                
            }


        }
    }
}
