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

        //[TestMethod]
        //public void NullCheck()//TC2.1 IF NULL RETURN HAPPY
        //{

        //  string message = null;
        // string expected = "HAPPY";

        //MoodAnalysing moodAnalysing = new MoodAnalysing(message);
        //string actual = moodAnalysing.AnalyseMood();

        //Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void ExceptionHandling()
        {
            string message = null;
            string expected = "Message is null";

            try
            {
                MoodAnalysing moodAnalysing = new MoodAnalysing(message);
                string actual = moodAnalysing.AnalyseMood();
            }

            catch (CustomException err)//cating the exception from main program
            {
                Assert.AreEqual(expected, err.Message);
            }
        }

        [TestMethod]

        public void ObjectareEqual()//return object are equal
        {
            string message = null;
            object expected = new MoodAnalysing(message);
            object obj = MoodAnalysingFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalysing", "MoodAnalysing");
            expected.Equals(obj);
        }

        [TestMethod]

        public void WrongClassName()//return wrong class name
        {
            try
            {
                string message = null;
                object expected = new MoodAnalysing(message);
                object obj = MoodAnalysingFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalysingWrong", "MoodAnalysingWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex1)
            {
                Assert.AreEqual("Class not found", ex1.Message);
            }
        }

        [TestMethod]

        public void WrongConstructor()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalysing(message);
                object obj = MoodAnalysingFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalysing", "MoodAnalysingWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex2)
            {
                Assert.AreEqual("Constructor not found", ex2.Message);
            }
        }

        [TestMethod]

        public void ParameterisedConstructor_ObjectAreEqual()//T.C5.1
        {
            object expected = new MoodAnalysing("HAPPY");
            object obj = MoodAnalysingFactory.CreateMoodAnalyseParaConstructor("MoodAnalyser.MoodAnalysing", "MoodAnalysing");
            expected.Equals(obj);
        }


        [TestMethod]

        public void ParameterisedConstructor_WrongClassName()//T.C5.2
        {
            try
            {
                object expected = new MoodAnalysing("HAPPY");
                object obj = MoodAnalysingFactory.CreateMoodAnalyseParaConstructor("MoodAnalyser.MoodAnalyserWrong", "MoodAnalysing");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }


        [TestMethod]
        public void ParameterisedConstructor_WrongConstrcutorName()//T.C5.3
        {
            try
            {
                object expected = new MoodAnalysing("HAPPY");
                object obj = MoodAnalysingFactory.CreateMoodAnalyseParaConstructor("MoodAnalyser.MoodAnalysing", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }
    }
}
