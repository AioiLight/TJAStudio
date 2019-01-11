using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TJAStudio
{
    public class Course
    {
        public string Name;
        public List<Header> Header;
        [XmlIgnore]
        public Sgry.Azuki.Document Document;
        public string Text;
    }
}
