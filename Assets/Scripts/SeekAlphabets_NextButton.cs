using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SeekAlphabets_NextButton : MonoBehaviour
{
    public string selectLetterLevel;
    public static Sprite SelectedSprite;

    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Nexttouch() 
    {
        Button selected_btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        Image img = selected_btn.GetComponent<Image>();
        Sprite sel_sprite = img.sprite;
        SelectedSprite = sel_sprite;
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(selectLetterLevel);
    }

}
