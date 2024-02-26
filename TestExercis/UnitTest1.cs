using CSharp2_23_02;

namespace TestExercis
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetEvenNumbers()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new int[] { 2, 4, 6, 8, 10 };
            int[] actual = CSharp2_23_02.Exercise1.GetEvenNumbers(arr);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestGetOddNumbers()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new int[] { 1, 3, 5, 7, 9 };
            int[] actual = CSharp2_23_02.Exercise1.GetOddNumbers(arr);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void TestGetUniqueNumbers()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = CSharp2_23_02.Exercise1.GetUniqueNumbers(arr);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
