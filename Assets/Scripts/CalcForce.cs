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
    private Vector3 pos_dif;

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
        AgentController agentcontroller;
        GameObject agent_obj = GameObject.Find("tori_agent");
        agentcontroller = agent_obj.GetComponent<AgentController>();

        CollisionManager collisionmanager;
        GameObject col_obj = GameObject.Find("fly");
        collisionmanager = col_obj.GetComponent<CollisionManager>();
        if (!collisionmanager.is_Muteki)
        {
        float speed = 1000.0f;
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        rb.AddForce(50f * x, 50f * z, 50f * z);
        }
        else // is_Mutekiのとき
        { 
            // 座標系の変換が必要そう.
        float speed = 10.0f;
        float forward_x = transform.forward.x * speed;
        float forward_y = transform.forward.y * speed;
        float forward_z = transform.forward.z * speed;
            rb.velocity = new Vector3(0f, 0f, 0f);
        // rb.velocity = new Vector3(forward_x, forward_y, forward_z);
        Debug.Log($"{agentcontroller.nextPosition}");
        }

        /*
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        characterController.Move(velocity);
        */
    }

    void FixedUpdate()
    {

    }
}
