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
       Rigidbody rb = this.GetComponent<Rigidbody>();

        // ↑キー押下時
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // rb.transform.Rotate(new Vector3(-10f, 0f, 0f));
        }
        // ↓キー押下時
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // rb.transform.Rotate(new Vector3(10f, 0f, 0f));
        }
        // →キー押下時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.transform.Rotate(new Vector3(0f, 0f, -20f));
        }
        // ←キー押下時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(new Vector3(0f, 0f, 20f));
        }
    }
}
