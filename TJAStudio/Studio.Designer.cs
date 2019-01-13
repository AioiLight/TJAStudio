namespace TJAStudio
{
    partial class Studio
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Dock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.openTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exporttjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toKaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abekobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detarameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_CommonHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_CourseHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Version = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dock
            // 
            this.Dock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.Dock.Location = new System.Drawing.Point(13, 62);
            this.Dock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dock.Name = "Dock";
            this.Dock.Size = new System.Drawing.Size(1238, 592);
            this.Dock.TabIndex = 0;
            this.Dock.ActiveDocumentChanged += new System.EventHandler(this.Dock_ActiveDocumentChanged);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_Window,
            this.Menu_Version,
            this.Menu_Tool});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.Menu.Size = new System.Drawing.Size(1264, 32);
            this.Menu.TabIndex = 2;
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_New,
            this.toolStripMenuItem3,
            this.Menu_File_Open,
            this.openTemplateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.Menu_File_Save,
            this.Menu_File_SaveAs,
            this.exporttjaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.Menu_File.Image = global::TJAStudio.Properties.Resources.FileGroup_16x;
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(58, 24);
            this.Menu_File.Text = "&File";
            // 
            // Menu_File_New
            // 
            this.Menu_File_New.Image = global::TJAStudio.Properties.Resources.NewFile_16x;
            this.Menu_File_New.Name = "Menu_File_New";
            this.Menu_File_New.Size = new System.Drawing.Size(190, 24);
            this.Menu_File_New.Text = "New Project...";
            this.Menu_File_New.Click += new System.EventHandler(this.Menu_File_New_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // Menu_File_Open
            // 
            this.Menu_File_Open.Image = global::TJAStudio.Properties.Resources.FolderOpen_16x;
            this.Menu_File_Open.Name = "Menu_File_Open";
            this.Menu_File_Open.Size = new System.Drawing.Size(190, 24);
            this.Menu_File_Open.Text = "Open...";
            this.Menu_File_Open.Click += new System.EventHandler(this.Menu_File_Open_Click);
            // 
            // openTemplateToolStripMenuItem
            // 
            this.openTemplateToolStripMenuItem.Name = "openTemplateToolStripMenuItem";
            this.openTemplateToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.openTemplateToolStripMenuItem.Text = "Open Template...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // Menu_File_Save
            // 
            this.Menu_File_Save.Image = global::TJAStudio.Properties.Resources.Save_16x;
            this.Menu_File_Save.Name = "Menu_File_Save";
            this.Menu_File_Save.Size = new System.Drawing.Size(190, 24);
            this.Menu_File_Save.Text = "Save";
            this.Menu_File_Save.Click += new System.EventHandler(this.Menu_File_Save_Click);
            // 
            // Menu_File_SaveAs
            // 
            this.Menu_File_SaveAs.Image = global::TJAStudio.Properties.Resources.SaveAs_16x;
            this.Menu_File_SaveAs.Name = "Menu_File_SaveAs";
            this.Menu_File_SaveAs.Size = new System.Drawing.Size(190, 24);
            this.Menu_File_SaveAs.Text = "Save As...";
            this.Menu_File_SaveAs.Click += new System.EventHandler(this.Menu_File_SaveAs_Click);
            // 
            // exporttjaToolStripMenuItem
            // 
            this.exporttjaToolStripMenuItem.Name = "exporttjaToolStripMenuItem";
            this.exporttjaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.exporttjaToolStripMenuItem.Text = "Export .tja...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.CloseSolution_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem5,
            this.goToToolStripMenuItem,
            this.toolStripMenuItem6,
            this.selectAllToolStripMenuItem,
            this.timeDateToolStripMenuItem,
            this.toolStripMenuItem7,
            this.repeatToolStripMenuItem,
            this.notesOperationToolStripMenuItem});
            this.Menu_Edit.Image = global::TJAStudio.Properties.Resources.Edit_16x;
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(61, 24);
            this.Menu_Edit.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Undo_16x;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Redo_16x;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Cut_16x;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Copy_16x;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Paste_16x;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(179, 6);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.goToToolStripMenuItem.Text = "Go To...";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(179, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.timeDateToolStripMenuItem.Text = "Time / Date";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(179, 6);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Image = global::TJAStudio.Properties.Resources.Restart_16x;
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // notesOperationToolStripMenuItem
            // 
            this.notesOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDonToolStripMenuItem,
            this.toKaToolStripMenuItem,
            this.abekobeToolStripMenuItem,
            this.detarameToolStripMenuItem});
            this.notesOperationToolStripMenuItem.Name = "notesOperationToolStripMenuItem";
            this.notesOperationToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.notesOperationToolStripMenuItem.Text = "Notes Operation";
            // 
            // toDonToolStripMenuItem
            // 
            this.toDonToolStripMenuItem.Name = "toDonToolStripMenuItem";
            this.toDonToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.toDonToolStripMenuItem.Text = "To Don";
            // 
            // toKaToolStripMenuItem
            // 
            this.toKaToolStripMenuItem.Name = "toKaToolStripMenuItem";
            this.toKaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.toKaToolStripMenuItem.Text = "To Ka";
            // 
            // abekobeToolStripMenuItem
            // 
            this.abekobeToolStripMenuItem.Name = "abekobeToolStripMenuItem";
            this.abekobeToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.abekobeToolStripMenuItem.Text = "Abekobe";
            // 
            // detarameToolStripMenuItem
            // 
            this.detarameToolStripMenuItem.Name = "detarameToolStripMenuItem";
            this.detarameToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.detarameToolStripMenuItem.Text = "Detarame";
            // 
            // Menu_Window
            // 
            this.Menu_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Window_CommonHeader,
            this.Menu_Window_CourseHeader,
            this.Menu_Window_Projects});
            this.Menu_Window.Image = global::TJAStudio.Properties.Resources.WindowsForm_16x;
            this.Menu_Window.Name = "Menu_Window";
            this.Menu_Window.Size = new System.Drawing.Size(88, 24);
            this.Menu_Window.Text = "&Window";
            // 
            // Menu_Window_CommonHeader
            // 
            this.Menu_Window_CommonHeader.Name = "Menu_Window_CommonHeader";
            this.Menu_Window_CommonHeader.Size = new System.Drawing.Size(192, 24);
            this.Menu_Window_CommonHeader.Text = "Common Headers";
            // 
            // Menu_Window_CourseHeader
            // 
            this.Menu_Window_CourseHeader.Name = "Menu_Window_CourseHeader";
            this.Menu_Window_CourseHeader.Size = new System.Drawing.Size(192, 24);
            this.Menu_Window_CourseHeader.Text = "Course Headers";
            // 
            // Menu_Window_Projects
            // 
            this.Menu_Window_Projects.Name = "Menu_Window_Projects";
            this.Menu_Window_Projects.Size = new System.Drawing.Size(192, 24);
            this.Menu_Window_Projects.Text = "Projects";
            // 
            // Menu_Version
            // 
            this.Menu_Version.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_Version.Name = "Menu_Version";
            this.Menu_Version.Size = new System.Drawing.Size(133, 24);
            this.Menu_Version.Text = "TJAStudio Ver.1.0";
            // 
            // Menu_Tool
            // 
            this.Menu_Tool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tool_About});
            this.Menu_Tool.Image = global::TJAStudio.Properties.Resources.Toolbox_16x;
            this.Menu_Tool.Name = "Menu_Tool";
            this.Menu_Tool.Size = new System.Drawing.Size(63, 24);
            this.Menu_Tool.Text = "&Tool";
            // 
            // Menu_Tool_About
            // 
            this.Menu_Tool_About.Name = "Menu_Tool_About";
            this.Menu_Tool_About.Size = new System.Drawing.Size(198, 24);
            this.Menu_Tool_About.Text = "About TJAStudio...";
            this.Menu_Tool_About.Click += new System.EventHandler(this.Menu_Tool_About_Click);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Status.Location = new System.Drawing.Point(0, 659);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1264, 22);
            this.Status.TabIndex = 3;
            // 
            // Tool
            // 
            this.Tool.Location = new System.Drawing.Point(0, 32);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(1264, 25);
            this.Tool.TabIndex = 4;
            this.Tool.Text = "toolStrip1";
            // 
            // Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Dock);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Studio";
            this.Text = "TJAStudio";
            this.Load += new System.EventHandler(this.Studio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0108 // 'Studio.Dock' は継承されたメンバー 'Control.Dock' を非表示にします。非表示にする場合は、キーワード new を使用してください。
        public WeifenLuo.WinFormsUI.Docking.DockPanel Dock;
#pragma warning restore CS0108 // 'Studio.Dock' は継承されたメンバー 'Control.Dock' を非表示にします。非表示にする場合は、キーワード new を使用してください。
#pragma warning disable CS0108 // 'Studio.Menu' は継承されたメンバー 'Form.Menu' を非表示にします。非表示にする場合は、キーワード new を使用してください。
        private System.Windows.Forms.MenuStrip Menu;
#pragma warning restore CS0108 // 'Studio.Menu' は継承されたメンバー 'Form.Menu' を非表示にします。非表示にする場合は、キーワード new を使用してください。
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_New;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem openTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem exporttjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notesOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toKaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abekobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detarameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_CommonHeader;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_CourseHeader;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_Projects;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool;
        private System.Windows.Forms.ToolStripMenuItem Menu_Version;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_About;
    }
}

