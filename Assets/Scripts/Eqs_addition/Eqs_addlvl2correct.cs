using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;


public class Eqs_addlvl2correct : MonoBehaviour
{
    private string minutes, seconds, milliseconds;
    public TextMeshProUGUI timeTaken;
    public string previousLevel;
    public string last_scene = "last_scene";
    public static float elapsedTime;
    public int privnum;
    public int scorenewval;
    //public int score=0;
    //public TextMeshProUGUI rightdis;
    public static int rightval;
    public static int scoreval;
    public static int failval;
    //public TextMeshProUGUI scoredis;
    //public TextMeshProUGUI faildis;

    private GameObject BgmObj;

    public int levelCount;

    // Start is called before the first frame update
    void Start()
    {
        BgmObj = Eqs_addsub_scenemanager.EQBgmObj;
        BgmObj.GetComponent<AudioSource>().Pause();

        levelCount = Eqs_addlvl2manager.levelCount;
        elapsedTime = Eqs_addlvl2manager.elapsedTime;

        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor(elapsedTime * 1000).ToString("00");

        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);

        previousLevel = PlayerPrefs.GetString(last_scene);
        scorenewval = Eqs_addlvl2manager.scoreval;
       // scoredis.text = "Score:" + scorenewval.ToString();
        //scoredis.SetText("scoretext");

    }

    // Update is called once per frame
    void Update()
    {
        //rightval = Eqs_addlvl2manager.right;
        //rightdis.text = "Correct:" + rightval.ToString();
        //failval = Eqs_addlvl2manager.fail;
        //faildis.text = "Wrong:" + failval.ToString();
    }

    public void Clicked()
    {
        BgmObj = Eqs_addsub_scenemanager.EQBgmObj;
        BgmObj.GetComponent<AudioSource>().Play();
        if (levelCount == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
        else
        {
            SceneManager.LoadScene(previousLevel);
        }
    }
    public void menu_clicked()
    {
        BgmObj = Eqs_addsub_scenemanager.EQBgmObj;
        BgmObj.GetComponent<AudioSource>().Play();
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