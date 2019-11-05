using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public GameObject demonP1;
    public GameObject impP1;
    public GameObject snauzP1;
    public GameObject demonP2;
    public GameObject impP2;
    public GameObject snauzP2;
    private Vector3 p1CharacterPosition;
    private Vector3 p2CharacterPosition;
    private Vector3 offScreen;
    private int characterInt = 1;
    private SpriteRenderer p1DemonRender, p1ImpRender, p1SnauzRender;
    private SpriteRenderer p2DemonRender, p2ImpRender, p2SnauzRender;
    private readonly string p1SelectedCharacter = "P1SelectedCharacter";
    private readonly string p2SelectedCharacter = "P2SelectedCharacter";

    private void Awake()
    {
        p1CharacterPosition = demonP1.transform.position;
        offScreen = impP1.transform.position;
        p1DemonRender = demonP1.GetComponent<SpriteRenderer>();
        p1ImpRender = impP1.GetComponent<SpriteRenderer>();
        p1SnauzRender = snauzP1.GetComponent<SpriteRenderer>();

        p2CharacterPosition = demonP2.transform.position;
        offScreen = impP2.transform.position;
        p2DemonRender = demonP2.GetComponent<SpriteRenderer>();
        p2ImpRender = impP2.GetComponent<SpriteRenderer>();
        p2SnauzRender = snauzP2.GetComponent<SpriteRenderer>();
    }

    public void P1NextCharacter()
    {
        switch (characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(p1SelectedCharacter, 1);
                p1DemonRender.enabled = false;
                demonP1.transform.position = offScreen;
                impP1.transform.position = p1CharacterPosition;
                p1ImpRender.enabled = true;
                characterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(p1SelectedCharacter, 2);
                p1ImpRender.enabled = false;
                impP1.transform.position = offScreen;
                snauzP1.transform.position = p1CharacterPosition;
                p1SnauzRender.enabled = true;
                characterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(p1SelectedCharacter, 3);
                p1SnauzRender.enabled = false;
                snauzP1.transform.position = offScreen;
                demonP1.transform.position = p1CharacterPosition;
                p1DemonRender.enabled = true;
                characterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void P1PreviousCharacter()
    {
        switch (characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(p1SelectedCharacter, 2);
                p1DemonRender.enabled = false;
                demonP1.transform.position = offScreen;
                snauzP1.transform.position = p1CharacterPosition;
                p1SnauzRender.enabled = true;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(p1SelectedCharacter, 3);
                p1ImpRender.enabled = false;
                impP1.transform.position = offScreen;
                demonP1.transform.position = p1CharacterPosition;
                p1DemonRender.enabled = true;
                characterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(p1SelectedCharacter, 1);
                p1SnauzRender.enabled = false;
                snauzP1.transform.position = offScreen;
                impP1.transform.position = p1CharacterPosition;
                p1ImpRender.enabled = true;
                characterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }
    public void P2NextCharacter()
    {
        switch (characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(p2SelectedCharacter, 4);
                p2DemonRender.enabled = false;
                demonP2.transform.position = offScreen;
                impP2.transform.position = p2CharacterPosition;
                p2ImpRender.enabled = true;
                characterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(p2SelectedCharacter, 5);
                p2ImpRender.enabled = false;
                impP2.transform.position = offScreen;
                snauzP2.transform.position = p2CharacterPosition;
                p2SnauzRender.enabled = true;
                characterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(p2SelectedCharacter, 6);
                p2SnauzRender.enabled = false;
                snauzP2.transform.position = offScreen;
                demonP2.transform.position = p2CharacterPosition;
                p2DemonRender.enabled = true;
                characterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void P2PreviousCharacter()
    {
        switch (characterInt)
        {
            case 1:
                PlayerPrefs.SetInt(p2SelectedCharacter, 5);
                p2DemonRender.enabled = false;
                demonP2.transform.position = offScreen;
                snauzP2.transform.position = p2CharacterPosition;
                p2SnauzRender.enabled = true;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(p2SelectedCharacter, 6);
                p2ImpRender.enabled = false;
                impP2.transform.position = offScreen;
                demonP2.transform.position = p2CharacterPosition;
                p2DemonRender.enabled = true;
                characterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(p2SelectedCharacter, 4);
                p2SnauzRender.enabled = false;
                snauzP2.transform.position = offScreen;
                impP2.transform.position = p2CharacterPosition;
                p2ImpRender.enabled = true;
                characterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }
    private void ResetInt()
    {
        if (characterInt >= 3)
        {
            characterInt = 1;
        }
        else
        {
            characterInt = 3;
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(3);
    }
}
