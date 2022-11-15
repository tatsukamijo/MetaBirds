using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);
        Debug.Log("Collision");
        gameOverText.SetActive(true);
    }
}
