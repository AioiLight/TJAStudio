using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TJAStudio
{
    public partial class Studio : Form
    {
        public Studio()
        {
            InitializeComponent();
            Dock.Theme = new VS2015LightTheme();

            Courses.Show(Dock, DockState.DockRight);
            Project.Show(Dock, DockState.DockRight);
            ListEditor.Add(new Editor());
            ListCourse.Add(new Course());
            ListEditor[ListEditor.Count - 1].Show(Dock);
            

        }


        private List<Editor> ListEditor = new List<Editor>();
        private List<Course> ListCourse = new List<Course>();
        private Courses Courses = new Courses();
        private Project Project = new Project();
    }
}
