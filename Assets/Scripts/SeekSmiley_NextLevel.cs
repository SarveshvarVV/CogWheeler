using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SeekSmiley_NextLevel : MonoBehaviour
{

    public string nextLevel;

    public TextMeshProUGUI timeTaken;
    public TextMeshProUGUI avgTimeTaken, scoreText;

    public Button nextBtn;
    public Button restartBtn;

    public float elapsedTime;
    public float avgET;

    string minutes, seconds, milliseconds, avgmin, avgsec, avgmsec;
    public int score;
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    private void Awake()
    {
        score = SeekSmiley_MainLevel.score;
        elapsedTime = SeekSmiley_MainLevel.elapsedTime;

        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor((elapsedTime * 1000) % 1000).ToString("000");
        scoreText.text = "Score: " + score;

        if (SeekSmiley_NextButton.staticLevelList.Count != 0)
        {
            int randomize = UnityEngine.Random.Range(0, SeekSmiley_NextButton.staticLevelList.Count);
            nextLevel = SeekSmiley_NextButton.staticLevelList[randomize];
            SeekSmiley_NextButton.staticLevelList.Remove(nextLevel);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);
        if (SeekSmiley_NextButton.staticLevelList.Count == 0)
        {
            for(int i = 0; i < SeekSmiley_MainLevel.ETList.Count; i++)
            {
                avgET += SeekSmiley_MainLevel.ETList[i];
            }
            avgET /= 10;
            avgmin = Mathf.Floor(avgET / 60).ToString("00");
            avgsec = Mathf.Floor(avgET % 60).ToString("00");
            avgmsec = Mathf.Floor((avgET * 1000) % 1000).ToString("000");
            avgTimeTaken.SetText("Average Time Taken: " + avgmin + ":" + avgsec + ":" + avgmsec);

            nextBtn.gameObject.SetActive(false);
            restartBtn.gameObject.SetActive(true);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextBtn_Clicked()
    {
        if (SeekSmiley_NextButton.staticLevelList.Count != 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    public void restartBtn_Clicked()
    {
        SceneManager.LoadScene("Smiley_Menu");
    }

}
