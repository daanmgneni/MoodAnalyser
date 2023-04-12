using MoodAnalyser;
using System.Linq.Expressions;

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
            try
            {
                if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if(this.message==" ")
                {
                    
                   throw new CustomException(CustomException.ExceptionType.EmptyException, "Empty String");
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(Exception) 
            {
                throw new CustomException(CustomException.ExceptionType.NullException,"Null String");
            }
            
        }
    }
}
