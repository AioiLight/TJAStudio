namespace TJAStudio
{
    partial class AddHeader
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Parameter = new System.Windows.Forms.TextBox();
            this.Label_Parameter = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(13, 13);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(53, 20);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "Name:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(126, 10);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Name.TabIndex = 1;
            // 
            // TextBox_Parameter
            // 
            this.TextBox_Parameter.Location = new System.Drawing.Point(126, 43);
            this.TextBox_Parameter.Name = "TextBox_Parameter";
            this.TextBox_Parameter.Size = new System.Drawing.Size(206, 27);
            this.TextBox_Parameter.TabIndex = 3;
            // 
            // Label_Parameter
            // 
            this.Label_Parameter.AutoSize = true;
            this.Label_Parameter.Location = new System.Drawing.Point(13, 46);
            this.Label_Parameter.Name = "Label_Parameter";
            this.Label_Parameter.Size = new System.Drawing.Size(82, 20);
            this.Label_Parameter.TabIndex = 2;
            this.Label_Parameter.Text = "Parameter:";
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add.Location = new System.Drawing.Point(126, 102);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 30);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(232, 102);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 30);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddHeader
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TextBox_Parameter);
            this.Controls.Add(this.Label_Parameter);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Label_Name);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 180);
            this.Name = "AddHeader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Header";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Parameter;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox TextBox_Name;
        public System.Windows.Forms.TextBox TextBox_Parameter;
    }
}