using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour
{
    public Transform goal;
    public GameObject gameOverText;
    // public Text TimeText;
    public bool is_Muteki;
    public bool is_GameOver;
    public bool is_Goal;
    public float time;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        is_Muteki = false;
        is_GameOver = false;
        is_Goal = false;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (is_GameOver == false)
        {
            time += Time.deltaTime;
            TimeText.text = time.ToString();
        }
        */
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
        else if (col.gameObject.tag == "Wall")
        {

        }
        else if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        {
            Debug.Log("{col.gameObject.tag}");
            gameOverText.SetActive(true);
            is_GameOver = true;
            Debug.Log("Collision");
        }
    }
}
