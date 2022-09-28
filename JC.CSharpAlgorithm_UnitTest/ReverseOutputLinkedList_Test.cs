using LinkedList;

namespace JC.CSharpAlgorithm_UnitTest
{
    [TestClass]
    public class ReverseOutputLinkedList_Test
    {
        [TestMethod]
        public void DoTest_1()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i); 
            }
            var result = ReverseOutputLinkedList.Reverse1(list);
            string expected = "9876543210";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_2()
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
            }
            var result = ReverseOutputLinkedList.Reverse2(list);
            string expected = "9876543210";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoTest_3()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            var reverseList = ReverseOutputLinkedList.Reverse3(list); 
            var reReverseList = ReverseOutputLinkedList.Reverse3(reverseList);
            var assertResult = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (reverseList[i] != reReverseList[i])
                {
                    assertResult = false;
                }
            }
            Assert.IsTrue(assertResult);
        }
    }
}
