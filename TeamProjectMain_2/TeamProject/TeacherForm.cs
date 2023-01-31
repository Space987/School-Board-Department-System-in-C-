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
    public partial class TeacherForm : Form
    {

        int language = Form1.language;
        bool deptOpen = DepartmentForm.wasOpen;

        ViewStaff view = new ViewStaff();
        public static string path;
        public bool notOpen = false;
        public static bool wasPressed = false;
        public static bool wasOpen = false;

        public TeacherForm()
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

        private void viewTeachBtn_Click(object sender, EventArgs e)
        {


                if (wasOpen)
                {
                    this.Hide();
                    ViewTeacher menu = new ViewTeacher();
                    menu.Show();

                }
            
            else
            {

                MessageBox.Show("You must open a file first");
            }
        }


        public bool AddTeacherCheck()
        {

            StreamReader stream = new StreamReader(path);
            String str;
            char test;

            while ((str = stream.ReadLine()) != null)
            {
                String[] teachLine = str.Split(',');
                test = teachLine[0].ToCharArray().ElementAt(0);
               

                if (test != '2')
                {
                    
                    return notOpen = true;
                }

            }
            stream.Close();
            return notOpen = false;

        }

    private void addTeachBtn_Click(object sender, EventArgs e)
    {

                if (wasOpen)
                {
                    this.Hide();
                    AddTeacher menu = new AddTeacher();
                    menu.Show();

                }
            

            else
            {

                MessageBox.Show("You must open a file first");
            }
        }


    private void backBtn_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form1 menu = new Form1();
        menu.Show();
    }

    private void setDeanBtn_Click(object sender, EventArgs e)
    {

            if (wasOpen)
            {

                if (deptOpen)
                {
                    this.Hide();
                    SetDeanForm menu = new SetDeanForm();
                    menu.Show();

                }
                else
                {

                    MessageBox.Show("You must open a Department file first");
                }
            }
            else
            {

                MessageBox.Show("You must open a teacher file first");
            }
        }

    private void openButton_Click(object sender, EventArgs e)
    {

        DialogResult result; // result of OpenFileDialog
        string fileName;  // name of file containing data

        using (OpenFileDialog fileChooser = new OpenFileDialog())
        {
            result = fileChooser.ShowDialog();
            fileName = fileChooser.FileName; // get specified name
            path = fileName;
        }


        // show error if user specified invalid file
        if (string.IsNullOrEmpty(fileName))
        {
            MessageBox.Show("Invalid File Name", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

            if (!AddTeacherCheck())
            {
                MessageBox.Show("Succesfully Opened File");
                wasPressed = true;
                wasOpen = true;
                openButton.Enabled = false;

            }
            else
            {

                MessageBox.Show("File must match required fields");

            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (wasOpen)
            {
                openButton.Enabled = false;
            }
        }
    }
}
