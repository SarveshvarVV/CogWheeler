using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR_MenuGo : MonoBehaviour
{
    public GameObject PRBgm;
    private void Awake()
    {
        PRBgm = PR_ChangeScene.PRGameBGM;
    }
    public void Goto()
    {
        Destroy(PRBgm);
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Menu"); //menu screen is loaded
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }



}
