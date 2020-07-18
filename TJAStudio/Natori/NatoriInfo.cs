namespace TJAStudio
{
    public class NatoriInfo
    {
        public NatoriInfo(string text)
        {
            Text = text;
            Type = null;
            Amount = null;
            NotesAmount = null;
        }

        public string Text { get; set; }
        public LineType? Type { get; set; }
        public int? Amount { get; set; }
        public int? NotesAmount { get; set; }
    }

    public enum LineType
    {
        Header,
        Command,
        Text
    }
}