using Sgry.Azuki;
using Sgry.Azuki.Highlighter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio
{
    public static class Highlighter
    {
        public static KeywordHighlighter InitHighlighter()
        {
            // ハイライト処理

            var keyWordHighlighter = new Sgry.Azuki.Highlighter.KeywordHighlighter();
            keyWordHighlighter.HighlightsNumericLiterals = false;
            keyWordHighlighter.AddRegex(@"[13]", true, CharClass.Heading1);
            keyWordHighlighter.AddRegex(@"[24]", true, CharClass.Heading2);
            keyWordHighlighter.AddRegex(@"0", true, CharClass.Heading3);
            keyWordHighlighter.AddEnclosure(@"5", @"8", CharClass.Heading4, false);
            keyWordHighlighter.AddEnclosure(@"6", @"8", CharClass.Heading4, false);
            keyWordHighlighter.AddEnclosure(@"7", @"8", CharClass.Heading5, false);
            keyWordHighlighter.AddRegex(@"F", true, CharClass.Heading6);
            keyWordHighlighter.AddLineHighlight("//", CharClass.Comment);
            keyWordHighlighter.AddLineHighlight("#", CharClass.Keyword2);
            keyWordHighlighter.AddLineHighlight(":", CharClass.Keyword3);
            var keyWords = Charts.Headers.GetHeaders();
            var words = new List<string>();
            foreach (var item in keyWords)
            {
                words.Add(item.Name);
            }
            words.Sort();
            keyWordHighlighter.AddKeywordSet(words.ToArray(), CharClass.Keyword, true);

            return keyWordHighlighter;
        }
    }
}
