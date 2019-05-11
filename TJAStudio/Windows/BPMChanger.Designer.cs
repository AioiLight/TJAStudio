namespace TJAStudio.Windows
{
    partial class BPMChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BPMChanger));
            this.Label_Amount = new System.Windows.Forms.Label();
            this.Num_Amount = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Amount
            // 
            resources.ApplyResources(this.Label_Amount, "Label_Amount");
            this.Label_Amount.Name = "Label_Amount";
            // 
            // Num_Amount
            // 
            this.Num_Amount.DecimalPlaces = 3;
            resources.ApplyResources(this.Num_Amount, "Num_Amount");
            this.Num_Amount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Num_Amount.Name = "Num_Amount";
            this.Num_Amount.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Button_Cancel, "Button_Cancel");
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Insert
            // 
            this.Button_Insert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Button_Insert, "Button_Insert");
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // BPMChanger
            // 
            this.AcceptButton = this.Button_Insert;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Num_Amount);
            this.Controls.Add(this.Label_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BPMChanger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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