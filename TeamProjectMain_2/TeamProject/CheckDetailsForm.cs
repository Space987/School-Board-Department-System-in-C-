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
    public partial class CheckDetailsForm : Form
    {
        int language = Form1.language;

        Student generalStu;

        Teacher generalTeacher;
        Decimal teachPay;

        Staff generalStaff;
        Decimal staffPay;

        int matchID;

        string viewPathStu = StudentForm.path;
        string viewPathTeach = TeacherForm.path;
        string viewPathStaff = StaffForm.path;

        
        public CheckDetailsForm(int check)
        {
            InitializeComponent();
            matchID = check;
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

        private void CheckDetailsForm_Load(object sender, EventArgs e)
        {

            Department.StudentList.Clear();
            AddStudents();

            Department.TeacherList.Clear();
            AddTeacher();

            Department.StaffList.Clear();
            AddStaff();
        }

        ///Student
        public void AddStudents()
        {


            StreamReader stream = new StreamReader(viewPathStu);
            String str;

            while ((str = stream.ReadLine()) != null)
            {

                String[] studentLine = str.Split(',');
                Student stu = new Student(Int32.Parse(studentLine[0]), studentLine[1],
                        Int32.Parse(studentLine[2]), studentLine[3], studentLine[4], Int32.Parse(studentLine[5]), Int32.Parse(studentLine[6]));
                generalStu = stu;
                Department.StudentList.Add(stu);


            }

            AddStuList();
            stream.Close();

        }

        public void AddStuList()
        {

            for (int i = 0; Department.StudentList.Count > i; i++)
            {

                stuDataGrid.Rows.Add();
                stuDataGrid.Rows[i].Cells[0].Value = Department.StudentList[i].ID;
                stuDataGrid.Rows[i].Cells[1].Value = Department.StudentList[i].Name;
                stuDataGrid.Rows[i].Cells[2].Value = Department.StudentList[i].Age;
                stuDataGrid.Rows[i].Cells[3].Value = Department.StudentList[i].Gender;
                stuDataGrid.Rows[i].Cells[4].Value = Department.StudentList[i].Course;
                stuDataGrid.Rows[i].Cells[5].Value = Department.StudentList[i].Semester;
                stuDataGrid.Rows[i].Cells[6].Value = Department.StudentList[i].DeptChoice;


            }

            CheckStuID();
        }

        public void CheckStuID()
        {
            try
            {
                for (int j = 0; stuDataGrid.Rows.Count > j; j++)
                {
                    if (stuDataGrid.Rows[j].Cells[6].Value.ToString() == matchID.ToString())
                    {

                        stuDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex) { 
            
            }
        }


        ///TEACHER
        public void AddTeacher()
        {

            StreamReader stream = new StreamReader(viewPathTeach);
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

            AddTeacherList();
            stream.Close();

        }

        public void AddTeacherList()
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

            CheckTeachID();
        }

        public void CheckTeachID()
        {
            try
            {
                for (int j = 0; teachDataGrid.Rows.Count > j; j++)
                {
                    if (teachDataGrid.Rows[j].Cells[7].Value.ToString() == matchID.ToString())
                    {

                        teachDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        ///STAFF
        public void AddStaff()
        {

            StreamReader stream = new StreamReader(viewPathStaff);
            String str;


            while ((str = stream.ReadLine()) != null)
            {

                String[] staffLine = str.Split(',');
                Staff staff2 = new Staff(Int32.Parse(staffLine[5]));
                Staff staff = new Staff(Int32.Parse(staffLine[0]), staffLine[1],
                        Int32.Parse(staffLine[2]), staffLine[3], staffLine[4], Int32.Parse(staffLine[5]), staff2.getSalary(), Int32.Parse(staffLine[6]));
                generalStaff = staff;
                Department.StaffList.Add(staff);
                staffPay = staff.computePayRoll();

            }

            AddStaffList();
            stream.Close();

        }

        public void AddStaffList()
        {

            for (int i = 0; Department.StaffList.Count > i; i++)
            {
                StaffDataGrid.Rows.Add();
                StaffDataGrid.Rows[i].Cells[0].Value = Department.StaffList[i].ID;
                StaffDataGrid.Rows[i].Cells[1].Value = Department.StaffList[i].Name;
                StaffDataGrid.Rows[i].Cells[2].Value = Department.StaffList[i].Age;
                StaffDataGrid.Rows[i].Cells[3].Value = Department.StaffList[i].Gender;
                StaffDataGrid.Rows[i].Cells[4].Value = Department.StaffList[i].Duty;
                StaffDataGrid.Rows[i].Cells[5].Value = Department.StaffList[i].WorkLoad;
                StaffDataGrid.Rows[i].Cells[6].Value = String.Format("{0:C}", Department.StaffList[i].Salary);
                StaffDataGrid.Rows[i].Cells[7].Value = Department.StaffList[i].DeptChoice;
            }
        }

        public void CheckStaffID()
        {
            try
            {
                for (int j = 0; StaffDataGrid.Rows.Count > j; j++)
                {
                    if (StaffDataGrid.Rows[j].Cells[7].Value.ToString() == matchID.ToString())
                    {

                        StaffDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewDepartmentForm menu = new ViewDepartmentForm();
            menu.Show();
        }
    }
}
