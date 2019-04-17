using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PourChai : MonoBehaviour
{
    public GameObject valve;
    public float pourTime;
    public GameObject best;
    public GameObject good;
    public GameObject bad;
    private bool pour;
    public ChaiLevelUpper upperChai;
    //public ChaiLevelLower lowerChai;
   // public spoonTrigger spoon;
    public Text stirTime;
    // Start is called before the first frame update
    void Start()
    {
        best.SetActive(false);
        good.SetActive(false);
        bad.SetActive(false);
        stirTime.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        

        if (pourTime > 8.0f)
        {
            
        }
    }

    void OnMouseDown()
    {
        valve.SetActive(false);
        pour = true;
        
    }
}
