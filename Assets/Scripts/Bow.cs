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

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //destroy sword and shield
            //instantiate bow
            Instantiate(bowPrefab, firePoint.position, firePoint.rotation, firePoint.transform);

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
            //instantiate sword and shield
        }
    }

    void AttemptShoot()
    {
        //see if charged long enough
        //if yes fire and reset to 0 and put bow away
        if (totalCharge >= totalChargeNeeded)
        {
            Shoot();
            Debug.Log("Shot!");
            totalCharge = 0f;
            Destroy(bowPrefab);

        }
        //if no dont and reset to 0 and put bow away
        else
        {
            totalCharge = 0f;
            Debug.Log("failed");
            Destroy(bowPrefab);
        }
    }
    void Shoot()
    {
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
    }
}