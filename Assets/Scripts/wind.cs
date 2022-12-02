using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public GameObject target;
    public Vector3 force;
    Rigidbody rb;
    AudioSource audioSource; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = target.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            audioSource.Play();
            Debug.Log("play");
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            rb.AddForce(force);
            //Debug.Log("hit");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            audioSource.mute = true;
            Debug.Log("end");
        }
    }
}
