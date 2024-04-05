using ConsoleApp9;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.CalculateGrade(70), 5);
            Assert.AreEqual(Program.CalculateGrade(40), 4);
            Assert.AreEqual(Program.CalculateGrade(20), 3);
            Assert.AreNotEqual(Program.CalculateGrade(100), 2);
        }
    }
}