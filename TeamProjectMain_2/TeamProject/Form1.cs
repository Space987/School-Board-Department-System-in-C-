using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Form1 : Form
    {

        bool stuOpen = DepartmentForm.wasOpen;
        public static int language = 0;
        public Form1()
        {
            InitializeComponent();
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            if (stuOpen)
            {
                this.Hide();
                StudentForm menu = new StudentForm();
                menu.Show();
            }
            else
            {

                MessageBox.Show("You must open a Department file ");
            }
        }

        private void teachBtn_Click(object sender, EventArgs e)
        {
            if (stuOpen)
            {

                this.Hide();
                TeacherForm menu = new TeacherForm();
                menu.Show();
            }
            else
            {

                MessageBox.Show("You must open a Department file");
            }
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            if (stuOpen)
            {
                this.Hide();
                StaffForm menu = new StaffForm();
                menu.Show();
            }
            else
            {

                MessageBox.Show("You must open a Department file");
            }
        }

        private void deptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentForm menu = new DepartmentForm();
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LanguagecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (LanguagecomboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    language = 0;
                    Application.Restart();
                    break;


                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    language = 1;
                    break;


                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    language = 2;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
