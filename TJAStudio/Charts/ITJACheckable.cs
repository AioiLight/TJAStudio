namespace TJAStudio
{
    /// <summary>
    /// TJAフォーマットの検証用インターフェイス。
    /// </summary>
    internal interface ITJACheckable
    {
        void CheckFormat(string text);

        bool IsAvailable(Simulator simulator);

        Simulator Simulator { get; }
        string[] Format { get; }
        string Name { get; }
    }
}