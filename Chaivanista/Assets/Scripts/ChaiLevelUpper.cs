using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaiLevelUpper : MonoBehaviour
{
    //public GameObject green;
   // public bool UpperLimit;
   // public bool spoonInGlass;
   // public ChaiLevelLower lowChai;
    //public float waitTime;
    public int count;
    //public int sugarCount;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
       // sugarCount = 0; 
        //UpperLimit = false;
       // green.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        //if(waitTime > 1.0f)
        //    green.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sugar")
        {
           // UpperLimit = true;
            count++;
        }

        //if (collision.gameObject.tag == "sugar")
        //{
        //    // UpperLimit = true;
        //    sugarCount++;
        //}


        // else
        // UpperLimit = false;

        //if (collision.gameObject.tag == "spoon")
        //{
        //    spoonInGlass = true;
        //    Debug.Log("spoon in glass");
        //}
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "chai")
    //    {
    //        UpperLimit = false;
    //    }
    //}
}
