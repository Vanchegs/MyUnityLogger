using System.IO;

namespace Vanchegs
{
    public class FileLogger : ILogger
    {
        private StreamWriter writer = new StreamWriter(@"C:\GitHub\MyUnityLogger\Assets\Scripts\TestFile", true);
        
        public void Logging(string message)
        {
            writer.WriteLine(message);
        }
    }
}