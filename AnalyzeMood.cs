using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Reflections
{
    public class AnalyzeMood
    {
        public string message;
        public string happy = "I am happy";
        public string sad = "I am sad";
        public AnalyzeMood()
        {
            // Default constructor
        }

        public AnalyzeMood(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalysisException("Exception Raised: No message was passed to determine user's mood!");
            }
            this.message = message;
        }

        public string Analyze(string message)
        {
            if (this.message == happy)
            {
                return "Happy";
            }
            else if (this.message == sad)
            {
                return "Sad";
            }
            return "Happy";
        }
    }
}
