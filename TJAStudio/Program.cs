using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace TJAStudio
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            #region 起動前処理
            EXEPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            SettingFileName = EXEPath + @"\Settings.xml";
            Version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, Assembly.GetExecutingAssembly().GetName().Version.ToString().Length - 4);
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
            CultureInfo.CurrentUICulture = new CultureInfo(Setting.Locale, false);
            #endregion
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(args.Length != 0 && !string.IsNullOrWhiteSpace(args[0]))
            {
                Application.Run(new Studio(args[0]));
            }
            else
            {
                Application.Run(new Studio());
            }
            #region 終了処理
            SettingsManager.SetSettings(SettingFileName, Setting);
            #endregion
        }
        public static string Version { get; private set; }
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
        /// <summary>
        /// プロジェクト。
        /// </summary>
        public static Projects Project { get; set; } = new Projects();
        /// <summary>
        /// ウィンドウマネージャ。
        /// </summary>
        public static WindowManager WindowManager { get; set; } = new WindowManager();
    }
}
