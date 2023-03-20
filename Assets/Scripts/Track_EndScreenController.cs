using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Track_EndScreenController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rht;
    [SerializeField] TextMeshProUGUI lht;
    // Start is called before the first frame update
    void Start()
    {
        rht.text = ""+ Track_MoveUp.timing;
        lht.text = "" + Track_MoveUp1.timing1;
        Track_MoveUp.timing = 0;
        Track_MoveUp1.timing1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GS()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("UI_MainMenu");
    }
}
