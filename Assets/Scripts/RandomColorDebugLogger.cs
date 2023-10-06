using UnityEngine;
using Random = UnityEngine.Random;

namespace Vanchegs
{
    public sealed class RandomColorDebugLogger : ILogger
    {
        private readonly string[] colorStock = new string[5]
        {
            "green",
            "red",
            "yellow",
            "white",
            "black"
        };
        
        public void Logging(string message)
        {
            int randomIndex = Random.Range(0, colorStock.Length);
            string color = colorStock[randomIndex];
            message = $"<color={color}>{message}</color>";
            Debug.Log(message);
        }
    }
}

