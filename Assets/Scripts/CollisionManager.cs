using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public Transform goal;
    public GameObject gameOverText;
    public bool is_Muteki;
    public float Time;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        is_Muteki = false;
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
            is_Muteki = true;
            Destroy(col.gameObject);
            Debug.Log("Muteki");
            Debug.Log("heading to the goal");
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
