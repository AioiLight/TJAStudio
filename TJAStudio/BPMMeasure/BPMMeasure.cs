using System;
using System.Windows.Forms;

namespace TJAStudio.BPMMeasure
{
    public partial class BPMMeasure : Form
    {
        public BPMMeasure()
        {
            InitializeComponent();
        }

        private void BPMMeasure_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Space();
                return;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Delete();
                return;
            }
        }

        private void Space()
        {
            if (!IsInit)
            {
                IsInit = true;

                // 初期化。
                PressCount = 0;
                // ミリ秒。
                StartTime = GetNow();

                BeforeTime = StartTime;
                Bayes = 0;

                DeltaCt = 0;
                Sum = 0;

                return;
            }

            var now = GetNow();

            var delta = now - BeforeTime;
            PressCount++;

            DeltaCt += PressCount * delta;
            Sum += DeltaCt;

            var e = PressCount * (PressCount + 1) * (PressCount + 2) / 6;

            Bayes = 60000.0 / (Sum / e);
            Console.WriteLine(Bayes);

            BeforeTime = now;

            UpdateChart();
            UpdateText();
        }

        private void Delete()
        {
            // 初期化するためのフラグをへし折る。
            IsInit = false;
            DeleteChart();
        }

        private long GetNow()
        {
            return DateTime.Now.Ticks / 10000;
        }

        private void UpdateChart()
        {
            // 秒で出すので1000で割る。
            Chart.Series[0].Points.AddXY((BeforeTime - StartTime) / 1000.0, Bayes);
        }

        private void DeleteChart()
        {
            Chart.Series[0].Points.Clear();
        }

        private void UpdateText()
        {
            TextBox_BPM.Text = Bayes.ToString();
        }

        private bool IsInit = false;

        private int PressCount = 0;
        private long StartTime = 0;
        private long BeforeTime = 0;
        private double Bayes = 0;

        private long DeltaCt = 0;
        private long Sum = 0;

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://yuinore.net/2017/12/bayes-bpm-counter-2/");
        }
    }
}