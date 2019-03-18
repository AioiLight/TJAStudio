namespace TJAStudio
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            Sgry.Azuki.FontInfo fontInfo1 = new Sgry.Azuki.FontInfo();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Tab_General = new System.Windows.Forms.TabPage();
            this.Tab_General_Workspace_Button = new System.Windows.Forms.Button();
            this.Tab_General_Workspace_TextBox = new System.Windows.Forms.TextBox();
            this.Tab_General_Workspace_Label = new System.Windows.Forms.Label();
            this.Tab_General_UTF8Mode = new System.Windows.Forms.CheckBox();
            this.Tab_General_SimulatorPath_Button = new System.Windows.Forms.Button();
            this.Tab_General_SimulatorPath_TextBox = new System.Windows.Forms.TextBox();
            this.Tab_General_SimulatorPath_Label = new System.Windows.Forms.Label();
            this.Tab_General_Language_Label = new System.Windows.Forms.Label();
            this.Tab_General_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tab_Editor = new System.Windows.Forms.TabPage();
            this.Tab_Editor_Font = new System.Windows.Forms.Button();
            this.Tab_Editor_HR_From_Zero = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_Command = new System.Windows.Forms.Button();
            this.Tab_Editor_Header = new System.Windows.Forms.Button();
            this.Tab_Editor_EoF = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_EoL = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_TabMark = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_SpaceMark = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_Line = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_Show_HR = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_Other = new System.Windows.Forms.Button();
            this.Tab_Editor_Space = new System.Windows.Forms.Button();
            this.Tab_Editor_Comment = new System.Windows.Forms.Button();
            this.Tab_Editor_Balloon = new System.Windows.Forms.Button();
            this.Tab_Editor_Roll = new System.Windows.Forms.Button();
            this.Tab_Editor_Ka = new System.Windows.Forms.Button();
            this.Tab_Editor_Don = new System.Windows.Forms.Button();
            this.Tab_Editor_Normal = new System.Windows.Forms.Button();
            this.Tab_Editor_Sample = new Sgry.Azuki.WinForms.AzukiControl();
            this.Tab_Editor_Label = new System.Windows.Forms.Label();
            this.Button_Apply = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.Tab_General.SuspendLayout();
            this.Tab_Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            resources.ApplyResources(this.Tab, "Tab");
            this.Tab.Controls.Add(this.Tab_General);
            this.Tab.Controls.Add(this.Tab_Editor);
            this.Tab.HotTrack = true;
            this.Tab.Multiline = true;
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // Tab_General
            // 
            resources.ApplyResources(this.Tab_General, "Tab_General");
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_Button);
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_TextBox);
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_Label);
            this.Tab_General.Controls.Add(this.Tab_General_UTF8Mode);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_Button);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_TextBox);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_Label);
            this.Tab_General.Controls.Add(this.Tab_General_Language_Label);
            this.Tab_General.Controls.Add(this.Tab_General_Language_ComboBox);
            this.Tab_General.Name = "Tab_General";
            this.Tab_General.UseVisualStyleBackColor = true;
            // 
            // Tab_General_Workspace_Button
            // 
            resources.ApplyResources(this.Tab_General_Workspace_Button, "Tab_General_Workspace_Button");
            this.Tab_General_Workspace_Button.Name = "Tab_General_Workspace_Button";
            this.Tab_General_Workspace_Button.UseVisualStyleBackColor = true;
            this.Tab_General_Workspace_Button.Click += new System.EventHandler(this.Tab_General_Workspace_Button_Click);
            // 
            // Tab_General_Workspace_TextBox
            // 
            resources.ApplyResources(this.Tab_General_Workspace_TextBox, "Tab_General_Workspace_TextBox");
            this.Tab_General_Workspace_TextBox.Name = "Tab_General_Workspace_TextBox";
            this.Tab_General_Workspace_TextBox.TextChanged += new System.EventHandler(this.Tab_General_Workspace_TextBox_TextChanged);
            // 
            // Tab_General_Workspace_Label
            // 
            resources.ApplyResources(this.Tab_General_Workspace_Label, "Tab_General_Workspace_Label");
            this.Tab_General_Workspace_Label.Name = "Tab_General_Workspace_Label";
            // 
            // Tab_General_UTF8Mode
            // 
            resources.ApplyResources(this.Tab_General_UTF8Mode, "Tab_General_UTF8Mode");
            this.Tab_General_UTF8Mode.Name = "Tab_General_UTF8Mode";
            this.Tab_General_UTF8Mode.UseVisualStyleBackColor = true;
            this.Tab_General_UTF8Mode.CheckedChanged += new System.EventHandler(this.Tab_General_UTF8Mode_CheckedChanged);
            // 
            // Tab_General_SimulatorPath_Button
            // 
            resources.ApplyResources(this.Tab_General_SimulatorPath_Button, "Tab_General_SimulatorPath_Button");
            this.Tab_General_SimulatorPath_Button.Name = "Tab_General_SimulatorPath_Button";
            this.Tab_General_SimulatorPath_Button.UseVisualStyleBackColor = true;
            this.Tab_General_SimulatorPath_Button.Click += new System.EventHandler(this.Tab_General_SimulatorPath_Button_Click);
            // 
            // Tab_General_SimulatorPath_TextBox
            // 
            resources.ApplyResources(this.Tab_General_SimulatorPath_TextBox, "Tab_General_SimulatorPath_TextBox");
            this.Tab_General_SimulatorPath_TextBox.Name = "Tab_General_SimulatorPath_TextBox";
            this.Tab_General_SimulatorPath_TextBox.TextChanged += new System.EventHandler(this.Tab_General_SimulatorPath_TextBox_TextChanged);
            // 
            // Tab_General_SimulatorPath_Label
            // 
            resources.ApplyResources(this.Tab_General_SimulatorPath_Label, "Tab_General_SimulatorPath_Label");
            this.Tab_General_SimulatorPath_Label.Name = "Tab_General_SimulatorPath_Label";
            // 
            // Tab_General_Language_Label
            // 
            resources.ApplyResources(this.Tab_General_Language_Label, "Tab_General_Language_Label");
            this.Tab_General_Language_Label.Name = "Tab_General_Language_Label";
            // 
            // Tab_General_Language_ComboBox
            // 
            resources.ApplyResources(this.Tab_General_Language_ComboBox, "Tab_General_Language_ComboBox");
            this.Tab_General_Language_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tab_General_Language_ComboBox.DropDownWidth = 180;
            this.Tab_General_Language_ComboBox.FormattingEnabled = true;
            this.Tab_General_Language_ComboBox.Items.AddRange(new object[] {
            resources.GetString("Tab_General_Language_ComboBox.Items"),
            resources.GetString("Tab_General_Language_ComboBox.Items1")});
            this.Tab_General_Language_ComboBox.Name = "Tab_General_Language_ComboBox";
            this.Tab_General_Language_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Tab_General_Language_ComboBox_SelectedIndexChanged);
            // 
            // Tab_Editor
            // 
            resources.ApplyResources(this.Tab_Editor, "Tab_Editor");
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Font);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_HR_From_Zero);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Command);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Header);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_EoF);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_EoL);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_TabMark);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_SpaceMark);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Line);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Show_HR);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Other);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Space);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Comment);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Balloon);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Roll);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Ka);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Don);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Normal);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Sample);
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Label);
            this.Tab_Editor.Name = "Tab_Editor";
            this.Tab_Editor.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Font
            // 
            resources.ApplyResources(this.Tab_Editor_Font, "Tab_Editor_Font");
            this.Tab_Editor_Font.Name = "Tab_Editor_Font";
            this.Tab_Editor_Font.UseVisualStyleBackColor = true;
            this.Tab_Editor_Font.FontChanged += new System.EventHandler(this.Tab_Editor_Font_FontChanged);
            this.Tab_Editor_Font.Click += new System.EventHandler(this.Tab_Editor_Font_Click);
            // 
            // Tab_Editor_HR_From_Zero
            // 
            resources.ApplyResources(this.Tab_Editor_HR_From_Zero, "Tab_Editor_HR_From_Zero");
            this.Tab_Editor_HR_From_Zero.Name = "Tab_Editor_HR_From_Zero";
            this.Tab_Editor_HR_From_Zero.UseVisualStyleBackColor = true;
            this.Tab_Editor_HR_From_Zero.CheckedChanged += new System.EventHandler(this.Tab_Editor_HR_From_Zero_CheckedChanged);
            // 
            // Tab_Editor_Command
            // 
            resources.ApplyResources(this.Tab_Editor_Command, "Tab_Editor_Command");
            this.Tab_Editor_Command.Name = "Tab_Editor_Command";
            this.Tab_Editor_Command.UseVisualStyleBackColor = true;
            this.Tab_Editor_Command.BackColorChanged += new System.EventHandler(this.Tab_Editor_Command_BackColorChanged);
            this.Tab_Editor_Command.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Command_ForeColorChanged);
            this.Tab_Editor_Command.Click += new System.EventHandler(this.Tab_Editor_Command_Click);
            // 
            // Tab_Editor_Header
            // 
            resources.ApplyResources(this.Tab_Editor_Header, "Tab_Editor_Header");
            this.Tab_Editor_Header.Name = "Tab_Editor_Header";
            this.Tab_Editor_Header.UseVisualStyleBackColor = true;
            this.Tab_Editor_Header.BackColorChanged += new System.EventHandler(this.Tab_Editor_Header_BackColorChanged);
            this.Tab_Editor_Header.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Header_ForeColorChanged);
            this.Tab_Editor_Header.Click += new System.EventHandler(this.Tab_Editor_Header_Click);
            // 
            // Tab_Editor_EoF
            // 
            resources.ApplyResources(this.Tab_Editor_EoF, "Tab_Editor_EoF");
            this.Tab_Editor_EoF.Name = "Tab_Editor_EoF";
            this.Tab_Editor_EoF.UseVisualStyleBackColor = true;
            this.Tab_Editor_EoF.CheckedChanged += new System.EventHandler(this.Tab_Editor_EoF_CheckedChanged);
            // 
            // Tab_Editor_EoL
            // 
            resources.ApplyResources(this.Tab_Editor_EoL, "Tab_Editor_EoL");
            this.Tab_Editor_EoL.Name = "Tab_Editor_EoL";
            this.Tab_Editor_EoL.UseVisualStyleBackColor = true;
            this.Tab_Editor_EoL.CheckedChanged += new System.EventHandler(this.Tab_Editor_EoL_CheckedChanged);
            // 
            // Tab_Editor_TabMark
            // 
            resources.ApplyResources(this.Tab_Editor_TabMark, "Tab_Editor_TabMark");
            this.Tab_Editor_TabMark.Name = "Tab_Editor_TabMark";
            this.Tab_Editor_TabMark.UseVisualStyleBackColor = true;
            this.Tab_Editor_TabMark.CheckedChanged += new System.EventHandler(this.Tab_Editor_TabMark_CheckedChanged);
            // 
            // Tab_Editor_SpaceMark
            // 
            resources.ApplyResources(this.Tab_Editor_SpaceMark, "Tab_Editor_SpaceMark");
            this.Tab_Editor_SpaceMark.Name = "Tab_Editor_SpaceMark";
            this.Tab_Editor_SpaceMark.UseVisualStyleBackColor = true;
            this.Tab_Editor_SpaceMark.CheckedChanged += new System.EventHandler(this.Tab_Editor_SpaceMark_CheckedChanged);
            // 
            // Tab_Editor_Line
            // 
            resources.ApplyResources(this.Tab_Editor_Line, "Tab_Editor_Line");
            this.Tab_Editor_Line.Name = "Tab_Editor_Line";
            this.Tab_Editor_Line.UseVisualStyleBackColor = true;
            this.Tab_Editor_Line.CheckedChanged += new System.EventHandler(this.Tab_Editor_Line_CheckedChanged);
            // 
            // Tab_Editor_Show_HR
            // 
            resources.ApplyResources(this.Tab_Editor_Show_HR, "Tab_Editor_Show_HR");
            this.Tab_Editor_Show_HR.Name = "Tab_Editor_Show_HR";
            this.Tab_Editor_Show_HR.UseVisualStyleBackColor = true;
            this.Tab_Editor_Show_HR.CheckedChanged += new System.EventHandler(this.Tab_Editor_Show_HR_CheckedChanged);
            // 
            // Tab_Editor_Other
            // 
            resources.ApplyResources(this.Tab_Editor_Other, "Tab_Editor_Other");
            this.Tab_Editor_Other.Name = "Tab_Editor_Other";
            this.Tab_Editor_Other.UseVisualStyleBackColor = true;
            this.Tab_Editor_Other.BackColorChanged += new System.EventHandler(this.Tab_Editor_Other_BackColorChanged);
            this.Tab_Editor_Other.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Other_ForeColorChanged);
            this.Tab_Editor_Other.Click += new System.EventHandler(this.Tab_Editor_Other_Click);
            // 
            // Tab_Editor_Space
            // 
            resources.ApplyResources(this.Tab_Editor_Space, "Tab_Editor_Space");
            this.Tab_Editor_Space.Name = "Tab_Editor_Space";
            this.Tab_Editor_Space.UseVisualStyleBackColor = true;
            this.Tab_Editor_Space.BackColorChanged += new System.EventHandler(this.Tab_Editor_Space_BackColorChanged);
            this.Tab_Editor_Space.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Space_ForeColorChanged);
            this.Tab_Editor_Space.Click += new System.EventHandler(this.Tab_Editor_Space_Click);
            // 
            // Tab_Editor_Comment
            // 
            resources.ApplyResources(this.Tab_Editor_Comment, "Tab_Editor_Comment");
            this.Tab_Editor_Comment.Name = "Tab_Editor_Comment";
            this.Tab_Editor_Comment.UseVisualStyleBackColor = true;
            this.Tab_Editor_Comment.BackColorChanged += new System.EventHandler(this.Tab_Editor_Comment_BackColorChanged);
            this.Tab_Editor_Comment.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Comment_ForeColorChanged);
            this.Tab_Editor_Comment.Click += new System.EventHandler(this.Tab_Editor_Comment_Click);
            // 
            // Tab_Editor_Balloon
            // 
            resources.ApplyResources(this.Tab_Editor_Balloon, "Tab_Editor_Balloon");
            this.Tab_Editor_Balloon.Name = "Tab_Editor_Balloon";
            this.Tab_Editor_Balloon.UseVisualStyleBackColor = true;
            this.Tab_Editor_Balloon.BackColorChanged += new System.EventHandler(this.Tab_Editor_Balloon_BackColorChanged);
            this.Tab_Editor_Balloon.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Balloon_ForeColorChanged);
            this.Tab_Editor_Balloon.Click += new System.EventHandler(this.Tab_Editor_Balloon_Click);
            // 
            // Tab_Editor_Roll
            // 
            resources.ApplyResources(this.Tab_Editor_Roll, "Tab_Editor_Roll");
            this.Tab_Editor_Roll.Name = "Tab_Editor_Roll";
            this.Tab_Editor_Roll.UseVisualStyleBackColor = true;
            this.Tab_Editor_Roll.BackColorChanged += new System.EventHandler(this.Tab_Editor_Roll_BackColorChanged);
            this.Tab_Editor_Roll.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Roll_ForeColorChanged);
            this.Tab_Editor_Roll.Click += new System.EventHandler(this.Tab_Editor_Roll_Click);
            // 
            // Tab_Editor_Ka
            // 
            resources.ApplyResources(this.Tab_Editor_Ka, "Tab_Editor_Ka");
            this.Tab_Editor_Ka.Name = "Tab_Editor_Ka";
            this.Tab_Editor_Ka.UseVisualStyleBackColor = true;
            this.Tab_Editor_Ka.BackColorChanged += new System.EventHandler(this.Tab_Editor_Ka_BackColorChanged);
            this.Tab_Editor_Ka.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Ka_ForeColorChanged);
            this.Tab_Editor_Ka.Click += new System.EventHandler(this.Tab_Editor_Ka_Click);
            // 
            // Tab_Editor_Don
            // 
            resources.ApplyResources(this.Tab_Editor_Don, "Tab_Editor_Don");
            this.Tab_Editor_Don.Name = "Tab_Editor_Don";
            this.Tab_Editor_Don.UseVisualStyleBackColor = true;
            this.Tab_Editor_Don.BackColorChanged += new System.EventHandler(this.Tab_Editor_Don_BackColorChanged);
            this.Tab_Editor_Don.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Don_ForeColorChanged);
            this.Tab_Editor_Don.Click += new System.EventHandler(this.Tab_Editor_Don_Click);
            // 
            // Tab_Editor_Normal
            // 
            resources.ApplyResources(this.Tab_Editor_Normal, "Tab_Editor_Normal");
            this.Tab_Editor_Normal.Name = "Tab_Editor_Normal";
            this.Tab_Editor_Normal.UseVisualStyleBackColor = true;
            this.Tab_Editor_Normal.BackColorChanged += new System.EventHandler(this.Tab_Editor_Normal_BackColorChanged);
            this.Tab_Editor_Normal.ForeColorChanged += new System.EventHandler(this.Tab_Editor_Normal_ForeColorChanged);
            this.Tab_Editor_Normal.Click += new System.EventHandler(this.Tab_Editor_Normal_Click);
            // 
            // Tab_Editor_Sample
            // 
            resources.ApplyResources(this.Tab_Editor_Sample, "Tab_Editor_Sample");
            this.Tab_Editor_Sample.BackColor = System.Drawing.Color.White;
            this.Tab_Editor_Sample.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tab_Editor_Sample.DrawingOption = ((Sgry.Azuki.DrawingOption)(((((((Sgry.Azuki.DrawingOption.DrawsFullWidthSpace | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsHRuler) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.Tab_Editor_Sample.FirstVisibleLine = 0;
            fontInfo1.Name = "MS UI Gothic";
            fontInfo1.Size = 9;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.Tab_Editor_Sample.FontInfo = fontInfo1;
            this.Tab_Editor_Sample.ForeColor = System.Drawing.Color.Black;
            this.Tab_Editor_Sample.HRulerStartsFromZero = false;
            this.Tab_Editor_Sample.IsReadOnly = true;
            this.Tab_Editor_Sample.MarksUri = true;
            this.Tab_Editor_Sample.Name = "Tab_Editor_Sample";
            this.Tab_Editor_Sample.ScrollPos = new System.Drawing.Point(0, 0);
            this.Tab_Editor_Sample.ShowsDirtBar = false;
            this.Tab_Editor_Sample.ShowsHRuler = true;
            this.Tab_Editor_Sample.ViewWidth = 4126;
            // 
            // Tab_Editor_Label
            // 
            resources.ApplyResources(this.Tab_Editor_Label, "Tab_Editor_Label");
            this.Tab_Editor_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab_Editor_Label.Name = "Tab_Editor_Label";
            // 
            // Button_Apply
            // 
            resources.ApplyResources(this.Button_Apply, "Button_Apply");
            this.Button_Apply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.UseVisualStyleBackColor = true;
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // Button_Cancel
            // 
            resources.ApplyResources(this.Button_Cancel, "Button_Cancel");
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // SettingWindow
            // 
            this.AcceptButton = this.Button_Apply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindow";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.Tab.ResumeLayout(false);
            this.Tab_General.ResumeLayout(false);
            this.Tab_General.PerformLayout();
            this.Tab_Editor.ResumeLayout(false);
            this.Tab_Editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Tab_General;
        private System.Windows.Forms.CheckBox Tab_General_UTF8Mode;
        private System.Windows.Forms.Button Tab_General_SimulatorPath_Button;
        private System.Windows.Forms.TextBox Tab_General_SimulatorPath_TextBox;
        private System.Windows.Forms.Label Tab_General_SimulatorPath_Label;
        private System.Windows.Forms.Label Tab_General_Language_Label;
        private System.Windows.Forms.ComboBox Tab_General_Language_ComboBox;
        private System.Windows.Forms.TabPage Tab_Editor;
        private Sgry.Azuki.WinForms.AzukiControl Tab_Editor_Sample;
        private System.Windows.Forms.Button Button_Apply;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.CheckBox Tab_Editor_Line;
        private System.Windows.Forms.CheckBox Tab_Editor_Show_HR;
        private System.Windows.Forms.Button Tab_Editor_Other;
        private System.Windows.Forms.Button Tab_Editor_Space;
        private System.Windows.Forms.Button Tab_Editor_Comment;
        private System.Windows.Forms.Button Tab_Editor_Balloon;
        private System.Windows.Forms.Button Tab_Editor_Roll;
        private System.Windows.Forms.Button Tab_Editor_Ka;
        private System.Windows.Forms.Button Tab_Editor_Don;
        private System.Windows.Forms.Button Tab_Editor_Normal;
        private System.Windows.Forms.CheckBox Tab_Editor_SpaceMark;
        private System.Windows.Forms.CheckBox Tab_Editor_EoL;
        private System.Windows.Forms.CheckBox Tab_Editor_TabMark;
        private System.Windows.Forms.CheckBox Tab_Editor_EoF;
        private System.Windows.Forms.Button Tab_General_Workspace_Button;
        private System.Windows.Forms.TextBox Tab_General_Workspace_TextBox;
        private System.Windows.Forms.Label Tab_General_Workspace_Label;
        private System.Windows.Forms.CheckBox Tab_Editor_HR_From_Zero;
        private System.Windows.Forms.Button Tab_Editor_Command;
        private System.Windows.Forms.Button Tab_Editor_Header;
        private System.Windows.Forms.Label Tab_Editor_Label;
        private System.Windows.Forms.Button Tab_Editor_Font;
    }
}