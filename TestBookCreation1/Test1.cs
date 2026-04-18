using System.Net;
using System.Reflection;
using static lab4.Form1;

namespace TestBookCreation1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
    }
}
