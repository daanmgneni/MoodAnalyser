namespace MoodAnalyserCore
{
    public class MoodAnalyzer
    {
        string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public MoodAnalyzer()
        {
            
        }

        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
