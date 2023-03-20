using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekSmiley_RetryBtn : MonoBehaviour
{
    private string last_scene = SeekSmiley_MainLevel.current_scene;
    public GameObject SeekSmileyBgm;

    // Start is called before the first frame update
    void Start()
    {
        SeekSmileyBgm = SeekSmiley_PlayButton.SeekSmileyBgmObj;
        SeekSmileyBgm.GetComponent<AudioSource>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retryBtn_Clicked()
    {
        SeekSmileyBgm.GetComponent<AudioSource>().Play();

        SceneManager.LoadScene(last_scene);
    }

    public void GS()
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }

}
