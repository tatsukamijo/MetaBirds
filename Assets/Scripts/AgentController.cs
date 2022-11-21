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
        CollisionManager collisionmanager;
        GameObject col_obj = GameObject.Find("fly");
        collisionmanager = col_obj.GetComponent<CollisionManager>();

        // ここをis_Mutekiで場合分け.どっちからどっちの座標を一致させるか.
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
