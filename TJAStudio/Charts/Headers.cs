using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio.Charts
{
    public static class Headers
    {
        public static List<HeaderCheker> GetHeaders()
        {
            var headers = new List<HeaderCheker> ();

            #region 次郎のReadmeにあるやつ
            headers.Add(new HeaderCheker("TITLE", new string[] { @".+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("SUBTITLE", new string[] { @".+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("LEVEL", new string[] { @"[0-9]*$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("WAVE", new string[] { @".+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("BPM", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("OFFSET", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("BALLOON", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));

            headers.Add(new HeaderCheker("SONGVOL", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 |  Simulator.TJAPlayer3));
            headers.Add(new HeaderCheker("SEVOL", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2));

            headers.Add(new HeaderCheker("SCOREINIT", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            headers.Add(new HeaderCheker("SCOREDIFF", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));

            headers.Add(new HeaderCheker("COURSE", new string[] { "[0-7]+$", "(easy|normal|hard|oni|edit|tower|dan)" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            //headers.Add(new HeaderCheker("COURSE", new string[] { "[0-6]+", "(easy|normal|hard|oni|edit|tower)" },Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            //headers.Add(new HeaderCheker("COURSE", new string[] { @"[0-7]+", "(easy|normal|hard|oni|edit|tower|dan)" }, Simulator.TJAPlayer3));

            headers.Add(new HeaderCheker("STYLE", new string[] { @"[1-2]+$", "(single|double|couple)" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoWeb_Bui));

            headers.Add(new HeaderCheker("GAME", new string[] { @"(taiko|jube)$" }, Simulator.Taikojiro | Simulator.Taikojiro2));

            headers.Add(new HeaderCheker("LIFE", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2));

            headers.Add(new HeaderCheker("DEMOSTART", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));

            headers.Add(new HeaderCheker("SIDE", new string[] { @"[1-2]+", "(single|double|couple)$" }, Simulator.Taikojiro | Simulator.Taikojiro2));

            headers.Add(new HeaderCheker("SCOREMODE", new string[] { @"[0-2]+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));

            headers.Add(new HeaderCheker("TOTAL", new string[] { @"\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2));
            #endregion

            #region TJAP2fPC、TJAP3専用ヘッダ
            for (int i = 1; i <= 3; i++)
            {
                headers.Add(new HeaderCheker("EXAM" + i, new string[] { @"(g|jp|jg|jb|s|r|h|c),\d+,\d+,(m|l)$" }, Simulator.TJAPlayer3));
            }
            var ptn = new string[] { "NOR", "EXP", "MAS" };
            for (int i = 0; i < ptn.Length; i++)
            {
                headers.Add(new HeaderCheker("BALLOON" + ptn[i], new string[] { @"\d+$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            }
            headers.Add(new HeaderCheker("GENRE", new string[] { @".+$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            headers.Add(new HeaderCheker("MOVIEOFFSET", new string[] { @"\d+(.\d+)?$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            headers.Add(new HeaderCheker("BGIMAGE", new string[] { @".+$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            headers.Add(new HeaderCheker("BGMOVIE", new string[] { @".+$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            headers.Add(new HeaderCheker("HIDDENBRANCH", new string[] { @".+$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            #endregion


            return headers;
        }
    }
}
