using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Eqs_addlvl2manager : MonoBehaviour
{
    public Sprite[] lvl2;
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
    public static int scoreval;
    public static List<float> timeList = new List<float>();
    public static List<string> resultList = new List<string>();
    public Text scoretext;
    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;

    public static int levelCount;

    private void Awake()
    {
        int random_1 = UnityEngine.Random.Range(0, lvl2.Length);
        
        if (Convert.ToInt32(lvl2[random_1].name)== 10 || Convert.ToInt32(lvl2[random_1].name) == 20 || Convert.ToInt32(lvl2[random_1].name) == 50)
        {
            Debug.Log("note1");
            coin1.rectTransform.localScale = new Vector3(2, 1, 1);
        }
        else
        {
            Debug.Log("coin1");
            coin1.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        
        coin1.sprite = lvl2[random_1];


        int random_2 = UnityEngine.Random.Range(0, lvl2.Length);
        
        if (Convert.ToInt32(lvl2[random_2].name) == 10 || Convert.ToInt32(lvl2[random_2].name) == 20 || Convert.ToInt32(lvl2[random_2].name) == 50)
        {
            Debug.Log("note2");
            coin2.rectTransform.localScale = new Vector3(2, 1, 1);
        }
        else
        {
            Debug.Log("coin2");
            coin2.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        
        coin2.sprite = lvl2[random_2];
        
        
        int coin1_val = Convert.ToInt32(coin1.sprite.name);
        int coin2_val = Convert.ToInt32(coin2.sprite.name);
        correct_ans = coin1_val + coin2_val;


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
        startTime = 1*Time.time;
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
            SceneManager.LoadScene("Eqs_addvictory2");
            elapsedTime = (1 * Time.time) - startTime;
            Debug.Log(elapsedTime);
            timeList.Add(elapsedTime);
            Debug.Log(timeList);
            resultList.Add("Right");

        }
        else
        {
            SceneManager.LoadScene("Eqs_addwrong2");
            elapsedTime = (1 * Time.time) - startTime;
            timeList.Add(elapsedTime);
            resultList.Add("Wrong");

        }
    }
}

