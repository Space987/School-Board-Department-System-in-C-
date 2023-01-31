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
    public partial class DeanForm : Form
    {
        int language = Form1.language;
        public DeanForm()
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void viewDeanBtn_Click(object sender, EventArgs e)
        {

        }

        private void addDeanBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
