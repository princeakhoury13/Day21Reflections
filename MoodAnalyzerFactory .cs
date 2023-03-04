using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day21Reflections
{
    public class MoodAnalyzerFactory
    {
        public static MoodAnalyzer CreateMoodAnalyzerObject(string message)
        {
            Type type = Type.GetType("Day21Reflections.MoodAnalyzer");
            if (type == null)
            {
                throw new MoodAnalysisException("Class not found");
            }
            if (!typeof(MoodAnalyzer).IsAssignableFrom(type))
            {
                throw new MoodAnalysisException("Given class does not inherit MoodAnalyzer class");
            }
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
            object instance = constructor.Invoke(new object[] { message });
            return (MoodAnalyzer)instance;
        }
    }
}
