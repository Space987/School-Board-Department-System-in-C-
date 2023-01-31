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
    public partial class ViewStaff : Form
    {
        int language = Form1.language;
        string viewPath = StaffForm.path;
        bool resetCount = false;
        Staff staff;
        bool correctStaff = false;
        DataGridViewRow correctStaff2;
        Staff generalStaff;
        public bool notOpen = false;



        public ViewStaff()
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

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {

            Department.StaffList.Clear();
            AddStaff();
            timer1.Start();
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            DateLB.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void AddStaff()
        {

            StreamReader stream = new StreamReader(viewPath);
            String str;


            while ((str = stream.ReadLine()) != null)
            {

                String[] staffLine = str.Split(',');
                Staff staff2 = new Staff(Int32.Parse(staffLine[5]));
                Staff staff = new Staff(Int32.Parse(staffLine[0]), staffLine[1],
                        Int32.Parse(staffLine[2]), staffLine[3], staffLine[4], Int32.Parse(staffLine[5]), staff2.getSalary(), Int32.Parse(staffLine[6]));
                generalStaff = staff;
                Department.StaffList.Add(staff);

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
                    for (int i = 0; i < Department.StaffList.Count; i++)
                    {
                        if (searchTextBox.Text == Department.StaffList[i].ID.ToString())
                        {
                            for (int j = 0; j < StaffDataGrid.Rows.Count; j++)
                            {

                                if (Department.StaffList[i].ID.ToString() == StaffDataGrid.Rows[j].Cells[0].Value.ToString())
                                {


                                    StaffDataGrid.Rows[j].DefaultCellStyle.BackColor = Color.Yellow;

                                    MessageBox.Show(Department.StaffList[i].Name + " was found in the Database");

                                    searchCount++;


                                    correctStaff = true;
                                    correctStaff2 = StaffDataGrid.Rows[j];
                                    resetCount = true;

                                }
                            }
                        }
                    }

                    if (searchCount == 0)
                    {

                        MessageBox.Show("Staff ID not Found");

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            StaffDataGrid.DefaultCellStyle.BackColor = Color.White;
            searchTextBox.Clear();
            StaffDataGrid.Rows.Clear();
            AddStaffList();
            resetCount = false;


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (correctStaff)
            {

                StaffDataGrid.Rows.Remove(correctStaff2);
                MessageBox.Show(correctStaff2.Cells[1].Value.ToString() + " Removed");

            }

            for (int i = 0; Department.StaffList.Count > i; i++)

            {
                if (correctStaff2.Cells[0].Value.ToString() == Department.StaffList[i].ID.ToString())
                {
                    Department.StaffList.RemoveAt(i);

                }

            }

            ClearStaff(viewPath);
            for (int i = 0; Department.StaffList.Count > i; i++)
            {
                AppendToStaff(Department.StaffList[i].toString(), viewPath);
            }

        }

        public void ClearStaff(String fileName)
        {

            System.IO.File.WriteAllText(fileName, string.Empty);

        }

        public void AppendToStaff(String data, String fileName)
        {

            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(data);

            sw.Close();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm menu = new StaffForm();
            menu.Show();
        }



        private void updateButton_Click(object sender, EventArgs e)
        {


            if (correctStaff)
            {
                for (int j = 0; j < StaffDataGrid.Rows.Count; j++)
                {

                    if (correctStaff2.Cells[0].Value == StaffDataGrid.Rows[j].Cells[0].Value)
                    {
                        StaffDataGrid.ReadOnly = false;

                        break;


                    }
                }

                for (int i = 0; StaffDataGrid.Rows.Count > i; i++)
                {
                    if (StaffDataGrid.Rows[i].Cells[0].Value != correctStaff2.Cells[0].Value)
                    {
                        StaffDataGrid.Rows[i].ReadOnly = true;
                    }

                    else
                    {
                        StaffDataGrid.Rows[i].Cells[0].ReadOnly = true;
                        StaffDataGrid.Rows[i].Cells[7].ReadOnly = true;
                        continue;
                    }
                }
                MessageBox.Show(correctStaff2.Cells[1].Value.ToString() + " Updated");
            }

        }


        private void enterButton_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < Department.StaffList.Count; i++)
            {
                if (searchTextBox.Text == Department.StaffList[i].ID.ToString())
                {
                    for (int j = 0; j < StaffDataGrid.Rows.Count; j++)
                    {

                        if (Department.StaffList[i].ID.ToString() == StaffDataGrid.Rows[j].Cells[0].Value.ToString())
                        {

                            Department.StaffList[i].Name = correctStaff2.Cells[1].Value.ToString();
                            Department.StaffList[i].Age = Int32.Parse(correctStaff2.Cells[2].Value.ToString());
                            Department.StaffList[i].Gender = correctStaff2.Cells[3].Value.ToString();
                            Department.StaffList[i].Duty = correctStaff2.Cells[4].Value.ToString();
                            Department.StaffList[i].WorkLoad = Int32.Parse(correctStaff2.Cells[5].Value.ToString());

                            Staff staff2 = new Staff(Department.StaffList[i].WorkLoad);
                            Department.StaffList[i].Salary = staff2.getSalary();
                            StaffDataGrid.ReadOnly = true;

                            try
                            {
                                if (Department.StaffList[i].Bonus)
                                {

                                    MessageBox.Show("You received 1000$ bonus!");
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                            break;

                        }
                    }
                }
            }

            ClearStaff(viewPath);
            for (int i = 0; Department.StaffList.Count > i; i++)
            {
                AppendToStaff(Department.StaffList[i].toString(), viewPath);

            }
        }
    }
}