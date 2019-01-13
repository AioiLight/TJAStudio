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
    public partial class HeadersWindow : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private bool IsCommon { get; }
        public HeadersWindow(bool isCommon)
        {
            InitializeComponent();
            Resized();
            IsCommon = isCommon;
        }

        public HeadersWindow(bool isCommon, string name)
        {
            InitializeComponent();
            Resized();
            Text = name;
            IsCommon = isCommon;
        }

        private void List_Resize(object sender, EventArgs e)
        {
            Resized();
        }

        private void Resized()
        {
            List.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Tool_Delete_Click(object sender, EventArgs e)
        {
            var to = IsCommon ? Program.Project.CommonHeader : Program.Project.Courses[Studio.CurrentCourseID].Header;
            if (to.Count <= 1 || List.SelectedCells.Count < 1) return;
            //Program.WindowManager.(List.SelectedItems[0].Index);]
            to.RemoveAt(List.SelectedCells[0].RowIndex);
            SetHeaderFromList(to);
        }

        public void SetHeaderFromList(List<Header> list)
        {
            List.Rows.Clear();
            foreach (var item in list)
            {
                List.Rows.Add(item.Name, item.Value);
            }
            if(!IsCommon)
            {
                this.Text = "Header - " + Program.Project.Courses[Studio.CurrentCourseID].Name;
            }
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            var dialog = new AddHeader();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                var header = new Header();
                header.Name = dialog.TextBox_Name.Text;
                header.Value = dialog.TextBox_Parameter.Text;
                if(IsCommon)
                {
                    Program.Project.CommonHeader.Add(header);
                }
                else
                {
                    Program.Project.Courses[Studio.CurrentCourseID].Header.Add(header);
                }
            }
            if(IsCommon)
            {
                SetHeaderFromList(Program.Project.CommonHeader);
            }
            else
            {
                SetHeaderFromList(Program.Project.Courses[Studio.CurrentCourseID].Header);
            }
        }


        private void List_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var list = new List<Header>();
            foreach (var row in List.Rows.Cast<DataGridViewRow>())
            {
                var index = new Header();
                index.Name = (string)row.Cells[0].Value;
                index.Value = (string)row.Cells[1].Value;
                list.Add(index);
            }
            if (IsCommon)
            {
                Program.Project.CommonHeader = list;
            }
            else
            {
                Program.Project.Courses[Studio.CurrentCourseID].Header = list;
            }
        }

        private void Tool_MoveUp_Click(object sender, EventArgs e)
        {
            var to = IsCommon ? Program.Project.CommonHeader : Program.Project.Courses[Studio.CurrentCourseID].Header;
            if (to.Count <= 1 || List.SelectedCells.Count < 1 || List.SelectedRows[0].Index <= 0) return;
            var index = List.SelectedRows[0].Index;
            var work = to[index];
            to.RemoveAt(index);
            to.Insert(index - 1, work);
            SetHeaderFromList(to);
            List.Rows[index - 1].Selected = true;
            List.CurrentCell = List.Rows[index - 1].Cells[0];
        }

        private void Tool_MoveDown_Click(object sender, EventArgs e)
        {
            var to = IsCommon ? Program.Project.CommonHeader : Program.Project.Courses[Studio.CurrentCourseID].Header;
            if (to.Count <= 1 || List.SelectedCells.Count < 1 || List.SelectedRows[0].Index + 1 > List.Rows.Count - 1) return;
            var index = List.SelectedRows[0].Index;
            var work = to[index];
            to.RemoveAt(index);
            to.Insert(index + 1, work);
            SetHeaderFromList(to);
            List.Rows[index + 1].Selected = true;
            List.CurrentCell = List.Rows[index + 1].Cells[0];
        }

        private void List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
