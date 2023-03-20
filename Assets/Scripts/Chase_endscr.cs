using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chase_endscr : MonoBehaviour
{

    public TMP_Text score;
    void Update()
    {
        timer();
    }

    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    //for back button
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_Menu");
    }

    //displaying the time taken in the game
    //called in the update function.
    public void timer()
    {
        if (Chase_EzManager.setTimerObj1 == true)
        {
            score.text = "Time Taken: " + Chase_EzManager.timer_obj + " seconds";
            Chase_EzManager.setTimerObj1 = false;
        }
        else if (Chase_Hard.setTimerObj2 == true)
        {
            score.text = "Time Taken: " + Chase_Hard.timer_obj + " seconds";
            Chase_Hard.setTimerObj2 = false;
        }
    }
}
