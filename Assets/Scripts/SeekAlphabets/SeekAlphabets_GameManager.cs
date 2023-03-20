using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SeekAlphabets_GameManager : MonoBehaviour
{
    Sprite selected_alphabet = SeekAlphabets_NextButton.SelectedSprite;
    public Sprite[] buttonSprites;
    private List<Sprite> btnSprites_2;
    public Button[] buttons;
    private List<Button> btns_2;
    public static string this_level;

    private float startTime;
    public static float elapsedTime;
    public static List<float> ETList = new List<float>();

    private int correctAns = 3;

    public static int levelCount = 0, score;

    private void Awake()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LastScene", sceneName);
        PlayerPrefs.Save();
        levelCount++;
    }

    // Start is called before the first frame update
    void Start()
    {
        this_level = SceneManager.GetActiveScene().name;

        btnSprites_2 = buttonSprites.ToList();
        btns_2 = buttons.ToList();


        int random_1 = UnityEngine.Random.Range(0, btns_2.Count);
        btns_2[random_1].image.sprite = selected_alphabet;
        btns_2.Remove(btns_2[random_1]);

        int random_2 = UnityEngine.Random.Range(0, btns_2.Count);
        btns_2[random_2].image.sprite = selected_alphabet;
        btns_2.Remove(btns_2[random_2]);

        int random_3 = UnityEngine.Random.Range(0, btns_2.Count);
        btns_2[random_3].image.sprite = selected_alphabet;
        btns_2.Remove(btns_2[random_3]);

        btnSprites_2.Remove(selected_alphabet);

        for (int i = 0; i < btns_2.Count; i++)
        {
            int random = UnityEngine.Random.Range(0, btnSprites_2.Count);
            btns_2[i].image.sprite = btnSprites_2[random];
        }

        startTime = Time.time;
        Debug.Log(levelCount);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (correctAns == 0)
        {
            score++;
            
            SceneManager.LoadScene("Alphabet_CorrectLevel");
            elapsedTime = Time.time - startTime;
            ETList.Add(elapsedTime);
            if(elapsedTime <= 2)
            {
                score += 5;
            }
            else if(elapsedTime <= 6)
            {
                score += 3;
            }
            else if(elapsedTime <= 10)
            {
                score += 2;
            }else if(elapsedTime > 10)
            {
                score++;
            }
        }
    }

    public void Check()
    {
        Image selectedBtn = EventSystem.current.currentSelectedGameObject.GetComponent<Image>();
        if(selectedBtn.sprite == selected_alphabet)
        {
            correctAns--;
            selectedBtn.gameObject.GetComponentInParent<Button>().interactable = false;
        }
        else
        {
            SceneManager.LoadScene("Alphabet_WrongLevel");
        }
    }

}
