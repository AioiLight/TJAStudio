using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TJAStudio
{
    public static class SettingsManager
    {
        /// <summary>
        /// 設定をファイルへ保存します。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <param name="setting">Settingクラスのインスタンス。</param>
        public static void SetSettings(string fileName, Setting setting)
        {
            var serializer = new XmlSerializer(typeof(Setting));
            using (var streamWriter = new StreamWriter(fileName, false, new UTF8Encoding(false)))
            {
                serializer.Serialize(streamWriter, setting);
                serializer = null;
            }
        }

        /// <summary>
        /// 設定をファイルから読み込みます。
        /// </summary>
        /// <param name="fileName">ファイル名。</param>
        /// <returns>Settingクラスのインスタンス。</returns>
        public static Setting GetSettings(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Setting));
            using (var streamReader = new StreamReader(fileName, new UTF8Encoding(false)))
            {
                var setting = (Setting)serializer.Deserialize(streamReader);
                serializer = null;
                return setting;
            }
        }
    }
}