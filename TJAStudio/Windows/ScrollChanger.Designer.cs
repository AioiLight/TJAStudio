namespace TJAStudio.Windows
{
    partial class ScrollChanger
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
            this.Label_Amount = new System.Windows.Forms.Label();
            this.Num_Amount = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Amount
            // 
            this.Label_Amount.AutoSize = true;
            this.Label_Amount.Location = new System.Drawing.Point(12, 14);
            this.Label_Amount.Name = "Label_Amount";
            this.Label_Amount.Size = new System.Drawing.Size(127, 24);
            this.Label_Amount.TabIndex = 0;
            this.Label_Amount.Text = "Scroll Amount:";
            // 
            // Num_Amount
            // 
            this.Num_Amount.DecimalPlaces = 3;
            this.Num_Amount.Location = new System.Drawing.Point(145, 12);
            this.Num_Amount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Num_Amount.Name = "Num_Amount";
            this.Num_Amount.Size = new System.Drawing.Size(147, 31);
            this.Num_Amount.TabIndex = 1;
            this.Num_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Num_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(172, 99);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(120, 30);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Insert
            // 
            this.Button_Insert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Insert.Location = new System.Drawing.Point(46, 99);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(120, 30);
            this.Button_Insert.TabIndex = 3;
            this.Button_Insert.Text = "Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // ScrollChanger
            // 
            this.AcceptButton = this.Button_Insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Num_Amount);
            this.Controls.Add(this.Label_Amount);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScrollChanger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Change Scroll";
            ((System.ComponentModel.ISupportInitialize)(this.Num_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Amount;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Insert;
        public System.Windows.Forms.NumericUpDown Num_Amount;
    }
}