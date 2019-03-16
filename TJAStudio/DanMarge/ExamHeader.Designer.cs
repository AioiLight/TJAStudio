namespace TJAStudio.DanMarge
{
    partial class ExamHeader
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamHeader));
            this.Label_Condition = new System.Windows.Forms.Label();
            this.ComboBox_Condition = new System.Windows.Forms.ComboBox();
            this.ComboBox_Scope = new System.Windows.Forms.ComboBox();
            this.Label_Scope = new System.Windows.Forms.Label();
            this.Label_Req_Red = new System.Windows.Forms.Label();
            this.NumBox_Req_Red = new System.Windows.Forms.NumericUpDown();
            this.NumBox_Req_Gold = new System.Windows.Forms.NumericUpDown();
            this.Label_Req_Gold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Req_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Req_Gold)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Condition
            // 
            resources.ApplyResources(this.Label_Condition, "Label_Condition");
            this.Label_Condition.Name = "Label_Condition";
            // 
            // ComboBox_Condition
            // 
            resources.ApplyResources(this.ComboBox_Condition, "ComboBox_Condition");
            this.ComboBox_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Condition.FormattingEnabled = true;
            this.ComboBox_Condition.Items.AddRange(new object[] {
            resources.GetString("ComboBox_Condition.Items"),
            resources.GetString("ComboBox_Condition.Items1"),
            resources.GetString("ComboBox_Condition.Items2"),
            resources.GetString("ComboBox_Condition.Items3"),
            resources.GetString("ComboBox_Condition.Items4"),
            resources.GetString("ComboBox_Condition.Items5"),
            resources.GetString("ComboBox_Condition.Items6"),
            resources.GetString("ComboBox_Condition.Items7")});
            this.ComboBox_Condition.Name = "ComboBox_Condition";
            this.ComboBox_Condition.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Condition_SelectedIndexChanged);
            // 
            // ComboBox_Scope
            // 
            resources.ApplyResources(this.ComboBox_Scope, "ComboBox_Scope");
            this.ComboBox_Scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Scope.FormattingEnabled = true;
            this.ComboBox_Scope.Items.AddRange(new object[] {
            resources.GetString("ComboBox_Scope.Items"),
            resources.GetString("ComboBox_Scope.Items1")});
            this.ComboBox_Scope.Name = "ComboBox_Scope";
            // 
            // Label_Scope
            // 
            resources.ApplyResources(this.Label_Scope, "Label_Scope");
            this.Label_Scope.Name = "Label_Scope";
            // 
            // Label_Req_Red
            // 
            resources.ApplyResources(this.Label_Req_Red, "Label_Req_Red");
            this.Label_Req_Red.Name = "Label_Req_Red";
            // 
            // NumBox_Req_Red
            // 
            resources.ApplyResources(this.NumBox_Req_Red, "NumBox_Req_Red");
            this.NumBox_Req_Red.Name = "NumBox_Req_Red";
            this.NumBox_Req_Red.ValueChanged += new System.EventHandler(this.NumBox_Req_Red_ValueChanged);
            // 
            // NumBox_Req_Gold
            // 
            resources.ApplyResources(this.NumBox_Req_Gold, "NumBox_Req_Gold");
            this.NumBox_Req_Gold.Name = "NumBox_Req_Gold";
            this.NumBox_Req_Gold.ValueChanged += new System.EventHandler(this.NumBox_Req_Gold_ValueChanged);
            // 
            // Label_Req_Gold
            // 
            resources.ApplyResources(this.Label_Req_Gold, "Label_Req_Gold");
            this.Label_Req_Gold.Name = "Label_Req_Gold";
            // 
            // ExamHeader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumBox_Req_Gold);
            this.Controls.Add(this.Label_Req_Gold);
            this.Controls.Add(this.NumBox_Req_Red);
            this.Controls.Add(this.Label_Req_Red);
            this.Controls.Add(this.ComboBox_Scope);
            this.Controls.Add(this.Label_Scope);
            this.Controls.Add(this.ComboBox_Condition);
            this.Controls.Add(this.Label_Condition);
            this.Name = "ExamHeader";
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Req_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox_Req_Gold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Condition;
        private System.Windows.Forms.ComboBox ComboBox_Condition;
        private System.Windows.Forms.ComboBox ComboBox_Scope;
        private System.Windows.Forms.Label Label_Scope;
        private System.Windows.Forms.Label Label_Req_Red;
        private System.Windows.Forms.NumericUpDown NumBox_Req_Red;
        private System.Windows.Forms.NumericUpDown NumBox_Req_Gold;
        private System.Windows.Forms.Label Label_Req_Gold;
    }
}
