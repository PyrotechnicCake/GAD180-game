﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //default stats
    public float maxhp;
    public float hp;
    public int atk;
    public int rngAtk;
    public int atkspd;
    public float stam;
    public int maxStam = 100;
    public float stamRecharge = 5f;
    private float rechargeDelay = 3f;
    public float stamDelayTimer = 0.0f;
    public float timeToRegen = 2f;
    public int ammo;
    public float lives;
    public float movespeed;
    public int dir;
    //Assigned gameobjects
    public GameObject bloodParticles;
    public GameObject player;
    public GameObject playerPrefab;
    public GameObject respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        LoadStats();
        respawnPoint = GameObject.FindGameObjectWithTag("Spawn point");
    }

    // Update is called once per frame
    void Update()
    {
        if (stam < maxStam)
        {
            if(stamDelayTimer >= timeToRegen)
            {
                stam = Mathf.Clamp(stam + (stamRecharge * Time.deltaTime), 0.0f, maxStam);
            }
            else
            {
                stamDelayTimer += Time.deltaTime;
            }
            //stam += Time.deltaTime * stamRecharge;
        }
        if(stam > maxStam)
        {
            stam = maxStam;
        }
        if(stam < 0)
        {
            stam = 0;
        }
    }

    IEnumerator StamDelay()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("stam delay");
    }

    void LoadStats()
    {
        maxhp = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().hp;
        hp = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().hp;
        atk = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().atk;
        rngAtk = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().rngAtk;
        stam = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().stam;
        ammo = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().ammo;
        lives = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().lives;
        movespeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().movespeed;
        dir = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().dir;
        stamRecharge = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().stamRecharge;
    }

    public void CheckIfDead()
    {
        //Emmit particles
        Instantiate(bloodParticles, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

        if (hp <= 0)
        {
            
            //Check remaining lives
            if (lives > 0)
            {
                //respawn
                GetComponent<CharacterController>().enabled = false;
                player.transform.position = respawnPoint.transform.position;
                GetComponent<CharacterController>().enabled = true;
                //subtract 1 life
                lives -= 1;
                //refill hp
                hp = 5;
                //give temporary invincibility
                //set camera
                GetComponent<CameraManager>().Setplayers();
            }
            else
            {
                //gameover
            }
        }
    }

    void MeleeAttack()
    {
        //for ();
        //check if other player is in range
        //if yes
        //GameObject.FindGameObjectWithTag("player1").GetComponent<GameManager>().Attack(GameObject.FindGameObjectWithTag("player1"), GameObject.FindGameObjectWithTag("player2"));
    }

    

    

   

}
