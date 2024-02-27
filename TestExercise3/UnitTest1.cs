using CSharp2_23_02;
namespace TestExercise3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountSequenceOccurrences_ReturnsCorrectCount_WhenSequencePresent()
        {

            int[] array = new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 };
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;


            int count = Exercise3.CountSequenceOccurrences(array, num1, num2, num3);


            Assert.AreEqual(3, count);
        }
    }
}