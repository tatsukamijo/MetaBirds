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
         if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
        }
         if (col.gameObject.tag == "Muteki")
        {
            Destroy(col.gameObject);
            Debug.Log("Muteki");
        }
        else
        {
            Debug.Log($"{col.gameObject}");
            gameOverText.SetActive(true);
            Debug.Log("Collision");
        }
    }
}
