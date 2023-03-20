using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Chase_Menu_Script : MonoBehaviour
{

    //public static bool objez=false;
    //public static bool objhard = false;
    //public static bool objmed = false;
    //// Start is called before the first frame update
    public static int objlvl = 0;
    public AudioSource GameAudio;
    public static GameObject Chase_game_audio;
    public AudioSource BtnClick;

    private void Start()
    {
        Chase_game_audio = GameAudio.gameObject;
        DontDestroyOnLoad(Chase_game_audio);
    }

    public void ObjEz()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_Objects_Menu");
        objlvl = 1;
    }
    public void ObjMed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_Objects_Menu");
        objlvl = 2;
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
   

    public void BtnClickSound()
    {
        BtnClick.Play();
    }
}
