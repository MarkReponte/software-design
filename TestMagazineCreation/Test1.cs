
using static lab4.Form1;

namespace TestMagazineCreation
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);
        }
    }
}
