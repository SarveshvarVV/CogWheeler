using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Memory_GMNumbers : MonoBehaviour
{
    public SpriteRenderer[] numbers;
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
    private int numberselect;
    private int positionInSequence;

    private bool gameActive;
    private int inputInSequence;

    

    public static List<float> ETList = new();

    
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
                numbers[activeSequence[positionInSequence]].color = new Color(numbers[activeSequence[positionInSequence]].color.r, numbers[activeSequence[positionInSequence]].color.g, numbers[activeSequence[positionInSequence]].color.b, 0.5f);
                shouldBeLit = false;
                shouldBeDark = true;
                waitBetweenCounter = waitBetweenLights;

                positionInSequence++;
            }
        }
      if (shouldBeDark)
        {
            waitBetweenCounter -= Time.deltaTime;
            if (positionInSequence>=activeSequence.Count)
            {
                shouldBeDark = false;
                gameActive = true;
            }
            else
            {
                if(waitBetweenCounter < 0)
                {
                    numbers[activeSequence[positionInSequence]].color = new Color(numbers[activeSequence[positionInSequence]].color.r, numbers[activeSequence[positionInSequence]].color.g, numbers[activeSequence[positionInSequence]].color.b, 1.5f);
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

        numberselect = Random.Range(0, numbers.Length);
        activeSequence.Add(numberselect);
        numbers[activeSequence[positionInSequence]].color = new Color(numbers[activeSequence[positionInSequence]].color.r, numbers[activeSequence[positionInSequence]].color.g, numbers[activeSequence[positionInSequence]].color.b, 1.5f);
        stayLitCounter = stayLit;
        shouldBeLit = true;
        
    }
    public void NumberPressed(int whichButton)
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

        numberselect = Random.Range(0, numbers.Length);

        activeSequence.Add(numberselect);
        if (activeSequence.Count > 5)
        {
            elapsedTime = (Time.time - startTime)/5;
            Debug.Log(elapsedTime);
            timeText.text = "Response Time: " + elapsedTime;
            //Debug.Log("Game limit");
            gameActive = false;
            Panel.SetActive(true);
        }
        else
        {

            numbers[activeSequence[positionInSequence]].color = new Color(numbers[activeSequence[positionInSequence]].color.r, numbers[activeSequence[positionInSequence]].color.g, numbers[activeSequence[positionInSequence]].color.b, 1f);


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
