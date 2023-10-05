using System.IO;

namespace Vanchegs
{
    public sealed class FileLogger : ILogger
    {
        private string filePath = @"C:\GitHub\MyUnityLogger\Assets\Scripts\TestFile";
        
        public void Logging(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}