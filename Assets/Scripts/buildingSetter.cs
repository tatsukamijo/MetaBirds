using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingSetter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] collection;
    public int N;
    public float startX;
    public float startZ;
    public float offset;
    void Start()
    {
        float x = startX;
        float z = startZ;
        for (int i = 0; i < N; i++)
        {
            int n = Random.Range(0, collection.Length);
            Instantiate(collection[n], new Vector3(x, 0, z), Quaternion.identity);
            z += 200 + offset;
        }
    }
}
