using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LightsOut_VictoryController : MonoBehaviour
{

    private float elapsedTime;
    private string minutes, seconds, milliseconds;
    public TextMeshProUGUI timeTaken;
    public int score;

    private void Awake()
    {
        elapsedTime = LightsOut_GameManager.elapsedtime;
        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor((elapsedTime * 1000) % 1000).ToString("000");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        score = LightsOut_GameManager.score;
        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);
        //scoreText.text = "Score: " + score;
    }
    public void backtoMenu()
    {
        SceneManager.LoadScene("LightsOut_Menu");
    }

}
