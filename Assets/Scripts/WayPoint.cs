using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class WayPoint : MonoBehaviour
{
    [SerializeField]
    [Tooltip("通過地点の配列")]
    private Transform[] waypoints;

    // NavMeshAgentコンポーネントを入れる変数
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private int currentWaypointIndex;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        // 目的地点までの距離(remainingDistance)が目的地の手前までの距離(stoppingDistance)以下になったら
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            Debug.Log($"waypoint{currentWaypointIndex} haspath{navMeshAgent.hasPath}");
            // Debug.Log($"path: {navMeshAgent.path.corners}");
            currentWaypointIndex += 1;
            // 目的地を次の場所に設定
            navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}
