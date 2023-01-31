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
    public partial class AddTeacher : Form
    {
        string viewPath = TeacherForm.path;
        int language = Form1.language;

        public AddTeacher()
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

        public void AddTeach()
        {

            StreamReader stream = new StreamReader(viewPath);
            String str;

            while ((str = stream.ReadLine()) != null)
            {

                String[] teachLine = str.Split(',');
                Teacher teach2 = new Teacher(teachLine[4]);
                Teacher teach = new Teacher(Int32.Parse(teachLine[0]), teachLine[1],
                        Int32.Parse(teachLine[2]), teachLine[3], teachLine[4], teachLine[5], teach2.getSalary(), Int32.Parse(teachLine[6]));
                Department.TeacherList.Add(teach);


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

        public void ClearTeach(String fileName2)
        {

            System.IO.File.WriteAllText(fileName2, string.Empty);

        }

        public void AppendToTeach(String data2, String fileName2)
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

            test = teachIDtb.Text.ToCharArray().ElementAt(0);

            if (test != '2')
            {
                matchCheck = true;
            }

            for (int i = 0; Department.TeacherList.Count > i; i++)
            {

                if (Department.TeacherList[i].ID.ToString() == teachIDtb.Text)
                {
                    idCheck = true;
                }
            }

            for (int j = 0; Department.DepartmentList.Count > j; j++)
            {

                if (Department.DepartmentList[j].ID == Int32.Parse(teachDepIDtb.Text))
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
                            Teacher teach2 = new Teacher(teachDegreetb.Text);
                            Teacher teach = new Teacher(Int32.Parse(teachIDtb.Text), teachNametb.Text,
                                Int32.Parse(teachAgetb.Text), teachGendertb.Text, teachDegreetb.Text, teachSpecialtytb.Text,
                                teach2.getSalary(), Int32.Parse(teachDepIDtb.Text));

                            Department.TeacherList.Add(teach);
                            MessageBox.Show(teachNametb.Text + " added");


                            ClearTextBoxes(); // clear TextBox values
                            AppendToTeach(teach.toString(), viewPath);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("You must enter every input");
                        }
                    }
                    else {
                        teachDepIDtb.Clear();
                        MessageBox.Show("Department ID must match with existing Department!");

                    }
                }

                else
                {
                    teachIDtb.Clear();
                    MessageBox.Show("You cannot Add teacher with same ID");
                }
            }
            else
            {
                teachIDtb.Clear();
                MessageBox.Show("ID must begin with 2");

            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm menu = new TeacherForm();
            menu.Show();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            AddTeach();
            AddDepartments();
        }
    }

    }

