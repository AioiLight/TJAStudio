using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        protected override string GetPersistString()
        {
            return IsCommon ? "CommonHeader" : "CourseHeader";
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
            Studio.TJAStudio.EditorChanged();
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
                this.Text = Properties.Common.Header + Program.Project.Courses[Studio.CurrentCourseID].Name;
            }
        }

        private void Tool_Add_Click(object sender, EventArgs e)
        {
            var dialog = new AddHeader();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                Studio.TJAStudio.EditorChanged();
                var header = new Header();
                header.Name = dialog.TextBox_Name.Text;
                header.Value = dialog.TextBox_Parameter.Text;
                if (header.Name.EndsWith(":")) header.Name = header.Name.Remove(header.Name.Length - 1);

                var to = IsCommon ? Program.Project.CommonHeader : Program.Project.Courses[Studio.CurrentCourseID].Header;
                // 重複してるやつのインデックスを記録。
                var duplicated = new List<int>();
                for (var i = 0; i < to.Count; i++)
                {
                    var item = to[i];
                    if (item.Name == header.Name)
                    {
                        duplicated.Add(i);
                    }
                }

                if (duplicated.Count > 0)
                {
                    // 重複がある
                    var list = new List<Header>();
                    foreach (var item in duplicated)
                    {
                        list.Add(to[item]);
                    }
                    // 表示用として連結
                    var oldHeaders = string.Join(", ", list.Select(x => x.ToString()).ToArray());

                    var taskDialog = Dialog.HeaderDuplicated(oldHeaders, header.ToString());
                    taskDialog.OwnerWindowHandle = Handle;
                    var taskDialogResult = taskDialog.Show();
                    if (taskDialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Yes)
                    {
                        // 重複分を消す。削除すると1つインデックスがズレるのでiを減算することで辻褄が合うようにする。
                        for (int i = 0; i < duplicated.Count; i++)
                        {
                            to.RemoveAt(duplicated[i] - i);
                        }
                    }
                    else if (taskDialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Cancel)
                    {
                        // キャンセルなのでreturn
                        return;
                    }
                }

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
            Studio.TJAStudio.EditorChanged();
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
            Studio.TJAStudio.EditorChanged();
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
            Studio.TJAStudio.EditorChanged();
        }

        private void List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HeadersWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
