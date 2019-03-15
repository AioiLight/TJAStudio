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
            this.Label_Condition.AutoSize = true;
            this.Label_Condition.Location = new System.Drawing.Point(3, 6);
            this.Label_Condition.Name = "Label_Condition";
            this.Label_Condition.Size = new System.Drawing.Size(75, 20);
            this.Label_Condition.TabIndex = 0;
            this.Label_Condition.Text = "Condition:";
            // 
            // ComboBox_Condition
            // 
            this.ComboBox_Condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Condition.FormattingEnabled = true;
            this.ComboBox_Condition.Items.AddRange(new object[] {
            "Gauge percentage",
            "Perfect amount",
            "Good amount",
            "Bad amount",
            "Score",
            "Drumroll hits",
            "Hits amount",
            "Max. combo"});
            this.ComboBox_Condition.Location = new System.Drawing.Point(84, 3);
            this.ComboBox_Condition.Name = "ComboBox_Condition";
            this.ComboBox_Condition.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_Condition.TabIndex = 1;
            // 
            // ComboBox_Scope
            // 
            this.ComboBox_Scope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Scope.FormattingEnabled = true;
            this.ComboBox_Scope.Items.AddRange(new object[] {
            "More",
            "Less"});
            this.ComboBox_Scope.Location = new System.Drawing.Point(710, 3);
            this.ComboBox_Scope.Name = "ComboBox_Scope";
            this.ComboBox_Scope.Size = new System.Drawing.Size(107, 28);
            this.ComboBox_Scope.TabIndex = 3;
            // 
            // Label_Scope
            // 
            this.Label_Scope.AutoSize = true;
            this.Label_Scope.Location = new System.Drawing.Point(650, 6);
            this.Label_Scope.Name = "Label_Scope";
            this.Label_Scope.Size = new System.Drawing.Size(54, 20);
            this.Label_Scope.TabIndex = 2;
            this.Label_Scope.Text = "Scope:";
            // 
            // Label_Req_Red
            // 
            this.Label_Req_Red.AutoSize = true;
            this.Label_Req_Red.Location = new System.Drawing.Point(211, 6);
            this.Label_Req_Red.Name = "Label_Req_Red";
            this.Label_Req_Red.Size = new System.Drawing.Size(86, 20);
            this.Label_Req_Red.TabIndex = 4;
            this.Label_Req_Red.Text = "Req. (Red):";
            // 
            // NumBox_Req_Red
            // 
            this.NumBox_Req_Red.Location = new System.Drawing.Point(303, 4);
            this.NumBox_Req_Red.Name = "NumBox_Req_Red";
            this.NumBox_Req_Red.Size = new System.Drawing.Size(120, 27);
            this.NumBox_Req_Red.TabIndex = 5;
            this.NumBox_Req_Red.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumBox_Req_Gold
            // 
            this.NumBox_Req_Gold.Location = new System.Drawing.Point(524, 3);
            this.NumBox_Req_Gold.Name = "NumBox_Req_Gold";
            this.NumBox_Req_Gold.Size = new System.Drawing.Size(120, 27);
            this.NumBox_Req_Gold.TabIndex = 7;
            this.NumBox_Req_Gold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label_Req_Gold
            // 
            this.Label_Req_Gold.AutoSize = true;
            this.Label_Req_Gold.Location = new System.Drawing.Point(429, 6);
            this.Label_Req_Gold.Name = "Label_Req_Gold";
            this.Label_Req_Gold.Size = new System.Drawing.Size(89, 20);
            this.Label_Req_Gold.TabIndex = 6;
            this.Label_Req_Gold.Text = "Req. (Gold):";
            // 
            // ExamHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumBox_Req_Gold);
            this.Controls.Add(this.Label_Req_Gold);
            this.Controls.Add(this.NumBox_Req_Red);
            this.Controls.Add(this.Label_Req_Red);
            this.Controls.Add(this.ComboBox_Scope);
            this.Controls.Add(this.Label_Scope);
            this.Controls.Add(this.ComboBox_Condition);
            this.Controls.Add(this.Label_Condition);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExamHeader";
            this.Size = new System.Drawing.Size(820, 34);
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
