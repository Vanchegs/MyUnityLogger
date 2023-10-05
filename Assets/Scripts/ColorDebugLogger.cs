using UnityEngine;
using ILogger = Vanchegs.ILogger;

public class ColorDebugLogger : ILogger
{
    public void Logging(string message)
    {
        message = $"<color=red>{message}</color>";
        Debug.Log(message);
    }
}
