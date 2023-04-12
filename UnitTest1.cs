using MoodAnalyser;
using MoodAnalyserCore;
using System.Data;

namespace MoodAnalyserMSTest

{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        //TC 3.1: Given null mood should throw moodanalysisException.
        public void Given_NULL_Mood_Should_Throw_MoodAnalyserException()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Null String", e.Message);
            }
        }

        [TestMethod]
        //TC 3.2: Given Empty mood should throw moodanalysisException Indicating Empty mood.
        public void Given_EMPTY_Mood_Should_Throw_MoodAnalyserException_IndicatingEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (CustomException e)
            {  
                Assert.AreEqual("Null String", e.Message);
            }
        }
    }
}