using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Track_EventController : MonoBehaviour
{
    // Start is called before the first frame update
        
    public static Sprite selected_object;
    public static int selectedsprite;

    void Start()
    {
        //btn_1.image.sprite = selected_sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked_btn()
    {
        Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        selected_object = btn.image.sprite; 
        DontDestroyOnLoad(gameObject);
        if (Track_Menucontrols.ez)
        {
            SceneManager.LoadScene("OGTrack");
        }
        else
        {
            SceneManager.LoadScene("OGTrackMedium");
        }
        Debug.Log("Objects Selected");
    }
    public void bottle()
    {
        selectedsprite = 1;
    }
    public void phone()
    {
        selectedsprite = 3;
    }
    public void keys()
    {
        selectedsprite = 2;
    }
    public void slippers()
    {
        selectedsprite = 4;
    }
    public void soap()
    {
        selectedsprite = 5;
    }
    public void specs()
    {
        selectedsprite = 6;
    }
    public void alphabet()
    {
        selectedsprite = 7;
    }
    public void number()
    {
        selectedsprite = 8;
    }
    public void tamil()
    {
        selectedsprite = 9;
    }
}
