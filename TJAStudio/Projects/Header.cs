using System;

namespace TJAStudio
{
    /// <summary>
    /// ヘッダー情報を扱うクラス。
    /// </summary>
    public class Header
    {
        /// <summary>
        /// ヘッダーの名前。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ヘッダーの値。
        /// </summary>
        public string Value { get; set; }

        public override string ToString()
        {
            return String.Format("{0}:{1}", Name, Value);
        }
    }
}