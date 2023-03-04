namespace Day21Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string mood = MoodAnalyzerFactory.InvokeAnalyzeMoodMethod("I am sad");
                Console.WriteLine(mood);
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}