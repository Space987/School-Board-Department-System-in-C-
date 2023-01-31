using System;
using System.Collections;
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


    public partial class ViewStuForm : Form
    {
        int language = Form1.language;
        string viewPath = StudentForm.path;
        bool resetCount = false;
        Student stu;
        int tmp;
        bool correctStu = false;
        DataGridViewRow correctSu2 = new DataGridViewRow();
        Student generalStu;


        public ViewStuForm()
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

        private void ViewStuForm_Load(object sender, EventArgs e)
        {

            Department.StudentList.Clear();
            AddStudents();

            timer1.Start();
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            DateLB.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void AddStudents()
        {


            StreamReader stream = new StreamReader(viewPath);
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
                    for (int i = 0; i < Department.StudentList.Count; i++)
                    {
                        if (searchTextBox.Text == Department.StudentList[i].ID.ToString())
                        {
                            for (int j = 0; j < stuDataGrid.Rows.Count; j++)
                            {

                                if (Department.StudentList[i].ID.ToString() == stuDataGrid.Rows[j].Cells[0].Value.ToString())
                                {


                                    stuDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;

                                    MessageBox.Show(Department.StudentList[i].Name + " was found in the Database");

                                    searchCount++;


                                    correctStu = true;
                                    correctSu2 = stuDataGrid.Rows[j];
                                    resetCount = true;

                                }
                            }
                        }
                    }

                    if (searchCount == 0)
                    {

                        MessageBox.Show("Student ID not Found");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stuDataGrid.DefaultCellStyle.BackColor = Color.White;
            searchTextBox.Clear();
            stuDataGrid.Rows.Clear();
            AddStuList();
            resetCount = false;


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (correctStu)
            {

                stuDataGrid.Rows.Remove(correctSu2);

                MessageBox.Show(correctSu2.Cells[1].Value.ToString() + " Removed");
            }

            for (int i = 0; Department.StudentList.Count > i; i++)

            {
                if (correctSu2.Cells[0].Value.ToString() == Department.StudentList[i].ID.ToString())
                {
                    Department.StudentList.RemoveAt(i);

                }

            }

            ClearStudent(viewPath);
            for (int i = 0; Department.StudentList.Count > i; i++)
            {
                AppendToStudent(Department.StudentList[i].toString(), viewPath);
            }

        }

        public void ClearStudent(String fileName)
        {

            System.IO.File.WriteAllText(fileName, string.Empty);

        }

        public void AppendToStudent(String data, String fileName)
        {

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(data);

            sw.Close();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm menu = new StudentForm();
            menu.Show();
        }



        private void updateButton_Click(object sender, EventArgs e)
        {


            if (correctStu)
            {
                for (int j = 0; j < stuDataGrid.Rows.Count; j++)
                {

                    if (correctSu2.Cells[0].Value == stuDataGrid.Rows[j].Cells[0].Value)
                    {
                        stuDataGrid.ReadOnly = false;

                        break;


                    }
                }

                for (int i = 0; stuDataGrid.Rows.Count > i; i++)
                {
                    if (stuDataGrid.Rows[i].Cells[0].Value != correctSu2.Cells[0].Value)
                    {
                        stuDataGrid.Rows[i].ReadOnly = true;

                    }

                    else
                    {
                        stuDataGrid.Rows[i].Cells[0].ReadOnly = true;
                        stuDataGrid.Rows[i].Cells[6].ReadOnly = true;
                        continue;
                    }

                }

                MessageBox.Show(correctSu2.Cells[1].Value.ToString() + " Updated");
            }

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Department.StudentList.Count; i++)
            {
                if (searchTextBox.Text == Department.StudentList[i].ID.ToString())
                {
                    for (int j = 0; j < stuDataGrid.Rows.Count; j++)
                    {

                        if (Department.StudentList[i].ID.ToString() == stuDataGrid.Rows[j].Cells[0].Value.ToString())
                        {

                            Department.StudentList[i].Name = correctSu2.Cells[1].Value.ToString();
                            Department.StudentList[i].Age = Int32.Parse(correctSu2.Cells[2].Value.ToString());
                            Department.StudentList[i].Gender = correctSu2.Cells[3].Value.ToString();
                            Department.StudentList[i].Course = correctSu2.Cells[4].Value.ToString();
                            Department.StudentList[i].Semester = Int32.Parse(correctSu2.Cells[5].Value.ToString());
                           
                            stuDataGrid.ReadOnly = true;
                            break;

                        }
                    }
                }
            }

            ClearStudent(viewPath);
            for (int i = 0; Department.StudentList.Count > i; i++)
            {
                AppendToStudent(Department.StudentList[i].toString(), viewPath);

            }
        }
    }
}

