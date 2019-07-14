using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Application.Idle += Idling_Process;
            Dock.Theme = new VS2015LightTheme();

            if (File.Exists(Program.EXEPath + @"\Windows.xml"))
            {
                Dock.LoadFromXml(Program.EXEPath + @"\Windows.xml", new DeserializeDockContent(GetDockContentFromPersistString));
            }
            else
            {
                Project.Show(Dock, DockState.DockRight);
                Courses.Show(Dock, DockState.DockRight);
                HeaderWindow.Show(Dock, DockState.DockLeft);
                CommonHeaderWindow.Show(Dock, DockState.DockLeft);
            }
            AddCourse("Oni");
            Dock.DockLeftPortion = 0.36;
            Dock.DockRightPortion = 0.36;
            Text = Properties.Common.Name;
            Menu_Version.Text = Properties.Common.Name + " Ver." + Program.Version;
            Program.Project.ProjectName = Properties.Common.UntitledProjectName;
            TitleChange();
        }

        public Studio(string fileName) : this()
        {
            FileOpen(false, fileName);
        } 

        private void Dock_ActiveDocumentChanged(object sender, EventArgs e)
        {
            if (Dock.DocumentsCount < 1) return;
            var index = Courses.List.FindItemWithText(Dock.ActiveDocument.DockHandler.TabText.Substring(Properties.Common.Editor.Length));
            if(index != null)CurrentCourseID = index.Index;
            HeaderWindow.SetHeaderFromList(Program.Project.Courses[CurrentCourseID].Header);
            CommonHeaderWindow.SetHeaderFromList(Program.Project.CommonHeader);
            Program.Project.Courses[CurrentCourseID].Document.GetCaretIndex(out var line, out var col);
            UpdateCaret(line, col);
            UpdateMeasures();
            UpdateHistory();
        }

        private void Menu_Tool_About_Click(object sender, EventArgs e)
        {
            var dialog = Dialog.Version();
            dialog.OwnerWindowHandle = Handle;
            dialog.Show();
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

        public void Save()
        {
            if (!File.Exists(FileName))
            {
                SaveAs();
                return;
            }
            FileManager.SaveFile(FileName, Program.Project);
            IsEdited = false;
            TitleChange();
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

        private void AddCourse(string name)
        {
            var index = Program.WindowManager.AddCourse(name);
            Courses.SetCoursesFromList();
            Program.WindowManager.Editors[index].Show(Dock);

        }

        private void Menu_File_New_Click(object sender, EventArgs e)
        {
            if (IsEdited)
            {
                var dialog = Dialog.SaveChange();
                dialog.OwnerWindowHandle = Handle;
                var dialogResult = dialog.Show();
                if (dialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Yes) Save();
                else if (dialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Cancel) return;
            }
            Close();
            Application.Restart();
        }

        private void Initaize()
        {
            Program.WindowManager = new WindowManager();
            Program.Project = new Projects();
        }

        private void Menu_File_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Open(string defalutDir = null, bool isTemplate = false)
        {
            if (IsEdited)
            {
                var dialog = Dialog.SaveChange();
                dialog.OwnerWindowHandle = Handle;
                var dialogResult = dialog.Show();
                if (dialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Yes) Save();
                else if (dialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Cancel) return;
            }
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = isTemplate ? Properties.SystemMessage.OpenTemplate : Properties.SystemMessage.OpenProject;
            if (defalutDir != null) fileDialog.InitialDirectory = defalutDir;
            fileDialog.Filter = String.Format("{0}|*{1}", Properties.Common.ExtensionDescription, Properties.Common.ExtensionName);
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileOpen(isTemplate, fileDialog.FileName);
            }
        }

        private void FileOpen(bool isTemplate, string fileName)
        {
            Initaize();
            Program.Project = FileManager.OpenFile(fileName);
            Courses.SetCoursesFromList();
            Project.SetCoursesFromList();


            foreach (var item in Dock.Documents)
            {
                item.DockHandler.Hide();
            }

            foreach (var item in Program.Project.Courses)
            {
                Program.WindowManager.Editors.Add(new Editor(new Sgry.Azuki.Document(), item));
                Program.WindowManager.Editors[Program.WindowManager.Editors.Count - 1].Show(Dock);
                Program.WindowManager.Editors[Program.WindowManager.Editors.Count - 1].TextEditor.Document.Text = item.Text?.Replace("\n", Environment.NewLine);
            }
            Courses.SetCoursesFromList();
            Project.SetCoursesFromList();
            Program.Project.ProjectName = isTemplate ? Properties.Common.UntitledProjectName : Program.Project.ProjectName;
            IsEdited = false;
            TitleChange();
            FileName = isTemplate ? "" : fileName;
        }

        private void Menu_File_OpenTmpl_Click(object sender, EventArgs e)
        {
            Open(Program.EXEPath + @"\Template\", true);
        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Menu_Edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private static void Undo()
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Undo();
        }

        private void Menu_Edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private static void Redo()
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Redo();
        }

        private void Menu_Edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private static void Cut()
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Cut();
        }

        private void Menu_Edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private static void Copy()
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Copy();
        }

        private void Menu_Edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private static void Paste()
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Paste();
        }

        private void Menu_Edit_GoTo_Click(object sender, EventArgs e)
        {
            var dialog = new GoTo(Program.WindowManager.Editors[CurrentCourseID].TextEditor.Document.LineCount);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Document.SetCaretIndex((int)dialog.Num.Value - 1, 0);
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.ScrollToCaret();
            }
        }

        private void Menu_Edit_SelectAll_Click(object sender, EventArgs e)
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.SelectAll();
        }

        private void Menu_Edit_Time_Click(object sender, EventArgs e)
        {
            TextInsert("//" + DateTime.Now.ToString());
        }

        private void TextInsert(string text)
        {
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused)
                Program.WindowManager.Editors[CurrentCourseID].TextEditor.Document.Replace(text);
        }

        private void Menu_Edit_NotesOperation_ToDon_Click(object sender, EventArgs e)
        {
            var splitedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Split('\n');
            string resultText = "";
            for (int i = 0; i < splitedText.Length; i++)
            {
                var index = "";
                splitedText[i] = Regex.Replace(splitedText[i], " *//.*", String.Empty);
                if (!splitedText[i].StartsWith("#") || !splitedText[i].Contains(":"))
                {
                    index = splitedText[i].Replace('2', '1');
                    index = index.Replace('4', '3');
                }
                resultText += index;
                if (i != splitedText.Length - 1) resultText += "\n";
            }
            TextInsert(resultText);
        }

        private void Menu_Edit_NotesOperation_ToKa_Click(object sender, EventArgs e)
        {
            var splitedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Split('\n');
            string resultText = "";
            for (int i = 0; i < splitedText.Length; i++)
            {
                var index = "";
                splitedText[i] = Regex.Replace(splitedText[i], " *//.*", String.Empty);
                if (!splitedText[i].StartsWith("#") || !splitedText[i].Contains(":"))
                {
                    index = splitedText[i].Replace('1', '2');
                    index = index.Replace('3', '4');
                }
                resultText += index;
                if (i != splitedText.Length - 1) resultText += "\n";
            }
            TextInsert(resultText);
        }

        private void Menu_Edit_NotesOperation_Abekobe_Click(object sender, EventArgs e)
        {
            var splitedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Split('\n');
            string resultText = "";
            for (int i = 0; i < splitedText.Length; i++)
            {
                var index = "";
                splitedText[i] = Regex.Replace(splitedText[i], " *//.*", String.Empty);
                if (!splitedText[i].StartsWith("#") || !splitedText[i].Contains(":"))
                {
                    foreach (var item in splitedText[i])
                    {
                        if (item == '1')
                        {
                            index += '2';
                        }
                        else if (item == '2')
                        {
                            index += '1';
                        }
                        else if (item == '3')
                        {
                            index += '4';
                        }
                        else if (item == '4')
                        {
                            index += '3';
                        }
                        else
                        {
                            index += item;
                        }
                    }
                }
                resultText += index;
                if (i != splitedText.Length - 1) resultText += "\n";
            }
            TextInsert(resultText);
        }

        private void Menu_Edit_NotesOperation_Detarame_Click(object sender, EventArgs e)
        {
            var splitedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Split('\n');
            var resultText = "";
            var random = new Random();
            for (int i = 0; i < splitedText.Length; i++)
            {
                var index = "";
                splitedText[i] = Regex.Replace(splitedText[i], " *//.*", String.Empty);
                if (!splitedText[i].StartsWith("#") || !splitedText[i].Contains(":"))
                {
                    foreach (var item in splitedText[i])
                    {
                        if (item == '1')
                        {
                            index += random.Next(2) + 1;
                        }
                        else if (item == '2')
                        {
                            index += random.Next(2) + 1;
                        }
                        else if (item == '3')
                        {
                            index += random.Next(2) + 3;
                        }
                        else if (item == '4')
                        {
                            index += random.Next(2) + 3;
                        }
                        else
                        {
                            index += item;
                        }
                    }
                }
                resultText += index;
                if (i != splitedText.Length - 1) resultText += "\n";
            }
            TextInsert(resultText);

        }

        private void Menu_Edit_Repert_Click(object sender, EventArgs e)
        {
            if (!Program.WindowManager.Editors[CurrentCourseID].TextEditor.Focused) return;
            var selectedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText();
            TextInsert(selectedText + "\n" + selectedText);
        }

        private void Menu_Window_CommonHeader_Click(object sender, EventArgs e)
        {
            CommonHeaderWindow.Show();
        }

        private void Menu_Window_Courses_Click(object sender, EventArgs e)
        {
            Courses.Show();
        }

        private void Menu_Window_CourseHeader_Click(object sender, EventArgs e)
        {
            HeaderWindow.Show();
        }

        private void Menu_Window_Projects_Click(object sender, EventArgs e)
        {
            Project.Show();
        }

        private void Tool_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void Tool_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void Tool_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void Tool_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void Tool_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void Menu_Execution_Start_Click(object sender, EventArgs e)
        {
            Execute();
        }
        private void Tool_Execute_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void Execute()
        {
            try
            {
                TJAStudio.MakePreview(Program.Project.Courses[Studio.CurrentCourseID]);
                System.Diagnostics.Process.Start(Program.Setting.SimulatorPath, String.Format("\"{0}{1}\"", Program.EXEPath + @"\temp\", Program.Project.ProjectName + ".tja"));
            }
            catch (Exception)
            {
                var dialog = Dialog.SimulatorNotFound();
                dialog.OwnerWindowHandle = Handle;
                dialog.Show();
            }
        }

        public void MakePreview(Course course, bool isCalledTextEditor = false)
        {
            if (isCalledTextEditor && !Menu_Execution_LiveUpdate.Checked) return;
            var tempDir = Program.EXEPath + @"\temp\";
            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
            }
            TJAManager.Build(tempDir + Program.Project.ProjectName + ".tja", Program.Project.CommonHeader, new Course[] { Program.Project.Courses[CurrentCourseID] }, Program.Setting.UTF8Mode ? Encoding.UTF8 : Encoding.GetEncoding("Shift_JIS"));
            foreach (var item in Program.Project.ProjectFile)
            {
                var fileName = tempDir + Path.GetFileName(item);
                if (File.Exists(fileName))
                {
                    try
                    {
                        File.Delete(fileName);
                    }
                    catch (Exception)
                    {

                    }
                }
                try
                {
                    File.Copy(item, fileName);
                }
                catch (Exception)
                {

                }
            }
        }

        private void Menu_Execution_LiveUpdate_Click(object sender, EventArgs e)
        {
            Menu_Execution_LiveUpdate.Checked = !Menu_Execution_LiveUpdate.Checked;
        }

        private void Menu_File_Export_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = Properties.SystemMessage.SaveTJA;
            dialog.FileName = Program.Project.ProjectName + Properties.Common.TJAExtensionName;
            dialog.Filter = string.Format("{0}|*{1}", Properties.Common.TJAExtensionDescription, Properties.Common.TJAExtensionName);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                TJAManager.Build(dialog.FileName, Program.Project, Program.Setting.UTF8Mode ? Encoding.UTF8 : Encoding.GetEncoding("Shift_JIS"));
                foreach (var item in Program.Project.ProjectFile)
                {
                    var fileName = Path.GetDirectoryName(dialog.FileName) + "\\" + Path.GetFileName(item);
                    try
                    {
                        File.Copy(item, fileName, true);
                    }
                    catch (Exception)
                    {

                    }
                }

                // フォルダを開く
                if (Program.Setting.Open_Extract_Folder)
                {
                    var dir = Path.GetDirectoryName(dialog.FileName);
                    System.Diagnostics.Process.Start(dir);
                }

            }
        }

        public static void UpdateCaret(int line, int col)
        {
            TJAStudio.Status_Caret.Text = string.Format(Properties.SystemMessage.NowCaret, ++line, ++col);
        }

        public static void UpdateMeasures()
        {
            var measure = Measure.GetMeasure(Program.Project.Courses[CurrentCourseID].Document);
            TJAStudio.Status_Measures.Text = string.Format(Properties.SystemMessage.Status_Measure, measure[1] + 1, measure[0] + 1);
        }
        private void Studio_Leave(object sender, EventArgs e)
        {
            //Studio.TJAStudio.MakePreview(Program.Project.Courses[Studio.CurrentCourseID], true);
        }

        public static void UpdateHistory()
        {
            var checkUndo = Program.Project.Courses[CurrentCourseID].Document.CanUndo;
            var checkRedo = Program.Project.Courses[CurrentCourseID].Document.CanRedo;
            TJAStudio.Menu_Edit_Undo.Enabled = checkUndo;
            TJAStudio.Tool_Undo.Enabled = checkUndo;
            TJAStudio.Menu_Edit_Redo.Enabled = checkRedo;
            TJAStudio.Tool_Redo.Enabled = checkRedo;
        }


        private void Menu_Version_Site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://aioilight.space/");
        }

        private void Menu_Version_TJAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://aioilight.space/taiko/tjas/");
        }

        private void Studio_Deactivate(object sender, EventArgs e)
        {
            if (Menu_Execution_LiveUpdate.Checked && Program.Project != null)
            {
                TJAStudio.MakePreview(Program.Project.Courses[CurrentCourseID]);
            }
        }

        private void Studio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsEdited)
            {
                var dialog = Dialog.SaveChange();
                dialog.OwnerWindowHandle = Handle;
                var dialogResult = dialog.Show();
                if (dialogResult == Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Yes)
                {
                    Save();
                    if (IsEdited) e.Cancel = true; 
                }
                else if (dialogResult ==  Microsoft.WindowsAPICodePack.Dialogs.TaskDialogResult.Cancel) e.Cancel = true;
            }

            // 子ウィンドウの保存とか
            Dock.SaveAsXml(Program.EXEPath + @"\Windows.xml");
        }

        private IDockContent GetDockContentFromPersistString(string persistString)
        {
            // GetPersistString()メソッドが返す名前に合わせたフォームを返す
            switch (persistString)
            {
                case nameof(Courses):
                    return Courses;
                case "CommonHeader":
                    return CommonHeaderWindow;
                case "CourseHeader":
                    return HeaderWindow;
                case "Project":
                    return Project;                
            }
            return null;
        }

        private void Tool_SaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void Tool_Save_Click(object sender, EventArgs e)
        {
            
        }

        private void Tool_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Tool_Save_ButtonClick(object sender, EventArgs e)
        {
            Save();
        }

        private void Idling_Process(object sender, EventArgs e)
        {
            // 入力モードの決定
            var mode = Properties.SystemMessage.Status_Mode;
            mode = !IsKeyLocked(Keys.Insert)
                ? string.Format(mode, Properties.SystemMessage.Status_Mode_Insert)
                : string.Format(mode, Properties.SystemMessage.Status_Mode_Overwrite);
            Status_Mode.Text = mode;
        }

        private void Menu_Window_FormatCheker_Click(object sender, EventArgs e)
        {
            ShowFormatChecker();
        }

        private void ShowFormatChecker()
        {
            if (FormatChecker == null || FormatChecker.IsDisposed)
            {
                FormatChecker = new FormatChecker();
                FormatChecker.Show(this);
            }
        }

        private void Tool_FormatCheker_Click(object sender, EventArgs e)
        {
            ShowFormatChecker();
        }

        private void Menu_Tool_Settings_Click(object sender, EventArgs e)
        {
            var dialog = new SettingWindow();
            var dialogResult = dialog.ShowDialog(this);
            dialog.Dispose();
            if(dialogResult == DialogResult.OK)
            {
                Close();
                Application.Restart();
            }
        }

        private void Menu_Tool_DanBuilder_Click(object sender, EventArgs e)
        {
            var dialog = new DanMarge.DanBuilder();
            dialog.ShowDialog(this);
            dialog.Dispose();
        }
        private void Menu_Edit_NotesOperation_Command_Click(object sender, EventArgs e)
        {
            var selectedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText();
            var result = "";
            // 改行で分割
            foreach (var item in selectedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (!item.Trim().StartsWith("#"))
                {
                    // 命令行ではない場合のみ処理する。
                    // カンマで終わる場合改行し、カンマでない場合は改行せずに続ける。
                    result += item.Trim().EndsWith(",") ? item + Environment.NewLine : item;
                }
            }
            TextInsert(result);
        }
        private void Menu_Command_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Command_StartEnd_Click(object sender, EventArgs e)
        {
            var isExistBefore = IsExistCharBeforeCaret();
            var isExistAfter = IsExistCharAfterCaret();
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Length > 0)
            {
                // 選択状態
                var text = "";
                if (isExistBefore)
                {
                    text += Environment.NewLine;
                }
                text += "#START" + Environment.NewLine
                    + Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText()
                    + Environment.NewLine + "#END";
                if (isExistAfter)
                {
                    text += Environment.NewLine;
                }
                TextInsert(text);
            }
            else
            {
                var text = "";
                if (isExistBefore)
                {
                    text += Environment.NewLine;
                }
                text += "#START" + Environment.NewLine + "#END";
                if (isExistAfter)
                {
                    text += Environment.NewLine;
                }
                TextInsert(text);
            }
        }

        private void Menu_Command_GoGoTime_Click(object sender, EventArgs e)
        {
            var isExistBefore = IsExistCharBeforeCaret();
            var isExistAfter = IsExistCharAfterCaret();
            if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Length > 0 )
            {
                // 選択状態
                var text = "";
                if (isExistBefore)
                {
                    text += Environment.NewLine;
                }
                text += "#GOGOSTART" + Environment.NewLine
                    + Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText()
                    + Environment.NewLine + "#GOGOEND";
                if (isExistAfter)
                {
                    text += Environment.NewLine;
                }
                TextInsert(text);
            }
            else
            {
                var text = "";
                if (isExistBefore)
                {
                    text += Environment.NewLine;
                }
                text += "#GOGOSTART" + Environment.NewLine + "#GOGOEND";
                if (isExistAfter)
                {
                    text += Environment.NewLine;
                }
                TextInsert(text);
            }
        }

        private void Menu_Command_Scroll_Click(object sender, EventArgs e)
        {
            var nearstScroll = GetCommandFromEditor("#SCROLL");
            var beforeScrollFound = false;
            var beforeScroll = 1.0;
            var isExistBefore = IsExistCharBeforeCaret();
            var isExistAfter = IsExistCharAfterCaret();
            if (nearstScroll != null)
            {
                double.TryParse(nearstScroll.Substring("#SCROLL".Length), out beforeScroll);
                beforeScrollFound = true;
            }
            var dialog = beforeScrollFound ? new Windows.ScrollChanger(beforeScroll) : new Windows.ScrollChanger();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // ちぇんじ!!!
                if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Length > 0)
                {
                    // 選択状態
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#SCROLL " + dialog.Num_Amount.Value + Environment.NewLine
                        + Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText()
                        + Environment.NewLine + "#SCROLL " + beforeScroll.ToString();
                    if(isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
                else
                {
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#SCROLL " + dialog.Num_Amount.Value;
                    if (isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
            }
        }

        private void Menu_Command_BPM_Click(object sender, EventArgs e)
        {
            var nearstHeader = GetHeaderFromHeader("BPM:");
            var beforeBPM = 120.0;
            var beforeBPMFound = false;
            if (nearstHeader != null)
            {
                double.TryParse(nearstHeader.Substring("BPM:".Length), out beforeBPM);
                beforeBPMFound = true;
            }

            var nearstBPM = GetCommandFromEditor("#BPMCHANGE");
            var isExistBefore = IsExistCharBeforeCaret();
            var isExistAfter = IsExistCharAfterCaret();
            if (nearstBPM != null)
            {
                double.TryParse(nearstBPM.Substring("#BPMCHANGE".Length), out beforeBPM);
                beforeBPMFound = true;
            }
            var dialog = beforeBPMFound ? new Windows.BPMChanger(beforeBPM) : new Windows.BPMChanger();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // ちぇんじ!!!
                if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Length > 0)
                {
                    // 選択状態
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#BPMCHANGE " + dialog.Num_Amount.Value + Environment.NewLine
                        + Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText()
                        + Environment.NewLine + "#BPMCHANGE " + beforeBPM.ToString();
                    if (isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
                else
                {
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#BPMCHANGE " + dialog.Num_Amount.Value;
                    if (isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
            }
        }

        private void Menu_Command_Measure_Click(object sender, EventArgs e)
        {
            var nearstMeasure = GetCommandFromEditor("#MEASURE");
            var beforeMeasureFound = false;
            var beforeMeasureChild = 4.0;
            var beforeMeasureMother = 4.0;
            var isExistBefore = IsExistCharBeforeCaret();
            var isExistAfter = IsExistCharAfterCaret();
            if (nearstMeasure != null)
            {
                double.TryParse(nearstMeasure.Substring("#MEASURE".Length).Split('/')[0], out beforeMeasureChild);
                double.TryParse(nearstMeasure.Substring("#MEASURE".Length).Split('/')[1], out beforeMeasureMother);
                beforeMeasureFound = true;
            }
            var dialog = beforeMeasureFound ? new Windows.MeasureChanger(beforeMeasureChild, beforeMeasureMother) : new Windows.MeasureChanger();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // ちぇんじ!!!
                if (Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText().Length > 0)
                {
                    // 選択状態
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#MEASURE " + dialog.Num_Child.Value + "/" + dialog.Num_Mother.Value + Environment.NewLine
                        + Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText()
                        + Environment.NewLine + "#MEASURE " + beforeMeasureChild + "/" + beforeMeasureMother;
                    if (isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
                else
                {
                    var text = "";
                    if (isExistBefore)
                    {
                        text += Environment.NewLine;
                    }
                    text += "#MEASURE " + dialog.Num_Child.Value + "/" + dialog.Num_Mother.Value;
                    if (isExistAfter)
                    {
                        text += Environment.NewLine;
                    }
                    TextInsert(text);
                }
            }

        }

        /// <summary>
        /// 現在位置より前にある、かつ一番近い#命令を返します。
        /// </summary>
        /// <param name="command">#命令名。</param>
        /// <returns>結果。ヒットしなかった場合、nullが返される。</returns>
        private string GetCommandFromEditor(string command)
        {
            var nowCaret = Program.WindowManager.Editors[CurrentCourseID].TextEditor.CaretIndex;
            var beforText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetTextInRange(0, nowCaret);
            var result = "";
            foreach (var item in beforText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (item.StartsWith(command))
                {
                    result = item;
                }
            }
            return string.IsNullOrWhiteSpace(result) ? null : result ;
        }

        /// <summary>
        /// 共通ヘッダとコースヘッダから、最後に追加されたヘッダーを返します。
        /// </summary>
        /// <param name="command">ヘッダー名。</param>
        /// <returns>結果。ヒットしなかった場合、nullが返される。</returns>
        private string GetHeaderFromHeader(string command)
        {
            var commonHeader = Program.Project.CommonHeader;
            var courseHeader = Program.Project.Courses[CurrentCourseID].Header;
            var headers = commonHeader.Concat(courseHeader);
            var result = "";
            foreach (var item in headers)
            {
                if (item.ToString().StartsWith(command))
                {
                    // HEADER:hogehoge
                    result = item.ToString();
                }
            }
            return string.IsNullOrWhiteSpace(result) ? null : result;
        }

        private bool IsExistCharBeforeCaret()
        {
            var caret = Program.WindowManager.Editors[CurrentCourseID].TextEditor.CaretIndex;
            if (caret == 0)
            {
                return false;
            }
            var beforChar = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetTextInRange(caret - 1, caret);
            if (beforChar != Environment.NewLine)
            {
                return true;
            }
            return false;
        }

        private bool IsExistCharAfterCaret()
        {
            var caret = Program.WindowManager.Editors[CurrentCourseID].TextEditor.CaretIndex;
            if (caret == Program.WindowManager.Editors[CurrentCourseID].TextEditor.TextLength)
            {
                return false;
            }

            var afterChar = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetTextInRange(caret, caret + 1);
            if (afterChar != Environment.NewLine)
            {
                return true;
            }
            return false;
        }

        private Courses Courses = new Courses();
        private Project Project = new Project();
        public  HeadersWindow HeaderWindow = new HeadersWindow(false);
        private HeadersWindow CommonHeaderWindow = new HeadersWindow(true, Properties.Common.CommonHeader);
        private FormatChecker FormatChecker { get; set; }
        public static Studio TJAStudio { get; set; }
        public static int CurrentCourseID { get; set; }
        public bool IsEdited { get; set; }
        public string FileName { get; set; }
    }
}
