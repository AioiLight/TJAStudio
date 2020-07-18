using System;
using System.Collections.Generic;

namespace TJAStudio
{
    /// <summary>
    /// プロジェクト用のクラス。
    /// </summary>
    [Serializable()]
    public class Projects
    {
        /// <summary>
        /// プロジェクト名。
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 共通ヘッダー。
        /// </summary>
        public List<Header> CommonHeader { get; set; } = new List<Header>();

        /// <summary>
        /// 各コースのリスト。
        /// </summary>
        public List<Course> Courses { get; set; } = new List<Course>();

        /// <summary>
        /// 取り込むファイルのリスト。
        /// </summary>
        public List<string> ProjectFile { get; set; } = new List<string>();
    }
}