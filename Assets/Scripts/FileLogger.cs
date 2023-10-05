using UnityEngine;
using System.IO;

namespace Vanchegs
{
    public class FileLogger : ILogger
    {
        private StreamWriter writer = new StreamWriter(@"C:\GitHub\MyUnityLogger\Assets\Scripts\TestFile");
        
        public void Logging()
        {
            writer.WriteLine("Вывод в файл прошел успешно!");
        }
    }
}