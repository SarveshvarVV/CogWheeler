using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eqs_addsub_scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void add1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl1");
    }
    public void add2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl2");
    }
    public void add3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_addlvl3");
    }
    public void back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_Menu");
    }
    public void sub1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl1");
    }
    public void sub2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl2");
    }
    public void sub3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_sublvl3");
    }
}
