using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Memory_SceneManager : MonoBehaviour
{

    public AudioSource GameAudio;
    public static GameObject Chase_Game_audio;

    private void Start()
    {

        Chase_Game_audio = GameAudio.gameObject;
        DontDestroyOnLoad(Chase_Game_audio);
    }
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
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
}
