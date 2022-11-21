using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcForce : MonoBehaviour
{
    /*
    private CharacterController characterController;
    private Vector3 velocity;
    */
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        /*
        characterController = GetComponent<CharacterController>();
        transform.position = new Vector3(0f, 1f, 0f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1000.0f;
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(50f*x, 50f*z, 50f*z);

        /*
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        characterController.Move(velocity);
        */       
    }

    void FixedUpdate()
    {

    }
}
