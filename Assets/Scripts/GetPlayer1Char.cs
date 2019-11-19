using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer1Char : MonoBehaviour
{
    public GameObject demon, imp, snauz;
    private readonly string p1SelectedCharacter = "P1SelectedCharacter";
    public int playerID = 0;
    public GameObject spawnPoint;

    // Start is called before the first frame update

    void SetPlayerID()
    {
        GetComponentInChildren<PlayerController>().playerID = 0;
        GetComponentInChildren<Shield>().playerID = 0;
        GetComponentInChildren<AttackScript>().playerID = 0;
        GetComponentInChildren<Bow>().playerID = 0;
        Debug.Log("playerID set to " + GetComponentInChildren<Shield>().playerID);
    }
    void Awake()
    {
        int getP1Character;
        getP1Character = PlayerPrefs.GetInt(p1SelectedCharacter);
        switch (getP1Character)
        {
            case 1:
                Instantiate(imp);
                imp.transform.parent = GameObject.FindGameObjectWithTag("Respawn").transform;
                break;
            case 2:
                Instantiate(snauz);
                snauz.transform.parent = GameObject.FindGameObjectWithTag("Respawn").transform;
                break;
            case 3:
                Instantiate(demon);
                demon.transform.parent = GameObject.FindGameObjectWithTag("Respawn").transform;
                break;
            default:
                break;
        }
    }
    void Start()
    {

        SetPlayerID();
    }

    


}
