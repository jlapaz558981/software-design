using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Author
{
    public int AuthorID { get; set; }
    public string? Name { get; set; }
    public ICollection<Book> Books { get; set; }
}

public class Book
{
    public int BookID { get; set; }
    public string? Title { get; set; }
    public int AuthorID { get; set; }
    public Author Author { get; set; }


    public override string ToString()
    {
       
        string authorName = Author != null ? Author.Name : "Unknown";
        return $"{BookID} - {Title} - {authorName}";
    }
}