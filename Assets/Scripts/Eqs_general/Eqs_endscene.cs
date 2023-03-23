using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.UI;

public class Eqs_endscene : MonoBehaviour
{
    public TextMeshProUGUI[] timeTaken;
    public TextMeshProUGUI[] result;
    public TextMeshProUGUI avg;
    public string last_scene;     // Get the scene(level) from the menu of the game

    private List<float> timeList;
    private List<string> resultList;

    private float avgTime;

    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    void Start()
    {
        last_scene = PlayerPrefs.GetString("last_scene");
        if (last_scene == "Eqs_mullev1") 
        {
            Eqs_mulmanager1.levelCount= 0;
            timeList = Eqs_mulmanager1.timeList;
            resultList = Eqs_mulmanager1.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText(avgTime.ToString());
            for(int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }

        else if (last_scene == "Eqs_mullev2")
        {
            Eqs_mulmanager2.levelCount = 0;
            timeList = Eqs_mulmanager2.timeList;
            resultList = Eqs_mulmanager2.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText(avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_div1")
        {
            Eqs_lvl1_GameManager.levelCount = 0;
            timeList = Eqs_lvl1_GameManager.timeList;
            resultList = Eqs_lvl1_GameManager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText(avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }


        }
        else if (last_scene == "Eqs_div2")
        {
            Eqs_lvl2_GameManager.levelCount = 0;
            timeList = Eqs_lvl2_GameManager.timeList;
            resultList = Eqs_lvl2_GameManager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText(avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
    }        // Update is called once per frame
            void Update()
    {
        
    }

    public void menu_clicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_Menu");
    }

}
