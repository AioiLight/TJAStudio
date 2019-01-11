using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TJAStudio.Charts
{
    /// <summary>
    /// ヘッダーをチェックするクラス。
    /// </summary>
    public class HeaderCheker : ITJACheckable
    {
        /// <summary>
        /// 初期化。
        /// </summary>
        /// <param name="name">ヘッダー名。</param>
        /// <param name="format">フォーマット(正規表現)。</param>
        /// <param name="availableSimulator">利用可能なシミュレーター。</param>
        public HeaderCheker(string name, string[] format, Simulator availableSimulator)
        {
            Name = name;
            Format = format;
            Simulator = availableSimulator;
        }
        /// <summary>
        /// ヘッダーのフォーマットをチェックし、有効であるかどうか調べます。
        /// </summary>
        /// <param name="text">テキスト。</param>
        public void CheckFormat(string text)
        {
            var isValid = false;
            text.Trim();
            foreach (var item in Format)
            {
                if(Regex.IsMatch(text, item)) isValid = true;
            }
            if (!isValid) throw new InvalidTJAFormatException();
        }

        /// <summary>
        /// そのシミュレーターでこのヘッダーが利用可能かどうかチェックします。
        /// </summary>
        /// <param name="simulator">Simulator列挙型。</param>
        /// <returns>利用可能かどうか。</returns>
        public bool IsAvailable(Simulator simulator)
        {
            return Simulator.HasFlag(simulator);
        }

        public Simulator Simulator { get; }

        public string[] Format { get; }

        public string Name { get; }
    }
}
