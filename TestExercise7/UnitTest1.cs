using CSharp2_23_02;


namespace TestExercise7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseWordsInSentence_Returns_Correct_Result()
        {
            string sentence = "sun cat dogs cup tea";

            string reversedSentence = Program.ReverseWordsInSentence(sentence);

            Assert.AreEqual("tea cup dogs cat sun", reversedSentence);
        }

        [TestMethod]
        public void ReverseWordsInSentence_With_Empty_String_Returns_Empty_String()
        {
            string sentence = "";

            string reversedSentence = Program.ReverseWordsInSentence(sentence);

            Assert.AreEqual("", reversedSentence);
        }

        [TestMethod]
        public void ReverseWordsInSentence_With_Null_String_Returns_Null_String()
        {
            string sentence = null;

            string reversedSentence = Program.ReverseWordsInSentence(sentence);

            Assert.IsNull(reversedSentence);
        }
    }
}
