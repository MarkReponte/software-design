using System.Reflection;
using static lab4.Form1;

namespace TestInvalidMagazineCreation
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Magazine magazine = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };
        }
    }
}
