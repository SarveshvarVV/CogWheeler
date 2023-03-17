using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eqs_Wrong : MonoBehaviour
{
    private int levelCount_add1 = Eqs_addlvl1manager.levelCount;
    private int levelCount_add2 = Eqs_addlvl2manager.levelCount;
    private int levelCount_add3 = Eqs_addlvl3manager.levelCount;
    private int levelCount_sub1 = Eqs_sub1manager.levelCount;
    private int levelCount_sub2 = Eqs_sub2manager.levelCount;
    private int levelCount_sub3 = Eqs_sub3manager.levelCount;


    public void sub1()
    {
        SceneManager.LoadScene("Eqs_sublvl1");
        if (levelCount_sub1 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
    public void sub2()
    {
        SceneManager.LoadScene("Eqs_sublvl2");
        if (levelCount_sub2 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
    public void sub3()
    {
        SceneManager.LoadScene("Eqs_sublvl3");
        if (levelCount_sub3 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
    public void add1()
    {
        SceneManager.LoadScene("Eqs_addlvl1");
        if (levelCount_add1 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
    public void add2()
    {
        SceneManager.LoadScene("Eqs_addlvl2");
        if (levelCount_add2 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
    public void add3()
    {
        SceneManager.LoadScene("Eqs_addlvl3");
        if (levelCount_add3 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene_add_sub");
        }
    }
}
