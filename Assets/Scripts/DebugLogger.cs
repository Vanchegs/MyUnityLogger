using UnityEngine;

namespace Vanchegs
{
    public class DebugLogger : ILogger
    {
        public void Logging(string message)
        {
            Debug.Log(message);
        }
    }
}

