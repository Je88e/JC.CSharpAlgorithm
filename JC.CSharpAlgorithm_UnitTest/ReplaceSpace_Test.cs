namespace JC.CSharpAlgorithm_UnitTest
{
    [TestClass]
    public class ReplaceSpace_Test
    {
        [TestMethod]
        public void DoTest_1()
        { 
            var result = ReplaceSpace.Replace1();
            string expected = "How%20Are%20You?";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_2()
        {
            string text = "How Are You?";
            var result = ReplaceSpace.Replace2(text);
            string expected = "How%20Are%20You?";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_3()
        {
            string text = "How Are You?";
            var result = ReplaceSpace.Replace3(text);
            string expected = "How%20Are%20You?";
            Assert.AreEqual(expected, result);
        }
    }
}
