using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LightsOut_menuController : MonoBehaviour
{
    public AudioSource LightsOutBgm;
    public static GameObject LightsOutBgmObj;
    // Start is called before the first frame update
    void Start()
    {
        LightsOutBgmObj = LightsOutBgm.gameObject;
        DontDestroyOnLoad(LightsOutBgmObj);
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
