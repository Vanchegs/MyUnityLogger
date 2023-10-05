using UnityEngine;
using Vanchegs;
using ILogger = Vanchegs.ILogger;

public sealed class StartAllLoggers : MonoBehaviour
{
    public void ClickOnLogginButton()
    {
        MyCustomLogger(message: "The output to the console was successful!", new DebugLogger());
        MyCustomLogger(message: "Output to file was successful!", new FileLogger());
        MyCustomLogger(message: "Color output to the console was successful!", new ColorDebugLogger());
    }

    private void MyCustomLogger(string message, ILogger logger) =>
        logger?.Logging(message);
}
