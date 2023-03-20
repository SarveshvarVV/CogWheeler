using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekAlphabets_wrongLevel : MonoBehaviour
{
    public GameObject SeekAlphabetsBgm;
    // Start is called before the first frame update
    void Start()
    {
        SeekAlphabetsBgm = SeekAlphabets_MenuPlayBtn.SeekAlphabetsBgmObj;
        SeekAlphabetsBgm.GetComponent<AudioSource>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retryBtn_clicked()
    {
        SeekAlphabetsBgm.GetComponent<AudioSource>().Play();
        string scene_name = PlayerPrefs.GetString("LastScene");
        SceneManager.LoadScene(scene_name);
    }

}
