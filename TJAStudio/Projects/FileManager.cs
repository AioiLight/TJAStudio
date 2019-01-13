using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TJAStudio
{
    public static class FileManager
    {
        /// <summary>
        /// プロジェクトファイルを開きます。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="projects">プロジェクト。</param>
        public static void SaveFile(string fileName, Projects projects)
        {
            var serializer = new XmlSerializer(typeof(Projects));
            using (var streamWriter = new StreamWriter(fileName, false, new UTF8Encoding(false)))
            {
                serializer.Serialize(streamWriter, projects);
                serializer = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <returns>プロジェクト。</returns>
        public static Projects OpenFile(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Projects));
            using (var streamReader = new StreamReader(fileName, new UTF8Encoding(false)))
            {
                var projects = (Projects)serializer.Deserialize(streamReader);
                serializer = null;
                return projects;
            }
        }
    }
}
