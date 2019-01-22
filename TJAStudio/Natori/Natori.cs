using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TJAStudio
{
    /// <summary>
    /// NatoriSanaChaaaaaaaaaaan!!!!!!!!
    /// Ahhhhhh!! SanaChaaaaaaaan!!!!!!!
    /// </summary>
    public class Natori
    {
        public Natori(string input)
        {
            if (!string.IsNullOrEmpty(input)) Init(input);
        }

        private void Init(string input)
        {
            foreach (var item in Regex.Split(input, "\r\n"))
            {
                Result.Add(new NatoriInfo(item));
            }
            foreach (var item in Result)
            {
                if (Regex.Replace(item.Text, " *//.*", "").Contains(":"))
                {
                    item.Type = LineType.Header;
                }
                else if (Regex.Replace(item.Text, " *//.*", "").StartsWith("#"))
                {
                    item.Type = LineType.Command;
                }
                else
                {
                    item.Type = LineType.Text;
                }
            }
            foreach (var item in Result)
            {
                if (item.Type == LineType.Text)
                {
                    item.Amount = Regex.Replace(item.Text, " *//.*", "").Trim().Length;
                    var notesCount = 0;
                    foreach (var measure in Regex.Replace(item.Text, " *//.*", "").Trim())
                    {
                        if (Regex.IsMatch(measure.ToString(), "[123456789]"))
                        {
                            notesCount++;
                        }
                    }
                    item.NotesAmount = notesCount;
                }
            }
        }

        public Natori(List<Header> input)
        {
            var constructor = "";
            foreach (var item in input)
            {
                constructor += String.Format("{0}:{1}", item.Name, item.Value) + Environment.NewLine;
            }
            Init(constructor);
        }

        public Natori SelectByType(LineType lineType)
        {
            var result = new List<NatoriInfo>();
            foreach (var item in Result)
            {
                if (item.Type == lineType) result.Add(item);
            }
            Result = result;
            return this;
        }

        public Natori GetHeaderByName(string name)
        {
            var result = SelectByType(LineType.Header).Result;
            foreach (var item in result)
            {
                if (item.Text.StartsWith(name)) result.Add(item);
            }
            Result = result;
            return this;
        }

        public Natori GetCommandByName(string name)
        {
            var result = SelectByType(LineType.Command).Result;
            foreach (var item in result)
            {
                if (item.Text.StartsWith(name)) result.Add(item);
            }
            Result = result;
            return this;
        }

        public List<NatoriInfo> ToList()
        {
            return Result;
        }

        public List<NatoriInfo> Result { get; private set; } = new List<NatoriInfo>();
    }
}
