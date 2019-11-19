using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer2Char : MonoBehaviour
{
    public GameObject demon, imp, snauz;
    private readonly string p2SelectedCharacter = "P2SelectedCharacter";
    public int playerID = 1;

    // Start is called before the first frame update
    void Start()
    {
        

        int getP2Character;
        getP2Character = PlayerPrefs.GetInt(p2SelectedCharacter);
        switch (getP2Character)
        {
            case 1:
                Instantiate(imp);
                break;
            case 2:
                Instantiate(snauz);
                break;
            case 3:
                Instantiate(demon);
                break;
            default:
                break;
        }
        GetComponentInChildren<PlayerController>().playerID = 1;
        GetComponentInChildren<Shield>().playerID = 1;
        GetComponentInChildren<AttackScript>().playerID = 1;
        GetComponentInChildren<Bow>().playerID = 1;

    }

}
