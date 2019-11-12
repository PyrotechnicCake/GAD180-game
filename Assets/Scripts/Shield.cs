using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool shieldUp = false;
    public Animator shieldAnim;
    public GameObject defenseArea;
    
    void Start()
    {
        shieldAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shieldUp = true;
            shieldAnim.SetTrigger("Defend");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
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
