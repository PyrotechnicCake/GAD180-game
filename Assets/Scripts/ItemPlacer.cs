using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    public GameObject itemsToDrop;
    public float dropTime;
    public GameObject theTime;

    //make list of places to place items
    public GameObject placement1;
    public GameObject placement2;
    public GameObject placement3;
    public GameObject placement4;
    public GameObject placement5;

    // Update is called once per frame
    void Update()
    {
        if (theTime.GetComponent<TimerScript>().timer - dropTime <= 1)
        {
            print("item dropping time!");
        }

    }
}
