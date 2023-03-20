    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class SeekAlphabets_CorrectLevelController : MonoBehaviour
{
    private float elapsedTime;
    public TextMeshProUGUI timeTaken, scoreText, avgTimeText;

    string minutes, seconds, milliseconds;
    private int score = SeekAlphabets_GameManager.score;
    private List<float> ETList = SeekAlphabets_GameManager.ETList;
    private float avtTime;
    public Button nextLevelbtn;
    public Button menu;
    public GameObject SeekAlphabetsBgm;

    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    private void Awake()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        elapsedTime = SeekAlphabets_GameManager.elapsedTime;

        minutes = Mathf.Floor(elapsedTime / 60).ToString("00");
        seconds = Mathf.Floor(elapsedTime % 60).ToString("00");
        milliseconds = Mathf.Floor((elapsedTime * 1000) % 1000).ToString("000");
        
    }

    // Start is called before the first frame update
    void Start()
    {
        SeekAlphabetsBgm = SeekAlphabets_MenuPlayBtn.SeekAlphabetsBgmObj;
        SeekAlphabetsBgm.GetComponent<AudioSource>().Pause();
        timeTaken.SetText("Time Taken: " + minutes + ":" + seconds + ":" + milliseconds);
        scoreText.text = "Score: " + score;
        if(SeekAlphabets_GameManager.levelCount == 10)
        {
            
            nextLevelbtn.gameObject.SetActive(false);
            menu.gameObject.SetActive(true);
            for(int i = 0; i < ETList.Count; i++)
            {
                avtTime += ETList[i];
            }
            avtTime /= ETList.Count;
            avgTimeText.text = "Average Time Taken: " + avtTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuBtn_clicked()
    {
        SceneManager.LoadScene("Alphabet_Menu");
    }

    public void NextBtn_clicked()
    {
        SeekAlphabetsBgm.GetComponent<AudioSource>().Play();
        string scene_name = PlayerPrefs.GetString("LastScene");
        SceneManager.LoadScene(scene_name);

    }



}
