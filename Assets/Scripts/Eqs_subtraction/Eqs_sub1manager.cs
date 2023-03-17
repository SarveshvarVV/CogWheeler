using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Unity.Mathematics;

public class Eqs_sub1manager : MonoBehaviour
{
    public Sprite[] lvl1;
    public Image coin1, coin2;
    public int left;
    public int correct_ans;
    public TextMeshProUGUI[] buttons;
    public Button correct_btn;
    public string victory;
    public string wrong;
    private float startTime;
    public static float elapsedTime;
    public int privnum;
    public static int right;
    public int scorenewval;
    //public int score=0;
    public static int fail = 0;
    public static List<float> timeList = new List<float>();
    public static List<string> resultList = new List<string>();
    public static int scoreval;
    public Text scoretext;
    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;
    private int c1, c2;

    public static int levelCount;

    private void Awake()
    {
        int random_1 = UnityEngine.Random.Range(0, lvl1.Length);
        int random_2 = UnityEngine.Random.Range(0, lvl1.Length);
        if (random_2 > random_1)
        {
            int temp;
            temp = random_1;
            random_1 = random_2;
            random_2 = temp;
        }
        coin1.sprite = lvl1[random_1];
        coin2.sprite = lvl1[random_2];
        int coin1_val = Convert.ToInt32(coin1.sprite.name);
        int coin2_val = Convert.ToInt32(coin2.sprite.name);
        correct_ans = coin1_val - coin2_val;


        int random_3 = UnityEngine.Random.Range(0, buttons.Length);
        buttons[random_3].text = correct_ans.ToString();
        correct_btn = buttons[random_3].GetComponentInParent<Button>();


        for (int i = 0; i < buttons.Length; i++)
        {
            if (i != random_3)
            {
                buttons[i].text = (correct_ans + ((i + 1) * 2)).ToString();
            }
        }
        string current_scene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("last_scene", current_scene);
        PlayerPrefs.Save();

    }

    // Start is called before the first frame update
    void Start()
    {
        levelCount++;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Check()
    {
        Button selected_btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        if (selected_btn == correct_btn)
        {
            SceneManager.LoadScene("Eqs_subvictory1");
            elapsedTime = Time.time - startTime;
            Debug.Log(elapsedTime);
            timeList.Add(elapsedTime);
            Debug.Log(timeList);
            resultList.Add("Right");

        }
        else
        {
            SceneManager.LoadScene("Eqs_subwrong1");
            elapsedTime = Time.time - startTime;
            timeList.Add(elapsedTime);
            resultList.Add("Wrong");

        }
    }
}

