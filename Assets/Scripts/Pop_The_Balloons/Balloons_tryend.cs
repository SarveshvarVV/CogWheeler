using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Balloons_tryend : MonoBehaviour
{

    public TMP_Text score;
    private GameObject mainScreenAudioSource;
    //public TMP_Text count;
    private void Start()
    {
        mainScreenAudioSource = Balloons_Menu_Script.Ballons_game_audio;
        Destroy(mainScreenAudioSource);
    }
    void Update()
    {
        timer();
    }

    //for back button
    public void back()
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_Menu");
    }

    //displaying the time taken in the game
    //called in the update function.
    public void timer()
    {
        if (Balloons_Ez_GameManager.setTimer1 == true)
        {
            score.text = "Score Achieved: " + Balloons_testDestroy.count;
            Balloons_Ez_GameManager.setTimer1 = false;
            Balloons_testDestroy.count = 0;
        }
        else if (Balloons_Med_GameManager.setTimer2 == true)
        {
            score.text = "Score Achieved: " + Balloons_testDestroy.count;
            Balloons_Med_GameManager.setTimer2 = false;
            Balloons_testDestroy.count = 0;
        }
        else if (Balloons_Hard_GameManager.setTimer3 == true)
        {
            score.text = "Score Achieved: " + Balloons_testDestroy.count;
            Balloons_Hard_GameManager.setTimer3 = false;
            Balloons_testDestroy.count = 0;
        }
    }

    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }


}
