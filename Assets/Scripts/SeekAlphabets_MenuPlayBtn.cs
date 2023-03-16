using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeekAlphabets_MenuPlayBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SeekAlphabets_GameManager.levelCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBtn_Clicked()
    {
        SceneManager.LoadScene("Alphabet_SelectLetters");
    }

    public void TamilPlayBtn_Clicked()
    {
        SceneManager.LoadScene("Alphabet_TamilSelectLetters");
    }

}
