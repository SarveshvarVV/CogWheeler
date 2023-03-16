using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Chase_EzManager : MonoBehaviour
{
    Sprite selected_alphabet = Chase_Obj_Menu.SelectedSprite;
    public Button[] buttons;
    private List<Button> btns_2;
    private float timetospawn = 1.7f;
    private float startTime;
    public static float elapsedTime;
    private float currentTimetoSpawn;
    public TextMeshProUGUI textMeshPro;
    private int correctAns;
    public static bool setTimerObj1;
    public static float timer_obj = 0;
    // Start is called before the first frame update
    void Start()
    {
        btns_2 = buttons.ToList();
        for (int i = 0; i < btns_2.Count; i++)
        {
            btns_2[i].interactable = false;
            btns_2[i].gameObject.SetActive(false);
        }
        startTime = Time.time;
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
        textMeshPro.text = correctAns.ToString();
        if (correctAns == 5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_End_Screen");
            setTimerObj1 = true;
        }
        else
        {
            timer_obj += Time.deltaTime;
            setTimerObj1 = false;
        }


    }

    public void spawning()
    {

        int random1 = Random.Range(0, btns_2.Count);
        btns_2[random1].interactable = true;
        btns_2[random1].image.sprite = selected_alphabet;
        btns_2[random1].gameObject.SetActive(true);
        btns_2.Remove(btns_2[random1]);
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
