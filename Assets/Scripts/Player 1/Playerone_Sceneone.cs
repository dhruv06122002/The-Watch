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
    public GameObject Watchbackwithcell;
    public GameObject WatchOn;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        Cell.SetActive(false);
        LampOff.SetActive(false);
        LampOn.SetActive(true);
        WatchOff.SetActive(true);
        Watchback.SetActive(false);
        WatchOn.SetActive(false);
        flag = false;
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
        flag = true;
    }
        
    public void Delay()
    {
        Invoke("LampIsOn", 1.80f);
    }

    public void WatchIsOff()
    {
        if(flag == true)
        {
            Debug.Log("Screen is turned");
            Cell.SetActive(true);
            WatchOff.SetActive(false);
            Watchback.SetActive(true);
            flag = false;
        }
    }

    public void WatchCellInserted()
    {
        if (flag == false)
        {
            Debug.Log("Cell is Inserted");
            Cell.SetActive(false);
            WatchOff.SetActive(false);
            Watchback.SetActive(false);
            Watchbackwithcell.SetActive(true);
            flag = true;
        }
    }

    public void WatchIsOn()
    {
        if (flag == true)
        {
            Debug.Log("Watch is On");
            Cell.SetActive(false);
            WatchOff.SetActive(false);
            Watchback.SetActive(false);
            Watchbackwithcell.SetActive(false);
            WatchOn.SetActive(true);
            flag = false;
        }
    }
}
