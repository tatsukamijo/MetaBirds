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
    // 現在の目的地
    private int currentWaypointIndex;
    // Start is called before the first frame update
    void Start()
    {
       // navMeshAgent変数にNavMeshAgentコンポーネントを入れる
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // 最初の目的地を入れる
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Update is called once per frame
    void Update()
    {
        // 目的地点までの距離(remainingDistance)が目的地の手前までの距離(stoppingDistance)以下になったら
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            Debug.Log($"waypoint{currentWaypointIndex} haspath{navMeshAgent.hasPath}");
            currentWaypointIndex += 1;
            // 目的地を次の場所に設定
            navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }
}
