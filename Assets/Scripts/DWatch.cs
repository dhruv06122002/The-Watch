using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DWatch : MonoBehaviour
{
    public GameObject WatchOff;
    public GameObject Watchback;
    public GameObject Watchbackwithscell;
    public GameObject WatchOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
        WatchOff.SetActive(false);
        Watchback.SetActive(false);
        Watchbackwithscell.SetActive(true);
    }
}
