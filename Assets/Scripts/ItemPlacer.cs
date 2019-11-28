using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlacer : MonoBehaviour
{
    public GameObject itemsToDrop;
    public float dropTime;
    public GameObject theTime;
    public bool hasDropped;

    //make list of places to place items
    public GameObject placement1;
    public GameObject placement2;
    public GameObject placement3;
    public GameObject placement4;
    public GameObject placement5;

    //make an item location
    public Vector3 myPlacement;

    //make an enum
    public enum itemSpot
    {
        spot1, spot2, spot3, spot4, spot5
    }
    public itemSpot spot;

    // Update is called once per frame
    void Update()
    {
        if ((theTime.GetComponent<TimerScript>().timer - dropTime <= 1) && (hasDropped == false))
        {
            print("item dropping time!");
            PlaceItem();
        }

    }

    public void PlaceItem()
    {
        spot = (itemSpot)Random.Range(1, 6);

        switch (spot)
        {
            case itemSpot.spot1:
                myPlacement = placement1.transform.position;
                break;
            case itemSpot.spot2:
                myPlacement = placement2.transform.position;
                break;
            case itemSpot.spot3:
                myPlacement = placement3.transform.position;
                break;
            case itemSpot.spot4:
                myPlacement = placement4.transform.position;
                break;
            case itemSpot.spot5:
                myPlacement = placement5.transform.position;
                break;
        }
        if (hasDropped == false)
            {
            Instantiate(itemsToDrop, myPlacement, Quaternion.identity);
            hasDropped = true;
            }
    }
}
