namespace TJAStudio
{
    partial class FormatChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatChecker));
            this.List = new System.Windows.Forms.ListView();
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Run = new System.Windows.Forms.ToolStripButton();
            this.Tool_Sims = new System.Windows.Forms.ToolStripComboBox();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            resources.ApplyResources(this.List, "List");
            this.List.AutoArrange = false;
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Line,
            this.Details});
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // Line
            // 
            resources.ApplyResources(this.Line, "Line");
            // 
            // Details
            // 
            resources.ApplyResources(this.Details, "Details");
            // 
            // Tool
            // 
            resources.ApplyResources(this.Tool, "Tool");
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Run,
            this.Tool_Sims});
            this.Tool.Name = "Tool";
            // 
            // Tool_Run
            // 
            resources.ApplyResources(this.Tool_Run, "Tool_Run");
            this.Tool_Run.Image = global::TJAStudio.Properties.Resources.FindResults_16x;
            this.Tool_Run.Name = "Tool_Run";
            this.Tool_Run.Click += new System.EventHandler(this.Tool_Run_Click);
            // 
            // Tool_Sims
            // 
            resources.ApplyResources(this.Tool_Sims, "Tool_Sims");
            this.Tool_Sims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tool_Sims.Items.AddRange(new object[] {
            resources.GetString("Tool_Sims.Items"),
            resources.GetString("Tool_Sims.Items1"),
            resources.GetString("Tool_Sims.Items2"),
            resources.GetString("Tool_Sims.Items3"),
            resources.GetString("Tool_Sims.Items4"),
            resources.GetString("Tool_Sims.Items5"),
            resources.GetString("Tool_Sims.Items6")});
            this.Tool_Sims.Name = "Tool_Sims";
            // 
            // FormatChecker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.List);
            this.Name = "FormatChecker";
            this.Load += new System.EventHandler(this.FormatChecker_Load);
            this.Resize += new System.EventHandler(this.FormatChecker_Resize);
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView List;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.ColumnHeader Details;
        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton Tool_Run;
        private System.Windows.Forms.ToolStripComboBox Tool_Sims;
    }
}