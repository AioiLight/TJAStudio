using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TJAStudio.Charts
{
    /// <summary>
    /// 命令をチェックするクラス。
    /// </summary>
    public class CommandCheker : ITJACheckable
    {
        /// <summary>
        /// 初期化。
        /// </summary>
        /// <param name="name">命令名。</param>
        /// <param name="format">フォーマット(正規表現)。</param>
        /// <param name="availableSimulator">利用可能なシミュレーター。</param>
        public CommandCheker(string name, string[] format, Simulator availableSimulator)
        {
            Name = name;
            Format = format;
            Simulator = availableSimulator;
        }
        /// <summary>
        /// 命令のフォーマットをチェックし、有効であるかどうか調べます。
        /// </summary>
        /// <param name="text">テキスト。</param>
        public void CheckFormat(string text)
        {
            var isValid = false;
            text.Trim();
            var parameterText = text.Substring(("#" + Name).Length);
            foreach (var item in Format)
            {
                if (item == null)
                {
                    isValid = true;
                    continue;
                }
                if(Regex.IsMatch(parameterText, item)) isValid = true;
                // 命令名の後に空白がなかったら例外を出す。
                if (Regex.IsMatch("#" + Name + " ", text, RegexOptions.IgnoreCase)) throw new CommandWithoutSpaceException();
            }
            if (!isValid) throw new InvalidTJAFormatException(String.Format(Properties.SystemMessage.InvalidCommand, text));
        }

        /// <summary>
        /// そのシミュレーターでこの命令が利用可能かどうかチェックします。
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
