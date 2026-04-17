using static lab4.Form1;

namespace TestProject5
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book("C# Programming", "John Smith");
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }
    }
}
