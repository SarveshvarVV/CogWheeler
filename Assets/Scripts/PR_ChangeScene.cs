using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR_ChangeScene : MonoBehaviour
{
  public void GoToObjectsEZ()
   {
       UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Objects");
   }
   public void GoToShapesEZ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Shape");
    }
    public void GoToTamilEZ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Tamil");
    }
    public void GoToEnglishEZ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Letter");
    }
    public void GoToNumbersEZ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Num");
    }
    public void GotoSymbolsEZ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_Symbols");
    }


    public void ObjectsHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_ObjectsHard");
    }
    public void ShapesHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_ShapeHard");
    }
    public void TamilHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_TamilHard");
    }
    public void EnglishHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_LetterHard");
    }
    public void NumbersHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_NumHard");
    }
    public void SymbolsHard()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PR_SymbolsHard");
    }
    
}
