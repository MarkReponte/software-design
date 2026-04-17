using static lab4.Form1;

namespace TestProject3
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
    }
}
