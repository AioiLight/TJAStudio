using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Studio.UpdateCaret(line, col);
            Studio.UpdateMeasures();
            Studio.UpdateHistory();
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
                var dialogResult = MessageBox.Show(String.Format(Properties.SystemMessage.ApplicationExit, Program.Project.ProjectName), Properties.Common.Name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                if (dialogResult == DialogResult.Yes) Save();
                else if (dialogResult == DialogResult.Cancel) return;
            }
            this.Close();
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
                var dialogResult = MessageBox.Show(String.Format(Properties.SystemMessage.ApplicationExit, Program.Project.ProjectName), Properties.Common.Name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                if (dialogResult == DialogResult.Yes) Save();
                else if (dialogResult == DialogResult.Cancel) return;
            }
            var dialog = new OpenFileDialog();
            dialog.Title = isTemplate ? Properties.SystemMessage.OpenTemplate : Properties.SystemMessage.OpenProject;
            if (defalutDir != null) dialog.InitialDirectory = defalutDir;
            dialog.Filter = String.Format("{0}|*{1}", Properties.Common.ExtensionDescription, Properties.Common.ExtensionName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileOpen(isTemplate, dialog.FileName);
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
                Program.WindowManager.Editors[Program.WindowManager.Editors.Count - 1].TextEditor.Document.Text = item.Text;
                Program.WindowManager.Editors[Program.WindowManager.Editors.Count - 1].Show(Dock);
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
            Application.Exit();
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
            string resultText = "";
            Random random = new Random();
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
            string selectedText = Program.WindowManager.Editors[CurrentCourseID].TextEditor.GetSelectedText();
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

        private static void Execute()
        {
            try
            {
                TJAStudio.MakePreview(Program.Project.Courses[Studio.CurrentCourseID]);
                System.Diagnostics.Process.Start(Program.Setting.SimulatorPath, String.Format("\"{0}{1}\"", Program.EXEPath + @"\temp\", Program.Project.ProjectName + ".tja"));
            }
            catch (Exception)
            {

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
            dialog.Filter = String.Format("{0}|*{1}", Properties.Common.TJAExtensionDescription, Properties.Common.TJAExtensionName);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                TJAManager.Build(dialog.FileName, Program.Project, Program.Setting.UTF8Mode ? Encoding.UTF8 : Encoding.GetEncoding("Shift_JIS"));
            }
        }

        public static void UpdateCaret(int line, int col)
        {
            TJAStudio.Status_Caret.Text = String.Format(Properties.SystemMessage.NowCaret, ++line, ++col);
        }

        public static void UpdateMeasures()
        {
            var measure = Measure.GetMeasure(Program.Project.Courses[Studio.CurrentCourseID].Document);
            TJAStudio.Status_Measures.Text = String.Format(Properties.SystemMessage.Status_Measure, measure[1] + 1, measure[0] + 1);
        }
        private void Studio_Leave(object sender, EventArgs e)
        {
            //Studio.TJAStudio.MakePreview(Program.Project.Courses[Studio.CurrentCourseID], true);
        }

        public static void UpdateHistory()
        {
            var checkUndo = Program.Project.Courses[Studio.CurrentCourseID].Document.CanUndo;
            var checkRedo = Program.Project.Courses[Studio.CurrentCourseID].Document.CanRedo;
            TJAStudio.Menu_Edit_Undo.Enabled = checkUndo;
            TJAStudio.Tool_Undo.Enabled = checkUndo;
            TJAStudio.Menu_Edit_Redo.Enabled = checkRedo;
            TJAStudio.Tool_Redo.Enabled = checkRedo;
        }

        private Courses Courses = new Courses();
        private Project Project = new Project();
        public  HeadersWindow HeaderWindow = new HeadersWindow(false);
        private HeadersWindow CommonHeaderWindow = new HeadersWindow(true, Properties.Common.CommonHeader);
        public static Studio TJAStudio { get; set; }
        public static int CurrentCourseID { get; set; }
        public bool IsEdited { get; set; }
        public string FileName { get; set; }

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
                Studio.TJAStudio.MakePreview(Program.Project.Courses[Studio.CurrentCourseID]);
            }
        }

        private void Studio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsEdited)
            {
                var dialogResult = MessageBox.Show(String.Format(Properties.SystemMessage.ApplicationExit, Program.Project.ProjectName), Properties.Common.Name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
                if (dialogResult == DialogResult.Yes)
                {
                    Save();
                    if (IsEdited) e.Cancel = true; 
                }
                else if (dialogResult == DialogResult.Cancel) e.Cancel = true;
            }
        }
    }
}
