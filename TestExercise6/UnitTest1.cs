using CSharp2_23_02;

namespace TestExercise6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CountLetters_Returns_Correct_Count()
        {
            
            string sentence = "Це тестове речення з 1234567 символами.";

            
            int count = Exercise6.CountLetters(sentence);

            Assert.AreEqual(1, count);
        }

        [TestMethod]

        public void CountLetters_With_Empty_String_Returns_Zero()
        {
            string sentence = "";
    
                
                int count = Exercise6.CountLetters(sentence);
    
                Assert.AreEqual(0, count);
        }

        [TestMethod]

        public void CountLetters_With_Null_String_Returns_Zero()
        {
            string sentence = null;
    
                
                int count = Exercise6.CountLetters(sentence);
    
                Assert.AreEqual(0, count);
        }
    }
}