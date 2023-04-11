using MoodAnalyserCore;

namespace MoodAnalyserMSTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToTestSadMood()
        {
            //Arrange
            String ExpectedOutput = "SAD";
            string message = "I'm in a Sad mood.";
            MoodAnalyzer moodAnalyzer=new MoodAnalyzer(message);
            //Act
            string mood = moodAnalyzer.AnalyseMood();
            //Assert
            Assert.AreEqual(ExpectedOutput, mood);

        }

        [TestMethod]
        public void ToTestAnyMood()
        {
            //Arrange
            String ExpectedOutput = "HAPPY";
            string message = "I'm in a any mood.";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string mood = moodAnalyzer.AnalyseMood();
            //Assert
            Assert.AreEqual(ExpectedOutput, mood);

        }
    }
}