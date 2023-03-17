using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Eqs_CorrectLevelController : MonoBehaviour
{

    public float elapsedTime;
    private string minutes, seconds, milliseconds;
    public TextMeshProUGUI timeTaken;
    public string previousLevel;
    public string last_scene = "last_scene";
    public int privnum;
    public static int right;
    //public int score=0;
    public static int fail = 0;
    //public TextMeshProUGUI rightdis;
    public static int rightval;
    public static int scoreval;
    public static int failval;
    //public int scorenewval;
    public Text scoretext;
    //public TextMeshProUGUI scoredis;
    //public TextMeshProUGUI faildis;

    private int levelCount;


    // Start is called before the first frame update
    void Start()
    {
        levelCount = Eqs_lvl2_GameManager.levelCount;
        elapsedTime = Eqs_lvl2_GameManager.elapsedTime;

        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor(elapsedTime * 1000).ToString("00");

        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);

        previousLevel = PlayerPrefs.GetString(last_scene);
        //scorenewval = Eqs_lvl2_GameManager.scoreval;
        // scoredis.text = scorenewval.ToString();
    //scoredis.SetText("scoretext");


    }

    // Update is called once per frame
    void Update()
    {
        //rightval = Eqs_lvl2_GameManager.right;
        //rightdis.text = rightval.ToString();
        //failval = Eqs_lvl2_GameManager.fail;
        //faildis.text = failval.ToString();
    
    }

    public void Clicked()
    {
        if (levelCount == 10)
        {
            SceneManager.LoadScene("Eqs_endscene");
        }
        else
        {
            SceneManager.LoadScene(previousLevel);
        }
    }
    //public void rightcount()
    //{
    //    rightval = lvl1_GameManager.right;
    //    rightdis.text = rightval.ToString();
    //}
    //public void failcount()
    //{
    //    failval = lvl1_GameManager.fail;
    //    faildis.text = failval.ToString();
    //}
}