using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMaker : MonoBehaviour
{
    public GameObject prefabObj;
    public int N;
    public float start_x;
    public float start_y;
    public float start_z;
    public float end_x;
    public float end_y;
    public float end_z;
    public float rand_x;
    public float rand_y;
    public float rand_z;
    // Start is called before the first frame update
    void Start()
    {
        float dx = (end_x - start_x) / (N - 1);
        float dy = (end_y - start_y) / (N - 1);
        float dz = (end_z - start_z) / (N - 1);
        for (int i = 0; i < N; i++)
        {
            float x = dx * i + Random.Range(-rand_x, rand_x);
            float y = dy * i + Random.Range(-rand_y, rand_y);
            float z = dz * i + Random.Range(-rand_z, rand_z);
            GameObject obj = Instantiate(prefabObj, new Vector3(x,y,z), Quaternion.identity);
        }
    }
}
