using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    internal class TextPost : Post
    {
        private string _text;
        public string Text { get { return _text; } set { _text = value; } }
        /*
        public TextPost(string author, string text)
        {
            _text = text;
        }
        */
        
    }
}
