using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Vanchegs
{
    
    public class GameTextLogger : MonoBehaviour, ILogger
    {
        [SerializeField] private Text gameText;
        
        public void Logging()
        {
            gameText.text = "Вывод в игре прошел успешно!";
        }
    }
}

