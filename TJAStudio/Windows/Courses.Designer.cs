namespace TJAStudio
{
    partial class Courses
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
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tool_MoveUp = new System.Windows.Forms.ToolStripButton();
            this.Tool_MoveDown = new System.Windows.Forms.ToolStripButton();
            this.List = new System.Windows.Forms.ListView();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tool
            // 
            this.Tool.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Add,
            this.Tool_Delete,
            this.Tool_MoveUp,
            this.Tool_MoveDown});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(420, 27);
            this.Tool.TabIndex = 0;
            // 
            // Tool_Add
            // 
            this.Tool_Add.Image = global::TJAStudio.Properties.Resources.AddColumn_16x;
            this.Tool_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Size = new System.Drawing.Size(102, 24);
            this.Tool_Add.Text = "Add Course";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Delete
            // 
            this.Tool_Delete.Image = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            this.Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Delete.Name = "Tool_Delete";
            this.Tool_Delete.Size = new System.Drawing.Size(119, 24);
            this.Tool_Delete.Text = "Delete Course";
            this.Tool_Delete.Click += new System.EventHandler(this.Tool_Delete_Click);
            // 
            // Tool_MoveUp
            // 
            this.Tool_MoveUp.Image = global::TJAStudio.Properties.Resources.GlyphUp_16x;
            this.Tool_MoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_MoveUp.Name = "Tool_MoveUp";
            this.Tool_MoveUp.Size = new System.Drawing.Size(84, 24);
            this.Tool_MoveUp.Text = "Move Up";
            this.Tool_MoveUp.Click += new System.EventHandler(this.Tool_MoveUp_Click);
            // 
            // Tool_MoveDown
            // 
            this.Tool_MoveDown.Image = global::TJAStudio.Properties.Resources.GlyphDown_16x;
            this.Tool_MoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_MoveDown.Name = "Tool_MoveDown";
            this.Tool_MoveDown.Size = new System.Drawing.Size(104, 24);
            this.Tool_MoveDown.Text = "Move Down";
            this.Tool_MoveDown.Click += new System.EventHandler(this.Tool_MoveDown_Click);
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.Location = new System.Drawing.Point(0, 30);
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(420, 428);
            this.List.TabIndex = 1;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.List;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Tool);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Courses";
            this.Text = "Courses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Courses_FormClosing);
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripButton Tool_Add;
        private System.Windows.Forms.ToolStripButton Tool_Delete;
        public System.Windows.Forms.ListView List;
        private System.Windows.Forms.ToolStripButton Tool_MoveDown;
        private System.Windows.Forms.ToolStripButton Tool_MoveUp;
    }
}