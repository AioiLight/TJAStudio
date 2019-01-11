namespace TJAStudio
{
    /// <summary>
    /// 設定を管理するクラス。
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// UIの言語。
        /// </summary>
        public string Locale { get; set; } = "ja";
        /// <summary>
        /// テキスト表示に使用するフォント名。
        /// </summary>
        public string FontName { get; set; } = "MS Gothic";
    }
}
