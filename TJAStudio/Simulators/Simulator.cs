using System;

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