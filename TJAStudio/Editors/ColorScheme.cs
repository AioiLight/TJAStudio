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
            azuki.SetColor(CharClass.Keyword2, Color.Brown, Color.Transparent); // キーワード
            azuki.SetColor(CharClass.Heading1, Color.Red, Color.Transparent); // ドン
            azuki.SetColor(CharClass.Heading2, Color.Blue, Color.Transparent); // カツ
            azuki.SetColor(CharClass.Heading3, Color.DimGray, Color.Transparent); // なし
            azuki.SetColor(CharClass.Heading4, Color.White, Color.Orange); // 連打
            azuki.SetColor(CharClass.Heading5, Color.White, Color.Tomato); // ふうせん
            azuki.SetColor(CharClass.Heading6, Color.DimGray, Color.Transparent); // ほか
        }
    }
}
