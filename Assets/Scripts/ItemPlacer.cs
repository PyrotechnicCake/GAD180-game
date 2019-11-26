using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    public GameObject itemsToDrop;
    public float dropTime;
    public Vector3 dropRange;
    public GameObject theTime;

    // Update is called once per frame
    void Update()
    {
        if (theTime.GetComponent<TimerScript>().timer - dropTime <= 1)
        {
            print("item dropping time!");
        }

    }
}
