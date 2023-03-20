using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Drawing;
using UnityEditor;

public class Eqs_mulmanager1 : MonoBehaviour
{
    public Sprite[] notecoin;
    public Image note1;
    public int left;
    public TextMeshProUGUI randomvar;
    public int correct_ans;
    public TextMeshProUGUI[] buttons;
    public Button correct_btn;
    public string victory;
    public string wrong;
    private float startTime;
    public static float elapsedTime;
    public int privnum;
    public static int right;
    //public int scorenewval;
    //public int score=0;
    public static int fail = 0;
    public static int scoreval;
    public Text scoretext;

    public static List<float> timeList = new List<float>();
    public static List<string> resultList = new List<string>();

    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;

    public static int levelCount = 0;

    private void Awake()
    {

        int random_1 = UnityEngine.Random.Range(0, notecoin.Length);
        note1.sprite = notecoin[random_1];
        
        int note1_val = Convert.ToInt32(note1.sprite.name);
        if (note1_val == 1)
        {
            note1.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (note1_val == 2)
        {
            note1.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (note1_val == 5)
        {
            note1.rectTransform.localScale = new Vector3(1, 1, 1);
        }

        else
        {
            note1.rectTransform.localScale = new Vector3(2, 1, 1);
        }
       
        
        privnum = UnityEngine.Random.Range(1,10);
        randomvar.text = privnum.ToString();
        
        correct_ans = note1_val * privnum;

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
            SceneManager.LoadScene("Eqs_mulvictory1");
            elapsedTime = (1 * Time.time) - startTime;
            Debug.Log(elapsedTime);
            timeList.Add(elapsedTime);
            Debug.Log(timeList);
            resultList.Add("Right");

        }
        else
        {
            SceneManager.LoadScene("Eqs_mulwrong1");
            elapsedTime = (1 * Time.time) - startTime;
            timeList.Add(elapsedTime);
            resultList.Add("Wrong");

        }
    }
}
