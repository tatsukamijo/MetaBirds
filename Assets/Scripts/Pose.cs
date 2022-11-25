using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    public SerialHandler serialHandler;
    public string[] data;
    public float acceleration;
    public float tilt;

    // Start is called before the first frame update
    void Start()
    {
        acceleration = 0f;
        tilt = 0f;
        serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localAngle = this.transform.localEulerAngles;
        localAngle.x = tilt;
        localAngle.y = 97.011f;
        localAngle.z = -20.215f;
        this.transform.localEulerAngles = localAngle;
        /*
        // →キー押下時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            localAngle.x += 10.0f;
            localAngle.y = 97.011f;
            localAngle.z = -20.215f;
            this.transform.localEulerAngles = localAngle;
        }
        // ←キー押下時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            localAngle.x -= 10.0f;
            localAngle.y = 97.011f;
            localAngle.z = -20.215f;
            this.transform.localEulerAngles = localAngle;
        }
        */
    }

    void OnDataReceived(string message)
    {
        data = message.Split(
            new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length != 1) return;
        var hoge = float.Parse(data[0]);
        Debug.Log(hoge);
        if (hoge > 5000f)
        {
            tilt = hoge - 10000f;
        }
        else
        {
            acceleration = hoge;
        }
    }

}
