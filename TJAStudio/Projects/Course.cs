using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TJAStudio
{
    /// <summary>
    /// コース情報を扱うクラス。
    /// </summary>
    public class Course
    {
        public string Name { get; set; }
        public List<Header> Header { get; set; }
        [XmlIgnore]
        public Sgry.Azuki.Document Document { get; set; }
        public string Text { get; set; }
    }
}
