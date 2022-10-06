using FootballLibrary;

namespace FootballLibraryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FootballPlayerWorking()
        {
            FootballPlayer test1 = new FootballPlayer(12, "sophus", 22, 1);
            Assert.IsNotNull(test1);
        }
        [TestMethod]
        public void FootballPlayerException1()
        {
            FootballPlayer test2 = new FootballPlayer(12, "s", 22, 2);
            Assert.ThrowsException<ArgumentException>(() => test2.Validator());
        }
        [TestMethod]
        public void FootballPlayerException2()
        {
            FootballPlayer test3 = new FootballPlayer(12, "sophus", 22, 101);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => test3.Validator());

        }
        [TestMethod]
        public void FootballPlayerException3()
        {
            FootballPlayer test4 = new FootballPlayer(12, "sophus", 22, -10);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => test4.Validator());
        }
    }
}