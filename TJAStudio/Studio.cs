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
            var index = WindowManager.AddCourse("Oni");
            WindowManager.Editors[index].Show(Dock);
        }

        private Courses Courses = new Courses();
        private Project Project = new Project();
        private WindowManager WindowManager = new WindowManager();
    }
}
