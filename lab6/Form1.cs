using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void ClearInputs()
        {
            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtBookID.Clear();
            txtSearchTitle.Clear();
        }

 
        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => pgBar.Value = value);
            btnFetchBooks.Enabled = false;

            listBoxBooks.DataSource = await FetchDataFromDbAsync(progress);

            
            listBoxBooks.DisplayMember = "";

            btnFetchBooks.Enabled = true;
        }

        private async Task<List<Book>> FetchDataFromDbAsync(IProgress<int> progress)
        {
            using (var db = new LibraryContext())
            {
                progress.Report(20);
                var list = await db.Books.Include(b => b.Author).ToListAsync();
                progress.Report(100);
                return list;
            }
        }


        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                var author = new Author { Name = txtAuthorName.Text };
                var book = new Book { Title = txtBookTitle.Text, Author = author };

                await db.AddAsync(book);
                await db.SaveChangesAsync();

                MessageBox.Show("New book and author added.");
                ClearInputs(); // Clears textboxes after adding
            }
        }

  
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int id))
            {
                using (var db = new LibraryContext())
                {
                    var book = await db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == id);
                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;
                        book.Author.Name = txtAuthorName.Text;

                        await db.SaveChangesAsync();
                        MessageBox.Show("Book and Author updated.");
                        ClearInputs(); // Clears textboxes after updating
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");
                    }
                }
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int id))
            {
                using (var db = new LibraryContext())
                {
                    var book = await db.Books.FindAsync(id);
                    if (book != null)
                    {
                        db.Books.Remove(book);
                        await db.SaveChangesAsync();

                        MessageBox.Show("Book deleted.");
                        ClearInputs(); // Clears textboxes after deleting
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");
                    }
                }
            }
        }

        
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new LibraryContext())
            {
                var searchResults = await db.Books
                    .Include(b => b.Author) // Ensure author data is loaded for the search
                    .Where(b => b.Title.Contains(txtSearchTitle.Text))
                    .ToListAsync();

                listBoxBooks.DataSource = searchResults;
              
            }
        }
    }
}