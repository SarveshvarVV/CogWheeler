using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    public void div2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_div2");
    }
    
    public void mult1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_mullev1");
    }
    public void mult2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Eqs_mullev2");
    }
}
