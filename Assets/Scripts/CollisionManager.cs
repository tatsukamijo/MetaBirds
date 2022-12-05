using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionManager : MonoBehaviour
{
    public Transform goal;
    public GameObject gameOverText;
    public GameObject ClearUI;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreText;
    public SerialHandler serialHandler;
    public bool is_Muteki;
    private bool is_GameOver;
    public bool is_Goal;
    public bool is_Clear;
    public float time;
    public int item_obtained;
    public AudioClip BGM_main;
    public AudioClip BGM_muteki;
    public AudioClip BGM_gameover;
    public AudioClip BGM_goal;
    public AudioClip SE_item;
    public AudioClip SE_muteki;
    public AudioClip SE_damage;
    AudioSource audioSource;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        is_Muteki = false;
        is_GameOver = false;
        is_Goal = false;
        is_Clear = false;
        time = 0.0f;
        item_obtained = 0;
        ScoreText.text = item_obtained.ToString();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = BGM_main;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_GameOver == false)
        {
            time += Time.deltaTime;
            TimeText.text = time.ToString("f2");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Item")
        {
            Destroy(col.gameObject);
            Debug.Log("Item");
            item_obtained += 1;
            ScoreText.text = item_obtained.ToString();
            audioSource.PlayOneShot(SE_item);
        }
        else if (col.gameObject.tag == "Muteki")
        {
            is_Muteki = true;
            // ESP32に送信
            serialHandler.Write("MutekiStart");
            Destroy(col.gameObject);
            Debug.Log("Muteki");
            Debug.Log("heading to the goal");
            audioSource.PlayOneShot(SE_muteki);
            audioSource.clip = BGM_muteki;
            audioSource.Play();
        }
        else if (col.gameObject.tag == "Goal")
        {
            is_Muteki = false;
            // ESP32に送信
            serialHandler.Write("MutekiEnd");
            Destroy(col.gameObject);
            Debug.Log("reached goal");
            audioSource.clip = BGM_main;
            audioSource.Play();
        }
        else if (col.gameObject.tag == "Clear")
        {
            is_Clear = true;
            ClearUI.SetActive(true);
        }
        else if (col.gameObject.tag == "Wall")
        {

        }
        else if (col.gameObject.tag != "Item" && col.gameObject.tag != "Muteki")
        { 
            Debug.Log("{col.gameObject.tag}");
            // ESP32に送信
            serialHandler.Write("2");
            gameOverText.SetActive(true);
            is_GameOver = true;
            Debug.Log($"{is_GameOver}");
            audioSource.PlayOneShot(SE_damage);
            Debug.Log("Collision");
            audioSource.clip = BGM_gameover;
            audioSource.Play();
        }
    }
}
