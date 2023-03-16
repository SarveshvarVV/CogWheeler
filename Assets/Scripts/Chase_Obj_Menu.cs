using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Chase_Obj_Menu : MonoBehaviour
{
    public static Sprite SelectedSprite;

    public void Nexttouch()
    {
        Button selected_btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();  //getting the input as to which button is selected

        Image img = selected_btn.GetComponent<Image>();  //the selected button's image is read
        
        Sprite sel_sprite = img.sprite;   //from image the sprite is read
        
        SelectedSprite = sel_sprite;      //assigning the retrived sprite to a static variable, which will be used in the gamemanager scripts of scenes
        
        Debug.Log(SelectedSprite.name);

        DontDestroyOnLoad(SelectedSprite);  //Sprites will be destroyed even if they are static in unity when scene is changed, so we are overriding that using this.

        //redirecting to the correct scene. (got the objlvl from MenuScript)
        if(Chase_Menu_Script.objlvl == 1)        
        {
            SceneManager.LoadScene("Chase_Ez");
        }
        else if(Chase_Menu_Script.objlvl == 2)
        {
            SceneManager.LoadScene("Chase_Hard");
        }
    }


}