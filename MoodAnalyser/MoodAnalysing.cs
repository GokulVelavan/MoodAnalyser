using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysing
    {
        public string message;

        public MoodAnalysing(string message) //constructor
        {
            this.message = message;
        }

        public string AnalyseMood() //program to find
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
