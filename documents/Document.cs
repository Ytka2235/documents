using System;
using System.Linq;
using System.Text;

namespace documents
{
    internal class Document
    {
        public string id;
        public string title;
        public string content;
        public string vid;
        public string tip;
        public string date;
        public string path;


        public Document(string id, string title, string date, string tip, string vid, string content, string path)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.vid = vid;
            this.tip = tip;
            this.date = date;
            this.path = path;
        }
    }
}
