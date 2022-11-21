using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform goal;
    public Transform tori;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        CollisionManager collisionmanager;
        collisionmanager = GameObject.Find("fly").GetComponent<CollisionManager>();

        //  is_Mutekiで制御主体を切り替え
        if (!collisionmanager.is_Muteki)
        {
            this.transform.position = tori.position;
        }
        else
        {
            agent.speed = 300;
            agent.acceleration = 300;
            agent.SetDestination(goal.position);
        }
    }
}
