using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Eqs_lvl2_GameManager : MonoBehaviour
{
    public Sprite[] notesList;
    public Sprite[] notecoin;
    public Image note1, note2;
    public int correct_ans;
    public TextMeshProUGUI[] buttons;
    public Button correct_btn;
    public string victory;
    public string wrong;
    private float startTime;
    public static float elapsedTime;
    public int privnum;
    public static int right;
    public static List<float> timeList = new List<float>();
    public static List<string> resultList = new List<string>();
    //public int scorenewval;
    //public int score=0;
    public static int fail = 0;
    public static int scoreval=0;
    public static float[] timearray4;
    public static string[] resultarr4;
    public Text scoretext;
    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;

    public static int levelCount = 0;

    private void Awake()
    {
        int random_1 = UnityEngine.Random.Range(0, notesList.Length);
        note1.sprite = notesList[random_1];
        int random_2 = UnityEngine.Random.Range(0, notecoin.Length);    
        note2.sprite = notecoin[random_2];

        int note1_val = Convert.ToInt32(note1.sprite.name);
        int note2_val = Convert.ToInt32(note2.sprite.name);
        if (note2_val == 1)
        {
            note2.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (note2_val == 2)
        {
            note2.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (note2_val == 5)
        {
            note2.rectTransform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            note2.rectTransform.localScale = new Vector3(2, 1, 1);
        }

        if (note1_val % note2_val == 0)
        {
            correct_ans = note1_val / note2_val;
        }
        else
        {
            Awake();
        }

        int random_3 = UnityEngine.Random.Range(0, buttons.Length);
        buttons[random_3].text = correct_ans.ToString();
        correct_btn = buttons[random_3].GetComponentInParent<Button>();


        for (int i = 0; i < buttons.Length; i++)
        {
            if (i != random_3)
            {
                buttons[i].text = (correct_ans * UnityEngine.Random.Range(0, 5) + (i * 2 + 1)).ToString();
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
        startTime = 1 * Time.time;
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
            SceneManager.LoadScene("Eqs_victory");
            elapsedTime = (1 * Time.time) - startTime;
            Debug.Log(elapsedTime);
            timeList.Add(elapsedTime);
            Debug.Log(timeList);
            resultList.Add("Right");

        }
        else
        {
            SceneManager.LoadScene("Eqs_wrong");
            elapsedTime = (1 * Time.time) - startTime;
            timeList.Add(elapsedTime);
            resultList.Add("Wrong");

        }
    }
}

