namespace TJAStudio.BPMMeasure
{
    partial class BPMMeasure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BPMMeasure));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label_Link = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Label_Help = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBox_BPM = new System.Windows.Forms.TextBox();
            this.Label_BPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Link
            // 
            resources.ApplyResources(this.Label_Link, "Label_Link");
            this.Label_Link.Name = "Label_Link";
            // 
            // LinkLabel
            // 
            resources.ApplyResources(this.LinkLabel, "LinkLabel");
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.TabStop = true;
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Label_Help
            // 
            resources.ApplyResources(this.Label_Help, "Label_Help");
            this.Label_Help.Name = "Label_Help";
            // 
            // Chart
            // 
            resources.ApplyResources(this.Chart, "Chart");
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelBorderWidth = 4;
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "BPM";
            this.Chart.Series.Add(series2);
            // 
            // TextBox_BPM
            // 
            resources.ApplyResources(this.TextBox_BPM, "TextBox_BPM");
            this.TextBox_BPM.Name = "TextBox_BPM";
            // 
            // Label_BPM
            // 
            resources.ApplyResources(this.Label_BPM, "Label_BPM");
            this.Label_BPM.Name = "Label_BPM";
            // 
            // BPMMeasure
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_BPM);
            this.Controls.Add(this.TextBox_BPM);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Label_Help);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.Label_Link);
            this.KeyPreview = true;
            this.Name = "BPMMeasure";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BPMMeasure_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Link;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Label Label_Help;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TextBox TextBox_BPM;
        private System.Windows.Forms.Label Label_BPM;
    }
}