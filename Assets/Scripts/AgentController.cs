using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform goal;
    public Transform tori;
    public Vector3 nextPosition;

    NavMeshPath path;
    private UnityEngine.AI.NavMeshAgent agent;
    const int maxPosition = 9;
    Vector3[] positions = new Vector3[maxPosition];

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        agent.CalculatePath(goal.position, path);
        path.GetCornersNonAlloc(positions);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = tori.position;
        agent.SetDestination(goal.position);
        nextPosition = agent.path.corners[0];
        // Debug.Log($"{agent.nextPosition}");
    }
    private void onDrawGizmoSelected()
    {
        for (int i = 0; i < positions.Length - 1; i++)
        {
            Gizmos.DrawLine(positions[i], positions[i + 1]);
        }
    }
}
