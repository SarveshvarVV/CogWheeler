using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PR_Qmark : MonoBehaviour
{
    [SerializeField] GameObject qmark;
    // Start is called before the first frame update
    void Start()
    {
        qmark.SetActive(false);
        StartCoroutine(qmark_enable());
    }

    
    IEnumerator qmark_enable()
    {
        yield return new WaitForSeconds(5f);
        qmark.SetActive(true);
    }
}
