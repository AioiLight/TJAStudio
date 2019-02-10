using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJAStudio.Charts
{
    public static class Commands
        {
        public static List<CommandCheker> GetCommands()
        {
            var commands = new List<CommandCheker> ();

            #region 次郎のReadmeにあるやつ
            commands.Add(new CommandCheker("BPMCHANGE", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("GOGOSTART", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("GOGOEND", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("MEASURE", new string[] { @"\d+(.\d+)?/\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("SCROLL", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("DELAY", new string[] { @"\d+(.\d+)?$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));

            commands.Add(new CommandCheker("SECTION", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("BRANCHSTART", new string[] { @"(r|p|s),\d+,\d+$" }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("N", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("E", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("M", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("LEVELHOLD", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("BMSCROLL", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2));
            commands.Add(new CommandCheker("HBSCROLL", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2));
            commands.Add(new CommandCheker("BARLINEOFF", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            commands.Add(new CommandCheker("BARLINEON", new string[] { null }, Simulator.Taikojiro | Simulator.Taikojiro2 | Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3 | Simulator.TaikoDaijiro2 | Simulator.TaikoWeb_Bui));
            #endregion

            #region TJAP2fPC、TJAP3専用ヘッダ
            commands.Add(new CommandCheker("LYRIC", new string[] { @".*$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            commands.Add(new CommandCheker("DIRECTION", new string[] { @"\d+(.\d+)?$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            commands.Add(new CommandCheker("SUDDEN", new string[] { @"\d+(.\d+)? d+(.\d+)?$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            commands.Add(new CommandCheker("JPOSSCROLL", new string[] { @"(0|1) \d+(.\d+)? d+(.\d+)?$" }, Simulator.TJAPlayer2fPC | Simulator.TJAPlayer3));
            commands.Add(new CommandCheker("SENOTECHANGE", new string[] { @"\d+$" }, Simulator.TJAPlayer3));
            commands.Add(new CommandCheker("NEXTSONG", new string[] { @".*,.*,.*,.*,.*,.*$" }, Simulator.TJAPlayer3));
            #endregion


            return commands;
        }
    }
}
