using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playertwo_Sceneone : MonoBehaviour
{
    public GameObject Frame;
    public GameObject Vault;
    public GameObject VaultOpen;
    public GameObject TextValue;
    public Text Details;
    public int score;
    public GameObject k1, k2, k3, k4, k5, k6, k7, k8, k9, k0;

    // Start is called before the first frame update
    void Start()
    {
        Frame.SetActive(true);
        Vault.SetActive(false);
        VaultOpen.SetActive(false);
        TextValue.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowVault()
    {
        Debug.Log("Click");
        TextValue.SetActive(true);
        Frame.SetActive(false);
        Vault.SetActive(true);
    }

    public void UnlockVault()
    {
        Details.text = "O P E N";
        Vault.SetActive(false);
        VaultOpen.SetActive(true);
    }

    public void one()
    {
        score++;
        k1.SetActive(false);
        Details.text = "0 0 0 1";
        Debug.Log("One");
    }
    public void two()
    {
        wrong();
        Details.text = "W R O N G";
        Debug.Log("two");
    }
    public void three()
    {
        Debug.Log("Three");
        if (score == 2)
        {
            score++;
            k3.SetActive(false);
            Details.text = "0 1 7 3";
        }
        else
        {
            Details.text = "W R O N G";
            wrong();
        }
        
    }
    public void four()
    {
        Debug.Log("four");
        Details.text = "W R O N G";
        wrong();
    }
    public void five()
    {
        Details.text = "W R O N G";
        Debug.Log("five");
        wrong();
    }
    public void six()
    {
        Debug.Log("six");
        if (score == 3)
        {
            Details.text = "O P E N";
            UnlockVault();
        }
    }
    public void seven()
    {
        Debug.Log("seven");
        if (score == 1)
        {
            score++;
            k7.SetActive(false);
            Details.text = "0 0 1 7";
        }
        else
        {
            Details.text = "W R O N G";
            wrong();
        }
    }
    public void eight()
    {
        Details.text = "W R O N G";
        Debug.Log("eight");
        wrong();
    }
    public void nine()
    {
        Details.text = "W R O N G";
        Debug.Log("nine");
        wrong();
    }
    public void zero()
    {
        Details.text = "W R O N G";
        Debug.Log("zero");
        wrong();
    }

    public void wrong()
    {
        Debug.Log("wrong");
        score = 0;
        k0.SetActive(true);
        k1.SetActive(true);
        k2.SetActive(true);
        k3.SetActive(true);
        k4.SetActive(true);
        k5.SetActive(true);
        k6.SetActive(true);
        k7.SetActive(true);
        k8.SetActive(true);
        k9.SetActive(true);
    }
}
