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
    public static float time1;
    public static float time2;
    public static float time3;
    public static float time4;
    public static float time5;
    public static float time6;
    public static float time7;
    public static float time8;
    public static float time9;
    public static float time10;
    public static string result1;
    public static string result2;
    public static string result3;
    public static string result4;
    public static string result5;
    public static string result6;
    public static string result7;
    public static string result8;
    public static string result9;
    public static string result10;
    public static int scoreval;
    public Text scoretext;
    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;
    private int c1, c2;
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
            scoreval++;
            right++;
            if (scoreval == 1)
            {
                result1 = "Right answer";
            }
            else if (scoreval == 2)
            {
                result2 = "Right answer";
            }
            else if (scoreval == 3)
            {
                result3 = "Right answer";
            }
            else if (scoreval == 4)
            {
                result4 = "Right answer";
            }
            else if (scoreval == 5)
            {
                result5 = "Right answer";
            }
            else if (scoreval == 6)
            {
                result6 = "Right answer";
            }
            else if (scoreval == 7)
            {
                result7 = "Right answer";
            }
            else if (scoreval == 8)
            {
                result8 = "Right answer";
            }
            else if (scoreval == 9)
            {
                result9 = "Right answer";
            }
            else if (scoreval == 10)
            {
                result10 = "Right answer";
            }

        }
        else
        {
            elapsedTime = Time.time - startTime;
            Debug.Log(elapsedTime);
            SceneManager.LoadScene("Eqs_subwrong1");
            scoreval++;
            fail++;
            if (scoreval == 1)
            {
                result1 = "Wrong answer";
            }
            else if (scoreval == 2)
            {
                result2 = "Wrong answer";
            }
            else if (scoreval == 3)
            {
                result3 = "Wrong answer";
            }
            else if (scoreval == 4)
            {
                result4 = "Wrong answer";
            }
            else if (scoreval == 5)
            {
                result5 = "Wrong answer";
            }
            else if (scoreval == 6)
            {
                result6 = "Wrong answer";
            }
            else if (scoreval == 7)
            {
                result7 = "Wrong answer";
            }
            else if (scoreval == 8)
            {
                result8 = "Wrong answer";
            }
            else if (scoreval == 9)
            {
                result9 = "Wrong answer";
            }
            else if (scoreval == 10)
            {
                result10 = "Wrong answer";
            }
        }
        Debug.Log(scoreval);
        //timearray1[scoreval - 1] = elapsedTime;
        if (scoreval == 1)
        {
            time1 = elapsedTime;
        }
        else if (scoreval == 2)
        {
            time2 = elapsedTime;
        }
        else if (scoreval == 3)
        {
            time3 = elapsedTime;
        }
        else if (scoreval == 4)
        {
            time4 = elapsedTime;
        }
        else if (scoreval == 5)
        {
            time5 = elapsedTime;
        }
        else if (scoreval == 6)
        {
            time6 = elapsedTime;
        }
        else if (scoreval == 7)
        {
            time7 = elapsedTime;
        }
        else if (scoreval == 8)
        {
            time8 = elapsedTime;
        }
        else if (scoreval == 9)
        {
            time9 = elapsedTime;
        }

        else if (scoreval == 10)
        {
            time10 = elapsedTime;
            SceneManager.LoadScene("Eqs_addsub_endscene");
            Eqs_addsub_endscene.lvldecider = 1.4f;
            //scorenewval = CorrectLevel_1.scoreval;
            //scoredis.text = scorenewval.ToString();
        }
    }
}

