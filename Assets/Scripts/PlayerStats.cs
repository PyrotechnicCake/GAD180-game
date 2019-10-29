using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //default stats
    public int hp;
    public int atk;
    public int rngAtk;
    public int atkspd;
    public int stam;
    public int ammo;
    public int lives;
    public float movespeed;
    public int dir;
    public GameObject player;
    public GameObject playerPrefab;
    public Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        LoadStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadStats()
    {
        hp = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().hp;
        atk = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().atk;
        rngAtk = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().rngAtk;
        stam = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().stam;
        ammo = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().ammo;
        lives = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().lives;
        movespeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().movespeed;
        dir = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().dir;
    }

    public void CheckIfDead()
    {
        if (hp <= 0)
        {
            //destroy player
            Destroy(player);
            //respawn
            Instantiate(playerPrefab, respawnPoint.position, respawnPoint.rotation);
            //attatched scripts auot turned off, need to reset stats and turn scripts on

            //Vector3
            //refill hp
            //give temporary invincibility
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
