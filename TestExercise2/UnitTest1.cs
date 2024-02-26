using CSharp2_23_02;
namespace TestExercise2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountElementsGreaterThan()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int threshold = 3;
            int expected = 2;
            int actual = Exercise2.CountElementsGreaterThan(arr, threshold);
            Assert.AreEqual(expected, actual);
        }

    }
}