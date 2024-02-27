using CSharp2_23_02;

namespace TestExercise4
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]

        public void MergeArrays()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 10 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = Exercise4.MergeArrays(arr1, arr2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MergeArrays2()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            int[] actual = Exercise4.MergeArrays(arr1, arr2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void MergeArrays3()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] actual = Exercise4.MergeArrays(arr1, arr2);
            CollectionAssert.AreEqual(expected, actual);
        }

        

       

       
    }
}