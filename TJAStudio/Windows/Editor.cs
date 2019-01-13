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
            Text = "Editor - " + course.Name;
            TextEditor.Highlighter = null;
            TextEditor.Highlighter = Highlighter.InitHighlighter();
            ColorScheme.SetColorScheme(TextEditor.ColorScheme);
            TextEditor.ForeColor = Program.Setting.Editor_ForeColor;
            TextEditor.BackColor = Program.Setting.Editor_BackColor;
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
            Studio.TJAStudio.EditorChanged();
        }
    }
}
