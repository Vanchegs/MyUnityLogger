using UnityEngine;

namespace Vanchegs
{
    public sealed class StartAllLoggers : MonoBehaviour
    {
        private readonly ILogger logger = new DebugLogger();
        
        public void ClickOnLoggingButton()
        {
            MyCustomLogger(message: "The output to the console was successful!", logger);
            MyCustomLogger(message: "Output to file was successful!", new FileLogger(@"C:\GitHub\MyUnityLogger\Assets\Scripts\TestFile"));
            MyCustomLogger(message: "Color output to the console was successful!", new RandomColorDebugLogger());
        }
    
        private void MyCustomLogger(string message, ILogger customLogger) =>
            customLogger?.Logging(message);
    }
}

