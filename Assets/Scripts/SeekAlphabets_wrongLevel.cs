using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekAlphabets_wrongLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retryBtn_clicked()
    {

        string scene_name = PlayerPrefs.GetString("LastScene");
        SceneManager.LoadScene(scene_name);
    }

}
