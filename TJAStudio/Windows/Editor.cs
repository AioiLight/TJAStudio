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
    public partial class Editor : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public Editor(Sgry.Azuki.Document doc, Course course)
        {
            InitializeComponent();
            TextEditor.Document = doc;
            Text = Properties.Common.Editor + course.Name;
            TextEditor.Highlighter = null;
            TextEditor.Highlighter = Highlighter.InitHighlighter();
            ColorScheme.SetColorScheme(TextEditor.ColorScheme, Program.Setting);
            TextEditor.ForeColor = Program.Setting.Editor_ForeColor;
            TextEditor.BackColor = Program.Setting.Editor_BackColor;
            TextEditor.Font = new Font(Program.Setting.FontName, Program.Setting.FontSize);
            TextEditor.SetKeyBind(Keys.Back | Keys.Shift, Sgry.Azuki.Actions.BackSpace);
            TextEditor.ShowsLineNumber = Program.Setting.Show_Line_Number;
            TextEditor.ShowsHRuler = Program.Setting.Show_Horizontal_Ruler;
            TextEditor.HRulerStartsFromZero = Program.Setting.Show_Horizontal_Ruler_Zero;
            TextEditor.DrawsEofMark = Program.Setting.Show_EoF_Mark;
            TextEditor.DrawsEolCode = Program.Setting.Show_EoL_Mark;
            TextEditor.DrawsFullWidthSpace = Program.Setting.Show_Space_Mark;
            TextEditor.DrawsSpace = Program.Setting.Show_Space_Mark;
            TextEditor.DrawsTab = Program.Setting.Show_Tab_Mark;
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void TextEditor_Click(object sender, EventArgs e)
        {

        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            Program.Project.Courses[Studio.CurrentCourseID].Document = TextEditor.Document;
            Program.Project.Courses[Studio.CurrentCourseID].Text = TextEditor.Document.Text;
            Studio.TJAStudio.EditorChanged();
            Studio.UpdateHistory();
        }

        private void TextEditor_CaretMoved(object sender, EventArgs e)
        {
            TextEditor.Document.GetCaretIndex(out var line, out var col);
            Studio.UpdateCaret(line, col);
            Studio.UpdateMeasures();
        }
    }
}
