﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mixLevel : MonoBehaviour
{
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "sugar")
        {
            // UpperLimit = true;
            count++;
        }
    }
}