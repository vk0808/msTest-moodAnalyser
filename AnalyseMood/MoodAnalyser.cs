using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyseMood
{
    public class MoodAnalyser
    {
        // instance variable
        private string message;

        // default constructor
        public MoodAnalyser()
        {
        }

        // parameterised constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        // method to analyse mood
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
