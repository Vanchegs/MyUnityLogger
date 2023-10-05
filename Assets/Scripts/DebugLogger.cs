using UnityEngine;

namespace Vanchegs
{
    public class DebugLogger : MonoBehaviour, ILogger
    {
        public void Logging()
        {
            Debug.Log("Вывод в консоль прошел успешно!");
        }
    }
}

