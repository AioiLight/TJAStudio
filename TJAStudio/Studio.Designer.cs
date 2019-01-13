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
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel1.Location = new System.Drawing.Point(0, 32);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(828, 440);
            this.dockPanel1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.Menu.Size = new System.Drawing.Size(828, 32);
            this.Menu.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.toolToolStripMenuItem.Text = "&Tool";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 450);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(828, 22);
            this.Status.TabIndex = 3;
            this.Status.Text = "statusStrip1";
            // 
            // Tool
            // 
            this.Tool.Location = new System.Drawing.Point(0, 32);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(828, 25);
            this.Tool.TabIndex = 4;
            this.Tool.Text = "toolStrip1";
            // 
            // Studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Studio";
            this.Text = "TJAStudio";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStrip Tool;
    }
}

