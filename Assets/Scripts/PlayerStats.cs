using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //default stats
    public float hp;
    public int atk;
    public int rngAtk;
    public int atkspd;
    public float stam;
    public int maxStam = 100;
    public float stamRecharge = 5;
    public int ammo;
    public int lives;
    public float movespeed;
    public int dir;
    //Assigned gameobjects
    public GameObject bloodParticles;
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
        if (stam < maxStam)
        {
            stam += Time.deltaTime * stamRecharge;
        }
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
        //Emmit particles
            Instantiate(bloodParticles, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        if (hp <= 0)
        {
            //respawn
            player.transform.position = respawnPoint.transform.position;
            //Check remaining lives

            //subtract 1 life
            lives -= 1;
            //refill hp
            hp = 5;
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
