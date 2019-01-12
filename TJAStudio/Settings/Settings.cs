﻿using System.Drawing;

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

        public ColorFormat Don { get; set; }
        public ColorFormat Ka { get; set; }
        public ColorFormat Space { get; set; }
        public ColorFormat Other { get; set; }
        public ColorFormat Roll { get; set; }
        public ColorFormat Balloon { get; set; }
        public ColorFormat Comment { get; set; }
        public ColorFormat Keyword { get; set; }
        public ColorFormat Command { get; set; }
        public ColorFormat Parameter { get; set; }
    }
    public class ColorFormat
    {
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
    }
}
