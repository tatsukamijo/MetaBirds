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
        Animator anim = GetComponent<Animator>();
        if (col.gameObject.tag == "Item")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
        }
         else if (col.gameObject.tag == "Muteki")
        {
            Destroy(col.gameObject);
            anim.SetBool("is_Muteki", true);
            Debug.Log("Muteki");
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
