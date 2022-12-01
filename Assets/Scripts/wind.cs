using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public GameObject target;
    public Vector3 force;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            rb.AddForce(force);
            Debug.Log("hit");
        }
    }
}
