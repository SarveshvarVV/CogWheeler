using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekAlphabets_selectLeveldiffTamil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_easy()
    {
        SceneManager.LoadScene("Alphabet_TamilMainLevel");
    }
    public void click_med()
    {
        SceneManager.LoadScene("Alphabet_TamilMainLevelMedium");
    }
    public void click_hard()
    {
        SceneManager.LoadScene("Alphabet_TamilMainLevelHard");
    }
}
