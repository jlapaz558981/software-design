using System.Data.Entity;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Author
        {

            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book>? Books { get; set; }

        }

        public class Book
        {
            public int BookID { get; set; }
            public string? Title { get; set; }

            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };

                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();

            }

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddAuthorWithBook(txtAuthorName.Text, txtBookTitle.Text);
        }

        public List<string> GetBooksWithAuthors()
        {

            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();

                return booksWithAuthors;
            }


        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }

        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {

                var book = context.Books
                                  .Include("Author")
                                  .FirstOrDefault(b => b.BookID == bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found!");
                    return;
                }

                book.Title = newTitle;

                if (book.Author != null)
                {
                    book.Author.Name = newAuthorName;
                }
                else
                {
                    var author = context.Authors.Find(book.AuthorID);
                    if (author != null)
                    {
                        author.Name = newAuthorName;
                    }
                }
                context.SaveChanges();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt16(txtBookID.Text);
            UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Authorupdated successfully.");
        }
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Book ID not found.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
            }
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .ToList()
                    .Select(b => $"{b.Title}")
                    .ToList();
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            var results = SearchBooksByAuthor(txtAuthorName.Text);
            listBoxBooks.DataSource = results;

            if (results.Count == 0)
                MessageBox.Show("No books found for this author.");
        }
    }
}
