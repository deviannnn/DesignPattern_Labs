using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSService
{
    public class Post
    {
        private string title { get; set; }
        private string content { get; set; }
        //getter, setter, constructor below

        public Post(string title, string content)
        {
            this.title = title;
            this.content = content;
        }
    }
}
