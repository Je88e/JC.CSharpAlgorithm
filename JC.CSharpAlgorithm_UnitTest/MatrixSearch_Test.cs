
namespace JC.CSharpAlgorithm_UnitTest
{
    [TestClass]
    public class MatrixSearch_Test
    {
        [TestMethod]
        public void DoTest_1()
        {
            //int[,] matrix = { { 1, 2, 8, 9 }, { 2, 4, 9, 12 }, { 4, 7, 10, 13 }, { 6, 8, 11, 15 } };
            int[][] matrix = new [] { new[] { 1, 2, 8, 9 }, new[] { 2, 4, 9, 12 }, new[] { 4, 7, 10, 13 }, new[] { 6, 8, 11, 15 } }; 
            var result = MatrixSearch.Find(matrix, 7);

            Assert.AreEqual(true, result);
            
        }
    }
}