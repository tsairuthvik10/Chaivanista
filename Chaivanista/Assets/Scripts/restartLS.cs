using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLS : MonoBehaviour
{
   

    void OnMouseDown()
    {
        SceneManager.LoadScene(1);

    }
}
