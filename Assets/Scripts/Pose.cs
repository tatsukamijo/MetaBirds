using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    // public SerialHandler serialHandler;
    public string[] data;
    public float acceleration;
    public float tilt;
    public float tilt_forward;
    private float hoge;

    // Start is called before the first frame update
    void Start()
    {
        acceleration = 0f;
        tilt = 0f;
        tilt_forward = 0f;
        // serialHandler.OnDataReceived += OnDataReceived;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 localAngle = this.transform.localEulerAngles;
        localAngle.x = tilt;
        localAngle.y = 97.011f;
        localAngle.z = -20.215f;
        this.transform.localEulerAngles = localAngle;
        */

        Vector3 localAngle = this.transform.localEulerAngles;
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

    }

    /*
    void OnDataReceived(string message)
    {
        data = message.Split(
            new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length != 1) return;
        try
        {
            hoge = float.Parse(data[0]);
        }
        catch
        {
            return;
        }

        Debug.Log(hoge);
        if (hoge < 5000)
        {
            acceleration = hoge;
            return;
        }
        if (hoge > 20000)
        {
            tilt_forward = hoge - 20000;
            return;
        }
        // -15から0
        else if (9985f < hoge && hoge <= 10000f)
        {
            tilt = 0.0f;
            return;
        }
        // 0から15
        else if (10000f < hoge && hoge <= 10015f)
        {
            tilt = 15.0f;
            return;
        }
        // -30から-15
        else if (9970f < hoge && hoge <= 9985f)
        {
            tilt = -15.0f;
            return;
        }
        // 15から30
        else if (10015f < hoge && hoge <= 10030f)
        {
            tilt = 30.0f;
            return;
        }
        // -45から-30
        else if (9955f < hoge && hoge <= 9970f)
        {
            tilt = -30.0f;
            return;
        }
        // 30から45
        else if (10030f < hoge && hoge <= 10045f)
        {
            tilt = 45.0f;
            return;
        }
        // -45より小さい場合
        else if (hoge <= 9955f)
        {
            tilt = -45.0f;
            return;
        }
        else if (10045 < hoge)
        {
            tilt = 45.0f;
            return;
        }

    }
    */   
}
