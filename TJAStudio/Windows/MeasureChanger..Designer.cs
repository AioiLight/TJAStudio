namespace TJAStudio.Windows
{
    partial class MeasureChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasureChanger));
            this.Label_Amount = new System.Windows.Forms.Label();
            this.Num_Child = new System.Windows.Forms.NumericUpDown();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.Num_Mother = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Mother)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Amount
            // 
            resources.ApplyResources(this.Label_Amount, "Label_Amount");
            this.Label_Amount.Name = "Label_Amount";
            // 
            // Num_Child
            // 
            resources.ApplyResources(this.Num_Child, "Num_Child");
            this.Num_Child.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Num_Child.Name = "Num_Child";
            this.Num_Child.Value = new decimal(new int[] {
            4,
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
            // Num_Mother
            // 
            resources.ApplyResources(this.Num_Mother, "Num_Mother");
            this.Num_Mother.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Num_Mother.Name = "Num_Mother";
            this.Num_Mother.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MeasureChanger
            // 
            this.AcceptButton = this.Button_Insert;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num_Mother);
            this.Controls.Add(this.Button_Insert);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Num_Child);
            this.Controls.Add(this.Label_Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeasureChanger";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Num_Child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Mother)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Amount;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Insert;
        public System.Windows.Forms.NumericUpDown Num_Child;
        public System.Windows.Forms.NumericUpDown Num_Mother;
        private System.Windows.Forms.Label label1;
    }
}