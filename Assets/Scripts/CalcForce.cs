using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcForce : MonoBehaviour
{
    private Rigidbody rb;
    public Transform agent;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        AgentController agentcontroller;
        agentcontroller = GameObject.Find("tori_agent").GetComponent<AgentController>();

        CollisionManager collisionmanager;
        collisionmanager = GameObject.Find("fly").GetComponent<CollisionManager>();

        if (!collisionmanager.is_Muteki)
        {
            float speed = 1000.0f;
            float x = Input.GetAxis("Horizontal") * speed;
            float z = Input.GetAxis("Vertical") * speed;
            rb.AddForce(50f * x, 50f * z, 50f * z);
            // Vector3 localAngle = this.transform.localEulerAngles;
            // Debug.Log($"{localAngle}");
            // rb.AddForce(transform.forward * 10.0f, ForceMode.Force);
        }
        else // is_Mutekiのとき. agentが制御.
        {
            this.transform.position = agent.position;
            Debug.Log($"{collisionmanager.is_Muteki}");
        }
    }
}
