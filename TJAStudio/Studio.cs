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
            TJAStudio = this;
            Dock.Theme = new VS2015LightTheme();

            Project.Show(Dock, DockState.DockRight);
            Courses.Show(Dock, DockState.DockRight);
            HeaderWindow.Show(Dock, DockState.DockLeft);
            var index = Program.WindowManager.AddCourse("Oni");
            Program.WindowManager.AddCourse("Edit");
            Courses.SetCoursesFromList();
            Program.WindowManager.Editors[index].Show(Dock);
            Program.WindowManager.Editors[index + 1].Show(Dock);
        }

        private void Dock_ActiveDocumentChanged(object sender, EventArgs e)
        {

        }

        private Courses Courses = new Courses();
        private Project Project = new Project();
        private HeaderWindow HeaderWindow = new HeaderWindow();
        public static Studio TJAStudio { get; set; }

    }
}
