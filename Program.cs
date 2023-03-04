namespace Day21Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MoodAnalyzer moodAnalyzer = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am happy");
                if (moodAnalyzer != null)
                {
                    Console.WriteLine("Original Mood: " + moodAnalyzer.AnalyzeMood());
                    MoodAnalyzerFactory.ModifyMessage("I am sad now", moodAnalyzer);
                    Console.WriteLine("Modified Mood: " + moodAnalyzer.AnalyzeMood());
                }
                else
                {
                    Console.WriteLine("Failed to create MoodAnalyzer object");
                }
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}