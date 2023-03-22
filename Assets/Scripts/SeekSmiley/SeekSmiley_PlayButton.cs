using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SeekSmiley_PlayButton : MonoBehaviour
{
    [SerializeField] private string seekingSmileyLevel = "Smiley_seekingSmiley";
    public AudioSource SeekSmiley;
    public static GameObject SeekSmileyBgmObj;
    public AudioSource BtnClick;
    public static GameObject BtnClickObj;

    // Start is called before the first frame update
    void Start()
    {
        BtnClickObj = BtnClick.gameObject;
        DontDestroyOnLoad(BtnClickObj);
        SeekSmileyBgmObj = SeekSmiley.gameObject;
        DontDestroyOnLoad(SeekSmileyBgmObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlay()
    {
        SceneManager.LoadScene(seekingSmileyLevel);

    }
}
