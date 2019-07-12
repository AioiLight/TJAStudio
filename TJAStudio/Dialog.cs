using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TJAStudio
{
    public static class Dialog
    {
        /// <summary>
        /// .バージョン情報ダイアログ。
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
            dialog.Text = Properties.Dialog.SaveChange_Text;
            dialog.StandardButtons = TaskDialogStandardButtons.Yes | TaskDialogStandardButtons.No | TaskDialogStandardButtons.Cancel;
            dialog.DefaultButton = TaskDialogDefaultButton.Cancel;

            return dialog;
        }


    }
}
