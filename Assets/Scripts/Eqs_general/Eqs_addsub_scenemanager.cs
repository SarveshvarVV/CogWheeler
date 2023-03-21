using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Eqs_addsub_scenemanager : MonoBehaviour
{
    public AudioSource EQBgm;
    public static GameObject EQBgmObj;

    // Start is called before the first frame update
    void Start()
    {
        EQBgmObj = EQBgm.gameObject;
        DontDestroyOnLoad(EQBgmObj);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GS()
    {
        Destroy(EQBgmObj);
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
    public void add1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl1");
        PlayerPrefs.SetString("last_scene", "Eqs_addlvl1");
        PlayerPrefs.Save();
    }
    public void add2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl2");
        PlayerPrefs.SetString("last_scene", "Eqs_addlvl2");
        PlayerPrefs.Save();
    }
    public void add3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl3");
        PlayerPrefs.SetString("last_scene", "Eqs_addlvl3");
        PlayerPrefs.Save();
    }
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_Menu");
        
    }
    public void sub1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl1");
        PlayerPrefs.SetString("last_scene", "Eqs_sublvl1");
        PlayerPrefs.Save();
    }
    public void sub2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl2");
        PlayerPrefs.SetString("last_scene", "Eqs_sublvl2");
        PlayerPrefs.Save();
    }
    public void sub3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl3");
        PlayerPrefs.SetString("last_scene", "Eqs_sublvl3");
        PlayerPrefs.Save();
    }
    
}
