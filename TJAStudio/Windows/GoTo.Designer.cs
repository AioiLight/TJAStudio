namespace TJAStudio
{
    partial class GoTo
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
            this.Label = new System.Windows.Forms.Label();
            this.Button_GoTo = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Label_Range = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(10, 11);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(96, 20);
            this.Label.TabIndex = 0;
            this.Label.Text = "Line Number:";
            // 
            // Button_GoTo
            // 
            this.Button_GoTo.Location = new System.Drawing.Point(149, 81);
            this.Button_GoTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_GoTo.Name = "Button_GoTo";
            this.Button_GoTo.Size = new System.Drawing.Size(80, 27);
            this.Button_GoTo.TabIndex = 2;
            this.Button_GoTo.Text = "Go To";
            this.Button_GoTo.UseVisualStyleBackColor = true;
            this.Button_GoTo.Click += new System.EventHandler(this.Button_GoTo_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(234, 81);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(80, 27);
            this.Button_Cancel.TabIndex = 3;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Label_Range
            // 
            this.Label_Range.AutoSize = true;
            this.Label_Range.Location = new System.Drawing.Point(10, 62);
            this.Label_Range.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Range.Name = "Label_Range";
            this.Label_Range.Size = new System.Drawing.Size(0, 20);
            this.Label_Range.TabIndex = 4;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(10, 33);
            this.Num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(304, 27);
            this.Num.TabIndex = 5;
            // 
            // GoTo
            // 
            this.AcceptButton = this.Button_GoTo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(323, 117);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Label_Range);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_GoTo);
            this.Controls.Add(this.Label);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 156);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 156);
            this.Name = "GoTo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.GoTo_Load);
            this.Shown += new System.EventHandler(this.GoTo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button Button_GoTo;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label Label_Range;
        public System.Windows.Forms.NumericUpDown Num;
    }
}