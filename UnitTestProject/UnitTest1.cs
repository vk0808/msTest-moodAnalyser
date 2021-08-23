using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyseMood;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// for TC-1.1, 1.2
        /// </summary>
        [TestMethod]
        public void WhenGivenMoodSad_ShouldReturnSad()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// for TC-1.1(repeat), 1.2(repeat), 2.1
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void WhenGivenThrDataRow_ShouldReturnHappy(string message)
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// for TC-3.1
        /// </summary>
        [TestMethod]
        public void WhenGivenMoodNull_ShouldThrowException()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

                //Act
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);
            }

        }
    }
}
