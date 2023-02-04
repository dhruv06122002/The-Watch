using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerone_Sceneone : MonoBehaviour
{
    [SerializeField] 
    public GameObject Cell;
    public GameObject LampOn;
    public GameObject LampOff;
    public GameObject WatchOff;
    public GameObject Watchback;
    public GameObject WatchOn;

    // Start is called before the first frame update
    void Start()
    {
        Cell.SetActive(false);
        LampOff.SetActive(false);
        LampOn.SetActive(true);
        WatchOff.SetActive(true);
        Watchback.SetActive(false);
        WatchOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LampIsOn()
    {
        Cell.SetActive(true);
        LampOff.SetActive(true);
        LampOn.SetActive(false);
    }
        
    public void Delay()
    {
        Invoke("LampIsOn", 1.80f);
    }

    public void WatchIsOff()
    {
        Cell.SetActive(true);
        WatchOff.SetActive(false);
        Watchback.SetActive(true);
    }
}
