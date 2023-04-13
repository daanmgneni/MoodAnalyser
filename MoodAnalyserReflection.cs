using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserReflection
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {

            string pattern = @"." + constructorName + @"\(\)$";
            Match result = Regex.Match(pattern, className);
            if (result.Success)
            {
                try
                {
                    Assembly execute = Assembly.GetExecutingAssembly();
                    Type checktype = execute.GetType(className);
                    return Activator.CreateInstance(checktype);
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.NoSuchClass, "Class not found");

                }
            }
            else
            {

                throw new CustomException(CustomException.ExceptionType.NoSuchMethod, "Constructor is not found");

            }
        }
    }
}
