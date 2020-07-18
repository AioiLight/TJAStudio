namespace TJAStudio.DanMarge
{
    public class Songs
    {
        public string FilePath { get; set; }
        public string Chart { get; set; }
        public string Course { get; set; }
        public string DemoStart { get; set; }
        public string ScoreMode { get; set; } = "2";
        public string Level { get; set; } = "1";
        public string Balloon { get; set; }
        public string BPM { get; set; }
        public string Offset { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Genre { get; set; }
        public string Wave { get; set; }
        public int ScoreInit { get; set; }
        public int ScoreDiff { get; set; }

        public override string ToString()
        {
            return string.Format("#NEXTSONG {0},{1},{2},{3},{4},{5}\r\n#BPMCHANGE {6}\r\n#MEASURE 4/4\r\n#SCROLL 1.0\r\n#DELAY {7}\r\n{8}", Title, SubTitle, Genre, Wave, ScoreInit, ScoreDiff, BPM, Offset, Chart);
        }
    }
}