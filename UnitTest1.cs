using Day21Reflections;

namespace ReflectionsTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_ShouldReturnHappyMood()
        {
            // Arrange
            string message = "I am happy";
            string expectedMood = "happy";

            // Act
            string mood = MoodAnalyzerFactory.InvokeAnalyzeMoodMethodUsingReflection(message);

            // Assert
            Assert.AreEqual(expectedMood, mood);
        }


        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrowMoodAnalysisException()
        {
            // Arrange
            string message = "I am happy";
            string methodName = "WrongMethodName";

            try
            {
                // Act
                string mood = MoodAnalyzerFactory.InvokeAnalyzeMoodMethodUsingReflection(message, methodName);
            }
            catch (MoodAnalysisException ex)
            {
                // Assert
                Assert.AreEqual("No such method found", ex.Message);
            }
        }
    }
}