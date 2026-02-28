using System.Windows.Forms;

namespace lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        public class Book
        {
            public string? Title { get; set; }

            public string? Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string Format { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook) - {Format}";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Textbook) - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public string Duration { get; set; } 
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (AudioBook) - {Duration} mins, Narrated by {Narrator}";
            }
        }
        private void DisplayBooks(List<Book> books)
        {
            listBox1.Items.Clear();
            foreach (Book b in books)
            {
                // Polymorphism in action: calling the same method name, 
                // but getting different behavior based on the object type.
                listBox1.Items.Add(b.GetInfo());
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<Book> myInventory = new List<Book>();

            myInventory.Add(new Book { Title="C# Programming", Author= "John Smith"});
            myInventory.Add(new Magazine { Title = "Tech Weekly",Author=  "Jane Doe", IssueNumber = 12 });
            myInventory.Add(new Ebook { Title = "C# for Beginners", Format = "PDF" });
            myInventory.Add(new Textbook { Title = "Calculus I", Subject = "Math" });
            myInventory.Add(new AudioBook { Title = "The Hobbit", Narrator = "Andy Serkis", Duration = "10 hours" });

            DisplayBooks(myInventory);
        }
        

    }
}
