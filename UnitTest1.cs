using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void SadMood() //TC 1.1 SAD MOOD
        {
          
            string message = "I am in Sad Mood ";
            string expected = "SAD";
            MoodAnalysing moodAnalysing = new MoodAnalysing(message);

            //Act
            string mood = moodAnalysing.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void HappyMood()//T.C2 HAPPY MOOD
        {

            string message = "I am in Happy Mood ";
            string expected = "HAPPY";
            MoodAnalysing moodAnalysing = new MoodAnalysing(message);

            string mood = moodAnalysing.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
