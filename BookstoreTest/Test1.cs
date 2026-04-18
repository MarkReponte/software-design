using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using static lab4.Form1;

namespace BookstoreTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new EBook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetDescription());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetDescription());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetDescription());
        }
    }
}
