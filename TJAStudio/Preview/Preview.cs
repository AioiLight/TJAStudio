using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Natori;
using DxLibDLL;

namespace TJAStudio.Preview
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
            DX.SetUserWindow(Handle);
            //DX.SetUserChildWindow(Pic.Handle);
            DX.SetOutApplicationLogValidFlag(DX.FALSE);
            DX.SetGraphMode(Width, Height, 32);
            //DX.WaitVSync(DX.FALSE);
            if (DX.DxLib_Init() < 0)
            {
                Close();
            }

            const string folder = @"\res\";

            Dong = DX.LoadSoundMem(Program.EXEPath + folder + "dong.ogg");
            Ka = DX.LoadSoundMem(Program.EXEPath + folder + "ka.ogg");
            Balloon = DX.LoadSoundMem(Program.EXEPath + folder + "balloon.ogg");

            Notes = DX.LoadGraph(Program.EXEPath + folder + "notes.png");
            Background = DX.LoadGraph(Program.EXEPath + folder + "background.png");

            Natori = new Natori.Natori("");

            Counter = new Counter(0, 1, 1, false);

            Timer = new Timer();
            Timer.Interval = 1000 / 90;
            Timer.Tick += Timer_Tick;
            Timer.Start();
       }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DX.ProcessMessage() == -1)
            {
                Close();
            }
            DX.ClearDrawScreen();
            DX.SetDrawScreen(DX.DX_SCREEN_BACK);
            Counter?.Tick();
            DX.DrawGraph(0, 0, Background, DX.TRUE);
            DX.DrawRectExtendGraph(0, 0, 130, 130, 0, 0, 130, 130, Notes, DX.TRUE);
            if (Natori == null || Natori.Chart.Courses.Count == 0 || Natori.Chart.Courses[0].Chip.Common.Count == 0)
            {
                return;
            }
            for (int note = Natori.Chart.Courses[0].Chip.Common.Count - 1; note > 0; note--)
            {
                var item = Natori.Chart.Courses[0].Chip.Common[note];
                if (item.ChipType == Chips.Measure)
                {
                    var x = (item.Time - Counter.Value) * item.BPM * item.Scroll * 0.0000036;
                    x += 130;
                    if (x < Width)
                    {
                        DX.DrawLine((int)x, 0, (int)x, 130, DX.GetColor(255, 255, 255));
                    }
                }
            }
            for (var chip = Natori.Chart.Courses[0].Chip.Common.Count - 1; chip >= 0; chip--)
            {
                var item = Natori.Chart.Courses[0].Chip.Common[chip];
                if (item.NoteType != global::Natori.Notes.Space && item.CanShow)
                {
                    var x = (item.Time - Counter.Value) * item.BPM * item.Scroll * 0.0000036;
                    x += 130 / 2;
                    if (x > 0 && x < Width)
                    {
                        // 後で変える。負荷軽減のため仮。
                        DX.DrawRectExtendGraph((int)x, 0, (int)x + 130, 130, (int)item.NoteType * 130, 0, 130, 130, Notes, DX.TRUE);

                    }
                    if (x <= 0 && !item.IsHitted)
                    {
                        if (item.NoteType == global::Natori.Notes.Don || item.NoteType == global::Natori.Notes.DON)
                        {
                            DX.PlaySoundMem(Dong, DX.DX_PLAYTYPE_BACK);
                        }
                        else if (item.NoteType == global::Natori.Notes.Ka || item.NoteType == global::Natori.Notes.KA)
                        {
                            DX.PlaySoundMem(Ka, DX.DX_PLAYTYPE_BACK);
                        }
                        item.IsHitted = true;
                    }
                    //Console.WriteLine(x);
                }
            }

            //DX.DrawGraph(0, 0, Notes, DX.TRUE);
            DX.ScreenFlip();

        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        public void UpdateChart(string chart)
        {
            Chart = chart;
            Natori = new Natori.Natori(Chart);
            if (Natori.Chart.Courses[0].Chip.Common.Count != 0)
            {
                var now = Counter.Value;
                Counter = new Counter(0, Natori.Chart.Courses[0].Chip.Common.Last().Time, 1, false);
                Counter.Value = now;
                SetHit();
            }
        }

        private void SetHit()
        {
            foreach (var item in Natori.Chart.Courses[0].Chip.Common)
            {
                item.IsHitted = false;
            }
            for (var chip = 0; chip < Natori.Chart.Courses[0].Chip.Common.Count; chip++)
            {
                var item = Natori.Chart.Courses[0].Chip.Common[chip];
                if (item.Time < Counter.Value)
                {
                    item.IsHitted = true;
                }
                else
                {
                    break;
                }
            }
        }

        private void Preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            DX.DxLib_End();
        }

        public void Preview_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F12)
            {
                if (Counter.Started)
                {
                    Counter.Stop();
                }
                else
                {
                    Counter.Start();
                }
            }
            else if (e.KeyData == Keys.F9)
            {
                // 前
                for (var chip = Natori.Chart.Courses[0].Chip.Common.Count - 1; chip >= 0; chip--)
                {
                    var item = Natori.Chart.Courses[0].Chip.Common[chip];
                    if (item.Time < Counter.Value && item.ChipType == Chips.Measure)
                    {
                        Counter.Value = item.Time;
                        break;
                    }
                }
                SetHit();

            }
            else if (e.KeyData == Keys.F10)
            {
                // 後ろ
                for (var chip = 0; chip < Natori.Chart.Courses[0].Chip.Common.Count; chip++)
                {
                    var item = Natori.Chart.Courses[0].Chip.Common[chip];
                    if (item.Time > Counter.Value && item.ChipType == Chips.Measure)
                    {
                        Counter.Value = item.Time;
                        break;
                    }
                }
                SetHit();
            }
            else if (e.KeyData == Keys.F11)
            {
                // 先頭
                while (Counter.Value > 0)
                {
                    Counter.Value--;
                }
                SetHit();
            }

        }
        private string Chart { get; set; }
        private Natori.Natori Natori { get; set; }
        private Counter Counter { get; set; }
        private bool IsPlaying { get; set; }

        private int Dong { get; set; }
        private int Ka { get; set; }
        private int Balloon { get; set; }
        private int Notes { get; set; }
        private int Background { get; set; }


        private int Wave { get; set; }

        private Timer Timer;

    }

    public class Counter
    {
        public Counter(long begin, long end, long interval, bool isLoop)
        {
            NowTime = DX.GetNowHiPerformanceCount();
            Begin = begin;
            End = end;
            Interval = interval;
            Value = 0;
            IsLoop = isLoop;
            Started = false;
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            Looped?.Invoke(this, e);
        }

        public void Start()
        {
            NowTime = DX.GetNowHiPerformanceCount();
            Started = true;
        }

        public void Stop()
        {
            NowTime = DX.GetNowHiPerformanceCount();
            Started = false;
        }

        public long Tick()
        {
            if (!Started)
            {
                NowTime = DX.GetNowHiPerformanceCount();
                return 0;
            }

            var tickCount = 0; // 何Tickしたかのカウント
            var nowTime = DX.GetNowHiPerformanceCount();
            var diffTime = nowTime - NowTime; // 現在時間からまえTick()したまでの時間の差
            while (diffTime > Interval)
            {
                // 時間の差が間隔未満になるまで進める
                Value++;
                tickCount++;
                if (IsLoop && Value > End)
                {
                    // ループ設定かつ現在の値が終了値より大きかったら
                    Value = Begin;
                    OnThresholdReached(EventArgs.Empty);
                }
                if (!IsLoop && Value > End)
                {
                    // 非ループ設定かつ現在の値が終了値より大きかったら
                    Value = End; // 終了値を維持する。
                }
                diffTime -= Interval;
            }
            NowTime = nowTime - diffTime; // 余ったdiffTimeを引いて、次Tick()したときにちゃんとなるように
            return tickCount; // 何Tickしたかのカウント
        }

        public event EventHandler Looped;
        public long NowTime { get; private set; }
        public long Begin { get; private set; }
        public long End { get; private set; }
        public long Interval { get; private set; }
        public long Value { get; set; }
        public bool IsLoop { get; private set; }
        public bool Started { get; set; }
    }
}
