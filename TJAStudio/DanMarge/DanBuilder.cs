using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            var result = System.IO.File.ReadAllText(fileName);
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
                if(dialog.DialogResult != DialogResult.OK)
                {
                    // DialogResultがOK以外ならnullでリターン。
                    dialog.Dispose();
                    return null;
                }
                var selectedIndex = dialog.SelectedCourseIndex;
                dialog.Dispose();

                result.Chart = commonHeader + splitedcourses[selectedIndex];
                result.Course = courseName[selectedIndex];
            }
            else
            {
                result.Chart = commonHeader + splitedcourses[0];
                result.Course = splitedcourses[0].Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            }
            return result;
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
    }
}
