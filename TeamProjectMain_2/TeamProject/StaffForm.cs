﻿using System;
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
    public partial class StaffForm : Form
    {
        int language = Form1.language;
        public static string path;
        public bool notOpen = false;
        public static bool wasPressed = false;
        public static bool wasOpen = false;

        public StaffForm()
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

        private void viewStaffBtn_Click(object sender, EventArgs e)
        {

            if (wasOpen)
            {
                this.Hide();
                ViewStaff menu = new ViewStaff();
                menu.Show();
            }


            else
            {

                MessageBox.Show("You must open a file first");
            }
        }

        public bool AddStaffCheck()
        {

            StreamReader stream = new StreamReader(path);
            String str;
            char test;

            while ((str = stream.ReadLine()) != null)
            {
                String[] staffLine = str.Split(',');
                test = staffLine[0].ToCharArray().ElementAt(0);


                if (test != '3')
                {

                    return notOpen = true;
                }

            }
            stream.Close();
            return notOpen = false;

        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {

                if (wasOpen)
                {
                    this.Hide();
                    AddStaffForm menu = new AddStaffForm();
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

            if (!AddStaffCheck())
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

        private void StaffForm_Load(object sender, EventArgs e)
        {
            if (wasOpen)
            {
                openButton.Enabled = false;
            }
        }
    }
}



