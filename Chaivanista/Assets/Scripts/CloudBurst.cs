using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBurst : MonoBehaviour
{
    public bool noCloud;
    public GameObject pourChai;
    public GameObject pourMilk;
    public GameObject restart;
    public GameObject goodJob;
    public GameObject badJob;
    public float wasteTime;
    public pourwasteChai wasteChai;
    public void Start()
    {
        pourMilk.SetActive(false);
        restart.SetActive(false);
        goodJob.SetActive(false);
        badJob.SetActive(false);
    }

    public void Update()
    {
        if (wasteChai.waste == true)
            wasteTime += Time.deltaTime;

        if (noCloud == false && wasteTime > 6.0f)
        {
            badJob.SetActive(true);
            restart.SetActive(true);
        }

        if(noCloud == true)
        {
            pourMilk.SetActive(true);
            pourChai.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("cloud burst outside");
        if (collision.gameObject.tag == "cloud")
        {
            Destroy(collision.gameObject);
            Debug.Log("cloud burst inside");
            noCloud = true;
        }
    }
    
}
