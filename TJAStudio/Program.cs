using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 起動前処理
            EXEPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SettingFileName = EXEPath + @"/Settings.xml";
            #region 設定ファイルの読み込み
            if (System.IO.File.Exists(SettingFileName))
            {
                // 設定ファイルがあればそれを読み込む。
                Setting = SettingsManager.GetSettings(SettingFileName);
            }
            else
            {
                // なければ新規にnew。
                Setting = new Setting();
            }
            #endregion
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            #region 終了処理
            SettingsManager.SetSettings(SettingFileName, Setting);
            #endregion
        }
        /// <summary>
        /// 設定管理クラス。性的。
        /// </summary>
        public static Setting Setting { get; set; }
        /// <summary>
        /// TJAStudio.exeのディレクトリ。
        /// </summary>
        public static string EXEPath { get; private set; }
        /// <summary>
        /// 設定ファイルのパス。
        /// </summary>
        public static string SettingFileName { get; private set; }
    }
}
