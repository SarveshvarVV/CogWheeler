using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons_Menu_Script : MonoBehaviour
{

    public static int objlvl = 0;
    public void SceneMed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_Med");
    }
    public void SceneEz()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_Ez");
    }
    public void SceneHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Balloons_Hard");
    }
}
