using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool shieldUp = false;
    public Animator shieldAnim;
    public GameObject defenseArea;
    public int playerID;
    string defend;

    void Start()
    {
        shieldAnim = gameObject.GetComponent<Animator>();

        if (playerID == 0)
        {
            defend = "Fire3";
        }
        else
        {
            defend = "Fire6";
        }
    }

    void Update()
    {
        if (Input.GetButtonDown(defend))
        {
            shieldUp = true;
            shieldAnim.SetTrigger("Defend");
        }
        if (Input.GetButtonUp(defend))
        {
            shieldAnim.SetTrigger("Lower");
            shieldUp = false;
        }

    }
    void ActivateDefenseArea()
    {
        defenseArea.SetActive(true);
    }
    void DeactivateAttackPoint()
    {
        if (defenseArea.activeInHierarchy)
        {
            defenseArea.SetActive(false);
        }
    }
    
}
