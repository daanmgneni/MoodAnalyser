using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        { NullException,EmptyException }
         public ExceptionType type;
        public CustomException(ExceptionType Type,string message ):base(message)
        {
            this.type = Type;
        }
        
    }
}
