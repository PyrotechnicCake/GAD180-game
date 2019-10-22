using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2stats : MonoBehaviour
{
    //default stats
    private bool invincible;
    private float invinciblityTime;
    public int hp;
    public int atk;
    public int rngAtk;
    public int atkspd;
    public int stam;
    public int ammo;
    public int lives;
    public float movespeed;
    public int dir;

    // Start is called before the first frame update
    void Start()
    {
        LoadStats();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (invincible == true)
        {
            invinciblityTime -= Time.deltaTime;
            if (invinciblityTime == 0)
            {
                invincible = false;
            }
        }*/
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

    /*public void TakeDamage()
    {
        if (invincible == false)
        {
            hp -= GameObject.FindGameObjectWithTag("Player1").GetComponent<Player1stats>().atk;
            invincible = true;
        }
    }*/
}
