using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track_MenuGo : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menugo()
    {
        SceneManager.LoadScene("Track_Menu");
    }
}
