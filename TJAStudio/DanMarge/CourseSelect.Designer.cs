namespace TJAStudio.DanMarge
{
    partial class CourseSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSelect));
            this.ListBox_Courses = new System.Windows.Forms.ListBox();
            this.Label_Text = new System.Windows.Forms.Label();
            this.Button_Select = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Courses
            // 
            resources.ApplyResources(this.ListBox_Courses, "ListBox_Courses");
            this.ListBox_Courses.FormattingEnabled = true;
            this.ListBox_Courses.Items.AddRange(new object[] {
            resources.GetString("ListBox_Courses.Items"),
            resources.GetString("ListBox_Courses.Items1"),
            resources.GetString("ListBox_Courses.Items2")});
            this.ListBox_Courses.Name = "ListBox_Courses";
            // 
            // Label_Text
            // 
            resources.ApplyResources(this.Label_Text, "Label_Text");
            this.Label_Text.Name = "Label_Text";
            // 
            // Button_Select
            // 
            resources.ApplyResources(this.Button_Select, "Button_Select");
            this.Button_Select.Name = "Button_Select";
            this.Button_Select.UseVisualStyleBackColor = true;
            this.Button_Select.Click += new System.EventHandler(this.Button_Select_Click);
            // 
            // Button_Cancel
            // 
            resources.ApplyResources(this.Button_Cancel, "Button_Cancel");
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // CourseSelect
            // 
            this.AcceptButton = this.Button_Select;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Select);
            this.Controls.Add(this.Label_Text);
            this.Controls.Add(this.ListBox_Courses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Courses;
        private System.Windows.Forms.Label Label_Text;
        private System.Windows.Forms.Button Button_Select;
        private System.Windows.Forms.Button Button_Cancel;
    }
}