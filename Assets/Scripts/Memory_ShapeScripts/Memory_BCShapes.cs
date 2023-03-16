using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory_BCShapes : MonoBehaviour
{
    private SpriteRenderer theSprite;
    private Memory_GMShapes theGm;


    public int thisButtonNumber;
    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theGm = FindObjectOfType<Memory_GMShapes>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        theSprite.color = new Color(1, 0, 0, 1.5f);
    }
    private void OnMouseUp()
    {
        theSprite.color = new Color(1, 1, 1, 0.5f);
        theGm.ColourPressed(thisButtonNumber);

    }
}
