using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track_Menucontrols : MonoBehaviour
{
    public static bool ez;
    // Start is called before the first frame update
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
