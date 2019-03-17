using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void SetCoursesFromList()
        {
            ListView_Songs.Items.Clear();
            foreach (var item in SongList)
            {
                ListView_Songs.Items.Add(item.FilePath);
            }
        }

        public string[] GetCoursesFromProjectFile(string fileName)
        {
            var result = new string[] { };
            return result;
        }

        public string[] GetCoursesFromTJAFile(string fileName)
        {
            var result = new string[] { };
            return result;
        }

        public string[] GetCoursesFromString(string document)
        {
            var result = new string[] { };
            return result;
        }

        public string GetCourseFromCourses(string[] courses)
        {
            // coursesに複数の要素があれば、ダイアログを出し、どのコースを使用するかの選択をユーザーにさせる。
            // 選択の際、コース名を出す必要があるが、それについてはとりあえず1行目を表示させることで対応させよう。
            var result = "";
            return result;
        }

        private void Button_AddSong_Click(object sender, EventArgs e)
        {

        }

        private void Button_RemoveSong_Click(object sender, EventArgs e)
        {

        }

        private void Button_UpSong_Click(object sender, EventArgs e)
        {

        }

        private void Button_DownSong_Click(object sender, EventArgs e)
        {

        }

        public List<Songs> SongList { get; set; } = new List<Songs>();
    }
}
