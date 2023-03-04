namespace Day21Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am happy");
                Console.WriteLine(moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}