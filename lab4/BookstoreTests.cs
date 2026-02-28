using System;


namespace lab4
{
    [TestClass]
    public class BookstoreTests
    {
        [TestMethod]
        public void TestBookCreation()
        {
            // Arrange & Act
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };

            // Assert
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            // Arrange & Act
            Magazine magazine = new Magazine { Title = "Tech weekly", Author = "Jane Doe", IssueNumber = 12 };

            // Assert
            Assert.AreEqual("Tech weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }

        [TestMethod]
        public void TestPolymorphism()
        {
            Book[] books = new Book[]
            {
            new Book { Title = "C# Basics", Author = "John Doe" },
            new Magazine { Title = "Tech Weekly", IssueNumber = 12 },
            new Ebook { Title = "Learn Git", FileFormat = "PDF" }
            };

            Assert.AreEqual("Generic Book: C# Basics by John Doe", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn Git (Digital: PDF)", books[2].GetInfo());
        }

        [TestMethod]
        public void TestNegativeIssueNumber()
        {
            Magazine mag = new Magazine { Title = "Invalid", IssueNumber = -1 };

            string result = mag.GetInfo();

            Assert.AreEqual("Invalid Issue Number", result);
        }
    }
}
