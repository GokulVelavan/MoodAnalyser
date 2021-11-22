using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood analyser");
            MoodAnalysing obj = new MoodAnalysing("I Am sad");
            Console.WriteLine(obj.AnalyseMood());
        }
    }
}
