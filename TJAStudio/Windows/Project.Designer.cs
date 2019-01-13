namespace TJAStudio
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.List = new System.Windows.Forms.ListView();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            resources.ApplyResources(this.List, "List");
            this.List.Name = "List";
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.List;
            // 
            // Tool
            // 
            resources.ApplyResources(this.Tool, "Tool");
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Add,
            this.Tool_Delete});
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
            // Project
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.List);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Delete;
    }
}