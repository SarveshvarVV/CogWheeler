using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Balloons_Hard_GameManager : MonoBehaviour
{

    public float maxx, maxy;
    public GameObject[] circle;
    public static int random1;
    public static float timer_hard=0;
    public TMP_Text score;
    public TMP_Text tim;
    public static bool setTimer3;
    private GameObject c;
    private float currentTimetoSpawn;
    private float timetospawn = 1.7f;
    float currentTime;
    public float startingTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        spawning();
        destroying();
        currentTime = startingTime;
    }

    // Update is called once per frame
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
            destroying();
            currentTimetoSpawn = timetospawn;
        }

        timing();
        score.text = "Score: " + Balloons_testDestroy.count;                // display the current score
        tim.text = "Time Remaining: " + Mathf.RoundToInt(currentTime);  // instead of score, display the timer in reverse order
    }

    // Spawning the Object in a imaginary box of boundries set here
    public void spawning()
    {
        maxx = Random.Range(-6, 6);
        maxy = Random.Range(-4, 4);
        random1 = Random.Range(0, circle.Length);

        c = Instantiate(circle[random1], new Vector3(maxx, maxy, 0), Quaternion.identity);

    }

    //counting time 
    public void timing()
    {
        if (currentTime <= 0)
        {
            setTimer3 = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_End_Screen");
        }
        else
        {
            timer_hard += Time.deltaTime;
            setTimer3 = false;
        }
    }
    // after every 3 seconds, the object will be destroyed to make the game more interesting
    public void destroying()
    {
        Destroy(c,3f);
    }



}
