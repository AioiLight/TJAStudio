using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TJAStudio
{
    public static class Measure
    {
        public static int[] GetMeasure(Sgry.Azuki.Document doc)
        {
            var listLine = doc.Text.Replace(",", ",\n").Split('\n');
            var listMeasure = new List<string>();
            var indexMeasure = "";
            foreach (var item in listLine)
            {
                var nowLine = Regex.Replace(item, @" *//.*", "");
                if (nowLine.StartsWith("#") || nowLine.IndexOf(':') >= 0)
                {
                    // コマンド行、ヘッダ行である
                    indexMeasure += nowLine + "\n";
                }
                else if (nowLine.IndexOf(',') >= 0)
                {
                    // カンマのある行である
                    indexMeasure += nowLine;
                    listMeasure.Add(indexMeasure);
                    indexMeasure = "";
                }
                else
                {
                    indexMeasure += nowLine + "\n";
                }
            }
            var totalMeasure = listMeasure.Count; // 総小節数
            var nowCaret = new int[] { 0, 0 };
            doc.GetCaretIndex(out nowCaret[0], out nowCaret[1]);
            var caret = doc.GetCharIndexFromLineColumnIndex(nowCaret[0], nowCaret[1]);
            var listNowLine = doc.GetTextInRange(0, caret).Replace(",", ",\n").Split('\n');
            var listNowMeasure = new List<string>();
            var nowIndexMeasure = "";
            foreach (var item in listNowLine)
            {
                var nowLine = Regex.Replace(item, @" *//.*", "");
                if (nowLine.StartsWith("#") || nowLine.IndexOf(':') >= 0)
                {
                    // コマンド行、ヘッダ行である
                    nowIndexMeasure += nowLine;
                }
                else if (nowLine.IndexOf(',') >= 0)
                {
                    // カンマのある行である
                    nowIndexMeasure += nowLine;
                    listNowMeasure.Add(nowIndexMeasure);
                    nowIndexMeasure = "";
                }
                else
                {
                    indexMeasure += nowLine + "\n";
                }
            }
            return new int[] { listMeasure.Count, listNowMeasure.Count };
        }
    }
}