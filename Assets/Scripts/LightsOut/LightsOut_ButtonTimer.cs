using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class LightsOut_ButtonTimer : MonoBehaviour
{

    public float timeLimit; // the time limit for each timer
    private bool timerActive = false; // whether the timer is currently active
    private float timeLeft; // the amount of time left on the timer
    Button btn;
    public Sprite glow, dark;

    public AudioSource BulbOn;
    public AudioSource BulbOff;

    void Start()
    {

        timeLimit = LightsOut_timerController.timer;
        Button b = gameObject.GetComponent<Button>();
        btn = b;
        // Initialize the timer
        timeLeft = timeLimit;
        //UpdateTimerDisplay();
    }

    void Update()
    {
        // Only update the timer if it's active
        if (timerActive)
        {
            timeLeft -= Time.deltaTime;
            //UpdateTimerDisplay();

            // If the timer runs out, deactivate it
            if (timeLeft <= 0f)
            {
                btn.interactable = true;
                btn.image.sprite = glow;
                timerActive = false;
                timeLeft = timeLimit;

                //UpdateTimerDisplay();
            }
        }
    }

    // Call this function when the button is clicked to start the timer
    public void StartTimer()
    {
        BulbOff.Play();
        btn = gameObject.GetComponent<Button>();
        btn.interactable = false;
        btn.image.sprite = dark;
        timerActive = true;
    }

    // Call this function to get the amount of time left on the timer
    public float GetTimeLeft()
    {
        return timeLeft;
    }

    public bool isTimerActive()
    {
        return timerActive;
    }

    // Update the timer text display
    //private void UpdateTimerDisplay()
    //{
    //    timerText.text = "Time left: " + timeLeft.ToString("F1") + "s";
    //}


}
