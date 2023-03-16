using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Chase_Hard : MonoBehaviour
{
    Sprite selected_alphabet = Chase_Obj_Menu.SelectedSprite;
    public Sprite[] buttonSprites;
    private List<Sprite> btnSprites_2;
    public Button[] buttons;
    private List<Button> btns_2;
    private float timetospawn = 1.7f;
    private float startTime;
    public static float elapsedTime;
    private float currentTimetoSpawn;
    public TextMeshProUGUI textMeshPro;
    private int correctAns;
    public static bool setTimerObj2;
    public static float timer_obj = 0;
    private Sprite[] array;
    private List<Sprite> listofsprites;
    private Sprite sprite1,sprite2;
    private int counting;
    // Start is called before the first frame update
    void Start()
    {
        btnSprites_2 = buttonSprites.ToList();
        btns_2 = buttons.ToList();
        for (int i = 0; i < btns_2.Count; i++)
        {
            btns_2[i].interactable = false;
            btns_2[i].gameObject.SetActive(false);
        }
        startTime = Time.time;

        btnSprites_2.Remove(selected_alphabet);
        
        int ranom1 = Random.Range(0, btnSprites_2.Count);
        btnSprites_2.Remove(btnSprites_2[ranom1]);
        
        int ranom2 = Random.Range(0, btnSprites_2.Count);

        sprite1= btnSprites_2[ranom1];
        sprite2= btnSprites_2[ranom2];

        array = new Sprite[] {selected_alphabet,sprite1,selected_alphabet,sprite2,selected_alphabet};
        listofsprites = array.ToList();

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(listofsprites[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimetoSpawn > 0)
        {
            currentTimetoSpawn -= Time.deltaTime;
        }
        else
        {
            spawning();
            currentTimetoSpawn = timetospawn;
        }
        if (counting == 1)
        {
            
            counting = Random.Range(1, 5);
        }
        textMeshPro.text = correctAns.ToString();
        if (correctAns == 5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_End_Screen");
            setTimerObj2 = true;
        }
        else
        {
            timer_obj += Time.deltaTime;
            setTimerObj2 = false;
        }
    }
    public void spawning()
    {
        int random1 =  Random.Range(0, btns_2.Count);
        int random2 = Random.Range(0,listofsprites.Count);
        btns_2[random1].interactable = true;
        btns_2[random1].image.sprite = listofsprites[random2];
        btns_2[random1].gameObject.SetActive(true);
        btns_2.Remove(btns_2[random1]);
        counting--;
    }
    public void Check()
    {
        Image selectedBtn = EventSystem.current.currentSelectedGameObject.GetComponent<Image>();
        Button selected = selectedBtn.GetComponentInParent<Button>();
        if (selectedBtn.sprite == selected_alphabet)
        {
            correctAns++;
            selectedBtn.gameObject.GetComponentInParent<Button>().interactable = false;
            selectedBtn.gameObject.GetComponentInParent<Button>().gameObject.SetActive(false);
            btns_2.Add(selected);
        }
        else
        {
            correctAns--;
            selectedBtn.gameObject.GetComponentInParent<Button>().interactable = false;
            selectedBtn.gameObject.GetComponentInParent<Button>().gameObject.SetActive(false);
            btns_2.Add(selected);
            //SceneManager.LoadScene("WrongLevel");
        }

    }

}