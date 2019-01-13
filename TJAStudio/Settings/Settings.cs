using System.Drawing;
using System.Xml.Serialization;

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

        public EditorColorScheme ColorScheme { get; set; } = new EditorColorScheme();

        [XmlIgnore]
        public Color Editor_ForeColor { get; set; } = Color.Black;
        [XmlIgnore]
        public Color Editor_BackColor { get; set; } = Color.White;

        [XmlElement("Editor_ForeColor")]
        public string _Editor_ForeColor
        {
            // 文字列との相互変換はお好みで
            get { return ColorTranslator.ToHtml(Editor_ForeColor); }
            set { Editor_ForeColor = ColorTranslator.FromHtml(value); }
        }
        [XmlElement("Editor_BackColor")]
        public string _Editor_BackColor
        {
            // 文字列との相互変換はお好みで
            get { return ColorTranslator.ToHtml(Editor_BackColor); }
            set { Editor_BackColor = ColorTranslator.FromHtml(value); }
        }

    }

    public class EditorColorScheme
    {
        public EditorColorScheme()
        {
            //デフォルト値の設定
            Don.ForeColor = Color.Red;
            Don.BackColor = Color.Transparent;
            Ka.ForeColor = Color.Blue;
            Ka.BackColor = Color.Transparent;
            Space.ForeColor = Color.DimGray;
            Space.BackColor = Color.Transparent;
            Other.ForeColor = Color.Black;
            Other.BackColor = Color.Transparent;
            Roll.ForeColor = Color.White;
            Roll.BackColor = Color.Orange;
            Balloon.ForeColor = Color.White;
            Balloon.BackColor = Color.Tomato;
            Comment.ForeColor = Color.Green;
            Comment.BackColor = Color.Transparent;
            Keyword.ForeColor = Color.Blue;
            Keyword.BackColor = Color.Transparent;
            Command.ForeColor = Color.Brown;
            Command.BackColor = Color.Transparent;
            Parameter.ForeColor = Color.Brown;
            Parameter.BackColor = Color.Transparent;
        }

        public ColorFormat Don { get; set; } = new ColorFormat();
        public ColorFormat Ka { get; set; } = new ColorFormat();
        public ColorFormat Space { get; set; } = new ColorFormat();
        public ColorFormat Other { get; set; } = new ColorFormat();
        public ColorFormat Roll { get; set; } = new ColorFormat();
        public ColorFormat Balloon { get; set; } = new ColorFormat();
        public ColorFormat Comment { get; set; } = new ColorFormat();
        public ColorFormat Keyword { get; set; } = new ColorFormat();
        public ColorFormat Command { get; set; } = new ColorFormat();
        public ColorFormat Parameter { get; set; } = new ColorFormat();
    }
    public class ColorFormat
    {
        [XmlIgnore]
        public Color ForeColor { get; set; }
        [XmlIgnore]
        public Color BackColor { get; set; }

        public string _ForeColor
        {
            // 文字列との相互変換はお好みで
            get { return ColorTranslator.ToHtml(ForeColor); }
            set { ForeColor = ColorTranslator.FromHtml(value); }
        }
        public string _BackColor
        {
            // 文字列との相互変換はお好みで
            get { return ColorTranslator.ToHtml(BackColor); }
            set { BackColor = ColorTranslator.FromHtml(value); }
        }
    }
}
