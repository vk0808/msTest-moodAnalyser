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

        /// <summary>
        /// for TC-3.2
        /// </summary>
        [TestMethod]
        public void WhenGivenMoodEmpty_ShouldThrowException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
                string mood = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }

        }

        /// <summary>
        /// for TC-4.1, 4.2, 4.3
        /// </summary>
        [TestMethod]
        [DataRow("AnalyseMood.MoodAnalyser")]
        [DataRow("AnalyseMoo.MoodAnalyser")]
        [DataRow("AnalyseMood.MoodAnalyse")]
        public void WhenGivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject(string className)
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse(className, "MoodAnalyser");
            expected.Equals(obj);

        }

        /// <summary>
        /// for TC-5.1, 5.2, 5.3
        /// </summary>
        [TestMethod]
        [DataRow("AnalyseMood.MoodAnalyser", "MoodAnalyser")]
        [DataRow("AnalyseMoo.MoodAnalyser", "MoodAnalyser")]
        [DataRow("AnalyseMood.MoodAnalyser", "MoodAnalyserr")]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor(string className, string ctorPara)
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor(className, ctorPara, "SAD");
            expected.Equals(obj);
        }
    }
}
