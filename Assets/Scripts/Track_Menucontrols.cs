using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Track_Menucontrols : MonoBehaviour
{
    public static bool ez;
    public AudioSource TrackBGMAudio;
    public static GameObject TrackAudioBGM;
    // Start is called before the first frame update
    private void Start()
    {
        TrackAudioBGM = TrackBGMAudio.gameObject;
        DontDestroyOnLoad(TrackAudioBGM);
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    public void GotoEz()
    {
        ez = true;
        
        SceneManager.LoadScene("Track_Objects");
    }
    public void GotoHard()
    {
        ez = false;
        
        SceneManager.LoadScene("Track_Objects");
    }

    public void GotoEZLetters()
    {
        ez = true;
        SceneManager.LoadScene("Track_Alphabets");
    }
    public void GotoHardLetters()
    {
        ez = false;
        SceneManager.LoadScene("Track_Alphabets");
    }
    public void GoToEZNumbers()
    {
        ez = true;
        SceneManager.LoadScene("Track_Numbers");
    }
    public void GoToHardNumbers()
    {
        ez = false;
        SceneManager.LoadScene("Track_Numbers");
    }
    public void GoToEZTamil()
    {
        ez = true;
        SceneManager.LoadScene("Track_Tamil");
    }
    public void GoToHardTamil()
    {
        ez = false;
        SceneManager.LoadScene("Track_Tamil");
    }
    
}
