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
    private Vector3 levelTextPosition;
    private Vector3 offScreen;
    private int characterInt = 1;
    private int levelInt = 1;
    private SpriteRenderer p1DemonRender, p1ImpRender, p1SnauzRender;
    private SpriteRenderer p2DemonRender, p2ImpRender, p2SnauzRender;
    private GameObject colosseum, hellscape;
    private readonly string p1SelectedCharacter = "P1SelectedCharacter";
    private readonly string p2SelectedCharacter = "P2SelectedCharacter";
    private readonly string selectedLevel = "SelectedLevel";

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

        colosseum = GameObject.FindGameObjectWithTag("Colosseum");
        hellscape = GameObject.FindGameObjectWithTag("Hellscape");
        levelTextPosition = colosseum.transform.position;

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
                PlayerPrefs.SetInt(p2SelectedCharacter, 1);
                p2DemonRender.enabled = false;
                demonP2.transform.position = offScreen;
                impP2.transform.position = p2CharacterPosition;
                p2ImpRender.enabled = true;
                characterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(p2SelectedCharacter, 2);
                p2ImpRender.enabled = false;
                impP2.transform.position = offScreen;
                snauzP2.transform.position = p2CharacterPosition;
                p2SnauzRender.enabled = true;
                characterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(p2SelectedCharacter, 3);
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
                PlayerPrefs.SetInt(p2SelectedCharacter, 2);
                p2DemonRender.enabled = false;
                demonP2.transform.position = offScreen;
                snauzP2.transform.position = p2CharacterPosition;
                p2SnauzRender.enabled = true;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(p2SelectedCharacter, 3);
                p2ImpRender.enabled = false;
                impP2.transform.position = offScreen;
                demonP2.transform.position = p2CharacterPosition;
                p2DemonRender.enabled = true;
                characterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(p2SelectedCharacter, 1);
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

    public void NextLevel()
    {
        switch (levelInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedLevel, 1);
                colosseum.transform.position = offScreen;
                hellscape.transform.position = levelTextPosition;
                levelInt++;
                //Debug.Log("Level int is " + levelInt);
                break;
            case 2:
                PlayerPrefs.SetInt(selectedLevel, 2);
                hellscape.transform.position = offScreen;
                colosseum.transform.position = levelTextPosition;
                ResetInt();
                //Debug.Log("Level int is " + levelInt);
                break;
            default:
                ResetInt();
                break;
        }
    }
    public void PreviousLevel()
    {
        switch (levelInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedLevel, 1);
                colosseum.transform.position = offScreen;
                hellscape.transform.position = levelTextPosition;
                ResetInt();
                //Debug.Log("Level int is " + levelInt);
                break;
            case 2:
                PlayerPrefs.SetInt(selectedLevel, 2);
                hellscape.transform.position = offScreen;
                colosseum.transform.position = levelTextPosition;
                levelInt--;
                //Debug.Log("Level int is " + levelInt);
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
        if(levelInt >= 2)
        {
            levelInt = 1;
            //Debug.Log("reset to " + levelInt);
        }
        else
        {
            levelInt = 2;
            //Debug.Log("doing a thing");
        }
    }
    public void ChangeScene()
    {
        /*colosseum 3
            hellscape 1*/
        if (levelInt == 1)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
}
