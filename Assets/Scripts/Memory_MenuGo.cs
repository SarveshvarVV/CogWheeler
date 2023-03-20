using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory_MenuGo : MonoBehaviour
{
    // Start is called before the first frame update
    public void PoDa()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Memory_Menu");
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
}
