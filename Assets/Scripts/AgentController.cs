using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform goal;
    public Transform tori;
    public Vector3 nextPosition;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = tori.position;
        agent.SetDestination(goal.position);
        nextPosition = agent.path.corners[0];
        // Debug.Log($"{agent.nextPosition}");
    }
}
