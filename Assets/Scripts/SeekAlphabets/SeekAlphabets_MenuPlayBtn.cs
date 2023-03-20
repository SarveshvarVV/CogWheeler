using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SeekAlphabets_MenuPlayBtn : MonoBehaviour
{
    public AudioSource SeekAlphabetsBgm;
    public static GameObject SeekAlphabetsBgmObj;

    // Start is called before the first frame update
    void Start()
    {
        SeekAlphabetsBgmObj = SeekAlphabetsBgm.gameObject;
        DontDestroyOnLoad(SeekAlphabetsBgmObj);
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
