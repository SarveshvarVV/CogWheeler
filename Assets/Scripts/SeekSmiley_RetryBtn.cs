using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekSmiley_RetryBtn : MonoBehaviour
{
    private string last_scene = SeekSmiley_MainLevel.current_scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retryBtn_Clicked()
    {
        SceneManager.LoadScene(last_scene);
    }

}
