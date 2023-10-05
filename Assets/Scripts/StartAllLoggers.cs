using System;
using UnityEngine;
using Vanchegs;
using ILogger = Vanchegs.ILogger;

public class StartAllLoggers : MonoBehaviour
{
    private void Start()
    {
        MyCustomLogger(message: "Вывод в консоль прошел успешно!", new DebugLogger());
        MyCustomLogger(message: "Вывод в файл прошел успешно!", new FileLogger());
        MyCustomLogger(message: "Красный вывод в консоль прошел успешно!", new ColorDebugLogger());
    }

    private void MyCustomLogger(string message, ILogger logger) =>
        logger?.Logging(message);
}
