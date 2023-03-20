using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Balloons_Menu_Script : MonoBehaviour
{

    public static int objlvl = 0;
    public AudioSource btnSound;
    public AudioSource GameAudio;
    public static GameObject Ballons_game_audio;

    private void Start()
    {
        Ballons_game_audio = GameAudio.gameObject;
        DontDestroyOnLoad(Ballons_game_audio);
    }

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

    public void BtnClickSound()
    {
        btnSound.Play();
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
}
