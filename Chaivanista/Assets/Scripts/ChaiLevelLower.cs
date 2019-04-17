using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChaiLevelLower : MonoBehaviour
{
    
   // public bool lowerLimit;
    public int stirCount;
    public Text stircount;
    public Text stirtime;
    public spoonTrigger spoon;
    public GameObject Good;
    public float winTime;
    public float stirTime;
    public GameObject badJob;
    public GameObject restart;
    public GameObject goodJob;
    public bool win;
    private void Start()
    {
        stirCount = 0;
        stircount.text = "";
        stirtime.text = "";
        badJob.SetActive(false);
        restart.SetActive(false);
        Good.SetActive(false);
        win = true;

        // lowerLimit = false;
    }

    public void Update()
    {
        if (spoon.spoonTrig == true)
        {
            stircount.text = "Spin Count: " + stirCount.ToString();

            stirTime += Time.deltaTime;
            stirtime.text = "Spin TIme: " + stirTime.ToString();


        }
        if (stirCount > 15 && win == true)
        {
            Good.SetActive(true);
            winTime += Time.deltaTime;
        }
        
        if(stirCount <= 15 && stirTime > 6.0f)
        {
            badJob.SetActive(true);
            restart.SetActive(true);
            goodJob.SetActive(false);
            win = false;
        }



        if(winTime > 2.0f)
            SceneManager.LoadScene(5);

    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "spoon")
        {
            //green.SetActive(true);
           // lowerLimit = true;
           
        }
      //  else
            //lowerLimit = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spoon")
        {
            //green.SetActive(true);
            stirCount++;
        }
    }


}
