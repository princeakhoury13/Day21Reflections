using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Reflections
{
    public class MoodAnalyzerFactory
    {
        public static AnalyzeMood CreateMoodAnalyzer()
        {
            try
            {
                Type type = Type.GetType("Day21Reflections.AnalyzeMood");
                AnalyzeMood moodAnalyzer = (AnalyzeMood)Activator.CreateInstance(type);
                return moodAnalyzer;
            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalysisException("Exception Raised: Class not found!");
            }
            catch (Exception)
            {
                throw new MoodAnalysisException("Exception Raised: Constructor is not found!");
            }
        }
    }
}
