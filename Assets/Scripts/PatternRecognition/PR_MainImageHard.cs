using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR_MainImageHard : MonoBehaviour
{

    [SerializeField] private GameObject image_unknown;
    [SerializeField] private PR_GameControllerHard gameController;



    public void OnMouseDown() //checks if user touches the screen
    {

        if (image_unknown.activeSelf && gameController.canOpen)
        {
            image_unknown.SetActive(false);             //question mark object is hiddern
            gameController.imageOpened(this);           //the main object is the image opened
        }

    }
    private int sprite_ID;
    public int spriteID
    {
        get { return sprite_ID; }  //sprite id is returned
    }

    public void ChangeSprite(int id, Sprite image)
    {
        sprite_ID = id;
        GetComponent<SpriteRenderer>().sprite = image; //gets sprite renderer to change sprite

    }
    public void Close()
    {
        image_unknown.SetActive(true); //Hide image
    }
}