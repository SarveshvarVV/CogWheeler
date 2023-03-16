using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Track_MoveDiagonal2 : MonoBehaviour
{
    public float speed;
    public bool Moved;
    public Sprite selobj;
    public float timer;
    private float ogtimer;
    public Image image;

    public float timeflow;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Track_EventController.selectedsprite == 1)
        {
            image.rectTransform.localScale = new Vector3(0.45f, 1.3f, 1);
        }
        else if (Track_EventController.selectedsprite == 2)
        {
            image.rectTransform.localScale = new Vector3(0.6f, 1, 1);
        }
        else if (Track_EventController.selectedsprite == 3)
        {
            image.rectTransform.localScale = new Vector3(0.55f, 1, 1);
        }
        else if (Track_EventController.selectedsprite == 4)
        {
            image.rectTransform.localScale = new Vector3(1, 1, 1);
        }
        else if (Track_EventController.selectedsprite == 5)
        {
            image.rectTransform.localScale = new Vector3(1.27f, 1, 1);
        }
        else if (Track_EventController.selectedsprite == 6)
        {
            image.rectTransform.localScale = new Vector3(1.18f, 0.79f, 1);
        }
        else if (Track_EventController.selectedsprite == 7)
        {
            image.rectTransform.localScale = new Vector3(0.85f, 0.85f, 1);
        }
        else if (Track_EventController.selectedsprite == 8)
        {
            image.rectTransform.localScale = new Vector3(0.7f, 0.95f, 1);
        }
        else if (Track_EventController.selectedsprite == 9)
        {
            image.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }
    void Start()
    {
        timeflow = 0;
        selobj = Track_EventController.selected_object;
        gameObject.GetComponent<Image>().sprite = selobj;
        ogtimer = timer; 
    }

    // Update is called once per frame
    void Update()
    {
        timeflow += Time.deltaTime;
        if(Moved){
            transform.Translate(2.13f* Time.deltaTime * speed,1 * Time.deltaTime * speed ,0);
            // transform.localScale = new Vector2(1,1);
        }
        else{
            transform.Translate(-2.13f * Time.deltaTime * speed,-1 * Time.deltaTime * speed ,0);
            // transform.localScale = new Vector2(-1,1);
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Collider")){
            if(Moved){
                Moved = false;
            }
            else{
                Moved = true;
            }
        }
    }
    private void OnMouseOver()
    {
        Debug.Log("Over");
        timer -= Time.deltaTime;
        Debug.Log(timer);
        if (timer < 0)
        {
            Track_MoveUp1.timing1 += timeflow;
            Debug.Log(Track_MoveUp1.timing1);
            // PlayerPrefs.SetInt("isDestr", 1);
            // PlayerPrefs.Save();

            Destroy(gameObject);
            SceneManager.LoadScene("Track_End");
        }
    }
    private void OnMouseExit()
    {
        timer = ogtimer;
    }
}
