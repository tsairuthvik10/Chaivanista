﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonTrigger : MonoBehaviour
{
    public bool spoonTrig;
    // Start is called before the first frame update
    void Start()
    {
        spoonTrig = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spoon")
        {
            
            spoonTrig = true;
            
        }
    }
    }
