using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    public class WindowManager
    {
        public int AddCourse(string name)
        {
            // リストへ追加
            Program.Project.Courses.Add(new Course());
            Program.Project.Courses[Program.Project.Courses.Count - 1].Name = name;
            Editors.Add(new Editor(Program.Project.Courses[Program.Project.Courses.Count -1].Document, Program.Project.Courses[Program.Project.Courses.Count - 1]));
            return Program.Project.Courses.Count - 1;
        }
        public int DeleteCourse(int index)
        {
            if (!Editors[index].IsDisposed) Editors[index].Close();
            Editors.RemoveAt(index);
            Program.Project.Courses.RemoveAt(index);
            return index;
        }
        public List<Editor> Editors { get; private set; } = new List<Editor>();
    }

}
