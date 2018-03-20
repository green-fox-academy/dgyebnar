using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogPost1 = new BlogPost();
            BlogPost blogpost2 = new BlogPost();
            BlogPost blogpost3 = new BlogPost();

            blogPost1.AuthorName = "John Doe";
            blogPost1.Title = "Lorem Ipsum";
            blogPost1.Text = "Lorem ipsum dolor sit amet.";
            blogPost1.PublicationDate = "2000.05.04.";

            blogpost2.AuthorName = "Tim Urban";
            blogpost2.Title = "Wait but why";
            blogpost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogpost2.PublicationDate = "2017.03.28.";

            blogpost3.AuthorName = "William Turton";
            blogpost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogpost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            blogpost3.PublicationDate = "2017.03.28.";
        }

        public class BlogPost
        {
           public string AuthorName;
           public string Title;
           public string Text;
           public string PublicationDate;
        } 
    }
}
