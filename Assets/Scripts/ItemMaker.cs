using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaker : MonoBehaviour
{
    public GameObject prefabObj;
    public GameObject start;
    public GameObject end;
    public int N;
    public float rand_x;
    public float rand_y;
    public float rand_z;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPos = start.transform.position;
        Vector3 endPos = end.transform.position;
        Vector3 dr = (endPos - startPos) / (N - 1);
        for (int i = 0; i < N; i++)
        {
            Vector3 randomness = new Vector3(Random.Range(-rand_x, rand_x), Random.Range(-rand_y, rand_y), Random.Range(-rand_z, rand_z));
            GameObject obj = Instantiate(prefabObj, startPos + dr * i + randomness, Quaternion.identity);
        }
    }
}
