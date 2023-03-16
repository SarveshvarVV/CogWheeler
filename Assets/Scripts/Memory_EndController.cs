using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory_EndController : MonoBehaviour
{
    public void GoToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
