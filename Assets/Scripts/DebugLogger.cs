using UnityEngine;

namespace Vanchegs
{
    public sealed class DebugLogger : ILogger
    {
        public void Logging(string message)
        {
            Debug.Log(message);
        }
    }
}

