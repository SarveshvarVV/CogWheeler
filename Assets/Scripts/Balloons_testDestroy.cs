using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons_testDestroy : MonoBehaviour
{
   // public GameObject videoPrefab;
    public static int count = 0;
    [SerializeField] GameObject animator;
    // Start is called before the first frame update
    //private void Start()
    //{
    //    GameObject videoInstance = Instantiate(videoPrefab);
    //}
    private void OnMouseDown()
    {

        if (gameObject.CompareTag("Red_Ball"))
        {
            StartCoroutine(destroying());
            count -= 1;
            
        }
        else if (gameObject.CompareTag("Green_Ball"))
        {
            StartCoroutine(destroying());
            count += 1;
            
        }
        else if (gameObject.CompareTag("Blue_Ball"))
        {
            StartCoroutine(destroying());
            count += 2;
            
        }

    }
    IEnumerator destroying()
    {
        Destroy(this.GetComponent<BoxCollider2D>());
        Instantiate(animator,transform.position,Quaternion.identity);
        Destroy(this.gameObject);
        yield return new WaitForSeconds(1f);
        Destroy(animator);
    }
    
    
}
