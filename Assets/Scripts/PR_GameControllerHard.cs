using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class PR_GameControllerHard : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] GameObject Back;
    public const int colums = 4; //number of columns
    public const int rows = 4;   //number of rows

    public const float Xspace = 3.5f;    //horizonatal space between the tiles
    public const float Yspace = -2f; //vertical space between the tiles

    [SerializeField] private PR_MainImageHard startObject;
    public Sprite[] all_elements;

    [SerializeField] private Sprite[] images;
    private float timer1;
    public static float timer_ez;


    private int[] Randomiser(int[] locations)
    {

        int[] array = locations.Clone() as int[];
        for (int i = 0; i < array.Length; i++)
        {
            int newArray = array[i];
            int j = Random.Range(i, array.Length);
            array[i] = array[j];
            array[j] = newArray;

        }
        return array;
    }

    private void Start()
    {
        for (int b = 0; b < 8; b++)
        {
            Initialise(b);
        }
        int[] locations = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 }; //postions to set the tiles
        locations = Randomiser(locations); //locations are randoised

        Vector3 startPosition = startObject.transform.position; //start position

        for (int i = 0; i < colums; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                PR_MainImageHard gameImage;
                if (i == 0 && j == 0)
                {
                    gameImage = startObject;  //if position is default gameimage is start object

                }
                else
                {
                    gameImage = Instantiate(startObject) as PR_MainImageHard; //new object is spawned or instantiated

                }
                int index = j * colums + i;
                int id = locations[index];
                gameImage.ChangeSprite(id, images[id]);
                float positionX = (Xspace * i) + startPosition.x;
                float positionY = (Yspace * j) + startPosition.y;


                gameImage.transform.position = new Vector3(positionX, positionY, startPosition.z);
            }
        }
    }
    private void Update()
    {
        timing();
    }


    private PR_MainImageHard firstOpen;
    private PR_MainImageHard secondOpen;

    private int score = 0;
    private int attempts = 0;

    [SerializeField] private TextMeshProUGUI attemptsText;
    [SerializeField] private TextMeshProUGUI timeText;

    public bool canOpen
    {
        get { return secondOpen == null; }
    }

    public void imageOpened(PR_MainImageHard startObject)
    {
        if (firstOpen == null)
        {
            firstOpen = startObject;

        }
        else
        {
            secondOpen = startObject;
            StartCoroutine(CheckGuessed());
        }
    }
    private IEnumerator CheckGuessed()
    {
        if (firstOpen.spriteID == secondOpen.spriteID)  //compare the two objects
        {
            score++;
            //if (score == 6)
            //{
            //    Panel.SetActive(true);
            //}

        }
        else
        {
            yield return new WaitForSeconds(0.5f);   //start timer

            firstOpen.Close();
            secondOpen.Close();
        }
        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        firstOpen = null;
        secondOpen = null;
    }
    public void RestartObjects()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_ObjectsHard");
    }
    public void RestartShapes()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_ShapeHard");
    }
    public void RestartEnglish()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_LetterHard");
    }
    public void RestartTamil()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_TamilHard");
    }
    public void RestartSymbols()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_SymbolsHard");
    }
    public void RestartNumbers()
    {
        timer_ez = 0;
        SceneManager.LoadScene("PR_NumHard");
    }

    void Initialise(int b)
    {
        int rnd = Random.Range(0, all_elements.Length); //random index of all sprites is selected

        if (images.Contains(all_elements[rnd]) == false)  //if sprite is not already chosen
        {
            images[b] = all_elements[rnd]; //adding sprite to the slot in images array
        }
        else
        {
            Initialise(b); //if sprite is already chose the function starts again to prevent dupplication
        }



    }
    public void timing()
    {
        if (score == 8) //score reaches
        {
            Panel.SetActive(true); //end game panel is set active
            Back.SetActive(false);
            timer1 = timer_ez;
            timeText.text = "Time: " + timer1;  //timmer value is set to the text
            timer_ez = 0; //timer reset
            score = 0; //score is reset
            Debug.Log(timer1);
            //timer_ez = 0;
        }
        else
        {
            timer_ez += Time.deltaTime; //timer value is increased


        }
    }

}