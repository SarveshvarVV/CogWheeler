using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase_Menu_Script : MonoBehaviour
{

    //public static bool objez=false;
    //public static bool objhard = false;
    //public static bool objmed = false;
    //// Start is called before the first frame update
    public static int objlvl = 0;
    

    public void ObjEz()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_Objects_Menu");
        objlvl = 1;
    }
    public void ObjMed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Chase_Objects_Menu");
        objlvl = 2;
    }

}
