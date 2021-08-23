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
                if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {

                return "HAPPY";
            }
        }
    }
}
