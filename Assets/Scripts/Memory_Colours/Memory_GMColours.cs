using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Memory_GMColours : MonoBehaviour
{
    public SpriteRenderer[] colours;
    public float stayLit;
    public float waitBetweenLights;
    public float waitBetweenSequence;
    public List<int> activeSequence;

    public GameObject gStart;
    public GameObject Panel;

    private float waitBetweenCounter;
    private bool shouldBeLit;
    private bool shouldBeDark;
    private float stayLitCounter;
    private int colourselect;
    private int positionInSequence;

    private bool gameActive;
    private int inputInSequence;

    public float startTime;
    private float elapsedTime;

    [SerializeField] private TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (shouldBeLit)
        {
            stayLitCounter -= Time.deltaTime;

            if (stayLitCounter < 0)
            {
                colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 0.5f);
                shouldBeLit = false;
                shouldBeDark = true;
                waitBetweenCounter = waitBetweenLights;

                positionInSequence++;
            }
        }
        if (shouldBeDark)
        {
            waitBetweenCounter -= Time.deltaTime;
            if (positionInSequence >= activeSequence.Count)
            {
                shouldBeDark = false;
                gameActive = true;
            }
            else
            {
                if (waitBetweenCounter < 0)
                {
                    colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 1.5f);
                    stayLitCounter = stayLit;
                    shouldBeLit = true;
                    shouldBeDark = false;
                }
            }
        }
    }

    public void StartGame()
    {
        startTime = Time.time;
        activeSequence.Clear();
        positionInSequence = 0;
        inputInSequence = 0;

        colourselect = Random.Range(0, colours.Length);
        activeSequence.Add(colourselect);
        colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 1.5f);
        stayLitCounter = stayLit;
        shouldBeLit = true;

    }
    public void ColourPressed(int whichButton)
    {
        if (gameActive)
        {

            if (activeSequence[inputInSequence] == whichButton)
            {

                inputInSequence++;

                if (inputInSequence >= activeSequence.Count)
                {
                    StartCoroutine(WaitBetweenSequences());
                }

            }
            else
            {
                
                Debug.Log("WRONG!");

                elapsedTime = (Time.time - startTime)/activeSequence.Count;
                Debug.Log(elapsedTime);
                timeText.text = "Response Time: " + elapsedTime;
                gameActive = false;
                Panel.SetActive(true);
            }
        }
    }

    IEnumerator WaitBetweenSequences()
    {
        yield return new WaitForSeconds(waitBetweenSequence);

        positionInSequence = 0;
        inputInSequence = 0;

        colourselect = Random.Range(0, colours.Length);

        activeSequence.Add(colourselect);

        if (activeSequence.Count > 5)
        {
            elapsedTime = (Time.time - startTime)/5;
            Debug.Log(elapsedTime);
            timeText.text = "Response Time: " + elapsedTime;
            Debug.Log("Game limit");
            gameActive = false;
            Panel.SetActive(true);
        }
        else
        {
            colours[activeSequence[positionInSequence]].color = new Color(colours[activeSequence[positionInSequence]].color.r, colours[activeSequence[positionInSequence]].color.g, colours[activeSequence[positionInSequence]].color.b, 1f);


            stayLitCounter = stayLit;
            shouldBeLit = true;

            gameActive = false;

            Debug.Log("GOOD!");
        }

        //if (gameActive)
        //{


        //    if (activeSequence[inputInSequence] == whichButton)
        //    {
        //        Debug.Log("Correct");

        //        inputInSequence++;

        //        if(inputInSequence >= activeSequence.Count)
        //        {
        //            positionInSequence = 0;
        //            inputInSequence = 0;
        //            numberselect = Random.Range(0, numbers.Length);
        //            activeSequence.Add(numberselect);                  
        //            numbers[activeSequence[positionInSequence]].color = new Color(numbers[activeSequence[positionInSequence]].color.r, numbers[activeSequence[positionInSequence]].color.g, numbers[activeSequence[positionInSequence]].color.b, 1.5f);
        //            stayLitCounter = stayLit;
        //            shouldBeLit = true;
        //            gameActive = false;

        //        }
        //    }
        //    else
        //    {
        //        Debug.Log("Wrong");
        //        gameActive = false;
        //    }
        //}
    }
}