﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartMB : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(3);

    }
}
