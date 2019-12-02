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
    public int totalArrows = 10;
    FMOD.Studio.EventInstance BowDraw;

    public int playerID;
    string chargeBow;


    void Start()
    {
        if (this.gameObject.CompareTag("player1"))
        {
            playerID = 0;
        }
        if (this.gameObject.CompareTag("player2"))
        {
            playerID = 1;
        }

        if (playerID == 0)
        {
            chargeBow = "Fire2";
        }
        else
        {
            chargeBow = "Fire5";
        }
    }
    void Update()
    {
        if (Input.GetButtonDown(chargeBow) && GetComponentInParent<PlayerStats>().stam > 0 && totalArrows > 0 && GetComponentInChildren<Shield>().shieldUp == false)
        {
            BowDraw = FMODUnity.RuntimeManager.CreateInstance("event:/Player/Weapons/Bow/Arrow Draw");
            BowDraw.start();

            //destroy sword and shield
            //instantiate bow
            Instantiate(bowPrefab, firePoint.position, firePoint.rotation, firePoint.transform);

            //start charging
            isCharging = true;
            //Debug.Log("charging");
        }
        /*else
        {
            Debug.Log("Out of Stamina!");
        }*/
        if(isCharging == true)
        {
            //charge
            totalCharge += Time.deltaTime;
        }
        if (Input.GetButtonUp(chargeBow))
        {

            //try to shoot
            AttemptShoot();   
            //Debug.Log("release");
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
            GetComponentInParent<PlayerStats>().stam -= 10;
            GetComponentInParent<PlayerStats>().stamDelayTimer = 0.0f;
            totalArrows -= 1;
            Shoot();
            //Debug.Log("Shot!");
            totalCharge = 0f;

        }
        //if no dont and reset to 0 and put bow away
        else
        {
            BowDraw.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            totalCharge = 0f;
            //Debug.Log("failed");
            Destroy(bowPrefab);
        }
    }
    void Shoot()
    {
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Bow/Fire", gameObject); 
    }
}