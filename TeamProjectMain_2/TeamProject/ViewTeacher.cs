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
    public partial class ViewTeacher : Form
    {
        string viewPath = TeacherForm.path;
        bool resetCount = false;
        bool correctTeacher = false;
        DataGridViewRow correctTeacher2;
        Teacher generalTeacher;

        public ViewTeacher()
        {

            InitializeComponent();

        }

        private void ViewTeacherForm_Load(object sender, EventArgs e)
        {

            Department.TeacherList.Clear();
            AddTeacher();
            timer1.Start();
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            DateLB.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void AddTeacher()
        {

            StreamReader stream = new StreamReader(viewPath);
            String str;


            while ((str = stream.ReadLine()) != null)
            {

                String[] teachLine = str.Split(',');
                Teacher teach2 = new Teacher(teachLine[4]);
                Teacher teach = new Teacher(Int32.Parse(teachLine[0]), teachLine[1],
                        Int32.Parse(teachLine[2]), teachLine[3], teachLine[4], teachLine[5], teach2.getSalary(), Int32.Parse(teachLine[6]));
                generalTeacher = teach;
                Department.TeacherList.Add(teach);


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

        private void resetButton_Click(object sender, EventArgs e)
        {
            teachDataGrid.DefaultCellStyle.BackColor = Color.White;
            searchTextBox.Clear();
            teachDataGrid.Rows.Clear();
            AddTeacherList();
            resetCount = false;


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (correctTeacher)
            {

                teachDataGrid.Rows.Remove(correctTeacher2);
                MessageBox.Show(correctTeacher2.Cells[1].Value.ToString() + " Removed");

            }

            for (int i = 0; Department.TeacherList.Count > i; i++)

            {
                if (correctTeacher2.Cells[0].Value.ToString() == Department.TeacherList[i].ID.ToString())
                {
                    Department.TeacherList.RemoveAt(i);

                }

            }

            ClearTeacher(viewPath);
            for (int i = 0; Department.TeacherList.Count > i; i++)
            {
                AppendToTeacher(Department.TeacherList[i].toString(), viewPath);
            }

        }

        public void ClearTeacher(String fileName)
        {

            System.IO.File.WriteAllText(fileName, string.Empty);

        }

        public void AppendToTeacher(String data, String fileName)
        {

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(data);

            sw.Close();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm menu = new TeacherForm();
            menu.Show();
        }



        private void updateButton_Click(object sender, EventArgs e)
        {


            if (correctTeacher)
            {
                for (int j = 0; j < teachDataGrid.Rows.Count; j++)
                {

                    if (correctTeacher2.Cells[0].Value == teachDataGrid.Rows[j].Cells[0].Value)
                    {
                        teachDataGrid.ReadOnly = false;

                        break;


                    }
                }

                for (int i = 0; teachDataGrid.Rows.Count > i; i++)
                {
                    if (teachDataGrid.Rows[i].Cells[0].Value != correctTeacher2.Cells[0].Value)
                    {
                        teachDataGrid.Rows[i].ReadOnly = true;
                    }

                    else
                    {
                        teachDataGrid.Rows[i].Cells[0].ReadOnly = true;
                        teachDataGrid.Rows[i].Cells[7].ReadOnly = true;
                        continue;
                    }
                }

                MessageBox.Show(correctTeacher2.Cells[1].Value.ToString() + " Updated");
            }

            
        }


        private void enterButton_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < Department.TeacherList.Count; i++)
            {
                if (searchTextBox.Text == Department.TeacherList[i].ID.ToString())
                {
                    for (int j = 0; j < teachDataGrid.Rows.Count; j++)
                    {

                        if (Department.TeacherList[i].ID.ToString() == teachDataGrid.Rows[j].Cells[0].Value.ToString())
                        {

                            Department.TeacherList[i].Name = correctTeacher2.Cells[1].Value.ToString();
                            Department.TeacherList[i].Age = Int32.Parse(correctTeacher2.Cells[2].Value.ToString());
                            Department.TeacherList[i].Gender = correctTeacher2.Cells[3].Value.ToString();
                            Department.TeacherList[i].Degree = correctTeacher2.Cells[4].Value.ToString();
                            Department.TeacherList[i].Specialty = correctTeacher2.Cells[5].Value.ToString();
                            

                            Teacher teach2 = new Teacher(Department.TeacherList[i].Degree);
                            Department.TeacherList[i].Salary = teach2.getSalary();
                            teachDataGrid.ReadOnly = true;

                            
                            break;

                        }
                    }
                }
            }

            ClearTeacher(viewPath);
            for (int i = 0; Department.TeacherList.Count > i; i++)
            {
                AppendToTeacher(Department.TeacherList[i].toString(), viewPath);

            }
        }
    }
}