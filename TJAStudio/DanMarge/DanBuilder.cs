using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio.DanMarge
{
    public partial class DanBuilder : Form
    {
        public DanBuilder()
        {
            InitializeComponent();
            Status_Songs.Text = string.Format(Properties.SystemMessage.DanMarge_Songs, SongList.Count);
            SetNotesRemain();
        }

        private void SetNotesRemain()
        {
            var natori = new Natori[SongList.Count];
            var notesRemain = 0;
            for (int i = 0; i < natori.Length; i++)
            {
                natori[i] = new Natori(SongList[i].Chart);
                foreach (var item in natori[i].Result)
                {
                    if (item.Type == LineType.Text) notesRemain += Convert.ToInt32(item.NotesAmount);
                }
            }
            Status_NotesRemain.Text = string.Format(Properties.SystemMessage.DanMarge_NotesRemain, notesRemain);
        }

        private void SetCoursesFromList()
        {
            ListView_Songs.Items.Clear();
            foreach (var item in SongList)
            {
                ListView_Songs.Items.Add(item.Course + " : " + item.FilePath);
            }
            Status_Songs.Text = string.Format(Properties.SystemMessage.DanMarge_Songs, SongList.Count);
            SetNotesRemain();
        }

        public Songs FromProjectFile(string fileName)
        {
            var project = FileManager.OpenFile(fileName);
            var result = TJAManager.Build(null, project, null, false);
            return GetCourseFromCourses(result);
        }

        public Songs FromTJAFile(string fileName)
        {
            var result = System.IO.File.ReadAllText(fileName, Program.Setting.UTF8Mode ? new UTF8Encoding() : Encoding.GetEncoding("Shift-JIS"));
            return GetCourseFromCourses(result);
        }

        public Songs GetCourseFromCourses(string courses)
        {
            // coursesに複数の要素があれば、ダイアログを出し、どのコースを使用するかの選択をユーザーにさせる。
            // 選択の際、コース名を出す必要があるが、それについてはとりあえず1行目を表示させることで対応させよう。
            var result = new Songs();
            var splitedcourses = courses.Split(new string[] { "COURSE:" }, StringSplitOptions.None);
            var commonHeader = splitedcourses[0];
            splitedcourses = splitedcourses.Skip(1).ToArray();
            for (int i = 0; i < splitedcourses.Length; i++)
            {
                // 分割して、そのあとまたくっつける
                splitedcourses[i] = "COURSE:" + splitedcourses[i];
            }

            if (splitedcourses.Length > 1)
            {
                // 複数のコースがある場合、ダイアログで選択させる。
                var courseName = new string[splitedcourses.Length];
                for (int i = 0; i < courseName.Length; i++)
                {
                    // 改行までをコース名とする。
                    courseName[i] = splitedcourses[i].Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
                }
                var dialog = new CourseSelect(courseName);
                dialog.ShowDialog(this);
                if (dialog.DialogResult != DialogResult.OK)
                {
                    // DialogResultがOK以外ならnullでリターン。
                    dialog.Dispose();
                    return null;
                }
                var selectedIndex = dialog.SelectedCourseIndex;
                dialog.Dispose();

                var chart = "";
                var inChart = false;
                foreach (var item in splitedcourses[selectedIndex].Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    if(item.Trim().StartsWith("#START"))
                    {
                        inChart = true;
                        continue;
                    }
                    if(item.Trim().StartsWith("#END"))
                    {
                        inChart = false;
                    }
                    if (inChart)
                    {
                        chart += item + Environment.NewLine;
                    }
                }

                result.Chart = chart;
                result.Course = courseName[selectedIndex];

                ParseTJA(result, splitedcourses[selectedIndex].Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Concat(commonHeader.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)).ToArray());
            }
            else
            {
                var chart = "";
                var inChart = false;
                foreach (var item in splitedcourses[0].Split(new string[] { Environment.NewLine }, StringSplitOptions.None))
                {
                    if (item.Trim().StartsWith("#START"))
                    {
                        inChart = true;
                        continue;
                    }
                    if (item.Trim().StartsWith("#END"))
                    {
                        inChart = false;
                    }
                    if (inChart)
                    {
                        chart += item + Environment.NewLine;
                    }
                }
                result.Chart = chart;
                result.Course = splitedcourses[0].Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];

                ParseTJA(result, splitedcourses[0].Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Concat(commonHeader.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)).ToArray());
            }
            return result;
        }

        private static void ParseTJA(Songs result, string[] text)
        {
            foreach (var item in text)
            {
                var nowLine = Regex.Replace(item, " *//.*", "");
                if (!nowLine.Contains(":")) continue;
                if (nowLine.StartsWith("TITLE:"))
                {
                    result.Title = nowLine.Substring("TITLE:".Length);
                }
                else if (nowLine.StartsWith("SUBTITLE:"))
                {
                    var subTitle = nowLine.Substring("SUBTITLE:".Length);
                    if (subTitle.StartsWith("++") || subTitle.StartsWith("--"))
                    {
                        subTitle = subTitle.Substring("++".Length);
                    }
                    result.SubTitle = subTitle;
                }
                else if (nowLine.StartsWith("BPM:"))
                {
                    result.BPM = nowLine.Substring("BPM:".Length);
                }
                else if (item.StartsWith("OFFSET:"))
                {
                    result.Offset = (Convert.ToDouble(nowLine.Substring("OFFSET:".Length)) * -1).ToString();
                }
                else if (nowLine.StartsWith("GENRE:"))
                {
                    result.Genre = nowLine.Substring("GENRE:".Length);
                }
                else if (nowLine.StartsWith("SCOREINIT:"))
                {
                    result.ScoreInit = Convert.ToInt32(nowLine.Substring("SCOREINIT:".Length));
                }
                else if (nowLine.StartsWith("SCOREDIFF:"))
                {
                    result.ScoreDiff = Convert.ToInt32(nowLine.Substring("SCOREDIFF:".Length));
                }
                else if (nowLine.StartsWith("WAVE:"))
                {
                    result.Wave = nowLine.Substring("WAVE:".Length);
                }
                else if (nowLine.StartsWith("LEVEL:"))
                {
                    result.Level = nowLine.Substring("LEVEL:".Length);
                }
                else if (nowLine.StartsWith("SCOREMODE:"))
                {
                    result.ScoreMode = nowLine.Substring("SCOREMODE:".Length);
                }
                else if (nowLine.StartsWith("BALLOON:"))
                {
                    result.Balloon = nowLine.Trim().EndsWith(",") ? nowLine.Substring("BALLOON:".Length, nowLine.Length - 1) : nowLine.Substring("BALLOON:".Length);
                }
                else if (nowLine.StartsWith("DEMOSTART:"))
                {
                    result.DemoStart = nowLine.Substring("DEMOSTART:".Length);
                }
            }
        }

        private void Button_AddSong_Click(object sender, EventArgs e)
        {
            var songs = new Songs();
            var dialog = new OpenFileDialog();
            dialog.Title = Properties.SystemMessage.OpenSongs;
            dialog.Filter = String.Format("{0}|*{1}|{2}|*{3}", Properties.Common.TJAExtensionDescription, Properties.Common.TJAExtensionName, Properties.Common.ExtensionDescription, Properties.Common.ExtensionName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(dialog.FileName);
                if (extension == Properties.Common.ExtensionName)
                {
                    songs = FromProjectFile(dialog.FileName);
                }
                else
                {
                    songs = FromTJAFile(dialog.FileName);
                }
                if(songs != null)
                {
                    songs.FilePath = dialog.FileName;
                    SongList.Add(songs);
                }
            }
            dialog.Dispose();

            SetCoursesFromList();
        }

        private void Button_RemoveSong_Click(object sender, EventArgs e)
        {
            if (SongList.Count < 1 || ListView_Songs.SelectedItems.Count < 1) return;
            SongList.RemoveAt(ListView_Songs.SelectedItems[0].Index);
            SetCoursesFromList();
        }

        private void Button_UpSong_Click(object sender, EventArgs e)
        {
            if (SongList.Count <= 1 || ListView_Songs.SelectedItems.Count < 1 || ListView_Songs.SelectedItems[0].Index <= 0) return;
            var index = ListView_Songs.SelectedItems[0].Index;
            var work = SongList[index];
            SongList.RemoveAt(index);
            SongList.Insert(index - 1, work);
            SetCoursesFromList();
        }

        private void Button_DownSong_Click(object sender, EventArgs e)
        {
            if (SongList.Count <= 1 || ListView_Songs.SelectedItems.Count < 1 || ListView_Songs.SelectedItems[0].Index + 1 > ListView_Songs.Items.Count - 1) return;
            var index = ListView_Songs.SelectedItems[0].Index;
            var work = SongList[index];
            SongList.RemoveAt(index);
            SongList.Insert(index + 1, work);
            SetCoursesFromList();
        }

        public List<Songs> SongList { get; set; } = new List<Songs>();

        private void Button_Build_Click(object sender, EventArgs e)
        {
            if (SongList.Count > 0)
            {
                var dialog = new SaveFileDialog();
                dialog.Title = Properties.SystemMessage.SaveTJA;
                dialog.Filter = String.Format("{0}|*{1}", Properties.Common.TJAExtensionDescription, Properties.Common.TJAExtensionName);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var result = "";
                    var danTitle = Path.GetFileNameWithoutExtension(dialog.FileName);
                    result += string.Format("TITLE:{0}" + Environment.NewLine, danTitle);
                    result += string.Format("BPM:{0}" + Environment.NewLine, SongList[0].BPM);
                    result += string.Format("WAVE:{0}" + Environment.NewLine, SongList[0].Wave);
                    result += string.Format("DEMOSTART:{0}" + Environment.NewLine, SongList[0].DemoStart);
                    result += string.Format("SCOREMODE:{0}" + Environment.NewLine, SongList[0].ScoreMode);

                    result += string.Format("COURSE:Dan" + Environment.NewLine);
                    result += string.Format("LEVEL:{0}" + Environment.NewLine, SongList[0].Level);
                    var balloon = "";
                    for (int i = 0; i < SongList.Count; i++)
                    {
                        balloon += SongList[i].Balloon;
                        if (!string.IsNullOrWhiteSpace(SongList[i].Balloon) && i != SongList.Count - 1) balloon += ",";
                    }
                    result += string.Format("BALLOON:{0}" + Environment.NewLine, balloon);

                    if (ExamHeader_Exam1.ToString() != null) result += string.Format("EXAM1:{0}" + Environment.NewLine, ExamHeader_Exam1.ToString());
                    if (ExamHeader_Exam2.ToString() != null) result += string.Format("EXAM2:{0}" + Environment.NewLine, ExamHeader_Exam2.ToString());
                    if (ExamHeader_Exam3.ToString() != null) result += string.Format("EXAM3:{0}" + Environment.NewLine, ExamHeader_Exam3.ToString());

                    result += string.Format("#START" + Environment.NewLine);
                    foreach (var item in SongList)
                    {
                        result += item.ToString();
                    }
                    result += string.Format("#END" + Environment.NewLine);

                    TJAManager.Build(dialog.FileName, result, Program.Setting.UTF8Mode ? new UTF8Encoding() : Encoding.GetEncoding("Shift-JIS"));
                }
                dialog.Dispose();
            }
            DialogResult = DialogResult.None;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            if(SongList.Count > 0)
            {
                var dialog = MessageBox.Show(Properties.SystemMessage.AreYouSure,
                    string.Format("{0} - {1}", Properties.Common.Name, Properties.Common.DanBuilder),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk);
                if(dialog == DialogResult.No)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            Close();
        }
    }
}
