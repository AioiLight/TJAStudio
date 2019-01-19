namespace TJAStudio
{
    partial class HeadersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadersWindow));
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tool_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.Tool_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.List = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.SuspendLayout();
            // 
            // Tool
            // 
            resources.ApplyResources(this.Tool, "Tool");
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Add,
            this.Tool_Delete,
            this.Tool_MoveUp,
            this.Tool_MoveDown});
            this.Tool.Name = "Tool";
            // 
            // Tool_Add
            // 
            resources.ApplyResources(this.Tool_Add, "Tool_Add");
            this.Tool_Add.Image = global::TJAStudio.Properties.Resources.AddColumn_16x;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Delete
            // 
            resources.ApplyResources(this.Tool_Delete, "Tool_Delete");
            this.Tool_Delete.Image = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            this.Tool_Delete.Name = "Tool_Delete";
            this.Tool_Delete.Click += new System.EventHandler(this.Tool_Delete_Click);
            // 
            // Tool_MoveUp
            // 
            resources.ApplyResources(this.Tool_MoveUp, "Tool_MoveUp");
            this.Tool_MoveUp.Image = global::TJAStudio.Properties.Resources.GlyphUp_16x;
            this.Tool_MoveUp.Name = "Tool_MoveUp";
            this.Tool_MoveUp.Click += new System.EventHandler(this.Tool_MoveUp_Click);
            // 
            // Tool_MoveDown
            // 
            resources.ApplyResources(this.Tool_MoveDown, "Tool_MoveDown");
            this.Tool_MoveDown.Image = global::TJAStudio.Properties.Resources.GlyphDown_16x;
            this.Tool_MoveDown.Name = "Tool_MoveDown";
            this.Tool_MoveDown.Click += new System.EventHandler(this.Tool_MoveDown_Click);
            // 
            // List
            // 
            resources.ApplyResources(this.List, "List");
            this.List.AllowUserToAddRows = false;
            this.List.AllowUserToDeleteRows = false;
            this.List.AllowUserToResizeColumns = false;
            this.List.AllowUserToResizeRows = false;
            this.List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.List.BackgroundColor = System.Drawing.SystemColors.Window;
            this.List.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Parameter});
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.List.RowTemplate.Height = 21;
            this.List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_CellContentClick);
            this.List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_CellEndEdit);
            // 
            // Name
            // 
            resources.ApplyResources(this.Name, "Name");
            this.Name.Name = "Name";
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Parameter
            // 
            resources.ApplyResources(this.Parameter, "Parameter");
            this.Parameter.Name = "Parameter";
            this.Parameter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HeadersWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.List);
            this.Controls.Add(this.Tool);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeadersWindow_FormClosing);
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Delete;
        public System.Windows.Forms.DataGridView List;
#pragma warning disable CS0108 // 'HeadersWindow.Name' は継承されたメンバー 'Control.Name' を非表示にします。非表示にする場合は、キーワード new を使用してください。
#pragma warning restore CS0108 // 'HeadersWindow.Name' は継承されたメンバー 'Control.Name' を非表示にします。非表示にする場合は、キーワード new を使用してください。
        private System.Windows.Forms.ToolStripButton Tool_MoveUp;
        private System.Windows.Forms.ToolStripButton Tool_MoveDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
    }
}