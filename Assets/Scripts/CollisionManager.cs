using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject gameOverText;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("is_Muteki", true);
        }
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
