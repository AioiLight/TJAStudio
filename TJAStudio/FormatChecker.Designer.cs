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
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.AutoArrange = false;
            this.List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Line,
            this.Details});
            this.List.Location = new System.Drawing.Point(16, 32);
            this.List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(875, 395);
            this.List.TabIndex = 0;
            this.List.UseCompatibleStateImageBehavior = false;
            this.List.View = System.Windows.Forms.View.Details;
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 122;
            // 
            // Details
            // 
            this.Details.Text = "Details";
            this.Details.Width = 571;
            // 
            // Tool
            // 
            this.Tool.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Run,
            this.Tool_Sims});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(904, 28);
            this.Tool.TabIndex = 1;
            this.Tool.Text = "toolStrip1";
            // 
            // Tool_Run
            // 
            this.Tool_Run.Image = global::TJAStudio.Properties.Resources.FindResults_16x;
            this.Tool_Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Run.Name = "Tool_Run";
            this.Tool_Run.Size = new System.Drawing.Size(114, 24);
            this.Tool_Run.Text = "Check format";
            this.Tool_Run.ToolTipText = "Tool_Run";
            this.Tool_Run.Click += new System.EventHandler(this.Tool_Run_Click);
            // 
            // Tool_Sims
            // 
            this.Tool_Sims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tool_Sims.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tool_Sims.Items.AddRange(new object[] {
            "Unspecified",
            "Taikojiro",
            "Taikojiro2",
            "TJAPlayer2 forPC",
            "TJAPlayer3",
            "TaikoDaijiro2",
            "TaikoWeb(Modded by Bui)"});
            this.Tool_Sims.Name = "Tool_Sims";
            this.Tool_Sims.Size = new System.Drawing.Size(120, 28);
            // 
            // FormatChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 441);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.List);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormatChecker";
            this.Text = "Format Checker";
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