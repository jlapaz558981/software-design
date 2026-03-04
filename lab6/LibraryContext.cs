using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace with your actual connection string
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LibraryDb;Trusted_Connection=True;");
    }
}