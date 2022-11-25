using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConsoleOutput : MonoBehaviour
{
    public SerialHandler serialHandler;
    public string[] data;

    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }

    void OnDataReceived(string message)
    {
        data = message.Split(
            new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length != 1) return;
        // アングルが10000足してくる
        Debug.Log(data[0]);
    }
}