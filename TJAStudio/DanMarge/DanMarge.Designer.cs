namespace TJAStudio.DanMarge
{
    partial class DanMarge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanMarge));
            this.GroupBox_Conditions = new System.Windows.Forms.GroupBox();
            this.ExamHeader_Exam1 = new TJAStudio.DanMarge.ExamHeader();
            this.Label_Exam1 = new System.Windows.Forms.Label();
            this.Label_Exam2 = new System.Windows.Forms.Label();
            this.ExamHeader_Exam2 = new TJAStudio.DanMarge.ExamHeader();
            this.Label_Exam3 = new System.Windows.Forms.Label();
            this.ExamHeader_Exam3 = new TJAStudio.DanMarge.ExamHeader();
            this.GroupBox_Songs = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Status_Songs = new System.Windows.Forms.ToolStripStatusLabel();
            this.Button_Build = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.ListView_Songs = new System.Windows.Forms.ListView();
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_AddSong = new System.Windows.Forms.Button();
            this.Button_RemoveSong = new System.Windows.Forms.Button();
            this.Button_UpSong = new System.Windows.Forms.Button();
            this.Button_DownSong = new System.Windows.Forms.Button();
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
            this.GroupBox_Conditions.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Conditions.Name = "GroupBox_Conditions";
            this.GroupBox_Conditions.Size = new System.Drawing.Size(920, 166);
            this.GroupBox_Conditions.TabIndex = 0;
            this.GroupBox_Conditions.TabStop = false;
            this.GroupBox_Conditions.Text = "Conditions";
            // 
            // ExamHeader_Exam1
            // 
            this.ExamHeader_Exam1.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.ExamHeader_Exam1.Location = new System.Drawing.Point(73, 28);
            this.ExamHeader_Exam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExamHeader_Exam1.Name = "ExamHeader_Exam1";
            this.ExamHeader_Exam1.Size = new System.Drawing.Size(820, 34);
            this.ExamHeader_Exam1.TabIndex = 0;
            // 
            // Label_Exam1
            // 
            this.Label_Exam1.AutoSize = true;
            this.Label_Exam1.Location = new System.Drawing.Point(6, 34);
            this.Label_Exam1.Name = "Label_Exam1";
            this.Label_Exam1.Size = new System.Drawing.Size(60, 20);
            this.Label_Exam1.TabIndex = 1;
            this.Label_Exam1.Text = "EXAM1:";
            // 
            // Label_Exam2
            // 
            this.Label_Exam2.AutoSize = true;
            this.Label_Exam2.Location = new System.Drawing.Point(6, 78);
            this.Label_Exam2.Name = "Label_Exam2";
            this.Label_Exam2.Size = new System.Drawing.Size(60, 20);
            this.Label_Exam2.TabIndex = 3;
            this.Label_Exam2.Text = "EXAM2:";
            // 
            // ExamHeader_Exam2
            // 
            this.ExamHeader_Exam2.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.ExamHeader_Exam2.Location = new System.Drawing.Point(73, 72);
            this.ExamHeader_Exam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExamHeader_Exam2.Name = "ExamHeader_Exam2";
            this.ExamHeader_Exam2.Size = new System.Drawing.Size(820, 34);
            this.ExamHeader_Exam2.TabIndex = 2;
            // 
            // Label_Exam3
            // 
            this.Label_Exam3.AutoSize = true;
            this.Label_Exam3.Location = new System.Drawing.Point(6, 122);
            this.Label_Exam3.Name = "Label_Exam3";
            this.Label_Exam3.Size = new System.Drawing.Size(60, 20);
            this.Label_Exam3.TabIndex = 5;
            this.Label_Exam3.Text = "EXAM3:";
            // 
            // ExamHeader_Exam3
            // 
            this.ExamHeader_Exam3.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.ExamHeader_Exam3.Location = new System.Drawing.Point(73, 116);
            this.ExamHeader_Exam3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExamHeader_Exam3.Name = "ExamHeader_Exam3";
            this.ExamHeader_Exam3.Size = new System.Drawing.Size(820, 34);
            this.ExamHeader_Exam3.TabIndex = 4;
            // 
            // GroupBox_Songs
            // 
            this.GroupBox_Songs.Controls.Add(this.Button_DownSong);
            this.GroupBox_Songs.Controls.Add(this.Button_UpSong);
            this.GroupBox_Songs.Controls.Add(this.Button_RemoveSong);
            this.GroupBox_Songs.Controls.Add(this.Button_AddSong);
            this.GroupBox_Songs.Controls.Add(this.ListView_Songs);
            this.GroupBox_Songs.Location = new System.Drawing.Point(12, 184);
            this.GroupBox_Songs.Name = "GroupBox_Songs";
            this.GroupBox_Songs.Size = new System.Drawing.Size(920, 180);
            this.GroupBox_Songs.TabIndex = 1;
            this.GroupBox_Songs.TabStop = false;
            this.GroupBox_Songs.Text = "Songs";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Songs});
            this.Status.Location = new System.Drawing.Point(0, 416);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(944, 25);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // Status_Songs
            // 
            this.Status_Songs.Name = "Status_Songs";
            this.Status_Songs.Size = new System.Drawing.Size(59, 20);
            this.Status_Songs.Text = "n Songs";
            // 
            // Button_Build
            // 
            this.Button_Build.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Build.Location = new System.Drawing.Point(752, 383);
            this.Button_Build.Name = "Button_Build";
            this.Button_Build.Size = new System.Drawing.Size(180, 30);
            this.Button_Build.TabIndex = 3;
            this.Button_Build.Text = "Build .tja file";
            this.Button_Build.UseVisualStyleBackColor = true;
            // 
            // Button_Close
            // 
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.Location = new System.Drawing.Point(566, 383);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(180, 30);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // ListView_Songs
            // 
            this.ListView_Songs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilePath});
            this.ListView_Songs.Location = new System.Drawing.Point(6, 26);
            this.ListView_Songs.Name = "ListView_Songs";
            this.ListView_Songs.Size = new System.Drawing.Size(872, 148);
            this.ListView_Songs.TabIndex = 0;
            this.ListView_Songs.UseCompatibleStateImageBehavior = false;
            this.ListView_Songs.View = System.Windows.Forms.View.Details;
            // 
            // FilePath
            // 
            this.FilePath.Text = "File path";
            this.FilePath.Width = 805;
            // 
            // Button_AddSong
            // 
            this.Button_AddSong.BackgroundImage = global::TJAStudio.Properties.Resources.AddColumn_16x;
            this.Button_AddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_AddSong.Location = new System.Drawing.Point(884, 26);
            this.Button_AddSong.Name = "Button_AddSong";
            this.Button_AddSong.Size = new System.Drawing.Size(30, 30);
            this.Button_AddSong.TabIndex = 1;
            this.Button_AddSong.UseVisualStyleBackColor = true;
            // 
            // Button_RemoveSong
            // 
            this.Button_RemoveSong.BackgroundImage = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            this.Button_RemoveSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_RemoveSong.Location = new System.Drawing.Point(884, 62);
            this.Button_RemoveSong.Name = "Button_RemoveSong";
            this.Button_RemoveSong.Size = new System.Drawing.Size(30, 30);
            this.Button_RemoveSong.TabIndex = 2;
            this.Button_RemoveSong.UseVisualStyleBackColor = true;
            // 
            // Button_UpSong
            // 
            this.Button_UpSong.BackgroundImage = global::TJAStudio.Properties.Resources.GlyphUp_16x;
            this.Button_UpSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_UpSong.Location = new System.Drawing.Point(884, 108);
            this.Button_UpSong.Name = "Button_UpSong";
            this.Button_UpSong.Size = new System.Drawing.Size(30, 30);
            this.Button_UpSong.TabIndex = 3;
            this.Button_UpSong.UseVisualStyleBackColor = true;
            // 
            // Button_DownSong
            // 
            this.Button_DownSong.BackgroundImage = global::TJAStudio.Properties.Resources.GlyphDown_16x;
            this.Button_DownSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_DownSong.Location = new System.Drawing.Point(884, 144);
            this.Button_DownSong.Name = "Button_DownSong";
            this.Button_DownSong.Size = new System.Drawing.Size(30, 30);
            this.Button_DownSong.TabIndex = 4;
            this.Button_DownSong.UseVisualStyleBackColor = true;
            // 
            // DanMarge
            // 
            this.AcceptButton = this.Button_Build;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Close;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Build);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.GroupBox_Songs);
            this.Controls.Add(this.GroupBox_Conditions);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DanMarge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TJAStudio - Dan Marge";
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
    }
}