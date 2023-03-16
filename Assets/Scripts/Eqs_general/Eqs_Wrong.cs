using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eqs_Wrong : MonoBehaviour
{
    public void sub1()
    {
        SceneManager.LoadScene("Eqs_sublvl1");
    }
    public void sub2()
    {
        SceneManager.LoadScene("Eqs_sublvl2");
    }
    public void sub3()
    {
        SceneManager.LoadScene("Eqs_sublvl3");
    }
    public void add1()
    {
        SceneManager.LoadScene("Eqs_addlvl1");
    }
    public void add2()
    {
        SceneManager.LoadScene("Eqs_addlvl2");
    }
    public void add3()
    {
        SceneManager.LoadScene("Eqs_addlvl3");
    }
}
