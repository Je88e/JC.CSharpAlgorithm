using JC.CSharpAlgorithm;
using LinkedList;
using System.Text;

namespace JC.CSharpAlgorithm_UnitTest
{
    [TestClass]
    public class TwoStackQueue_Test
    {
        [TestMethod]
        public void DoTest_1()
        {
            TwoStackQueue1<int> queue = new TwoStackQueue1<int>();
            for (int i = 0; i < 10; i++)
            { 
                queue.AppendTail(i);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(queue.DeleteHead());
            } 
            var result = sb.ToString();
            string expected = "0123456789";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_2()
        {
            TwoStackQueue2<int> queue = new TwoStackQueue2<int>();
            for (int i = 0; i < 10; i++)
            {
                queue.AppendTail(i);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(queue.DeleteHead());
            }
            var result = sb.ToString();
            string expected = "0123456789";
            Assert.AreEqual(expected, result);
        } 
    }
}
