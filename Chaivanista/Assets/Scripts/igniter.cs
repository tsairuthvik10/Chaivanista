using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igniter : MonoBehaviour
{
    public int igniteMeter;
    public GameObject fire;
    public GameObject electricity;
    //public Animation elecanim;
    public float electime;
    public Animator elecAnimator;
   // public bool milkpowder;
    public GameObject pourChai;
    public GameObject pourMilk;
    public GameObject restart;
    public GameObject goodJob;
    public GameObject badJob;
    public float wasteTime;
    public pourwasteChai wasteChai;
    // Start is called before the first frame update
    void Start()
    {
        igniteMeter = 0;
        fire.SetActive(false);
        electricity.SetActive(false);
        pourMilk.SetActive(false);
        restart.SetActive(false);
        goodJob.SetActive(false);
        badJob.SetActive(false);
        //  elecanim = electricity.GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (wasteChai.waste == true)
            wasteTime += Time.deltaTime;

        if(igniteMeter > 8)
        {
            //add time with electricity anim
            elecAnimator.SetBool("elec", true);

            electricity.SetActive(true);
          //  elecanim.Play();
            electime += Time.deltaTime;
        }
        else
            elecAnimator.SetBool("elec", false);

        if (electime >= 6) {
            electricity.SetActive(false);
            elecAnimator.SetBool("elec", false);
            fire.SetActive(true);
            pourMilk.SetActive(true);
            pourChai.SetActive(false);


        }

        if(igniteMeter <= 8 && wasteTime > 6.0f)
        {
            badJob.SetActive(true);
            restart.SetActive(true);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "stove")
        {
            Debug.Log("hello");
            igniteMeter++;
        }
    }

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "stove")
    //    {
    //        Debug.Log("hello");
    //        igniteMeter++;
    //    }
    //}

    //public void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "igniter")
    //    {
    //        igniteMeter++;
    //    }
    //}
}
