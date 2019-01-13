using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class Courses : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public Courses()
        {
            InitializeComponent();
        }

        public void SetCoursesFromList()
        {
            List.Items.Clear();
            foreach (var item in Program.Project.Courses)
            {
                List.Items.Add(item.Name);
            }
        }

        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            if (Program.Project.Courses.Count <= 1) return;
            Program.WindowManager.DeleteCourse(List.SelectedItems[0].Index);
            SetCoursesFromList();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count < 1) return;
            Program.WindowManager.Editors[List.SelectedItems[0].Index].Show();

        }
    }
}
