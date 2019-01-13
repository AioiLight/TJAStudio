﻿using System;
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

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            var dialog = new AddCourse();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                Program.WindowManager.AddCourse(dialog.TextBox_Name.Text);
                SetCoursesFromList();
                Studio.TJAStudio.EditorChanged();
            }
        }
        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            if (Program.Project.Courses.Count <= 1 || List.SelectedItems.Count < 1) return;
            Program.WindowManager.DeleteCourse(List.SelectedItems[0].Index);
            SetCoursesFromList();
            Studio.TJAStudio.EditorChanged();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count < 1) return;
            Program.WindowManager.Editors[List.SelectedItems[0].Index].Show(Studio.TJAStudio.Dock);

        }

        private void Tool_MoveDown_Click(object sender, EventArgs e)
        {
            if (Program.Project.Courses.Count <= 1 || List.SelectedItems.Count < 1 || List.SelectedItems[0].Index + 1 > List.Items.Count - 1) return;
            var index = List.SelectedItems[0].Index;
            var work = Program.Project.Courses[index];
            Program.Project.Courses.RemoveAt(index);
            Program.Project.Courses.Insert(index + 1, work);
            SetCoursesFromList();
            Studio.TJAStudio.EditorChanged();
        }

        private void Tool_MoveUp_Click(object sender, EventArgs e)
        {
            if (Program.Project.Courses.Count <= 1 || List.SelectedItems.Count < 1 || List.SelectedItems[0].Index <= 0) return;
            var index = List.SelectedItems[0].Index;
            var work = Program.Project.Courses[index];
            Program.Project.Courses.RemoveAt(index);
            Program.Project.Courses.Insert(index - 1, work);
            SetCoursesFromList();
            Studio.TJAStudio.EditorChanged();
        }

        private void Courses_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
