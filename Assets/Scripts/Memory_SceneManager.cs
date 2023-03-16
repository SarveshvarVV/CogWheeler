using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory_SceneManager : MonoBehaviour
{
    public void GoToColors()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Memory_Colours");
    }
    public void GoToShape()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Memory_Shapes");
    }
    public void GoToNumbers()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Memory_Numbers");
    }
}
