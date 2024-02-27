using CSharp2_23_02;

namespace TestExercise5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateArra()
        {
            int[,] arr = Exercise5.GenerateArray(5);
            Assert.AreEqual(5, arr.GetLength(0));
            Assert.AreEqual(5, arr.GetLength(1));
        }

        [TestMethod]

        public void TestGetMin()
        {
            int[,] arr = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            Assert.AreEqual(1, Exercise5.GetMin(arr));
        }

        [TestMethod]

        public void TestGetMax()
        {
            int[,] arr = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            Assert.AreEqual(25, Exercise5.GetMax(arr));
        }
    }
}