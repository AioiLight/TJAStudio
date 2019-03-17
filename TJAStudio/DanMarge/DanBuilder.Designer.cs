namespace TJAStudio.DanMarge
{
    partial class DanBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanBuilder));
            this.GroupBox_Conditions = new System.Windows.Forms.GroupBox();
            this.Label_Exam3 = new System.Windows.Forms.Label();
            this.Label_Exam2 = new System.Windows.Forms.Label();
            this.Label_Exam1 = new System.Windows.Forms.Label();
            this.GroupBox_Songs = new System.Windows.Forms.GroupBox();
            this.Button_DownSong = new System.Windows.Forms.Button();
            this.Button_UpSong = new System.Windows.Forms.Button();
            this.Button_RemoveSong = new System.Windows.Forms.Button();
            this.Button_AddSong = new System.Windows.Forms.Button();
            this.ListView_Songs = new System.Windows.Forms.ListView();
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Status_Songs = new System.Windows.Forms.ToolStripStatusLabel();
            this.Button_Build = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Status_NotesRemain = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExamHeader_Exam3 = new TJAStudio.DanMarge.ExamHeader();
            this.ExamHeader_Exam2 = new TJAStudio.DanMarge.ExamHeader();
            this.ExamHeader_Exam1 = new TJAStudio.DanMarge.ExamHeader();
            this.GroupBox_Conditions.SuspendLayout();
            this.GroupBox_Songs.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Conditions
            // 
            this.GroupBox_Conditions.Controls.Add(this.Label_Exam3);
            this.GroupBox_Conditions.Controls.Add(this.ExamHeader_Exam3);
            this.GroupBox_Conditions.Controls.Add(this.Label_Exam2);
            this.GroupBox_Conditions.Controls.Add(this.ExamHeader_Exam2);
            this.GroupBox_Conditions.Controls.Add(this.Label_Exam1);
            this.GroupBox_Conditions.Controls.Add(this.ExamHeader_Exam1);
            resources.ApplyResources(this.GroupBox_Conditions, "GroupBox_Conditions");
            this.GroupBox_Conditions.Name = "GroupBox_Conditions";
            this.GroupBox_Conditions.TabStop = false;
            // 
            // Label_Exam3
            // 
            resources.ApplyResources(this.Label_Exam3, "Label_Exam3");
            this.Label_Exam3.Name = "Label_Exam3";
            // 
            // Label_Exam2
            // 
            resources.ApplyResources(this.Label_Exam2, "Label_Exam2");
            this.Label_Exam2.Name = "Label_Exam2";
            // 
            // Label_Exam1
            // 
            resources.ApplyResources(this.Label_Exam1, "Label_Exam1");
            this.Label_Exam1.Name = "Label_Exam1";
            // 
            // GroupBox_Songs
            // 
            this.GroupBox_Songs.Controls.Add(this.Button_DownSong);
            this.GroupBox_Songs.Controls.Add(this.Button_UpSong);
            this.GroupBox_Songs.Controls.Add(this.Button_RemoveSong);
            this.GroupBox_Songs.Controls.Add(this.Button_AddSong);
            this.GroupBox_Songs.Controls.Add(this.ListView_Songs);
            resources.ApplyResources(this.GroupBox_Songs, "GroupBox_Songs");
            this.GroupBox_Songs.Name = "GroupBox_Songs";
            this.GroupBox_Songs.TabStop = false;
            // 
            // Button_DownSong
            // 
            this.Button_DownSong.BackgroundImage = global::TJAStudio.Properties.Resources.GlyphDown_16x;
            resources.ApplyResources(this.Button_DownSong, "Button_DownSong");
            this.Button_DownSong.Name = "Button_DownSong";
            this.Button_DownSong.UseVisualStyleBackColor = true;
            this.Button_DownSong.Click += new System.EventHandler(this.Button_DownSong_Click);
            // 
            // Button_UpSong
            // 
            this.Button_UpSong.BackgroundImage = global::TJAStudio.Properties.Resources.GlyphUp_16x;
            resources.ApplyResources(this.Button_UpSong, "Button_UpSong");
            this.Button_UpSong.Name = "Button_UpSong";
            this.Button_UpSong.UseVisualStyleBackColor = true;
            this.Button_UpSong.Click += new System.EventHandler(this.Button_UpSong_Click);
            // 
            // Button_RemoveSong
            // 
            this.Button_RemoveSong.BackgroundImage = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            resources.ApplyResources(this.Button_RemoveSong, "Button_RemoveSong");
            this.Button_RemoveSong.Name = "Button_RemoveSong";
            this.Button_RemoveSong.UseVisualStyleBackColor = true;
            this.Button_RemoveSong.Click += new System.EventHandler(this.Button_RemoveSong_Click);
            // 
            // Button_AddSong
            // 
            this.Button_AddSong.BackgroundImage = global::TJAStudio.Properties.Resources.AddColumn_16x;
            resources.ApplyResources(this.Button_AddSong, "Button_AddSong");
            this.Button_AddSong.Name = "Button_AddSong";
            this.Button_AddSong.UseVisualStyleBackColor = true;
            this.Button_AddSong.Click += new System.EventHandler(this.Button_AddSong_Click);
            // 
            // ListView_Songs
            // 
            this.ListView_Songs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilePath});
            this.ListView_Songs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            resources.ApplyResources(this.ListView_Songs, "ListView_Songs");
            this.ListView_Songs.MultiSelect = false;
            this.ListView_Songs.Name = "ListView_Songs";
            this.ListView_Songs.Scrollable = false;
            this.ListView_Songs.UseCompatibleStateImageBehavior = false;
            this.ListView_Songs.View = System.Windows.Forms.View.Details;
            // 
            // FilePath
            // 
            resources.ApplyResources(this.FilePath, "FilePath");
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Songs,
            this.Status_NotesRemain});
            this.Status.Name = "Status";
            // 
            // Status_Songs
            // 
            this.Status_Songs.Name = "Status_Songs";
            resources.ApplyResources(this.Status_Songs, "Status_Songs");
            // 
            // Button_Build
            // 
            this.Button_Build.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Button_Build, "Button_Build");
            this.Button_Build.Name = "Button_Build";
            this.Button_Build.UseVisualStyleBackColor = true;
            this.Button_Build.Click += new System.EventHandler(this.Button_Build_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Button_Close, "Button_Close");
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Status_NotesRemain
            // 
            this.Status_NotesRemain.Name = "Status_NotesRemain";
            resources.ApplyResources(this.Status_NotesRemain, "Status_NotesRemain");
            // 
            // ExamHeader_Exam3
            // 
            resources.ApplyResources(this.ExamHeader_Exam3, "ExamHeader_Exam3");
            this.ExamHeader_Exam3.Name = "ExamHeader_Exam3";
            // 
            // ExamHeader_Exam2
            // 
            resources.ApplyResources(this.ExamHeader_Exam2, "ExamHeader_Exam2");
            this.ExamHeader_Exam2.Name = "ExamHeader_Exam2";
            // 
            // ExamHeader_Exam1
            // 
            resources.ApplyResources(this.ExamHeader_Exam1, "ExamHeader_Exam1");
            this.ExamHeader_Exam1.Name = "ExamHeader_Exam1";
            // 
            // DanBuilder
            // 
            this.AcceptButton = this.Button_Build;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Close;
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Build);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.GroupBox_Songs);
            this.Controls.Add(this.GroupBox_Conditions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanBuilder";
            this.ShowInTaskbar = false;
            this.GroupBox_Conditions.ResumeLayout(false);
            this.GroupBox_Conditions.PerformLayout();
            this.GroupBox_Songs.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Conditions;
        private System.Windows.Forms.Label Label_Exam3;
        private ExamHeader ExamHeader_Exam3;
        private System.Windows.Forms.Label Label_Exam2;
        private ExamHeader ExamHeader_Exam2;
        private System.Windows.Forms.Label Label_Exam1;
        private ExamHeader ExamHeader_Exam1;
        private System.Windows.Forms.GroupBox GroupBox_Songs;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Status_Songs;
        private System.Windows.Forms.Button Button_Build;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_DownSong;
        private System.Windows.Forms.Button Button_UpSong;
        private System.Windows.Forms.Button Button_RemoveSong;
        private System.Windows.Forms.Button Button_AddSong;
        private System.Windows.Forms.ListView ListView_Songs;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.ToolStripStatusLabel Status_NotesRemain;
    }
}