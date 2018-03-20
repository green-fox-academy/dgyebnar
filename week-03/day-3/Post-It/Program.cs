using System;

namespace Post_It
{
    class Program
    {

        public struct PostIt
        {
            public string backgroundColor;
            public string text;
            public string textColor;

        }

        static void Main(string[] args)
        {
            PostIt postit1;
            PostIt postit2;
            PostIt postit3;
            postit1.backgroundColor = "orange";
            postit1.textColor = "blue";
            postit1.text = "Idea1";

            postit2.backgroundColor = "pink";
            postit2.textColor = "black";
            postit2.text = "Awesome";

            postit3.backgroundColor = "yellow";
            postit3.textColor = "green";
            postit3.text = "Superb";
        }
    }
}
