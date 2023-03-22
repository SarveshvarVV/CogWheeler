using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class UI_Menu_Controller : MonoBehaviour
{

    public AudioSource BtnSound;
    private GameObject ChaseAudioSource, MemoryMatchAudioSource, BallonAudioSource, PatternRecogAudioSource, TrackAudioSource, SeekAlphabetsAudioSource, SeekSmileyAudioSource, LightsOutAudioSource, EqsAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        BallonAudioSource = Balloons_Menu_Script.Ballons_game_audio;
        ChaseAudioSource = Chase_Menu_Script.Chase_game_audio;
        MemoryMatchAudioSource = PR_ChangeScene.PRGameBGM;
        PatternRecogAudioSource = Memory_SceneManager.Chase_Game_audio;
        TrackAudioSource = Track_Menucontrols.TrackAudioBGM;
        SeekAlphabetsAudioSource = SeekAlphabets_MenuPlayBtn.SeekAlphabetsBgmObj;
        SeekSmileyAudioSource = SeekSmiley_PlayButton.SeekSmileyBgmObj;
        LightsOutAudioSource = LightsOut_menuController.LightsOutBgmObj;
        EqsAudioSource = Eqs_addsub_scenemanager.EQBgmObj;
        Destroy(BallonAudioSource);
        Destroy(ChaseAudioSource);
        Destroy(MemoryMatchAudioSource);
        Destroy(PatternRecogAudioSource);
        Destroy(TrackAudioSource);
        Destroy(SeekAlphabetsAudioSource);
        Destroy(SeekSmileyAudioSource);
        Destroy(LightsOutAudioSource);
        Destroy(EqsAudioSource);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void baby_gurl()
    {
        BtnSound.Play();
    }

    public void Balloons()
    {
        SceneManager.LoadScene("Balloons_Menu");
    }
    public void Chase()
    {
        SceneManager.LoadScene("Chase_Menu");
    }
    public void Eqn()
    {
        SceneManager.LoadScene("Eqs_Menu");
    }
    public void Lights_out()
    {
        SceneManager.LoadScene("LightsOut_TimerScreen");
    }
    public void Memory()
    {
        SceneManager.LoadScene("Memory_Menu");
    }
    public void PR()
    {
        SceneManager.LoadScene("PR_Menu");
    }
    public void SeekAlpha()
    {
        SceneManager.LoadScene("Alphabet_Menu");
    }
    public void Smiley()
    {
        SceneManager.LoadScene("Smiley_Menu");
    }
    public void Track()
    {
        SceneManager.LoadScene("Track_Menu");
    }
}
