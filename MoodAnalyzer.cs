using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Reflections
{
    public class MoodAnalyzer
    {
        public string message;
        public string happy = "I am happy";
        public string sad = "I am sad";

        public MoodAnalyzer()
        {

        }

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            if (string.IsNullOrEmpty(this.message))
            {
                throw new MoodAnalysisException("Exception Raised: No message was passed to determine user's mood!");
            }
            else if (this.message.Contains("happy"))
            {
                return "happy";
            }
            else if (this.message.Contains("sad"))
            {
                return "sad";
            }
            return "";
        }
    }
}
