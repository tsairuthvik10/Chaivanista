using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pourWater : MonoBehaviour
{
    public GameObject valve;
    public GameObject goodJob;
    public GameObject badJob;
    public GameObject restart;
    public waterLevelUpper upperChai;
    private float moveToTealeaves;
    private bool pour;
    private float pourTime;
    private bool nextlevel;
    // Start is called before the first frame update
    void Start()
    {
        goodJob.SetActive(false);
        badJob.SetActive(false);
        restart.SetActive(false);
        nextlevel = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (pour == true)
            pourTime += Time.deltaTime;

        if(upperChai.count >= 20 && nextlevel == true)
        {
            goodJob.SetActive(true);
            moveToTealeaves += Time.deltaTime;
        }
        if(upperChai.count < 20 && pourTime > 10.0f)
        {
            badJob.SetActive(true);
            restart.SetActive(true);
            nextlevel = false;
        }

        if (moveToTealeaves >= 3.0f)
            SceneManager.LoadScene(2);
    }

    void OnMouseDown()
    {
        valve.SetActive(false);
        pour = true;

    }
}
