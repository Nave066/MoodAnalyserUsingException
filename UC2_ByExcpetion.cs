using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserUsingException
{
    internal class UC2_ByExcpetion
    {
        string message;
        public UC2_ByExcpetion(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
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
            catch (NullReferenceException)
            {
                return "happy";

            }
        }
    }
}
