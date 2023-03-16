using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Balloons_Ez_GameManager : MonoBehaviour
{
    //declaring required variables
    public float maxx, maxy;
    public GameObject[] circle;
    public static int random1;
    public static float timer_ez=0;
    public TMP_Text score;
    public TMP_Text tim;
    public static bool setTimer1;
    private float currentTimetoSpawn;
    public float timetospawn = 3f;
    float currentTime;
    public float startingTime = 30f;
    void Start()
    {
        spawning();
        spawning();
        currentTime = startingTime;
    }

    // Update is called once per frame

    void Update()
    {   
        currentTime -= Time.deltaTime;
        //Calculating the delay between each spawn
        if (currentTimetoSpawn > 0)
        {
            currentTimetoSpawn -= Time.deltaTime;
        }
        else
        {
            spawning();
            currentTimetoSpawn = timetospawn;
        }

        timing();
        score.text = "Your Score: " + Balloons_testDestroy.count;                // display the current score
        tim.text = "Time Remaining: " + Mathf.RoundToInt(currentTime);      //displaying the time remianing
    }

    // Spawning the Object in a imaginary box of boundries set here
    public void spawning()
    {
        maxx = Random.Range(-6, 6);
        maxy = Random.Range(-4, 4);
        random1 = Random.Range(0, circle.Length);

        Instantiate(circle[random1], new Vector3(maxx, maxy, 0), Quaternion.identity);

    }

    //counting time and checking if the score attained the required to end the game
    public void timing()
    {   
        if(currentTime <= 0)
        {
            setTimer1 = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_End_Screen");
        }
        else
        {
            timer_ez += Time.deltaTime;
            setTimer1 = false;
        }
    }
}
