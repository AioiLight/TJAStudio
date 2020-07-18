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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.Label_Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Link.AutoSize = true;
            this.Label_Link.Location = new System.Drawing.Point(227, 252);
            this.Label_Link.Name = "Label_Link";
            this.Label_Link.Size = new System.Drawing.Size(40, 20);
            this.Label_Link.TabIndex = 0;
            this.Label_Link.Text = "Ref.:";
            // 
            // LinkLabel
            // 
            this.LinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(273, 252);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(339, 20);
            this.LinkLabel.TabIndex = 1;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "http://yuinore.net/2017/12/bayes-bpm-counter-2/";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Label_Help
            // 
            this.Label_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Help.AutoSize = true;
            this.Label_Help.Location = new System.Drawing.Point(460, 9);
            this.Label_Help.Name = "Label_Help";
            this.Label_Help.Size = new System.Drawing.Size(152, 40);
            this.Label_Help.TabIndex = 2;
            this.Label_Help.Text = "Enter: Measure tempo\r\nDelete: Clear tempo";
            this.Label_Help.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 4;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "BPM";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(454, 249);
            this.Chart.TabIndex = 3;
            this.Chart.Text = "Chart";
            // 
            // TextBox_BPM
            // 
            this.TextBox_BPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_BPM.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox_BPM.Location = new System.Drawing.Point(464, 52);
            this.TextBox_BPM.Name = "TextBox_BPM";
            this.TextBox_BPM.Size = new System.Drawing.Size(148, 39);
            this.TextBox_BPM.TabIndex = 4;
            this.TextBox_BPM.Text = "120.0";
            // 
            // Label_BPM
            // 
            this.Label_BPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_BPM.AutoSize = true;
            this.Label_BPM.Location = new System.Drawing.Point(575, 94);
            this.Label_BPM.Name = "Label_BPM";
            this.Label_BPM.Size = new System.Drawing.Size(37, 20);
            this.Label_BPM.TabIndex = 5;
            this.Label_BPM.Text = "BPM";
            // 
            // BPMMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.Label_BPM);
            this.Controls.Add(this.TextBox_BPM);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Label_Help);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.Label_Link);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(640, 320);
            this.Name = "BPMMeasure";
            this.Text = "BPMMeasure";
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