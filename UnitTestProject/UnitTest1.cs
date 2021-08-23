using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyseMood;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
