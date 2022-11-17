using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject gameOverText;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Item")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
        }
         else if (col.gameObject.tag == "Muteki")
        {
            Destroy(col.gameObject);
            navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            navMeshAgent.speed = 100;
            navMeshAgent.acceleration = 100;

            Debug.Log("Muteki");
            // navMeshAgent.SetDestination(navMeshAgent.nextPosition);
            Debug.Log($"Path: {navMeshAgent.speed}");
        }
         else if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        {
            Debug.Log($"{col.gameObject.tag}");
            gameOverText.SetActive(true);
            Debug.Log("Collision");
        }
    }
}
