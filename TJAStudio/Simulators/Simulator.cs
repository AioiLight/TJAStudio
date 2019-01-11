using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    [Flags]
    public enum Simulator
    {
        // PC
        Taikojiro = 1,
        Taikojiro2 = 1 << 1,
        TJAPlayer2fPC = 1 << 2,
        TJAPlayer3 = 1 << 3,
        // SP
        TaikoDaijiro2 = 1 << 4,
        // Web
        TaikoWeb_Bui = 1 << 5,
    }
}
