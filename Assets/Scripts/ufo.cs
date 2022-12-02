using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 moveDirection;
    public float omega;
    Vector3 origin;
    float t = 0.0f;
    void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = moveDirection * Mathf.Sin(omega * t);
        t++;
    }
}
