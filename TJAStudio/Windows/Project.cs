using System;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class Project : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public Project()
        {
            InitializeComponent();
        }

        protected override string GetPersistString()
        {
            return "Project";
        }

        private void Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        public void SetCoursesFromList()
        {
            List.Items.Clear();
            foreach (var item in Program.Project.ProjectFile)
            {
                List.Items.Add(item);
            }
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                Program.Project.ProjectFile.Add(dialog.FileName);
                SetCoursesFromList();
                Studio.TJAStudio.EditorChanged();
            }
        }

        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            if (Program.Project.ProjectFile.Count < 1 || List.SelectedItems.Count < 1) return;
            Program.Project.ProjectFile.RemoveAt(List.SelectedItems[0].Index);
            SetCoursesFromList();
            Studio.TJAStudio.EditorChanged();
        }
    }
}