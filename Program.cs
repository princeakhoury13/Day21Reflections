namespace Day21Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am happy");
                Console.WriteLine("Original Mood: " + moodAnalyzer.AnalyzeMood());
                MoodAnalyzerFactory.ModifyMessage("I am sad now", moodAnalyzer);
                Console.WriteLine("Modified Mood: " + moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}