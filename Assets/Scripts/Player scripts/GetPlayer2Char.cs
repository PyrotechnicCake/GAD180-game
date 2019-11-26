using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer2Char : MonoBehaviour
{
    public GameObject demon, imp, snauz;
    private readonly string p2SelectedCharacter = "P2SelectedCharacter";
    public int playerID = 1;
    public GameObject P2_UI;


    // Start is called before the first frame update
    void Start()
    {
        P2_UI = GameObject.FindGameObjectWithTag("Player2UI");

        int getP2Character;
        getP2Character = PlayerPrefs.GetInt(p2SelectedCharacter);
        switch (getP2Character)
        {
            case 1:
                GameObject playerImp = Instantiate(imp);
                playerImp.gameObject.tag = "player2";
                playerImp.gameObject.layer = 10;
                playerImp.transform.position = GameObject.FindGameObjectWithTag("Player 2 Spawn").transform.position;
                P2_UI.GetComponent<UIManager>().AssignUI();
                break;
            case 2:
                GameObject playerSnauz = Instantiate(snauz);
                playerSnauz.gameObject.tag = "player2";
                playerSnauz.gameObject.layer = 10;
                playerSnauz.transform.position = GameObject.FindGameObjectWithTag("Player 2 Spawn").transform.position;
                P2_UI.GetComponent<UIManager>().AssignUI();
                break;
            case 3:
                GameObject playerDemon = Instantiate(demon);
                playerDemon.gameObject.tag = "player2";
                playerDemon.gameObject.layer = 10;
                playerDemon.transform.position = GameObject.FindGameObjectWithTag("Player 2 Spawn").transform.position;
                P2_UI.GetComponent<UIManager>().AssignUI();
                break;
        }
        /*GetComponentInChildren<PlayerController>().playerID = 1;
        GetComponentInChildren<Shield>().playerID = 1;
        GetComponentInChildren<AttackScript>().playerID = 1;
        GetComponentInChildren<Bow>().playerID = 1;
        */
    }

}
