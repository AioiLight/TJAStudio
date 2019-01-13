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
            this.List = new System.Windows.Forms.ListView();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.Location = new System.Drawing.Point(0, 30);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(422, 430);
            this.List.TabIndex = 2;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.List;
            // 
            // Tool
            // 
            this.Tool.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Add,
            this.Tool_Delete});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(420, 27);
            this.Tool.TabIndex = 3;
            this.Tool.Text = "toolStrip1";
            // 
            // Tool_Add
            // 
            this.Tool_Add.Image = global::TJAStudio.Properties.Resources.AddColumn_16x;
            this.Tool_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Size = new System.Drawing.Size(79, 24);
            this.Tool_Add.Text = "Add File";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Delete
            // 
            this.Tool_Delete.Image = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            this.Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Delete.Name = "Tool_Delete";
            this.Tool_Delete.Size = new System.Drawing.Size(96, 24);
            this.Tool_Delete.Text = "Delete File";
            this.Tool_Delete.Click += new System.EventHandler(this.Tool_Delete_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.List);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Project";
            this.Text = "Project";
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