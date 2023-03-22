using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LightsOut_GameManager : MonoBehaviour
{

    public List<Button> btns;
    private List<Button> btns2;
    public Sprite glow, dark;
    private List<int> btn_timer;
    public static float elapsedtime;
    private float starttime;
    public static int score;

    public AudioSource BulbOn;
    public AudioSource BulbOff;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
        btns2 = new List<Button>(btns);

        int randomize = UnityEngine.Random.Range(0, btns.Count);
        btns[randomize].image.sprite = dark;
        btns[randomize].interactable = false;
        btns[randomize].GetComponent<LightsOut_ButtonTimer>().StartTimer();
        btns.Remove(btns[randomize]);

        int randomize2 = UnityEngine.Random.Range(0, btns.Count);
        btns[randomize2].image.sprite = dark;
        btns[randomize2].interactable = false;
        btns[randomize2].GetComponent<LightsOut_ButtonTimer>().StartTimer();
        btns.Remove(btns[randomize2]);

        int randomize3 = UnityEngine.Random.Range(0, btns.Count);
        btns[randomize3].image.sprite = dark;
        btns[randomize3].interactable = false;
        btns[randomize3].GetComponent<LightsOut_ButtonTimer>().StartTimer();
        btns.Remove(btns[randomize3]);
    }

    // Update is called once per frame
    void Update()
    {

       foreach(Button b in btns2)
        {
            if(b.GetComponent<LightsOut_ButtonTimer>().isTimerActive() == false)
            {
                
                if (!btns.Contains(b))
                {
                    BulbOn.Play();
                    Debug.Log("Added Btn" + b.name);
                    btns.Add(b);
                }
            }
            else
            {
                btns.Remove(b);
            }
        }
      




        if (btns.Count == 0)
        {
            elapsedtime = 1 * Time.deltaTime - starttime;
            SceneManager.LoadScene("LightsOut_Victory_lightsout");
            elapsedtime = (1 * Time.time) - starttime;
            score++;
            if(elapsedtime < 10)
            {
                score += 10;
            }
            else if(elapsedtime < 20)
            {
                score += 7;
            }
            else if(elapsedtime < 30)
            {
                score += 5;
            }
            else if(elapsedtime > 30)
            {
                score += 2;
            }
        }
        
        


    }

}
