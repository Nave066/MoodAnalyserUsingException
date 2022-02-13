using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUsingException
{
    public class UC1_MoodAnalyzing
    {
        string message;
        public UC1_MoodAnalyzing(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
