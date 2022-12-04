using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcForce : MonoBehaviour
{
    private Rigidbody rb;
    public Transform agent;
    private float forceKeisu;
    private float speed_z = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += 100f*Vector3.forward * Time.deltaTime;

        AgentController agentcontroller;
        agentcontroller = GameObject.Find("tori_agent").GetComponent<AgentController>();

        CollisionManager collisionmanager;
        collisionmanager = GameObject.Find("fly").GetComponent<CollisionManager>();

        Pose pose;
        pose = GameObject.Find("fly").GetComponent<Pose>();

        if (!collisionmanager.is_Muteki)
        {
            float speed = 1000.0f;
            float x = Input.GetAxis("Horizontal") * speed;
            float z = Input.GetAxis("Vertical") * speed;
            Vector3 forceAngle = new Vector3(Mathf.Cos(pose.tilt_forward + 10f) * Mathf.Sin(pose.tilt), Mathf.Cos(pose.tilt) * Mathf.Sin(pose.tilt_forward + 10f), 0f);
            // rb.AddForce(50000f*forceAngle.x, 50000f*forceAngle.y, 50000f*forceAngle.z);
            rb.AddForce(50f * x, 50f * z, 0f);
            forceKeisu = 50000f * pose.acceleration;
            // rb.AddForce(forceKeisu * forceAngle.x, forceKeisu * forceAngle.y, forceKeisu * forceAngle.z);
        }
        else // is_Mutekiのとき. agentが制御.
        {
            this.transform.position = agent.position;
            Debug.Log($"{collisionmanager.is_Muteki}");
        }
    }
}
