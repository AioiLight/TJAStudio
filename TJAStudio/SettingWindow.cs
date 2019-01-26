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
    public partial class SettingWindow : Form
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            Tab_Editor_Sample.Text = Properties.Common.SampleText;
            Tab_Editor_Sample.Highlighter = Highlighter.InitHighlighter();
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme);
            Tab_Editor_Sample.ForeColor = Program.Setting.Editor_ForeColor;
            Tab_Editor_Sample.BackColor = Program.Setting.Editor_BackColor;
            Tab_Editor_Sample.Font = new Font(Program.Setting.FontName, Program.Setting.FontSize);
            Tab_Editor_Sample.SetKeyBind(Keys.Back | Keys.Shift, Sgry.Azuki.Actions.BackSpace);
            GetSettings();
        }

        private void GetSettings()
        {
            // 言語
            Tab_General_Language_ComboBox.SelectedText = Program.Setting.Locale;

            Tab_General_SimulatorPath_TextBox.Text = Program.Setting.SimulatorPath;
            Tab_General_Workspace_TextBox.Text = Program.Setting.WorkspacePath;

            // 色
            GetColorsFromSettings(Program.Setting.Editor_ForeColor, Program.Setting.Editor_BackColor, ref Tab_Editor_Normal);
            GetColorsFromSettings(Program.Setting.ColorScheme.Comment, ref Tab_Editor_Comment);
            GetColorsFromSettings(Program.Setting.ColorScheme.Keyword, ref Tab_Editor_Header);
            GetColorsFromSettings(Program.Setting.ColorScheme.Command, ref Tab_Editor_Command);

            GetColorsFromSettings(Program.Setting.ColorScheme.Space, ref Tab_Editor_Space);
            GetColorsFromSettings(Program.Setting.ColorScheme.Don, ref Tab_Editor_Don);
            GetColorsFromSettings(Program.Setting.ColorScheme.Ka, ref Tab_Editor_Ka);
            GetColorsFromSettings(Program.Setting.ColorScheme.Roll, ref Tab_Editor_Roll);
            GetColorsFromSettings(Program.Setting.ColorScheme.Balloon, ref Tab_Editor_Balloon);
            GetColorsFromSettings(Program.Setting.ColorScheme.Other, ref Tab_Editor_Other);

            // チェックボックス
            GetBooleanFromSettings(Program.Setting.UTF8Mode, ref Tab_General_UTF8Mode);
            GetBooleanFromSettings(Program.Setting.Show_Horizontal_Ruler, ref Tab_Editor_Show_HR);
            GetBooleanFromSettings(Program.Setting.Show_Line_Number, ref Tab_Editor_Line);
            GetBooleanFromSettings(Program.Setting.Show_Horizontal_Ruler_Zero, ref Tab_Editor_HR_From_Zero);
            GetBooleanFromSettings(Program.Setting.Show_Space_Mark, ref Tab_Editor_SpaceMark);
            GetBooleanFromSettings(Program.Setting.Show_Tab_Mark, ref Tab_Editor_TabMark);
            GetBooleanFromSettings(Program.Setting.Show_EoL_Mark, ref Tab_Editor_EoL);
            GetBooleanFromSettings(Program.Setting.Show_EoF_Mark, ref Tab_Editor_EoF);
        }

        private void GetBooleanFromSettings(bool boolean, ref CheckBox checkbox)
        {
            checkbox.Checked = boolean;
        }
        private void GetColorsFromSettings(ColorFormat colorFormat, ref Button button)
        {
            GetColorsFromSettings(colorFormat.ForeColor, colorFormat.BackColor, ref button);
        }
        private void GetColorsFromSettings(Color foreColor, Color backColor, ref Button button)
        {
            button.ForeColor = foreColor;
            button.BackColor = backColor;
        }

        private void Tab_Editor_HR_From_Zero_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
