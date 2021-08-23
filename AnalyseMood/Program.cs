using System;

namespace AnalyseMood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser");

            MoodAnalyser mood = new MoodAnalyser("sad");
            Console.WriteLine(mood.AnalyseMood());
        }
    }
}
