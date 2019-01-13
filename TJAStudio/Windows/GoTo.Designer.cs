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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoTo));
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
            resources.ApplyResources(this.Label, "Label");
            this.Label.Name = "Label";
            // 
            // Button_GoTo
            // 
            resources.ApplyResources(this.Button_GoTo, "Button_GoTo");
            this.Button_GoTo.Name = "Button_GoTo";
            this.Button_GoTo.UseVisualStyleBackColor = true;
            this.Button_GoTo.Click += new System.EventHandler(this.Button_GoTo_Click);
            // 
            // Button_Cancel
            // 
            resources.ApplyResources(this.Button_Cancel, "Button_Cancel");
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Label_Range
            // 
            resources.ApplyResources(this.Label_Range, "Label_Range");
            this.Label_Range.Name = "Label_Range";
            // 
            // Num
            // 
            resources.ApplyResources(this.Num, "Num");
            this.Num.Name = "Num";
            // 
            // GoTo
            // 
            this.AcceptButton = this.Button_GoTo;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Label_Range);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_GoTo);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoTo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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