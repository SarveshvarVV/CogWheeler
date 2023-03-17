using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eqs_addsub_endscene : MonoBehaviour
{
    public TextMeshProUGUI[] timeTaken;
    public TextMeshProUGUI[] result;
    public TMP_Text avg;
    public string last_scene;     // Get the scene(level) from the menu of the game

    private List<float> timeList;
    private List<string> resultList;

    public float avgTime;

    // Start is called before the first frame update
    void Start()
    {
        last_scene = PlayerPrefs.GetString("last_scene");

        if (last_scene == "Eqs_addlvl1")
        {
            timeList = Eqs_addlvl1manager.timeList;
            resultList = Eqs_addlvl1manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_addlvl2")
        {
            timeList = Eqs_addlvl2manager.timeList;
            resultList = Eqs_addlvl2manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_addlvl3")
        {
            timeList = Eqs_addlvl3manager.timeList;
            resultList = Eqs_addlvl3manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_sublvl1")
        {
            timeList = Eqs_sub1manager.timeList;
            resultList = Eqs_sub1manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_sublvl2")
        {
            timeList = Eqs_sub2manager.timeList;
            resultList = Eqs_sub2manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }
        else if (last_scene == "Eqs_sublvl3")
        {
            timeList = Eqs_sub3manager.timeList;
            resultList = Eqs_sub3manager.resultList;
            for (int i = 0; i < 10; i++)
            {
                avgTime += timeList[i];
            }
            avgTime /= timeList.Count;
            avg.SetText("Average: " + avgTime.ToString());
            for (int j = 0; j < 10; j++)
            {
                timeTaken[j].SetText(timeList[j].ToString());
                result[j].SetText(resultList[j].ToString());
            }
        }

    }
    public void menu_clicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_Menu");
    }
}
