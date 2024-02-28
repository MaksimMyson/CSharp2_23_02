using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp2_23_02;

namespace Test9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountOccurrences_Returns_Correct_Count()
        {
            string inputString = "Why she had to go. I don't know, she wouldn't say";
            string searchString = "she";

            int count = Program.CountOccurrences(inputString, searchString);

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void CountOccurrences_With_Empty_String_Returns_Zero()
        {
            string inputString = "";
            string searchString = "she";

            int count = Program.CountOccurrences(inputString, searchString);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountOccurrences_With_Null_String_Returns_Zero()
        {
            string inputString = null;
            string searchString = "she";

            int count = Program.CountOccurrences(inputString, searchString);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountOccurrences_With_No_Match_Returns_Zero()
        {
            string inputString = "This is a test string";
            string searchString = "not found";

            int count = Program.CountOccurrences(inputString, searchString);

            Assert.AreEqual(0, count);
        }
    }
}
