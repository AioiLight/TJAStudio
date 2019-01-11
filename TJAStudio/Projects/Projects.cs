using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TJAStudio
{
    /// <summary>
    /// プロジェクト用のクラス。
    /// </summary>
    [Serializable()]
    class Projects
    {
        /// <summary>
        /// プロジェクト名。
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 各コースのリスト。
        /// </summary>
        public List<Course> Courses { get; set; } = new List<Course>();
        /// <summary>
        /// 取り込むファイルのリスト。
        /// </summary>
        public List<string> ProjectFile { get; set; } = new List<string>();

        public class Course
        {
            public string CourseName;
            public List<Params> Params;
            [XmlIgnore]
            public Sgry.Azuki.Document Document;
            public string DocumentText;
        }

        public class Params
        {
            public string Parameter;
            public string Value;
        }
    }
}
