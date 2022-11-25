using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
