using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eqs_Wrng : MonoBehaviour
{

    private int levelCount_mul = Eqs_mulmanager1.levelCount;
    private int levelCount_mul2 = Eqs_mulmanager2.levelCount;
    private int levelCount_div1 = Eqs_lvl1_GameManager.levelCount;
    private int levelCount_div2 = Eqs_lvl2_GameManager.levelCount;

    public void div1()
    {
        SceneManager.LoadScene("Eqs_div1");
        if (levelCount_div1 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene");
        }
    }
    public void div2()
    {
        SceneManager.LoadScene("Eqs_div2");
        if (levelCount_div2 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene");
        }
    }
    public void mul1()
    {
        SceneManager.LoadScene("Eqs_mullev1");
        if (levelCount_mul == 10)
        {
            SceneManager.LoadScene("Eqs_endscene");
        }
    }
    public void mul2()
    {
        SceneManager.LoadScene("Eqs_mullev2");
        if (levelCount_mul2 == 10)
        {
            SceneManager.LoadScene("Eqs_endscene");
        }
    }




}
