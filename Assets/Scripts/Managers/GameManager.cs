using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //intialize a stat set for both players
    public float hp = 5;
    public int atk = 1;
    public int rngAtk = 1;
    public int atkspd = 1;
    public int stam = 100;
    public int ammo = 20;
    public int lives = 3;

    //movement based stats to be called when calling movement
    public float movespeed = 5f;
    public int dir;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack(GameObject attacker, GameObject defender)
    {
        //check if shield is between players
        //if not
        defender.GetComponent<PlayerStats>().hp -= 1;
        Debug.Log(defender + " was hit! ");
        //check if defender is out of hp
        if (defender.GetComponent<PlayerStats>().hp <= 0)
        {
            //if yes destroy and respawn
            defender.GetComponent<PlayerStats>().lives -= 1;
            Debug.Log(defender + "was defeated!");
            Destroy(defender);
            //then respawn
        }
        
    }
}
