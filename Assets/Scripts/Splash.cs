using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startpage", 2.2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startpage()
    {
        SceneManager.LoadScene("Start");
    }
}
