using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaker : MonoBehaviour
{
    public GameObject prefabObj1;
    public GameObject prefabObj2;
    public GameObject start;
    public GameObject end;
    public int N;
    public float rand_x;
    public float rand_y;
    public float rand_z;
    public float mix_rate;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPos = start.transform.position;
        Vector3 endPos = end.transform.position;
        Vector3 dr = (endPos - startPos) / (N + 1);
        for (int i = 1; i <= N; i++)
        {
            Vector3 randomness = new Vector3(Random.Range(-rand_x, rand_x), Random.Range(-rand_y, rand_y), Random.Range(-rand_z, rand_z));
            if (Random.Range(0.0f, 1.0f) > mix_rate)
            {
                GameObject obj = Instantiate(prefabObj1, startPos + dr * i + randomness, Quaternion.identity);
            }
            else
            {
                GameObject obj = Instantiate(prefabObj2, startPos + dr * i + randomness, Quaternion.identity);
            }
        }
    }
}
