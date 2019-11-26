using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer1Char : MonoBehaviour
{
    public GameObject demon, imp, snauz;
    private readonly string p1SelectedCharacter = "P1SelectedCharacter";
    public int playerID = 0;
    public GameObject P1_UI;
    //public GameObject spawnPoint;

    // Start is called before the first frame update

    /*void SetPlayerID()
    {
        GetComponentInChildren<PlayerController>().playerID = 0;
        GetComponentInChildren<Shield>().playerID = 0;
        GetComponentInChildren<AttackScript>().playerID = 0;
        GetComponentInChildren<Bow>().playerID = 0;
        Debug.Log("playerID set to " + GetComponentInChildren<Shield>().playerID);
    }*/
    
    void Start()
    {
        P1_UI = GameObject.FindGameObjectWithTag("Player1UI");

        int getP1Character;
        getP1Character = PlayerPrefs.GetInt(p1SelectedCharacter);
        switch (getP1Character)
        {
            case 1:
                GameObject playerImp = Instantiate(imp);
                playerImp.gameObject.tag = "player1";
                playerImp.gameObject.layer = 9;
                playerImp.transform.position = GameObject.FindGameObjectWithTag("Player 1 Spawn").transform.position;
                P1_UI.GetComponent<UIManager>().AssignUI();
                break;
            case 2:
                GameObject playerSnauz = Instantiate(snauz);
                playerSnauz.gameObject.tag = "player1";
                playerSnauz.gameObject.layer = 9;
                playerSnauz.transform.position = GameObject.FindGameObjectWithTag("Player 1 Spawn").transform.position;
                P1_UI.GetComponent<UIManager>().AssignUI();
                break;
            case 3:
                GameObject playerDemon = Instantiate(demon);
                playerDemon.gameObject.tag = "player1";
                playerDemon.gameObject.layer = 9;
                playerDemon.transform.position = GameObject.FindGameObjectWithTag("Player 1 Spawn").transform.position;
                P1_UI.GetComponent<UIManager>().AssignUI();
                break;
        }
    }

    


}
