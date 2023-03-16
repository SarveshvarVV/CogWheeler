using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut_menuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menuBtn_clicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LightsOut_TimerScreen");
    }
}
