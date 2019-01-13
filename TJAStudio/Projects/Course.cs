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
        /// <summary>
        /// コース名。ここで言うコース名はCOUREヘッダとは別。
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// コース別ヘッダのリスト。
        /// </summary>
        public List<Header> Header { get; set; } = new List<Header>();
        /// <summary>
        /// ドキュメント。
        /// </summary>
        [XmlIgnore]
        public Sgry.Azuki.Document Document { get; set; } = new Sgry.Azuki.Document();
        /// <summary>
        /// ドキュメントの中のテキスト。
        /// </summary>
        public string Text { get; set; }
    }
}
