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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studio));
            this.Dock = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_OpenTmpl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_GoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Time = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Repert = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_NotesOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_NotesOperation_ToDon = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_NotesOperation_ToKa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_NotesOperation_Abekobe = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_NotesOperation_Detarame = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Version = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Version_Site = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Version_TJAS = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool_DanBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Tool_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_Courses = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_CommonHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_CourseHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Window_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Window_FormatCheker = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Execution = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Execution_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Execution_LiveUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Measures = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Caret = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Open = new System.Windows.Forms.ToolStripButton();
            this.Tool_Save = new System.Windows.Forms.ToolStripSplitButton();
            this.Tool_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Undo = new System.Windows.Forms.ToolStripButton();
            this.Tool_Redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Cut = new System.Windows.Forms.ToolStripButton();
            this.Tool_Copy = new System.Windows.Forms.ToolStripButton();
            this.Tool_Paste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_Execute = new System.Windows.Forms.ToolStripButton();
            this.Tool_FormatCheker = new System.Windows.Forms.ToolStripButton();
            this.Menu.SuspendLayout();
            this.Status.SuspendLayout();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dock
            // 
            resources.ApplyResources(this.Dock, "Dock");
            this.Dock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.Dock.Name = "Dock";
            this.Dock.ActiveDocumentChanged += new System.EventHandler(this.Dock_ActiveDocumentChanged);
            // 
            // Menu
            // 
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_Version,
            this.Menu_Tool,
            this.Menu_Window,
            this.Menu_Execution});
            this.Menu.Name = "Menu";
            // 
            // Menu_File
            // 
            resources.ApplyResources(this.Menu_File, "Menu_File");
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_New,
            this.toolStripMenuItem3,
            this.Menu_File_Open,
            this.Menu_File_OpenTmpl,
            this.toolStripMenuItem2,
            this.Menu_File_Save,
            this.Menu_File_SaveAs,
            this.Menu_File_Export,
            this.toolStripMenuItem1,
            this.Menu_File_Exit});
            this.Menu_File.Image = global::TJAStudio.Properties.Resources.FileGroup_16x;
            this.Menu_File.Name = "Menu_File";
            // 
            // Menu_File_New
            // 
            resources.ApplyResources(this.Menu_File_New, "Menu_File_New");
            this.Menu_File_New.Image = global::TJAStudio.Properties.Resources.NewFile_16x;
            this.Menu_File_New.Name = "Menu_File_New";
            this.Menu_File_New.Click += new System.EventHandler(this.Menu_File_New_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // Menu_File_Open
            // 
            resources.ApplyResources(this.Menu_File_Open, "Menu_File_Open");
            this.Menu_File_Open.Image = global::TJAStudio.Properties.Resources.FolderOpen_16x;
            this.Menu_File_Open.Name = "Menu_File_Open";
            this.Menu_File_Open.Click += new System.EventHandler(this.Menu_File_Open_Click);
            // 
            // Menu_File_OpenTmpl
            // 
            resources.ApplyResources(this.Menu_File_OpenTmpl, "Menu_File_OpenTmpl");
            this.Menu_File_OpenTmpl.Name = "Menu_File_OpenTmpl";
            this.Menu_File_OpenTmpl.Click += new System.EventHandler(this.Menu_File_OpenTmpl_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // Menu_File_Save
            // 
            resources.ApplyResources(this.Menu_File_Save, "Menu_File_Save");
            this.Menu_File_Save.Image = global::TJAStudio.Properties.Resources.Save_16x;
            this.Menu_File_Save.Name = "Menu_File_Save";
            this.Menu_File_Save.Click += new System.EventHandler(this.Menu_File_Save_Click);
            // 
            // Menu_File_SaveAs
            // 
            resources.ApplyResources(this.Menu_File_SaveAs, "Menu_File_SaveAs");
            this.Menu_File_SaveAs.Image = global::TJAStudio.Properties.Resources.SaveAs_16x;
            this.Menu_File_SaveAs.Name = "Menu_File_SaveAs";
            this.Menu_File_SaveAs.Click += new System.EventHandler(this.Menu_File_SaveAs_Click);
            // 
            // Menu_File_Export
            // 
            resources.ApplyResources(this.Menu_File_Export, "Menu_File_Export");
            this.Menu_File_Export.Name = "Menu_File_Export";
            this.Menu_File_Export.Click += new System.EventHandler(this.Menu_File_Export_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // Menu_File_Exit
            // 
            resources.ApplyResources(this.Menu_File_Exit, "Menu_File_Exit");
            this.Menu_File_Exit.Image = global::TJAStudio.Properties.Resources.CloseSolution_16x;
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // Menu_Edit
            // 
            resources.ApplyResources(this.Menu_Edit, "Menu_Edit");
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_Undo,
            this.Menu_Edit_Redo,
            this.toolStripMenuItem4,
            this.Menu_Edit_Cut,
            this.Menu_Edit_Copy,
            this.Menu_Edit_Paste,
            this.toolStripMenuItem5,
            this.Menu_Edit_GoTo,
            this.toolStripMenuItem6,
            this.Menu_Edit_SelectAll,
            this.Menu_Edit_Time,
            this.toolStripMenuItem7,
            this.Menu_Edit_Repert,
            this.Menu_Edit_NotesOperation});
            this.Menu_Edit.Image = global::TJAStudio.Properties.Resources.Edit_16x;
            this.Menu_Edit.Name = "Menu_Edit";
            // 
            // Menu_Edit_Undo
            // 
            resources.ApplyResources(this.Menu_Edit_Undo, "Menu_Edit_Undo");
            this.Menu_Edit_Undo.Image = global::TJAStudio.Properties.Resources.Undo_16x;
            this.Menu_Edit_Undo.Name = "Menu_Edit_Undo";
            this.Menu_Edit_Undo.Click += new System.EventHandler(this.Menu_Edit_Undo_Click);
            // 
            // Menu_Edit_Redo
            // 
            resources.ApplyResources(this.Menu_Edit_Redo, "Menu_Edit_Redo");
            this.Menu_Edit_Redo.Image = global::TJAStudio.Properties.Resources.Redo_16x;
            this.Menu_Edit_Redo.Name = "Menu_Edit_Redo";
            this.Menu_Edit_Redo.Click += new System.EventHandler(this.Menu_Edit_Redo_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // Menu_Edit_Cut
            // 
            resources.ApplyResources(this.Menu_Edit_Cut, "Menu_Edit_Cut");
            this.Menu_Edit_Cut.Image = global::TJAStudio.Properties.Resources.Cut_16x;
            this.Menu_Edit_Cut.Name = "Menu_Edit_Cut";
            this.Menu_Edit_Cut.Click += new System.EventHandler(this.Menu_Edit_Cut_Click);
            // 
            // Menu_Edit_Copy
            // 
            resources.ApplyResources(this.Menu_Edit_Copy, "Menu_Edit_Copy");
            this.Menu_Edit_Copy.Image = global::TJAStudio.Properties.Resources.Copy_16x;
            this.Menu_Edit_Copy.Name = "Menu_Edit_Copy";
            this.Menu_Edit_Copy.Click += new System.EventHandler(this.Menu_Edit_Copy_Click);
            // 
            // Menu_Edit_Paste
            // 
            resources.ApplyResources(this.Menu_Edit_Paste, "Menu_Edit_Paste");
            this.Menu_Edit_Paste.Image = global::TJAStudio.Properties.Resources.Paste_16x;
            this.Menu_Edit_Paste.Name = "Menu_Edit_Paste";
            this.Menu_Edit_Paste.Click += new System.EventHandler(this.Menu_Edit_Paste_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // Menu_Edit_GoTo
            // 
            resources.ApplyResources(this.Menu_Edit_GoTo, "Menu_Edit_GoTo");
            this.Menu_Edit_GoTo.Name = "Menu_Edit_GoTo";
            this.Menu_Edit_GoTo.Click += new System.EventHandler(this.Menu_Edit_GoTo_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            // 
            // Menu_Edit_SelectAll
            // 
            resources.ApplyResources(this.Menu_Edit_SelectAll, "Menu_Edit_SelectAll");
            this.Menu_Edit_SelectAll.Name = "Menu_Edit_SelectAll";
            this.Menu_Edit_SelectAll.Click += new System.EventHandler(this.Menu_Edit_SelectAll_Click);
            // 
            // Menu_Edit_Time
            // 
            resources.ApplyResources(this.Menu_Edit_Time, "Menu_Edit_Time");
            this.Menu_Edit_Time.Name = "Menu_Edit_Time";
            this.Menu_Edit_Time.Click += new System.EventHandler(this.Menu_Edit_Time_Click);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            // 
            // Menu_Edit_Repert
            // 
            resources.ApplyResources(this.Menu_Edit_Repert, "Menu_Edit_Repert");
            this.Menu_Edit_Repert.Image = global::TJAStudio.Properties.Resources.Restart_16x;
            this.Menu_Edit_Repert.Name = "Menu_Edit_Repert";
            this.Menu_Edit_Repert.Click += new System.EventHandler(this.Menu_Edit_Repert_Click);
            // 
            // Menu_Edit_NotesOperation
            // 
            resources.ApplyResources(this.Menu_Edit_NotesOperation, "Menu_Edit_NotesOperation");
            this.Menu_Edit_NotesOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_NotesOperation_ToDon,
            this.Menu_Edit_NotesOperation_ToKa,
            this.Menu_Edit_NotesOperation_Abekobe,
            this.Menu_Edit_NotesOperation_Detarame,
            this.removeCommandToolStripMenuItem});
            this.Menu_Edit_NotesOperation.Name = "Menu_Edit_NotesOperation";
            // 
            // Menu_Edit_NotesOperation_ToDon
            // 
            resources.ApplyResources(this.Menu_Edit_NotesOperation_ToDon, "Menu_Edit_NotesOperation_ToDon");
            this.Menu_Edit_NotesOperation_ToDon.Name = "Menu_Edit_NotesOperation_ToDon";
            this.Menu_Edit_NotesOperation_ToDon.Click += new System.EventHandler(this.Menu_Edit_NotesOperation_ToDon_Click);
            // 
            // Menu_Edit_NotesOperation_ToKa
            // 
            resources.ApplyResources(this.Menu_Edit_NotesOperation_ToKa, "Menu_Edit_NotesOperation_ToKa");
            this.Menu_Edit_NotesOperation_ToKa.Name = "Menu_Edit_NotesOperation_ToKa";
            this.Menu_Edit_NotesOperation_ToKa.Click += new System.EventHandler(this.Menu_Edit_NotesOperation_ToKa_Click);
            // 
            // Menu_Edit_NotesOperation_Abekobe
            // 
            resources.ApplyResources(this.Menu_Edit_NotesOperation_Abekobe, "Menu_Edit_NotesOperation_Abekobe");
            this.Menu_Edit_NotesOperation_Abekobe.Name = "Menu_Edit_NotesOperation_Abekobe";
            this.Menu_Edit_NotesOperation_Abekobe.Click += new System.EventHandler(this.Menu_Edit_NotesOperation_Abekobe_Click);
            // 
            // Menu_Edit_NotesOperation_Detarame
            // 
            resources.ApplyResources(this.Menu_Edit_NotesOperation_Detarame, "Menu_Edit_NotesOperation_Detarame");
            this.Menu_Edit_NotesOperation_Detarame.Name = "Menu_Edit_NotesOperation_Detarame";
            this.Menu_Edit_NotesOperation_Detarame.Click += new System.EventHandler(this.Menu_Edit_NotesOperation_Detarame_Click);
            // 
            // removeCommandToolStripMenuItem
            // 
            resources.ApplyResources(this.removeCommandToolStripMenuItem, "removeCommandToolStripMenuItem");
            this.removeCommandToolStripMenuItem.Name = "removeCommandToolStripMenuItem";
            this.removeCommandToolStripMenuItem.Click += new System.EventHandler(this.RemoveCommandToolStripMenuItem_Click);
            // 
            // Menu_Version
            // 
            resources.ApplyResources(this.Menu_Version, "Menu_Version");
            this.Menu_Version.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_Version.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Version_Site,
            this.Menu_Version_TJAS});
            this.Menu_Version.Name = "Menu_Version";
            // 
            // Menu_Version_Site
            // 
            resources.ApplyResources(this.Menu_Version_Site, "Menu_Version_Site");
            this.Menu_Version_Site.Name = "Menu_Version_Site";
            this.Menu_Version_Site.Click += new System.EventHandler(this.Menu_Version_Site_Click);
            // 
            // Menu_Version_TJAS
            // 
            resources.ApplyResources(this.Menu_Version_TJAS, "Menu_Version_TJAS");
            this.Menu_Version_TJAS.Name = "Menu_Version_TJAS";
            this.Menu_Version_TJAS.Click += new System.EventHandler(this.Menu_Version_TJAS_Click);
            // 
            // Menu_Tool
            // 
            resources.ApplyResources(this.Menu_Tool, "Menu_Tool");
            this.Menu_Tool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tool_DanBuilder,
            this.toolStripMenuItem9,
            this.Menu_Tool_Settings,
            this.Menu_Tool_About});
            this.Menu_Tool.Image = global::TJAStudio.Properties.Resources.Toolbox_16x;
            this.Menu_Tool.Name = "Menu_Tool";
            // 
            // Menu_Tool_DanBuilder
            // 
            resources.ApplyResources(this.Menu_Tool_DanBuilder, "Menu_Tool_DanBuilder");
            this.Menu_Tool_DanBuilder.Name = "Menu_Tool_DanBuilder";
            this.Menu_Tool_DanBuilder.Click += new System.EventHandler(this.Menu_Tool_DanBuilder_Click);
            // 
            // toolStripMenuItem9
            // 
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            // 
            // Menu_Tool_Settings
            // 
            resources.ApplyResources(this.Menu_Tool_Settings, "Menu_Tool_Settings");
            this.Menu_Tool_Settings.Image = global::TJAStudio.Properties.Resources.Settings_16x;
            this.Menu_Tool_Settings.Name = "Menu_Tool_Settings";
            this.Menu_Tool_Settings.Click += new System.EventHandler(this.Menu_Tool_Settings_Click);
            // 
            // Menu_Tool_About
            // 
            resources.ApplyResources(this.Menu_Tool_About, "Menu_Tool_About");
            this.Menu_Tool_About.Image = global::TJAStudio.Properties.Resources.VersionInformation_16x;
            this.Menu_Tool_About.Name = "Menu_Tool_About";
            this.Menu_Tool_About.Click += new System.EventHandler(this.Menu_Tool_About_Click);
            // 
            // Menu_Window
            // 
            resources.ApplyResources(this.Menu_Window, "Menu_Window");
            this.Menu_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Window_Courses,
            this.Menu_Window_CommonHeader,
            this.Menu_Window_CourseHeader,
            this.Menu_Window_Projects,
            this.toolStripMenuItem8,
            this.Menu_Window_FormatCheker});
            this.Menu_Window.Image = global::TJAStudio.Properties.Resources.WindowsForm_16x;
            this.Menu_Window.Name = "Menu_Window";
            // 
            // Menu_Window_Courses
            // 
            resources.ApplyResources(this.Menu_Window_Courses, "Menu_Window_Courses");
            this.Menu_Window_Courses.Name = "Menu_Window_Courses";
            this.Menu_Window_Courses.Click += new System.EventHandler(this.Menu_Window_Courses_Click);
            // 
            // Menu_Window_CommonHeader
            // 
            resources.ApplyResources(this.Menu_Window_CommonHeader, "Menu_Window_CommonHeader");
            this.Menu_Window_CommonHeader.Name = "Menu_Window_CommonHeader";
            this.Menu_Window_CommonHeader.Click += new System.EventHandler(this.Menu_Window_CommonHeader_Click);
            // 
            // Menu_Window_CourseHeader
            // 
            resources.ApplyResources(this.Menu_Window_CourseHeader, "Menu_Window_CourseHeader");
            this.Menu_Window_CourseHeader.Name = "Menu_Window_CourseHeader";
            this.Menu_Window_CourseHeader.Click += new System.EventHandler(this.Menu_Window_CourseHeader_Click);
            // 
            // Menu_Window_Projects
            // 
            resources.ApplyResources(this.Menu_Window_Projects, "Menu_Window_Projects");
            this.Menu_Window_Projects.Name = "Menu_Window_Projects";
            this.Menu_Window_Projects.Click += new System.EventHandler(this.Menu_Window_Projects_Click);
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            // 
            // Menu_Window_FormatCheker
            // 
            resources.ApplyResources(this.Menu_Window_FormatCheker, "Menu_Window_FormatCheker");
            this.Menu_Window_FormatCheker.Image = global::TJAStudio.Properties.Resources.FindResults_16x;
            this.Menu_Window_FormatCheker.Name = "Menu_Window_FormatCheker";
            this.Menu_Window_FormatCheker.Click += new System.EventHandler(this.Menu_Window_FormatCheker_Click);
            // 
            // Menu_Execution
            // 
            resources.ApplyResources(this.Menu_Execution, "Menu_Execution");
            this.Menu_Execution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Execution_Start,
            this.Menu_Execution_LiveUpdate});
            this.Menu_Execution.Image = global::TJAStudio.Properties.Resources.Run_16x;
            this.Menu_Execution.Name = "Menu_Execution";
            // 
            // Menu_Execution_Start
            // 
            resources.ApplyResources(this.Menu_Execution_Start, "Menu_Execution_Start");
            this.Menu_Execution_Start.Image = global::TJAStudio.Properties.Resources.Run_16x;
            this.Menu_Execution_Start.Name = "Menu_Execution_Start";
            this.Menu_Execution_Start.Click += new System.EventHandler(this.Menu_Execution_Start_Click);
            // 
            // Menu_Execution_LiveUpdate
            // 
            resources.ApplyResources(this.Menu_Execution_LiveUpdate, "Menu_Execution_LiveUpdate");
            this.Menu_Execution_LiveUpdate.Checked = true;
            this.Menu_Execution_LiveUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_Execution_LiveUpdate.Name = "Menu_Execution_LiveUpdate";
            this.Menu_Execution_LiveUpdate.Click += new System.EventHandler(this.Menu_Execution_LiveUpdate_Click);
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status_Mode,
            this.Status_Measures,
            this.Status_Caret});
            this.Status.Name = "Status";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Spring = true;
            // 
            // Status_Mode
            // 
            resources.ApplyResources(this.Status_Mode, "Status_Mode");
            this.Status_Mode.Name = "Status_Mode";
            this.Status_Mode.Spring = true;
            // 
            // Status_Measures
            // 
            resources.ApplyResources(this.Status_Measures, "Status_Measures");
            this.Status_Measures.Name = "Status_Measures";
            this.Status_Measures.Spring = true;
            // 
            // Status_Caret
            // 
            resources.ApplyResources(this.Status_Caret, "Status_Caret");
            this.Status_Caret.Name = "Status_Caret";
            this.Status_Caret.Spring = true;
            // 
            // Tool
            // 
            resources.ApplyResources(this.Tool, "Tool");
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Open,
            this.Tool_Save,
            this.toolStripSeparator3,
            this.Tool_Undo,
            this.Tool_Redo,
            this.toolStripSeparator1,
            this.Tool_Cut,
            this.Tool_Copy,
            this.Tool_Paste,
            this.toolStripSeparator2,
            this.Tool_Execute,
            this.Tool_FormatCheker});
            this.Tool.Name = "Tool";
            // 
            // Tool_Open
            // 
            resources.ApplyResources(this.Tool_Open, "Tool_Open");
            this.Tool_Open.Image = global::TJAStudio.Properties.Resources.FolderOpen_16x;
            this.Tool_Open.Name = "Tool_Open";
            this.Tool_Open.Click += new System.EventHandler(this.Tool_Open_Click);
            // 
            // Tool_Save
            // 
            resources.ApplyResources(this.Tool_Save, "Tool_Save");
            this.Tool_Save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_SaveAs});
            this.Tool_Save.Image = global::TJAStudio.Properties.Resources.Save_16x;
            this.Tool_Save.Name = "Tool_Save";
            this.Tool_Save.ButtonClick += new System.EventHandler(this.Tool_Save_ButtonClick);
            this.Tool_Save.Click += new System.EventHandler(this.Tool_Save_Click);
            // 
            // Tool_SaveAs
            // 
            resources.ApplyResources(this.Tool_SaveAs, "Tool_SaveAs");
            this.Tool_SaveAs.Image = global::TJAStudio.Properties.Resources.SaveAs_16x;
            this.Tool_SaveAs.Name = "Tool_SaveAs";
            this.Tool_SaveAs.Click += new System.EventHandler(this.Tool_SaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // Tool_Undo
            // 
            resources.ApplyResources(this.Tool_Undo, "Tool_Undo");
            this.Tool_Undo.Image = global::TJAStudio.Properties.Resources.Undo_16x;
            this.Tool_Undo.Name = "Tool_Undo";
            this.Tool_Undo.Click += new System.EventHandler(this.Tool_Undo_Click);
            // 
            // Tool_Redo
            // 
            resources.ApplyResources(this.Tool_Redo, "Tool_Redo");
            this.Tool_Redo.Image = global::TJAStudio.Properties.Resources.Redo_16x;
            this.Tool_Redo.Name = "Tool_Redo";
            this.Tool_Redo.Click += new System.EventHandler(this.Tool_Redo_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // Tool_Cut
            // 
            resources.ApplyResources(this.Tool_Cut, "Tool_Cut");
            this.Tool_Cut.Image = global::TJAStudio.Properties.Resources.Cut_16x;
            this.Tool_Cut.Name = "Tool_Cut";
            this.Tool_Cut.Click += new System.EventHandler(this.Tool_Cut_Click);
            // 
            // Tool_Copy
            // 
            resources.ApplyResources(this.Tool_Copy, "Tool_Copy");
            this.Tool_Copy.Image = global::TJAStudio.Properties.Resources.Copy_16x;
            this.Tool_Copy.Name = "Tool_Copy";
            this.Tool_Copy.Click += new System.EventHandler(this.Tool_Copy_Click);
            // 
            // Tool_Paste
            // 
            resources.ApplyResources(this.Tool_Paste, "Tool_Paste");
            this.Tool_Paste.Image = global::TJAStudio.Properties.Resources.Paste_16x;
            this.Tool_Paste.Name = "Tool_Paste";
            this.Tool_Paste.Click += new System.EventHandler(this.Tool_Paste_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // Tool_Execute
            // 
            resources.ApplyResources(this.Tool_Execute, "Tool_Execute");
            this.Tool_Execute.Image = global::TJAStudio.Properties.Resources.Run_16x;
            this.Tool_Execute.Name = "Tool_Execute";
            this.Tool_Execute.Click += new System.EventHandler(this.Tool_Execute_Click);
            // 
            // Tool_FormatCheker
            // 
            resources.ApplyResources(this.Tool_FormatCheker, "Tool_FormatCheker");
            this.Tool_FormatCheker.Image = global::TJAStudio.Properties.Resources.FindResults_16x;
            this.Tool_FormatCheker.Name = "Tool_FormatCheker";
            this.Tool_FormatCheker.Click += new System.EventHandler(this.Tool_FormatCheker_Click);
            // 
            // Studio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Dock);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Studio";
            this.Deactivate += new System.EventHandler(this.Studio_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Studio_FormClosing);
            this.Load += new System.EventHandler(this.Studio_Load);
            this.Leave += new System.EventHandler(this.Studio_Leave);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem Menu_File_OpenTmpl;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_GoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Time;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Repert;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_NotesOperation;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_NotesOperation_ToDon;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_NotesOperation_ToKa;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_NotesOperation_Abekobe;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_NotesOperation_Detarame;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_CommonHeader;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_CourseHeader;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_Projects;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool;
        private System.Windows.Forms.ToolStripMenuItem Menu_Version;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_Courses;
        private System.Windows.Forms.ToolStripMenuItem Menu_Execution;
        private System.Windows.Forms.ToolStripMenuItem Menu_Execution_Start;
        private System.Windows.Forms.ToolStripMenuItem Menu_Execution_LiveUpdate;
        private System.Windows.Forms.ToolStripButton Tool_Undo;
        private System.Windows.Forms.ToolStripButton Tool_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Tool_Cut;
        private System.Windows.Forms.ToolStripButton Tool_Copy;
        private System.Windows.Forms.ToolStripButton Tool_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Tool_Execute;
        private System.Windows.Forms.ToolStripStatusLabel Status_Caret;
        private System.Windows.Forms.ToolStripStatusLabel Status_Measures;
        private System.Windows.Forms.ToolStripMenuItem Menu_Version_Site;
        private System.Windows.Forms.ToolStripMenuItem Menu_Version_TJAS;
        private System.Windows.Forms.ToolStripButton Tool_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton Tool_Save;
        private System.Windows.Forms.ToolStripMenuItem Tool_SaveAs;
        private System.Windows.Forms.ToolStripStatusLabel Status_Mode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem Menu_Window_FormatCheker;
        private System.Windows.Forms.ToolStripButton Tool_FormatCheker;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_Settings;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_DanBuilder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem removeCommandToolStripMenuItem;
    }
}

