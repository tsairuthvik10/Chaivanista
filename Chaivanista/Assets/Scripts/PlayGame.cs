   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour {
    public Button m_YourFirstButton;

    public void Clickevent()
    {
        SceneManager.LoadScene(1);
    }


}