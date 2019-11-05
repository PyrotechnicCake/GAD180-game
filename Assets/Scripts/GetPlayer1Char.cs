using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer1Char : MonoBehaviour
{
    public GameObject demon, imp, snauz;
    private readonly string p1SelectedCharacter = "P1SelectedCharacter";

    // Start is called before the first frame update
    void Start()
    {
        int getP1Character;
        getP1Character = PlayerPrefs.GetInt(p1SelectedCharacter);
        switch (getP1Character)
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
           
    }


}
