using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1()
    {
        SceneManager.LoadScene("P1_One");
    }

    public void Player2()
    {
        SceneManager.LoadScene("P2_One");
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Selectplayer()
    {
        SceneManager.LoadScene("SelectPlayer");
    }
}
