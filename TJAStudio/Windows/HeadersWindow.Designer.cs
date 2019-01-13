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
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Tool_Add = new System.Windows.Forms.ToolStripButton();
            this.Tool_Delete = new System.Windows.Forms.ToolStripButton();
            this.List = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.SuspendLayout();
            // 
            // Tool
            // 
            this.Tool.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Add,
            this.Tool_Delete});
            this.Tool.Location = new System.Drawing.Point(0, 0);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(539, 27);
            this.Tool.TabIndex = 5;
            this.Tool.Text = "toolStrip1";
            // 
            // Tool_Add
            // 
            this.Tool_Add.Image = global::TJAStudio.Properties.Resources.AddColumn_16x;
            this.Tool_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Add.Name = "Tool_Add";
            this.Tool_Add.Size = new System.Drawing.Size(105, 24);
            this.Tool_Add.Text = "Add Header";
            this.Tool_Add.Click += new System.EventHandler(this.Tool_Add_Click);
            // 
            // Tool_Delete
            // 
            this.Tool_Delete.Image = global::TJAStudio.Properties.Resources.DeleteColumn_16x;
            this.Tool_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tool_Delete.Name = "Tool_Delete";
            this.Tool_Delete.Size = new System.Drawing.Size(122, 24);
            this.Tool_Delete.Text = "Delete Header";
            this.Tool_Delete.Click += new System.EventHandler(this.Tool_Delete_Click);
            // 
            // List
            // 
            this.List.AllowUserToAddRows = false;
            this.List.AllowUserToDeleteRows = false;
            this.List.AllowUserToResizeColumns = false;
            this.List.AllowUserToResizeRows = false;
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.List.BackgroundColor = System.Drawing.SystemColors.Window;
            this.List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Parameter});
            this.List.Location = new System.Drawing.Point(0, 30);
            this.List.Name = "List";
            this.List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.List.RowTemplate.Height = 21;
            this.List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List.Size = new System.Drawing.Size(539, 671);
            this.List.TabIndex = 6;
            this.List.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_CellEndEdit);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 72;
            // 
            // Parameter
            // 
            this.Parameter.HeaderText = "Parameter";
            this.Parameter.Name = "Parameter";
            this.Parameter.Width = 101;
            // 
            // HeadersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 702);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Tool);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "Header";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
    }
}