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


        public static string InvokeAnalyzeMoodMethod(string message)
        {
            MoodAnalyzer moodAnalyzer = CreateMoodAnalyzerObject(message);
            Type type = moodAnalyzer.GetType();
            MethodInfo analyzeMoodMethod = type.GetMethod("AnalyzeMood");
            return (string)analyzeMoodMethod.Invoke(moodAnalyzer, null);
        }

        public static void ModifyMessage(string message, MoodAnalyzer moodAnalyzer)
        {
            Type type = moodAnalyzer.GetType();
            PropertyInfo propertyInfo = type.GetProperty("message");
            propertyInfo.SetValue(moodAnalyzer, message);
        }
    }
}
