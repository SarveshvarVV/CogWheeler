using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeekSmiley_MainLevel : MonoBehaviour
{
    string correctSmiley = SeekSmiley_randomSmiley.correctSmiley;
    public Button[] buttons;
    int correctAns;

    public static string current_scene;

    [SerializeField] private string victoryLevel = "Smiley_Victory";

    [SerializeField] private string wrongLevel = "Smiley_Wrong";

    private float startTime;
    public static float elapsedTime;

    public static List<float> ETList = new();

    public static int score = 0;


    private void Awake()
    {
        getNumberOfCorrectAns();
    }

    // Start is called before the first frame update
    void Start()
    {
        current_scene = SceneManager.GetActiveScene().name;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (correctAns == 0)
        {
            score++;
            SceneManager.LoadScene(victoryLevel);
            elapsedTime = Time.time - startTime;
            ETList.Add(elapsedTime);
            if(elapsedTime < 2)
            {
                score += 5;
            }
            else if(elapsedTime < 6)
            {
                score += 3;
            }
            else if (elapsedTime < 10)
            {
                score += 1;
            }
            else if(elapsedTime > 10)
            {
                score += 1;
            }
        }

    }

    private void getNumberOfCorrectAns()
    {
        foreach(Button i in buttons)
        {
            if(i.image.sprite.name == correctSmiley)
            {
                correctAns++;
            }
        }
    }

    public void Check()
    {
        Image selectedbtn = EventSystem.current.currentSelectedGameObject.GetComponent<Image>();
        string selectedbtn_name = selectedbtn.sprite.name;
        if(selectedbtn_name == correctSmiley)
        {
            correctAns--;
            selectedbtn.gameObject.GetComponentInParent<Button>().interactable = false;
        }
        else
        {
            SceneManager.LoadScene(wrongLevel);
        }
    }

}
