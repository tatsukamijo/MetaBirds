using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WindTextScript : MonoBehaviour
{
    public float speed = 1.0f;

    private TextMeshProUGUI windScript;
    private float time;
    private wind windy;

    // Start is called before the first frame update
    void Start()
    {
        windScript = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        windScript.color = GetAlphaColor(windScript.color);       
    }

    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}