using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string Build(string fileName, Projects project, Encoding encoding, bool writeToFile = true)
        {
            var result = "";
            // 共通ヘッダ。
            foreach (var item in project.CommonHeader)
            {
                result += item.Name + ":" + item.Value + Environment.NewLine;
            }

            // 各コース。
            foreach (var course in project.Courses)
            {
                // コース別ヘッダ。
                foreach (var header in course.Header)
                {
                    result += header.Name + ":" + header.Value + Environment.NewLine;
                }
                // #START～#END
                result += course.Text;
            }
            if (writeToFile) WriteToFile(result, fileName, encoding);
            return result;
        }

        /// <summary>
        /// 共通ヘッダとコースから.tjaファイルを生成します。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="commonheader">共通ヘッダ。</param>
        /// <param name="course">コース。</param>
        /// <param name="encoding">エンコーディング。</param>
        public static string Build(string fileName,  List<Header> commonHeader, Course[] course, Encoding encoding, bool writeToFile = true)
        {
            var result = "";
            // 共通ヘッダ。
            foreach (var item in commonHeader)
            {
                result += item.Name + ":" + item.Value + Environment.NewLine;
            }

            // 各コース。
            foreach (var argCourse in course)
            {
                // コース別ヘッダ。
                foreach (var header in argCourse.Header)
                {
                    result += header.Name + ":" + header.Value + Environment.NewLine;
                }
                result += argCourse.Text;
            }
            if (writeToFile) WriteToFile(result, fileName, encoding);
            return result;
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
