namespace MoodAnalyserCore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a message");
            string message = Console.ReadLine();
            
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            string mood = moodAnalyser.AnalyseMood();
            Console.WriteLine(mood);
        }   
            
    }
}