using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    public static class TJAManager
    {
        /// <summary>
        /// プロジェクトから.tjaファイルを生成します。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="project">プロジェクト。</param>
        /// <param name="encoding">エンコーディング。</param>
        public static void Build(string fileName, Projects project, Encoding encoding)
        {
            var result = "";
            // 共通ヘッダ。
            foreach (var item in project.CommonHeader)
            {
                result += item.Name + ":" + item.Value + "\r\n";
            }

            // 各コース。
            foreach (var course in project.Courses)
            {
                // コース別ヘッダ。
                foreach (var header in course.Header)
                {
                    result += header.Name + ":" + header.Value + "\r\n";
                }
                // #START～#END
                foreach (var item in course.Text.Split('\n') != null ? course.Text.Split('\n') : new string[] { "" })
                {
                    result += item + "\r\n";
                }
            }
            WriteToFile(result, fileName, encoding);
        }

        /// <summary>
        /// 共通ヘッダとコースから.tjaファイルを生成します。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="commonheader">共通ヘッダ。</param>
        /// <param name="course">コース。</param>
        /// <param name="encoding">エンコーディング。</param>
        public static void Build(string fileName,  List<Header> commonHeader, Course[] course, Encoding encoding)
        {
            var result = "";
            // 共通ヘッダ。
            foreach (var item in commonHeader)
            {
                result += item.Name + ":" + item.Value + "\r\n";
            }

            // 各コース。
            foreach (var argCourse in course)
            {
                // コース別ヘッダ。
                foreach (var header in argCourse.Header)
                {
                    result += header.Name + ":" + header.Value + "\r\n";
                }
                foreach (var item in argCourse.Text != null ? argCourse.Text.Split('\n') : new string[] { "" })
                {
                    result += item + "\r\n";
                }
            }
            WriteToFile(result, fileName, encoding);
        }


        /// <summary>
        /// string型から.tjaファイルを生成します。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="input">string。</param>
        /// <param name="encoding">エンコーディング。</param>
        public static void Build(string fileName, string input, Encoding encoding)
        {
            WriteToFile(input, fileName, encoding);
        }

        private static void WriteToFile(string output, string fileName, Encoding encoding)
        {
            using (var streamWriter = new StreamWriter(fileName, false, encoding))
            {
                streamWriter.Write(output);
            }
        }
    }
}
