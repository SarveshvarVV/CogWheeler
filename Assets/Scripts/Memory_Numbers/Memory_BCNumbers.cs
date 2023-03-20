using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Memory_BCNumbers : MonoBehaviour
{
    private SpriteRenderer theSprite;
    private Memory_GMNumbers theGm;

    public AudioSource btnClick;
    public int thisButtonNumber;
    // Start is called before the first frame update
    void Start()
    {
        
        theSprite = GetComponent<SpriteRenderer>();
        theGm = FindObjectOfType<Memory_GMNumbers>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void OnMouseDown()
    {
        btnClick.Play();
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1.5f);
    }
    private void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.5f);
        theGm.NumberPressed(thisButtonNumber);
       
    }
}


