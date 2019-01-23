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
            this.Tab_Editor_Sample = new Sgry.Azuki.WinForms.AzukiControl();
            this.Button_Apply = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
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
            this.Tab_General_UTF8Mode.Location = new System.Drawing.Point(11, 73);
            this.Tab_General_UTF8Mode.Name = "Tab_General_UTF8Mode";
            this.Tab_General_UTF8Mode.Size = new System.Drawing.Size(265, 24);
            this.Tab_General_UTF8Mode.TabIndex = 5;
            this.Tab_General_UTF8Mode.Text = "Use UTF-8 encoding when export .tja";
            this.Tab_General_UTF8Mode.UseVisualStyleBackColor = true;
            // 
            // Tab_General_SimulatorPath_Button
            // 
            this.Tab_General_SimulatorPath_Button.Location = new System.Drawing.Point(634, 40);
            this.Tab_General_SimulatorPath_Button.Name = "Tab_General_SimulatorPath_Button";
            this.Tab_General_SimulatorPath_Button.Size = new System.Drawing.Size(32, 27);
            this.Tab_General_SimulatorPath_Button.TabIndex = 4;
            this.Tab_General_SimulatorPath_Button.Text = "...";
            this.Tab_General_SimulatorPath_Button.UseVisualStyleBackColor = true;
            // 
            // Tab_General_SimulatorPath_TextBox
            // 
            this.Tab_General_SimulatorPath_TextBox.Location = new System.Drawing.Point(142, 40);
            this.Tab_General_SimulatorPath_TextBox.Name = "Tab_General_SimulatorPath_TextBox";
            this.Tab_General_SimulatorPath_TextBox.Size = new System.Drawing.Size(486, 27);
            this.Tab_General_SimulatorPath_TextBox.TabIndex = 3;
            // 
            // Tab_General_SimulatorPath_Label
            // 
            this.Tab_General_SimulatorPath_Label.AutoSize = true;
            this.Tab_General_SimulatorPath_Label.Location = new System.Drawing.Point(7, 43);
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
            this.Tab_Editor.Controls.Add(this.Tab_Editor_Sample);
            this.Tab_Editor.Location = new System.Drawing.Point(4, 29);
            this.Tab_Editor.Name = "Tab_Editor";
            this.Tab_Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Editor.Size = new System.Drawing.Size(672, 328);
            this.Tab_Editor.TabIndex = 1;
            this.Tab_Editor.Text = "Editor";
            this.Tab_Editor.UseVisualStyleBackColor = true;
            // 
            // Tab_Editor_Sample
            // 
            this.Tab_Editor_Sample.BackColor = System.Drawing.Color.White;
            this.Tab_Editor_Sample.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tab_Editor_Sample.DrawingOption = ((Sgry.Azuki.DrawingOption)(((((((Sgry.Azuki.DrawingOption.DrawsFullWidthSpace | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsDirtBar) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.Tab_Editor_Sample.FirstVisibleLine = 0;
            this.Tab_Editor_Sample.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            fontInfo1.Name = "MS UI Gothic";
            fontInfo1.Size = 9;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.Tab_Editor_Sample.FontInfo = fontInfo1;
            this.Tab_Editor_Sample.ForeColor = System.Drawing.Color.Black;
            this.Tab_Editor_Sample.Location = new System.Drawing.Point(67, 112);
            this.Tab_Editor_Sample.Name = "Tab_Editor_Sample";
            this.Tab_Editor_Sample.ScrollPos = new System.Drawing.Point(0, 0);
            this.Tab_Editor_Sample.Size = new System.Drawing.Size(535, 210);
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
            this.Tab.ResumeLayout(false);
            this.Tab_General.ResumeLayout(false);
            this.Tab_General.PerformLayout();
            this.Tab_Editor.ResumeLayout(false);
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
    }
}