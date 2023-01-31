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
    public partial class AddDepartment : Form
    {
        int language = Form1.language;
        string viewPath = DepartmentForm.path;
        public AddDepartment()
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


        public void ClearDepartment(String fileName2)
        {

            System.IO.File.WriteAllText(fileName2, string.Empty);

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

            public void AppendToDepartment(String data2, String fileName2)
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
            char test;

            test = deptIDtb.Text.ToCharArray().ElementAt(0);

            if (test != '4')
            {
                matchCheck = true;
            }

            for (int i = 0; Department.DepartmentList.Count > i; i++)
            {

                if (Department.DepartmentList[i].ID.ToString() == deptIDtb.Text)
                {
                    idCheck = true;
                }
           
            }

            if (!matchCheck) {
                if (!idCheck)
                {

                    try { 
                    Department dept = new Department(Int32.Parse(deptIDtb.Text), deptDescriptiontb.Text);
                    Department.DepartmentList.Add(dept);
                        MessageBox.Show(deptDescriptiontb.Text + " Department added");

                        ClearTextBoxes();
                    AppendToDepartment(dept.toString(), viewPath);
                }
                    catch (Exception ex)
                    {

                        MessageBox.Show("You must enter every input");
                    }

                }

                else
                {
                    deptIDtb.Clear();
                    MessageBox.Show("You cannot Add Department with same ID");
                }
            }
            else {

                deptIDtb.Clear();
                MessageBox.Show("ID must begin with 4");

            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm menu = new DepartmentForm();
            menu.Show();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            AddDepartments();
        }
    }
}
