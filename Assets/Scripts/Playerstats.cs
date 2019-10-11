using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerstats : MonoBehaviour
{
    //default stats
    public int hp;
    public int atk;
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
        
    }

    void LoadStats()
    {
        hp = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().hp;
        atk = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().atk;
        stam = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().stam;
        ammo = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().ammo;
        lives = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().lives;
        movespeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().movespeed;
        dir = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().dir;
    }
}
