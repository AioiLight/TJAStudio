using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    /// <summary>
    /// TJAフォーマットの検証用インターフェイス。
    /// </summary>
    interface ITJACheckable
    {
        void CheckFormat(string text);
        bool IsAvailable(Simulator simulator);
        Simulator Simulator { get; }
        string[] Format { get; }
        string Name { get; }
    }
}
