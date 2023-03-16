using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.Windows;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Balloons_Med_GameManager : MonoBehaviour
{
    //declaring required variables
    public float maxx,maxy;
    public GameObject[] circle;
    public static int random1;
    public static float timer_med=0;
    public TMP_Text score;
    public TMP_Text tim;
    public static bool setTimer2;
    private float currentTimetoSpawn;
    private float timetospawn = 5f;
    float currentTime;
    public float startingTime = 30f;
    void Start()
    {
        spawning();
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
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
        tim.text = "Time Remaining: " + Mathf.RoundToInt(currentTime);  //displaying score
    }

    // Spawning the Object in a imaginary box of boundries set here
    public void spawning() 
    {
        maxx = Random.Range(-6,6);
        maxy = Random.Range(-4,4);
        random1 = Random.Range(0, circle.Length);

        Instantiate(circle[random1],new Vector3(maxx, maxy, 0),Quaternion.identity);

    }
    
    //counting time and checking the score so that end screen will be loaded
    public void timing()
    {
        
        if (currentTime <= 0)
        {
            setTimer2 = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_End_Screen");
        }
        else
        {
            timer_med += Time.deltaTime;
            setTimer2 = false;
        }
    }
}
