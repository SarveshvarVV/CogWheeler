using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;

public class SeekSmiley_NextButton : MonoBehaviour
{

    public List<string> nextLevelList = new();
    public string nextLevel;
    public static List<string> staticLevelList = new();

    private void Awake()
    {

        staticLevelList = nextLevelList;
        if (staticLevelList.Count != 0)
        {
            int randomize = UnityEngine.Random.Range(0, staticLevelList.Count);
            nextLevel = nextLevelList[randomize];
            staticLevelList.Remove(nextLevel);
        }
    }



    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Nexttouch()
    {
        SceneManager.LoadScene(nextLevel);
    }

}
