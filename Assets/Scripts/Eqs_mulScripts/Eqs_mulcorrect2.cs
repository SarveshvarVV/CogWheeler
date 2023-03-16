using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;


public class Eqs_mulcorrect2 : MonoBehaviour
{
    private string minutes, seconds, milliseconds;
    public TextMeshProUGUI timeTaken;
    public string previousLevel;
    public string last_scene = "last_scene";
    public static float elapsedTime;
    public int privnum;
    public int scorenewval;
    //public int score=0;
    public TextMeshProUGUI rightdis;
    public static int rightval;
    //public static int scoreval;
    public static int failval;
    public TextMeshProUGUI scoredis;
    public TextMeshProUGUI faildis;



    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = Eqs_mulmanager2.elapsedTime;

        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor(elapsedTime * 1000).ToString("00");

        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);

        previousLevel = PlayerPrefs.GetString(last_scene);
        //scorenewval = Eqs_mulmanager2.scoreval;
        //scoredis.text = scorenewval.ToString();
        //scoredis.SetText("scoretext");

    }

    // Update is called once per frame
    void Update()
    {
        rightval = Eqs_mulmanager2.right;
        rightdis.text = rightval.ToString();
        failval = Eqs_mulmanager2.fail;
        faildis.text = failval.ToString();
    }

    public void Clicked()
    {
        SceneManager.LoadScene(previousLevel);
    }
    public void menu_clicked()
    {
        SceneManager.LoadScene("Eqs_Chase_Menu");
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
