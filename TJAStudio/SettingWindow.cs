using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class SettingWindow : Form
    {
        private Setting Setting { get; set; } = new Setting();

        public SettingWindow()
        {
            InitializeComponent();
            Setting = Program.Setting.DeepCopy();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            Tab_Editor_Sample.Text = Properties.Common.SampleText;
            Tab_Editor_Sample.Highlighter = Highlighter.InitHighlighter();
            Tab_Editor_Sample.SetKeyBind(Keys.Back | Keys.Shift, Sgry.Azuki.Actions.BackSpace);
            GetSettings();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            SetSettings();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Tab_Editor_Normal_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Normal);
        }

        private void Tab_Editor_Comment_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Comment);
        }

        private void Tab_Editor_Header_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Header);
        }

        private void Tab_Editor_Command_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Command);
        }

        private void Tab_Editor_Space_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Space);
        }

        private void Tab_Editor_Don_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Don);
        }

        private void Tab_Editor_Ka_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Ka);
        }

        private void Tab_Editor_Roll_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Roll);
        }

        private void Tab_Editor_Balloon_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Balloon);
        }

        private void Tab_Editor_Other_Click(object sender, EventArgs e)
        {
            SetColor(ref Tab_Editor_Other);
        }

        private void Tab_Editor_Show_HR_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_Horizontal_Ruler = Tab_Editor_Sample.ShowsHRuler = Tab_Editor_Show_HR.Checked;
        }

        private void Tab_Editor_Line_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_Line_Number = Tab_Editor_Sample.ShowsLineNumber = Tab_Editor_Line.Checked;
        }

        private void Tab_Editor_HR_From_Zero_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_Horizontal_Ruler_Zero = Tab_Editor_Sample.HRulerStartsFromZero = Tab_Editor_HR_From_Zero.Checked;
        }

        private void Tab_Editor_SpaceMark_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_Space_Mark = Tab_Editor_Sample.DrawsSpace = Tab_Editor_SpaceMark.Checked;
            Tab_Editor_Sample.DrawsFullWidthSpace = Tab_Editor_SpaceMark.Checked;
            Tab_Editor_Sample.DrawsSpace = Tab_Editor_SpaceMark.Checked;
        }

        private void Tab_Editor_TabMark_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_Tab_Mark = Tab_Editor_Sample.DrawsTab = Tab_Editor_TabMark.Checked;
        }

        private void Tab_Editor_EoL_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_EoL_Mark = Tab_Editor_Sample.DrawsEolCode = Tab_Editor_EoL.Checked;
        }

        private void Tab_Editor_EoF_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Show_EoF_Mark = Tab_Editor_Sample.DrawsEofMark = Tab_Editor_EoF.Checked;
        }

        private void Tab_Editor_Normal_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.Editor_ForeColor = Tab_Editor_Sample.ForeColor = Tab_Editor_Normal.ForeColor;
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Normal_BackColorChanged(object sender, EventArgs e)
        {
            Setting.Editor_BackColor = Tab_Editor_Sample.BackColor = Tab_Editor_Normal.BackColor;
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Comment_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Comment.ForeColor = Tab_Editor_Comment.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Comment_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Comment.BackColor = Tab_Editor_Comment.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Header_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Keyword.ForeColor = Tab_Editor_Header.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Header_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Keyword.BackColor = Tab_Editor_Header.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Command_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Command.ForeColor = Tab_Editor_Command.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Command_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Command.BackColor = Tab_Editor_Command.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Space_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Space.ForeColor = Tab_Editor_Space.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Space_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Space.BackColor = Tab_Editor_Space.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Don_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Don.ForeColor = Tab_Editor_Don.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Don_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Don.BackColor = Tab_Editor_Don.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Ka_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Ka.ForeColor = Tab_Editor_Ka.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Ka_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Ka.BackColor = Tab_Editor_Ka.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Roll_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Roll.ForeColor = Tab_Editor_Roll.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Roll_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Roll.BackColor = Tab_Editor_Roll.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Balloon_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Balloon.ForeColor = Tab_Editor_Balloon.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Balloon_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Balloon.BackColor = Tab_Editor_Balloon.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Other_ForeColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Other.ForeColor = Tab_Editor_Other.ForeColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_Editor_Other_BackColorChanged(object sender, EventArgs e)
        {
            Setting.ColorScheme.Other.BackColor = Tab_Editor_Other.BackColor;
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.Invalidate();
        }

        private void Tab_General_UTF8Mode_CheckedChanged(object sender, EventArgs e)
        {
            Setting.UTF8Mode = Tab_General_UTF8Mode.Checked;
        }

        private void Tab_General_Open_Extract_Folder_CheckedChanged(object sender, EventArgs e)
        {
            Setting.Open_Extract_Folder = Tab_General_Open_Extract_Folder.Checked;
        }

        private void Tab_Editor_Font_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.AllowVerticalFonts = false;
            dialog.ShowColor = false;
            dialog.ShowEffects = false;
            dialog.ShowApply = false;
            dialog.FontMustExist = false;
            dialog.Font = new Font(Setting.FontName, Setting.FontSize);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Setting.FontName = dialog.Font.Name;
                Setting.FontSize = dialog.Font.SizeInPoints;
                Tab_Editor_Font.Font = Tab_Editor_Sample.Font = new Font(Setting.FontName, Setting.FontSize);
            }
        }

        private void Tab_Editor_Font_FontChanged(object sender, EventArgs e)
        {
        }

        private void Tab_General_Workspace_Button_Click(object sender, EventArgs e)
        {
            SetDirectoryToTextBox(Tab_General_Workspace_TextBox);
        }

        private void Tab_General_SimulatorPath_Button_Click(object sender, EventArgs e)
        {
            SetPathToTextBox(Tab_General_SimulatorPath_TextBox);
        }

        private void Tab_General_Workspace_TextBox_TextChanged(object sender, EventArgs e)
        {
            Setting.WorkspacePath = Tab_General_Workspace_TextBox.Text;
        }

        private void Tab_General_SimulatorPath_TextBox_TextChanged(object sender, EventArgs e)
        {
            Setting.SimulatorPath = Tab_General_SimulatorPath_TextBox.Text;
        }

        private void Tab_General_Language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setting.Locale = GetLocaleFromLocale((Locale)Tab_General_Language_ComboBox.SelectedIndex);
        }

        private void GetSettings()
        {
            // 言語
            ColorScheme.SetColorScheme(Tab_Editor_Sample.ColorScheme, Setting);
            Tab_Editor_Sample.ForeColor = Setting.Editor_ForeColor;
            Tab_Editor_Sample.BackColor = Setting.Editor_BackColor;
            Tab_Editor_Sample.Font = new Font(Setting.FontName, Setting.FontSize);
            Tab_Editor_Font.Font = new Font(Setting.FontName, Setting.FontSize);
            Tab_Editor_Sample.ShowsLineNumber = Setting.Show_Line_Number;
            Tab_Editor_Sample.ShowsHRuler = Setting.Show_Horizontal_Ruler;
            Tab_Editor_Sample.HRulerStartsFromZero = Setting.Show_Horizontal_Ruler_Zero;
            Tab_Editor_Sample.DrawsEofMark = Setting.Show_EoF_Mark;
            Tab_Editor_Sample.DrawsEolCode = Setting.Show_EoL_Mark;
            Tab_Editor_Sample.DrawsFullWidthSpace = Setting.Show_Space_Mark;
            Tab_Editor_Sample.DrawsSpace = Setting.Show_Space_Mark;
            Tab_Editor_Sample.DrawsTab = Setting.Show_Tab_Mark;
            Tab_General_Language_ComboBox.SelectedIndex = (int)GetLocaleFromText(Setting.Locale);
            Tab_General_SimulatorPath_TextBox.Text = Setting.SimulatorPath;
            Tab_General_Workspace_TextBox.Text = Setting.WorkspacePath;

            // 色
            GetColorsFromSettings(Setting.Editor_ForeColor, Setting.Editor_BackColor, ref Tab_Editor_Normal);
            GetColorsFromSettings(Setting.ColorScheme.Comment, ref Tab_Editor_Comment);
            GetColorsFromSettings(Setting.ColorScheme.Keyword, ref Tab_Editor_Header);
            GetColorsFromSettings(Setting.ColorScheme.Command, ref Tab_Editor_Command);

            GetColorsFromSettings(Setting.ColorScheme.Space, ref Tab_Editor_Space);
            GetColorsFromSettings(Setting.ColorScheme.Don, ref Tab_Editor_Don);
            GetColorsFromSettings(Setting.ColorScheme.Ka, ref Tab_Editor_Ka);
            GetColorsFromSettings(Setting.ColorScheme.Roll, ref Tab_Editor_Roll);
            GetColorsFromSettings(Setting.ColorScheme.Balloon, ref Tab_Editor_Balloon);
            GetColorsFromSettings(Setting.ColorScheme.Other, ref Tab_Editor_Other);

            // チェックボックス
            GetBooleanFromSettings(Setting.UTF8Mode, ref Tab_General_UTF8Mode);
            GetBooleanFromSettings(Setting.Open_Extract_Folder, ref Tab_General_Open_Extract_Folder);
            GetBooleanFromSettings(Setting.Show_Horizontal_Ruler, ref Tab_Editor_Show_HR);
            GetBooleanFromSettings(Setting.Show_Line_Number, ref Tab_Editor_Line);
            GetBooleanFromSettings(Setting.Show_Horizontal_Ruler_Zero, ref Tab_Editor_HR_From_Zero);
            GetBooleanFromSettings(Setting.Show_Space_Mark, ref Tab_Editor_SpaceMark);
            GetBooleanFromSettings(Setting.Show_Tab_Mark, ref Tab_Editor_TabMark);
            GetBooleanFromSettings(Setting.Show_EoL_Mark, ref Tab_Editor_EoL);
            GetBooleanFromSettings(Setting.Show_EoF_Mark, ref Tab_Editor_EoF);
        }

        private void SetSettings()
        {
            Program.Setting = Setting.DeepCopy();
        }

        private void GetBooleanFromSettings(bool boolean, ref CheckBox checkbox)
        {
            checkbox.Checked = boolean;
            Update();
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

        private static void SetBooleanFromSettings(ref bool boolean, ref CheckBox checkbox)
        {
            boolean = checkbox.Checked;
        }

        private static void SetColorsFromSettings(ColorFormat colorFormat, ref Button button)
        {
            SetColorsFromSettings(colorFormat.ForeColor, colorFormat.BackColor, ref button);
        }

        private static void SetColorsFromSettings(Color foreColor, Color backColor, ref Button button)
        {
            foreColor = button.ForeColor;
            backColor = button.BackColor;
        }

        private static void SetColor(ref Button button)
        {
            var isBackground = (ModifierKeys & Keys.Alt) == Keys.Alt;
            var color = isBackground ? button.BackColor : button.ForeColor;
            var dialog = new ColorDialog();
            dialog.Color = color;
            dialog.FullOpen = true;
            dialog.SolidColorOnly = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            dialog.Dispose();
            if (isBackground)
            {
                button.BackColor = color;
            }
            else
            {
                button.ForeColor = color;
            }
        }

        private static void SetDirectoryToTextBox(TextBox textBox)
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = textBox.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = dialog.SelectedPath;
            }
        }

        private static void SetPathToTextBox(TextBox textBox)
        {
            var dialog = new OpenFileDialog();
            dialog.FileName = textBox.Text;
            dialog.Title = Properties.SystemMessage.OpenSimulatorPath;
            if (!string.IsNullOrWhiteSpace(textBox.Text)) dialog.InitialDirectory = Path.GetDirectoryName(textBox.Text);
            dialog.Filter = String.Format("{0}|*{1}", Properties.Common.EXEExtensionDescripion, Properties.Common.EXEExtensionName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = dialog.FileName;
            }
        }

        private enum Locale
        {
            English,
            Japanese
        }

        private static Locale GetLocaleFromText(string text)
        {
            switch (text)
            {
                case "en-US":
                    return Locale.English;

                case "ja-JP":
                    return Locale.Japanese;

                default:
                    return Locale.English;
            }
        }

        private static string GetLocaleFromLocale(Locale locale)
        {
            switch (locale)
            {
                case Locale.English:
                    return "en-US";

                case Locale.Japanese:
                    return "ja-JP";

                default:
                    return "en-US";
            }
        }
    }

    public static class Extension
    {
        public static T DeepCopy<T>(this T src)
        {
            using (var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, src);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }
}