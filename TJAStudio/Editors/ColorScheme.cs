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
        public static void SetColorScheme(Sgry.Azuki.ColorScheme azuki, Setting setting)
        {
            SetColor(CharClass.Keyword, setting.ColorScheme.Keyword, azuki); // キーワード
            SetColor(CharClass.Keyword2, setting.ColorScheme.Command, azuki); // コマンド
            SetColor(CharClass.Keyword3, setting.ColorScheme.Parameter, azuki); // パラメータ
            SetColor(CharClass.Comment, setting.ColorScheme.Comment, azuki); // コメント
            SetColor(CharClass.Heading1, setting.ColorScheme.Don, azuki);
            SetColor(CharClass.Heading2, setting.ColorScheme.Ka, azuki);
            SetColor(CharClass.Heading3, setting.ColorScheme.Space, azuki);
            SetColor(CharClass.Heading4, setting.ColorScheme.Roll, azuki);
            SetColor(CharClass.Heading5, setting.ColorScheme.Balloon, azuki);
            SetColor(CharClass.Heading6, setting.ColorScheme.Other, azuki);
        }

        private static void SetColor(CharClass charClass, ColorFormat scheme, Sgry.Azuki.ColorScheme azuki)
        {
            azuki.SetColor(charClass, scheme.ForeColor, scheme.BackColor);
        }
    }
}
