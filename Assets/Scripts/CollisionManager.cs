using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public GameObject gameOverText;

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
         if (col.gameObject.name == "Item")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
        }
        else
        {
            gameOverText.SetActive(true);
            Debug.Log("Collision");
        }
    }
}
