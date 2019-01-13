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
            CommonHeaderWindow.Show(Dock, DockState.DockLeft);
            var index = Program.WindowManager.AddCourse("Oni");
            Program.WindowManager.AddCourse("Edit");
            Courses.SetCoursesFromList();
            Program.WindowManager.Editors[index].Show(Dock);
            Program.WindowManager.Editors[index + 1].Show(Dock);
            Dock.DockLeftPortion = 0.36;
            Dock.DockRightPortion = 0.36;
            Text = Properties.Common.Name;
            Menu_Version.Text = Properties.Common.Name + " Ver." + Program.Version;
            Program.Project.ProjectName = Properties.Common.UntitledProjectName;
            TitleChange();
        }

        private void Dock_ActiveDocumentChanged(object sender, EventArgs e)
        {
            CurrentCourseID = Courses.List.FindItemWithText(Dock.ActiveDocument.DockHandler.TabText.Substring(9)).Index;
            HeaderWindow.SetHeaderFromList(Program.Project.Courses[CurrentCourseID].Header);
        }


        private void Menu_Tool_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(Properties.SystemMessage.VersionDialog, Properties.Common.Name, Program.Version, Properties.Common.Developer, Properties.Common.Website), Properties.Common.Name, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        public void EditorChanged()
        {
            IsEdited = true;
            TitleChange();
        }

        private void TitleChange()
        {
            Text = Properties.Common.Name;
            Text += " - " + Program.Project.ProjectName;
            if (IsEdited) Text += " *";
        }

        private void Studio_Load(object sender, EventArgs e)
        {

        }

        public void Save()
        {
            if (!File.Exists(FileName))
            {
                SaveAs();
                return;
            }
            FileManager.SaveFile(FileName, Program.Project);
        }

        private void SaveAs()
        {
            var dialog = new SaveFileDialog();
            dialog.Title = Properties.SystemMessage.SaveProject;
            dialog.FileName = Program.Project.ProjectName + Properties.Common.ExtensionName;
            dialog.Filter = String.Format("{0}|*{1}", Properties.Common.ExtensionDescription, Properties.Common.ExtensionName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Program.Project.ProjectName = Path.GetFileNameWithoutExtension(dialog.FileName);
                FileManager.SaveFile(dialog.FileName, Program.Project);
                IsEdited = false;
                FileName = dialog.FileName;
                TitleChange();
            }
        }

        private void Menu_File_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Menu_File_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();            
        }

        private Courses Courses = new Courses();
        private Project Project = new Project();
        public  HeadersWindow HeaderWindow = new HeadersWindow(false);
        private HeadersWindow CommonHeaderWindow = new HeadersWindow(true, "Common Header");
        public static Studio TJAStudio { get; set; }
        public static int CurrentCourseID { get; set; }
        public bool IsEdited { get; set; }
        public string FileName { get; set; }
    }
}
