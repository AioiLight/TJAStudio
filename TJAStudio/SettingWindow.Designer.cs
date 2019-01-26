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
            Sgry.Azuki.FontInfo fontInfo1 = new Sgry.Azuki.FontInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            this.Tab = new System.Windows.Forms.TabControl();
            this.Tab_General = new System.Windows.Forms.TabPage();
            this.Tab_General_UTF8Mode = new System.Windows.Forms.CheckBox();
            this.Tab_General_SimulatorPath_Button = new System.Windows.Forms.Button();
            this.Tab_General_SimulatorPath_TextBox = new System.Windows.Forms.TextBox();
            this.Tab_General_SimulatorPath_Label = new System.Windows.Forms.Label();
            this.Tab_General_Language_Label = new System.Windows.Forms.Label();
            this.Tab_General_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Tab_Editor = new System.Windows.Forms.TabPage();
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
            this.Button_Apply = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Tab_Editor_SpaceMark = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_TabMark = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_EoL = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_EoF = new System.Windows.Forms.CheckBox();
            this.Tab_General_Workspace_Button = new System.Windows.Forms.Button();
            this.Tab_General_Workspace_TextBox = new System.Windows.Forms.TextBox();
            this.Tab_General_Workspace_Label = new System.Windows.Forms.Label();
            this.Tab_Editor_Header = new System.Windows.Forms.Button();
            this.Tab_Editor_Command = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Tab_Editor_Label = new System.Windows.Forms.Label();
            this.Tab.SuspendLayout();
            this.Tab_General.SuspendLayout();
            this.Tab_Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Tab_General);
            this.Tab.Controls.Add(this.Tab_Editor);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(680, 361);
            this.Tab.TabIndex = 0;
            // 
            // Tab_General
            // 
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_Button);
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_TextBox);
            this.Tab_General.Controls.Add(this.Tab_General_Workspace_Label);
            this.Tab_General.Controls.Add(this.Tab_General_UTF8Mode);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_Button);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_TextBox);
            this.Tab_General.Controls.Add(this.Tab_General_SimulatorPath_Label);
            this.Tab_General.Controls.Add(this.Tab_General_Language_Label);
            this.Tab_General.Controls.Add(this.Tab_General_Language_ComboBox);
            this.Tab_General.Location = new System.Drawing.Point(4, 29);
            this.Tab_General.Name = "Tab_General";
            this.Tab_General.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_General.Size = new System.Drawing.Size(672, 328);
            this.Tab_General.TabIndex = 0;
            this.Tab_General.Text = "General";
            this.Tab_General.UseVisualStyleBackColor = true;
            // 
            // Tab_General_UTF8Mode
            // 
            this.Tab_General_UTF8Mode.AutoSize = true;
            this.Tab_General_UTF8Mode.Location = new System.Drawing.Point(10, 106);
            this.Tab_General_UTF8Mode.Name = "Tab_General_UTF8Mode";
            this.Tab_General_UTF8Mode.Size = new System.Drawing.Size(265, 24);
            this.Tab_General_UTF8Mode.TabIndex = 5;
            this.Tab_General_UTF8Mode.Text = "Use UTF-8 encoding when export .tja";
            this.Tab_General_UTF8Mode.UseVisualStyleBackColor = true;
            // 
            // Tab_General_SimulatorPath_Button
            // 
            this.Tab_General_SimulatorPath_Button.Location = new System.Drawing.Point(633, 73);
            this.Tab_General_SimulatorPath_Button.Name = "Tab_General_SimulatorPath_Button";
            this.Tab_General_SimulatorPath_Button.Size = new System.Drawing.Size(32, 27);
            this.Tab_General_SimulatorPath_Button.TabIndex = 4;
            this.Tab_General_SimulatorPath_Button.Text = "...";
            this.Tab_General_SimulatorPath_Button.UseVisualStyleBackColor = true;
            // 
            // Tab_General_SimulatorPath_TextBox
            // 
            this.Tab_General_SimulatorPath_TextBox.Location = new System.Drawing.Point(141, 73);
            this.Tab_General_SimulatorPath_TextBox.Name = "Tab_General_SimulatorPath_TextBox";
            this.Tab_General_SimulatorPath_TextBox.Size = new System.Drawing.Size(486, 27);
            this.Tab_General_SimulatorPath_TextBox.TabIndex = 3;
            // 
            // Tab_General_SimulatorPath_Label
            // 
            this.Tab_General_SimulatorPath_Label.AutoSize = true;
            this.Tab_General_SimulatorPath_Label.Location = new System.Drawing.Point(6, 76);
            this.Tab_General_SimulatorPath_Label.Name = "Tab_General_SimulatorPath_Label";
            this.Tab_General_SimulatorPath_Label.Size = new System.Drawing.Size(108, 20);
            this.Tab_General_SimulatorPath_Label.TabIndex = 2;
            this.Tab_General_SimulatorPath_Label.Text = "Simulator Path:";
            // 
            // Tab_General_Language_Label
            // 
            this.Tab_General_Language_Label.AutoSize = true;
            this.Tab_General_Language_Label.Location = new System.Drawing.Point(7, 9);
            this.Tab_General_Language_Label.Name = "Tab_General_Language_Label";
            this.Tab_General_Language_Label.Size = new System.Drawing.Size(78, 20);
            this.Tab_General_Language_Label.TabIndex = 1;
            this.Tab_General_Language_Label.Text = "Language:";
            // 
            // Tab_General_Language_ComboBox
            // 
            this.Tab_General_Language_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tab_General_Language_ComboBox.FormattingEnabled = true;
            this.Tab_General_Language_ComboBox.Location = new System.Drawing.Point(142, 6);
            this.Tab_General_Language_ComboBox.Name = "Tab_General_Language_ComboBox";
            this.Tab_General_Language_ComboBox.Size = new System.Drawing.Size(151, 28);
            this.Tab_General_Language_ComboBox.TabIndex = 0;
            // 
            // Tab_Editor
            // 
            this.Tab_Editor.Controls.Add(this.checkBox1);
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
            this.Tab_Editor.Location = new System.Drawing.Point(4, 29);
            this.Tab_Editor.Name = "Tab_Editor";
            this.Tab_Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Editor.Size = new System.Drawing.Size(672, 328);
            this.Tab_Editor.TabIndex = 1;
            this.Tab_Editor.Text = "Editor";
            this.Tab_Editor.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Line
            // 
            this.Tab_Editor_Line.AutoSize = true;
            this.Tab_Editor_Line.Location = new System.Drawing.Point(181, 72);
            this.Tab_Editor_Line.Name = "Tab_Editor_Line";
            this.Tab_Editor_Line.Size = new System.Drawing.Size(148, 24);
            this.Tab_Editor_Line.TabIndex = 10;
            this.Tab_Editor_Line.Text = "Shows line number";
            this.Tab_Editor_Line.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Show_HR
            // 
            this.Tab_Editor_Show_HR.AutoSize = true;
            this.Tab_Editor_Show_HR.Location = new System.Drawing.Point(6, 72);
            this.Tab_Editor_Show_HR.Name = "Tab_Editor_Show_HR";
            this.Tab_Editor_Show_HR.Size = new System.Drawing.Size(169, 24);
            this.Tab_Editor_Show_HR.TabIndex = 9;
            this.Tab_Editor_Show_HR.Text = "Shows horizontal ruler";
            this.Tab_Editor_Show_HR.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Other
            // 
            this.Tab_Editor_Other.Location = new System.Drawing.Point(516, 39);
            this.Tab_Editor_Other.Name = "Tab_Editor_Other";
            this.Tab_Editor_Other.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Other.TabIndex = 8;
            this.Tab_Editor_Other.Text = "Other";
            this.Tab_Editor_Other.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Space
            // 
            this.Tab_Editor_Space.Location = new System.Drawing.Point(6, 39);
            this.Tab_Editor_Space.Name = "Tab_Editor_Space";
            this.Tab_Editor_Space.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Space.TabIndex = 7;
            this.Tab_Editor_Space.Text = "Space(0)";
            this.Tab_Editor_Space.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Comment
            // 
            this.Tab_Editor_Comment.Location = new System.Drawing.Point(108, 6);
            this.Tab_Editor_Comment.Name = "Tab_Editor_Comment";
            this.Tab_Editor_Comment.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Comment.TabIndex = 6;
            this.Tab_Editor_Comment.Text = "Comment";
            this.Tab_Editor_Comment.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Balloon
            // 
            this.Tab_Editor_Balloon.Location = new System.Drawing.Point(414, 39);
            this.Tab_Editor_Balloon.Name = "Tab_Editor_Balloon";
            this.Tab_Editor_Balloon.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Balloon.TabIndex = 5;
            this.Tab_Editor_Balloon.Text = "Balloon(7)";
            this.Tab_Editor_Balloon.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Roll
            // 
            this.Tab_Editor_Roll.Location = new System.Drawing.Point(312, 39);
            this.Tab_Editor_Roll.Name = "Tab_Editor_Roll";
            this.Tab_Editor_Roll.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Roll.TabIndex = 4;
            this.Tab_Editor_Roll.Text = "Roll(5,6)";
            this.Tab_Editor_Roll.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Ka
            // 
            this.Tab_Editor_Ka.Location = new System.Drawing.Point(210, 39);
            this.Tab_Editor_Ka.Name = "Tab_Editor_Ka";
            this.Tab_Editor_Ka.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Ka.TabIndex = 3;
            this.Tab_Editor_Ka.Text = "Ka(2,4)";
            this.Tab_Editor_Ka.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Don
            // 
            this.Tab_Editor_Don.Location = new System.Drawing.Point(108, 39);
            this.Tab_Editor_Don.Name = "Tab_Editor_Don";
            this.Tab_Editor_Don.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Don.TabIndex = 2;
            this.Tab_Editor_Don.Text = "Don(1,3)";
            this.Tab_Editor_Don.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Normal
            // 
            this.Tab_Editor_Normal.Location = new System.Drawing.Point(6, 6);
            this.Tab_Editor_Normal.Name = "Tab_Editor_Normal";
            this.Tab_Editor_Normal.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Normal.TabIndex = 1;
            this.Tab_Editor_Normal.Text = "Normal";
            this.Tab_Editor_Normal.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Sample
            // 
            this.Tab_Editor_Sample.BackColor = System.Drawing.Color.White;
            this.Tab_Editor_Sample.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tab_Editor_Sample.DrawingOption = ((Sgry.Azuki.DrawingOption)((((((((Sgry.Azuki.DrawingOption.DrawsFullWidthSpace | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsHRuler) 
            | Sgry.Azuki.DrawingOption.ShowsDirtBar) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.Tab_Editor_Sample.FirstVisibleLine = 0;
            this.Tab_Editor_Sample.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            fontInfo1.Name = "MS UI Gothic";
            fontInfo1.Size = 9;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.Tab_Editor_Sample.FontInfo = fontInfo1;
            this.Tab_Editor_Sample.ForeColor = System.Drawing.Color.Black;
            this.Tab_Editor_Sample.Location = new System.Drawing.Point(6, 141);
            this.Tab_Editor_Sample.Name = "Tab_Editor_Sample";
            this.Tab_Editor_Sample.ScrollPos = new System.Drawing.Point(0, 0);
            this.Tab_Editor_Sample.ShowsHRuler = true;
            this.Tab_Editor_Sample.Size = new System.Drawing.Size(660, 181);
            this.Tab_Editor_Sample.TabIndex = 0;
            this.Tab_Editor_Sample.ViewWidth = 4129;
            // 
            // Button_Apply
            // 
            this.Button_Apply.Location = new System.Drawing.Point(378, 379);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Size = new System.Drawing.Size(154, 30);
            this.Button_Apply.TabIndex = 1;
            this.Button_Apply.Text = "Apply and Restart";
            this.Button_Apply.UseVisualStyleBackColor = true;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(538, 379);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(154, 30);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_SpaceMark
            // 
            this.Tab_Editor_SpaceMark.AutoSize = true;
            this.Tab_Editor_SpaceMark.Location = new System.Drawing.Point(6, 102);
            this.Tab_Editor_SpaceMark.Name = "Tab_Editor_SpaceMark";
            this.Tab_Editor_SpaceMark.Size = new System.Drawing.Size(146, 24);
            this.Tab_Editor_SpaceMark.TabIndex = 11;
            this.Tab_Editor_SpaceMark.Text = "Shows space mark";
            this.Tab_Editor_SpaceMark.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_TabMark
            // 
            this.Tab_Editor_TabMark.AutoSize = true;
            this.Tab_Editor_TabMark.Location = new System.Drawing.Point(158, 102);
            this.Tab_Editor_TabMark.Name = "Tab_Editor_TabMark";
            this.Tab_Editor_TabMark.Size = new System.Drawing.Size(130, 24);
            this.Tab_Editor_TabMark.TabIndex = 12;
            this.Tab_Editor_TabMark.Text = "Shows tab mark";
            this.Tab_Editor_TabMark.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_EoL
            // 
            this.Tab_Editor_EoL.AutoSize = true;
            this.Tab_Editor_EoL.Location = new System.Drawing.Point(294, 102);
            this.Tab_Editor_EoL.Name = "Tab_Editor_EoL";
            this.Tab_Editor_EoL.Size = new System.Drawing.Size(132, 24);
            this.Tab_Editor_EoL.TabIndex = 13;
            this.Tab_Editor_EoL.Text = "Shows EoL mark";
            this.Tab_Editor_EoL.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_EoF
            // 
            this.Tab_Editor_EoF.AutoSize = true;
            this.Tab_Editor_EoF.Location = new System.Drawing.Point(432, 102);
            this.Tab_Editor_EoF.Name = "Tab_Editor_EoF";
            this.Tab_Editor_EoF.Size = new System.Drawing.Size(132, 24);
            this.Tab_Editor_EoF.TabIndex = 14;
            this.Tab_Editor_EoF.Text = "Shows EoF mark";
            this.Tab_Editor_EoF.UseVisualStyleBackColor = true;
            // 
            // Tab_General_Workspace_Button
            // 
            this.Tab_General_Workspace_Button.Location = new System.Drawing.Point(633, 40);
            this.Tab_General_Workspace_Button.Name = "Tab_General_Workspace_Button";
            this.Tab_General_Workspace_Button.Size = new System.Drawing.Size(32, 27);
            this.Tab_General_Workspace_Button.TabIndex = 8;
            this.Tab_General_Workspace_Button.Text = "...";
            this.Tab_General_Workspace_Button.UseVisualStyleBackColor = true;
            // 
            // Tab_General_Workspace_TextBox
            // 
            this.Tab_General_Workspace_TextBox.Location = new System.Drawing.Point(141, 40);
            this.Tab_General_Workspace_TextBox.Name = "Tab_General_Workspace_TextBox";
            this.Tab_General_Workspace_TextBox.Size = new System.Drawing.Size(486, 27);
            this.Tab_General_Workspace_TextBox.TabIndex = 7;
            // 
            // Tab_General_Workspace_Label
            // 
            this.Tab_General_Workspace_Label.AutoSize = true;
            this.Tab_General_Workspace_Label.Location = new System.Drawing.Point(6, 43);
            this.Tab_General_Workspace_Label.Name = "Tab_General_Workspace_Label";
            this.Tab_General_Workspace_Label.Size = new System.Drawing.Size(117, 20);
            this.Tab_General_Workspace_Label.TabIndex = 6;
            this.Tab_General_Workspace_Label.Text = "Workspace Path:";
            // 
            // Tab_Editor_Header
            // 
            this.Tab_Editor_Header.Location = new System.Drawing.Point(210, 6);
            this.Tab_Editor_Header.Name = "Tab_Editor_Header";
            this.Tab_Editor_Header.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Header.TabIndex = 15;
            this.Tab_Editor_Header.Text = "Comment";
            this.Tab_Editor_Header.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Command
            // 
            this.Tab_Editor_Command.Location = new System.Drawing.Point(312, 6);
            this.Tab_Editor_Command.Name = "Tab_Editor_Command";
            this.Tab_Editor_Command.Size = new System.Drawing.Size(96, 27);
            this.Tab_Editor_Command.TabIndex = 16;
            this.Tab_Editor_Command.Text = "Comment";
            this.Tab_Editor_Command.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(230, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Horizontal ruler starts from zero";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Label
            // 
            this.Tab_Editor_Label.AutoSize = true;
            this.Tab_Editor_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab_Editor_Label.Location = new System.Drawing.Point(501, 3);
            this.Tab_Editor_Label.Name = "Tab_Editor_Label";
            this.Tab_Editor_Label.Size = new System.Drawing.Size(165, 40);
            this.Tab_Editor_Label.TabIndex = 18;
            this.Tab_Editor_Label.Text = "Click: Foreground\r\nAlt + Click: Backgrounds";
            this.Tab_Editor_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.Tab);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Tab_Editor_Command;
        private System.Windows.Forms.Button Tab_Editor_Header;
        private System.Windows.Forms.Label Tab_Editor_Label;
    }
}