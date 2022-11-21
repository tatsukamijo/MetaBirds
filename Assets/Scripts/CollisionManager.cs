using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Transform goal;
    public GameObject gameOverText;
    public bool is_Muteki;
    private Animator anim;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        // anim = gameObject.GetComponent<Animator>();
        is_Muteki = false;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter(Collision col)
    {
        Animator anim = GetComponent<Animator>();
        if (col.gameObject.tag == "Item")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
        }
         else if (col.gameObject.tag == "Muteki")
        {
            // UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // agent.enabled = true;
            Destroy(col.gameObject);
            is_Muteki = true;
            Debug.Log("Muteki");
            // agent.SetDestination(goal.position);
            Debug.Log("heading to the goal");
            // navMeshAgent.SetDestination(navMeshAgent.nextPosition);
            // Debug.Log($"Path: {navMeshAgent.speed}");
        }
        else if (col.gameObject.tag == "Goal")
        {
            is_Muteki = false;
            Destroy(col.gameObject);
            Debug.Log("reached goal");
        }
        else if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        {
            Debug.Log("{col.gameObject.tag}");
            gameOverText.SetActive(true);
            Debug.Log("Collision");
        }
    }
}
