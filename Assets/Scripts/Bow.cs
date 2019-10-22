using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Transform firePoint;
    public GameObject arrowPrefab;
    public GameObject bowPrefab;
    public float totalCharge = 0f;
    private float totalChargeNeeded = 1f;
    public bool isCharging = false;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //instantiate bow
            //Instantiate(bowPrefab,)

            //start charging
            isCharging = true;
            Debug.Log("charging");
        }
        if(isCharging == true)
        {
            //charge
            totalCharge += Time.deltaTime;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            //try to shoot
            AttemptShoot();   
            Debug.Log("release");
            isCharging = false;
            //destroy bow


        }
    }

    void AttemptShoot()
    {
        //see if charged long enough
        //if yes fire and reset to 0
        if (totalCharge >= totalChargeNeeded)
        {
            Shoot();
            Debug.Log("Shot!");
            totalCharge = 0f;

        }
        //if no dont and reset to 0
        else
        {
            totalCharge = 0f;
            Debug.Log("failed");
        }
    }
    void Shoot()
    {
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
    }
}