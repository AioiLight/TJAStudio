using Sgry.Azuki;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    public static class ColorScheme
    {
        public static void SetColorScheme(Sgry.Azuki.ColorScheme azuki)
        {
            SetColor(CharClass.Keyword, Program.Setting.ColorScheme.Keyword, azuki); // キーワード
            SetColor(CharClass.Keyword2, Program.Setting.ColorScheme.Command, azuki); // コマンド
            SetColor(CharClass.Keyword3, Program.Setting.ColorScheme.Parameter, azuki); // パラメータ
            SetColor(CharClass.Comment, Program.Setting.ColorScheme.Comment, azuki); // コメント
            SetColor(CharClass.Heading1, Program.Setting.ColorScheme.Don, azuki);
            SetColor(CharClass.Heading2, Program.Setting.ColorScheme.Ka, azuki);
            SetColor(CharClass.Heading3, Program.Setting.ColorScheme.Space, azuki);
            SetColor(CharClass.Heading4, Program.Setting.ColorScheme.Roll, azuki);
            SetColor(CharClass.Heading5, Program.Setting.ColorScheme.Balloon, azuki);
            SetColor(CharClass.Heading6, Program.Setting.ColorScheme.Other, azuki);
        }

        private static void SetColor(CharClass charClass, ColorFormat scheme, Sgry.Azuki.ColorScheme azuki)
        {
            azuki.SetColor(charClass, scheme.ForeColor, scheme.BackColor);
        }
    }
}
