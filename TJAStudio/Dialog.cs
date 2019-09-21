using System;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TJAStudio
{
    public static class Dialog
    {
        /// <summary>
        /// バージョン情報ダイアログ。
        /// </summary>
        /// <returns></returns>
        public static TaskDialog Version()
        {
            void Link_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start(@"https://aioilight.space/");
            }

            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = string.Format(Properties.Dialog.Version_Title, Properties.Common.Name);
            dialog.Text = string.Format(Properties.Dialog.Version_Text, Properties.Common.Name, Program.Version, Properties.Common.Developer, Properties.Common.Website);
            var link = new TaskDialogCommandLink();            
            link.Text = Properties.Dialog.Version_Link;
            link.Click += Link_Click;
            dialog.Controls.Add(link);
            dialog.StandardButtons = TaskDialogStandardButtons.Ok;
            dialog.DefaultButton = TaskDialogDefaultButton.Ok;

            return dialog;
        }

        public static TaskDialog SaveChange()
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = string.Format(Properties.Dialog.SaveChange_Title, Program.Project.ProjectName);
            dialog.Text = string.Format(Properties.Dialog.SaveChange_Text, Program.Project.ProjectName);
            dialog.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No | TaskDialogStandardButtons.Cancel;
            dialog.DefaultButton = TaskDialogDefaultButton.Cancel;

            return dialog;
        }

        public static TaskDialog DanMargeExit()
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = Properties.Dialog.DanMargeExit_Title;
            dialog.Text = Properties.Dialog.DanMargeExit_Text;
            dialog.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No;
            dialog.DefaultButton = TaskDialogDefaultButton.Yes;

            return dialog;
        }

        public static TaskDialog HeaderDuplicated(string oldHeader, string newHeader)
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = Properties.Dialog.HeaderDuplicated_Title;
            dialog.Text = string.Format(Properties.Dialog.HeaderDuplicated_Text, oldHeader, newHeader);
            var remove = new TaskDialogCommandLink();
            remove.Text = Properties.Dialog.HeaderDuplicated_Remove;
            remove.Default = true;
            remove.Click += Remove_Click;
            dialog.Controls.Add(remove);
            var leave = new TaskDialogCommandLink();
            leave.Text = Properties.Dialog.HeaderDuplicated_Leave;
            leave.Click += Leave_Click;
            dialog.Controls.Add(leave);
            var cancel = new TaskDialogCommandLink();
            cancel.Text = Properties.Dialog.HeaderDuplicated_Cancel;
            cancel.Click += Leave_Cancel;
            dialog.Controls.Add(cancel);

            return dialog;

            void Remove_Click(object sender, EventArgs e)
            {
                dialog.Close(TaskDialogResult.Yes);
            }

            void Leave_Click(object sender, EventArgs e)
            {
                dialog.Close(TaskDialogResult.No);
            }

            void Leave_Cancel(object sender, EventArgs e)
            {
                dialog.Close(TaskDialogResult.Cancel);
            }
        }

        public static TaskDialog SimulatorNotFound()
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = Properties.Dialog.SimulatorNotFound_Title;
            dialog.Text = string.Format(Properties.Dialog.SimulatorNotFound_Text, Program.Setting.SimulatorPath);
            dialog.StandardButtons = TaskDialogStandardButtons.Ok;
            dialog.DefaultButton = TaskDialogDefaultButton.Ok;

            return dialog;
        }

        public static TaskDialog ItsNotTJAFile(string fileName)
        {
            var dialog = new TaskDialog();
            dialog.Icon = TaskDialogStandardIcon.Information;
            dialog.Caption = Properties.Common.Name;
            dialog.InstructionText = Properties.Dialog.ItsNotTJAFile_Title;
            dialog.Text = string.Format(Properties.Dialog.ItsNotTJAFile_Text, fileName);
            dialog.StandardButtons = TaskDialogStandardButtons.Ok;
            dialog.DefaultButton = TaskDialogDefaultButton.Ok;

            return dialog;
        }
    }
}
