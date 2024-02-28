using CSharp2_23_02;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountVowels_Returns_Correct_Count()
        {
            string sentence = "This is a test sentence.";

            int count = Program.CountVowels(sentence);

            Assert.AreEqual(7, count);
        }

        [TestMethod]
        public void CountVowels_With_No_Vowels_Returns_Zero()
        {
            string sentence = "C# programming is fun.";

            int count = Program.CountVowels(sentence);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountVowels_With_Empty_String_Returns_Zero()
        {
            string sentence = "";

            int count = Program.CountVowels(sentence);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CountVowels_With_Null_String_Returns_Zero()
        {
            string sentence = null;

            int count = Program.CountVowels(sentence);

            Assert.AreEqual(0, count);
        }
    }
}
