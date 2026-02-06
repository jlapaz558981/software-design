using System;


namespace lab4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"Generic Book: {Title} by {Author}";
        }
    }
}
