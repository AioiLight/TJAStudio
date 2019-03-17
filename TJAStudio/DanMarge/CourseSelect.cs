using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio.DanMarge
{
    public partial class CourseSelect : Form
    {
        public CourseSelect(string[] courses)
        {
            InitializeComponent();
            ListBox_Courses.Items.Clear();
            foreach (var item in courses)
            {
                ListBox_Courses.Items.Add(item);
            }
        }

        public int SelectedCourseIndex { get; private set; }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedCourseIndex = ListBox_Courses.SelectedIndex;
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
