using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
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

    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        {
            gameOverText.SetActive(true);
        }
    }
}
