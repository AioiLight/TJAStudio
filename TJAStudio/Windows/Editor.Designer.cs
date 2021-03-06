﻿namespace TJAStudio
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.TextEditor = new Sgry.Azuki.WinForms.AzukiControl();
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.TextEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.DrawingOption = ((Sgry.Azuki.DrawingOption)((((((((((Sgry.Azuki.DrawingOption.DrawsSpace | Sgry.Azuki.DrawingOption.DrawsFullWidthSpace) 
            | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsHRuler) 
            | Sgry.Azuki.DrawingOption.DrawsEof) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket) 
            | Sgry.Azuki.DrawingOption.HRulerStartsFromZero)));
            this.TextEditor.DrawsEofMark = true;
            this.TextEditor.DrawsSpace = true;
            this.TextEditor.FirstVisibleLine = 0;
            this.TextEditor.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            fontInfo1.Name = "ＭＳ ゴシック";
            fontInfo1.Size = 12;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.TextEditor.FontInfo = fontInfo1;
            this.TextEditor.ForeColor = System.Drawing.Color.Black;
            this.TextEditor.HRulerIndicatorType = Sgry.Azuki.HRulerIndicatorType.CharCount;
            this.TextEditor.LeftMargin = 8;
            this.TextEditor.LinePadding = 4;
            this.TextEditor.Location = new System.Drawing.Point(0, 0);
            this.TextEditor.MarksUri = true;
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.ScrollPos = new System.Drawing.Point(0, 0);
            this.TextEditor.ShowsDirtBar = false;
            this.TextEditor.ShowsHRuler = true;
            this.TextEditor.Size = new System.Drawing.Size(842, 452);
            this.TextEditor.TabIndex = 0;
            this.TextEditor.Text = "azukiControl1";
            this.TextEditor.ViewWidth = 4145;
            this.TextEditor.CaretMoved += new System.EventHandler(this.TextEditor_CaretMoved);
            this.TextEditor.TextChanged += new System.EventHandler(this.TextEditor_TextChanged);
            this.TextEditor.Click += new System.EventHandler(this.TextEditor_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.TextEditor);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Editor";
            this.Text = "エディター";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        internal Sgry.Azuki.WinForms.AzukiControl TextEditor;
    }
}