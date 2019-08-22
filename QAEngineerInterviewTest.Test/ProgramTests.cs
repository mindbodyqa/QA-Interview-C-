using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QAEngineerInterviewTest.Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SmokeTest()
        {
            Program.Main(null);
        }

        [TestMethod]
        public void GetAverageEldestTest()
        {
            Program.GetAverageEldestSpecies();
        }
    }
}
