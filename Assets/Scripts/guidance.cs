using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float detectLimit = 0;
    public Vector3 rotateAdjust;
    GameObject nearest_item;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        if (items.Length > 0)
        {
            float min_dist = Vector3.Distance(player.transform.position, items[0].transform.position);
            nearest_item = items[0];
            foreach (GameObject obj in items)
            {
                float dist = Vector3.Distance(player.transform.position, obj.transform.position);
                float zdist = (obj.transform.position - player.transform.position)[2];
                Debug.Log(zdist);
                if (dist <= min_dist && zdist > detectLimit)
                {
                    nearest_item = obj;
                    min_dist = dist;
                }
            }
                transform.LookAt(nearest_item.transform.position);
                transform.Rotate(rotateAdjust);
        }
    }
  
}
