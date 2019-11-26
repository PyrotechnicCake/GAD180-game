using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// This script is to be applied to the parent object that holds the players UI elements, then it must have those UI elements assigned
    /// to their respective variables, they must also have a player assigned to them
    /// </summary>
    
    //Initialiize gameobjects
    public GameObject myPlayer;
    public GameObject myUI;
    //Initialize UI elements
    public Image healthBar;
    public Image stamBar;
    public Image stockLives;
    //Initialize text UI
    public Text ammoNum;
    
    //Initialize floats (must be floats not ints)
    public float playerHp;
    public float playerStam;
    public float playerLives;
    //Initialize arrows
    public int arrows;
    public int playerID;


    private void Start()
    {
        if(playerID == 0)
        {
            myPlayer = GameObject.FindGameObjectWithTag("player1");
        }
        else
        {
            myPlayer = GameObject.FindGameObjectWithTag("player2");
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Update the UI
        //update health
        playerHp = (myPlayer.GetComponent<PlayerStats>().hp / myPlayer.GetComponent<PlayerStats>().maxhp);
        healthBar.fillAmount = playerHp;
        //update stamina
        playerStam = (myPlayer.GetComponent<PlayerStats>().stam / myPlayer.GetComponent<PlayerStats>().maxStam);
        stamBar.fillAmount = playerStam;
        //update lives
        playerLives = (myPlayer.GetComponent<PlayerStats>().lives / 3);
        stockLives.fillAmount = playerLives;
        //update arrows
        arrows = (myPlayer.GetComponent<Bow>().totalArrows);
        ammoNum.text = arrows.ToString();
    }
}
