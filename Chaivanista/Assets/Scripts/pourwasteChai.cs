using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pourwasteChai : MonoBehaviour
{
    public GameObject valve;
    public bool waste;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        valve.SetActive(false);

        waste = true;
    }
}
