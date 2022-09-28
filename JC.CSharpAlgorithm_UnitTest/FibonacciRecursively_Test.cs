namespace JC.CSharpAlgorithm_UnitTest
{
    [TestClass]
    public class FibonacciRecursively_Test
    {
        [TestMethod]
        public void DoTest_1()
        { 
            var result = FibonacciRecursively.Calc1(50);
            long expected = 12586269025;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_2()
        {
            var result = FibonacciRecursively.Calc2(50);
            long expected = 12586269025;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_3()
        {
            //通项公式
            var result = FibonacciRecursively.Calc3(50);
            long expected = 12586269025;
            Assert.AreEqual(expected, result);
        }
    }
}
