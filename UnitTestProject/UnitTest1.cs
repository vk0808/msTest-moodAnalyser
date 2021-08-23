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
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
