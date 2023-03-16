using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class SeekSmiley_PlayButton : MonoBehaviour
{
    [SerializeField] private string seekingSmileyLevel = "Smiley_seekingSmiley";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlay()
    {
        SceneManager.LoadScene(seekingSmileyLevel);

    }
}
