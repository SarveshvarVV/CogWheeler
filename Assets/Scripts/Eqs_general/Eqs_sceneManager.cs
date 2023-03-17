using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eqs_sceneManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void div1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_div1");
        PlayerPrefs.SetString("last_scene","Eqs_div1");
        PlayerPrefs.Save();

    }
    public void div2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_div2");
        PlayerPrefs.SetString("last_scene", "Eqs_div2");
        PlayerPrefs.Save();
    }
    
    public void mult1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_mullev1");
        PlayerPrefs.SetString("last_scene", "Eqs_mullev1");
        PlayerPrefs.Save();
    }
    public void mult2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_mullev2");
        PlayerPrefs.SetString("last_scene", "Eqs_mullev2");
        PlayerPrefs.Save();
    }
}
