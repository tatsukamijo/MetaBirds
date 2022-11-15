using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
                                                        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //Rigidbodyに力を加える
        rb.AddForce(50 * x, 20 * z, 30 * z);
    }

    void FixedUpdate()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);

    }
}
