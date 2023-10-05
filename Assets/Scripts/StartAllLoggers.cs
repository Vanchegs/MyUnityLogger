using UnityEngine;
using Vanchegs;
using ILogger = Vanchegs.ILogger;

public class StartAllLoggers : MonoBehaviour
{
    private ILogger debugLogger = new DebugLogger();
    private ILogger fileLogger = new FileLogger();
    private ILogger gameTextLogger = new GameTextLogger();

    private void Start()
    {
        debugLogger.Logging();
        fileLogger.Logging();
        gameTextLogger.Logging();
    }
}
