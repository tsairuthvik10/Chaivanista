using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pourMilk : MonoBehaviour
{
    public GameObject valve;
    public GameObject goodJob;
    public GameObject badJob;
    public GameObject restart;
    public milkLevel upperChai;
    private float moveToTealeaves;
    private bool pour;
    private float pourTime;
    // Start is called before the first frame update
    void Start()
    {
        goodJob.SetActive(false);
        badJob.SetActive(false);
        restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pour == true)
            pourTime += Time.deltaTime;

        if (upperChai.count >= 4)
        {
            goodJob.SetActive(true);
            moveToTealeaves += Time.deltaTime;
        }
        if (upperChai.count < 4 && pourTime > 6.0f)
        {
            badJob.SetActive(true);
            restart.SetActive(true);
        }

        if (moveToTealeaves >= 3.0f)
            SceneManager.LoadScene(4);

    }

    void OnMouseDown()
    {
        valve.SetActive(false);
        pour = true;

    }
}
