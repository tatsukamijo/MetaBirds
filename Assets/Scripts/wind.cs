using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public GameObject target;
    public Vector3 force;
    public bool is_Wind;
    public GameObject windWarnText;
    Rigidbody rb;
    AudioSource audioSource; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = target.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        is_Wind = false;
        windWarnText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            windWarnText.SetActive(true);
            audioSource.Play();
            is_Wind = true;
            Debug.Log("play");
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            rb.AddForce(force);
            Debug.Log("hit");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.attachedRigidbody == rb)
        {
            windWarnText.SetActive(false);
            audioSource.mute = true;
            is_Wind = false;
            Debug.Log("end");
        }
    }
}
