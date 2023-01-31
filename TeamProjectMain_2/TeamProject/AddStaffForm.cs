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
    public partial class AddStaffForm : Form
    {
        string viewPath = StaffForm.path;
        int language = Form1.language;


        public AddStaffForm()
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
                Department.StaffList.Add(staff);

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

        public void ClearStaff(String fileName2)
        {

            System.IO.File.WriteAllText(fileName2, string.Empty);

        }

        public void AppendToStaff(String data2, String fileName2)
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

            test = staffIDtb.Text.ToCharArray().ElementAt(0);

            if (test != '3')
            {
                matchCheck = true;
            }


            for (int i = 0; Department.StaffList.Count > i; i++)
            {

                if (Department.StaffList[i].ID.ToString() == staffIDtb.Text)
                {
                    idCheck = true;
                }
            }

            for (int j = 0; Department.DepartmentList.Count > j; j++)
            {

                if (Department.DepartmentList[j].ID == Int32.Parse(staffDepIDtb.Text))
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
                            Staff staff2 = new Staff(Int32.Parse(staffWorkloadtb.Text));
                            Staff staff = new Staff(Int32.Parse(staffIDtb.Text), staffNametb.Text,
                                Int32.Parse(staffAgetb.Text), staffGendertb.Text, staffDutytb.Text, Int32.Parse(staffWorkloadtb.Text),
                                staff2.getSalary(), Int32.Parse(staffDepIDtb.Text));

                            Department.StaffList.Add(staff);
                            MessageBox.Show(staffNametb.Text + " added");

                            ClearTextBoxes(); // clear TextBox values
                            AppendToStaff(staff.toString(), viewPath);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("You must enter every input");
                        }
                    }
                    else {

                        staffDepIDtb.Clear();
                        MessageBox.Show("Department ID must match with existing Department!");
                    }
                }

                else
                {
                    staffIDtb.Clear();
                    MessageBox.Show("You cannot Add student with same ID");
                }
            }
            else {


                staffIDtb.Clear();
                MessageBox.Show("ID must begin with 3");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm menu = new StaffForm();
            menu.Show();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            AddStaff();
            AddDepartments();
        }
    }
}

