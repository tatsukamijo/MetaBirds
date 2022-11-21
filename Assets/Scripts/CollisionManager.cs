using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Transform goal;
    public GameObject gameOverText;
    private Animator anim;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        // anim = gameObject.GetComponent<Animator>();
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
            // agent.updatePosition = false;
            Debug.Log("Item");
        }
         else if (col.gameObject.tag == "Muteki")
        {
            // UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            // agent.enabled = true;
            Destroy(col.gameObject);
            Debug.Log("Muteki");
            // agent.SetDestination(goal.position);
            Debug.Log("heading to the goal");
            // navMeshAgent.SetDestination(navMeshAgent.nextPosition);
            // Debug.Log($"Path: {navMeshAgent.speed}");
        }
         else if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        {
            Debug.Log($"{col.gameObject.tag}");
            gameOverText.SetActive(true);
            Debug.Log("Collision");
        }
    }
}
