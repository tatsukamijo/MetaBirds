using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalTextScript : MonoBehaviour
{
    public float speed = 1.0f;

    private TextMesh goalScript;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        goalScript = this.gameObject.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        goalScript.color = GetAlphaColor(goalScript.color);
    }

    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}