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
    public partial class AddStudents : Form
    {

        int language = Form1.language;
        string viewPath = StudentForm.path;


        public AddStudents()
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
        public void AddStu()
        {


            StreamReader stream = new StreamReader(viewPath);
            String str;

            while ((str = stream.ReadLine()) != null)
            {

                String[] studentLine = str.Split(',');
                Student stu = new Student(Int32.Parse(studentLine[0]), studentLine[1],
                        Int32.Parse(studentLine[2]), studentLine[3], studentLine[4], Int32.Parse(studentLine[5]), Int32.Parse(studentLine[6]));
                Department.StudentList.Add(stu);


            }

            stream.Close();

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
            stream.Close();

        }



        public void ClearStudent(String fileName2)
        {

            System.IO.File.WriteAllText(fileName2, string.Empty);

        }

        public void AppendToStudent(String data2, String fileName2)
        {

            StreamWriter sw = new StreamWriter(fileName2, true);
            sw.WriteLine(data2);

            sw.Close();
        }

        public void ClearTextBoxes()
        {
            foreach (Control control in base.Controls)
            {
                (control as TextBox)?.Clear();
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            bool idCheck = false;
            bool matchCheck = false;
            bool deptCheck = false;
            char test;

            test = stuIDtb.Text.ToCharArray().ElementAt(0);

            if (test != '1')
            {
                matchCheck = true;
            }

            for (int i = 0; Department.StudentList.Count > i; i++)
            {
                if (Department.StudentList[i].ID == Int32.Parse(stuIDtb.Text))
                {
                    idCheck = true;


                }
            }


            for (int j = 0; Department.DepartmentList.Count > j; j++)
            {
                
                if (Department.DepartmentList[j].ID == Int32.Parse(stuDepIDtb.Text))
                {

                    deptCheck = true;
                    break;
                }
            }



            if (!matchCheck)
            {
                if (!idCheck)
                {

                    if (deptCheck)
                    {
                        try
                        {
                            Student student = new Student(Int32.Parse(stuIDtb.Text), stuNametb.Text,
                                Int32.Parse(stuAgetb.Text), stuGendertb.Text, stuCoursetb.Text, Int32.Parse(stuSemestertb.Text),
                                Int32.Parse(stuDepIDtb.Text));

                            Department.StudentList.Add(student);
                            MessageBox.Show(stuNametb.Text + " added");
                            

                            ClearTextBoxes();
                            AppendToStudent(student.toString(), viewPath);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("You must enter every input");
                        }
                    }
                    else
                    {
                        stuDepIDtb.Clear();
                        MessageBox.Show("Department ID must match with existing Department!");
                    }

                }

                else
                {
                    stuIDtb.Clear();
                    MessageBox.Show("You cannot Add student with same ID");
                }
            }
            else
            {

                stuIDtb.Clear();
                MessageBox.Show("ID must begin with 1");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm menu = new StudentForm();
            menu.Show();
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            AddStu();
            AddDepartments();
        }
    }
}
