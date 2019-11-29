﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private float RemainingAttackLag;
    public float attackLag;

    public Transform meleeAttackPos;
    public float meleeAttackRange;
    public LayerMask enemyInRangePlayer;
    public Animator swordAnim;
    public GameObject attackPoint;

    public int playerID;
    string swingSword;



    void Start()
    {
        if (GetComponentInParent<PlayerController>().gameObject.CompareTag("player1"))
        {
            playerID = 0;

        }
        if (GetComponentInParent<PlayerController>().gameObject.CompareTag("player2"))
        {
            playerID = 1;
        }

        swordAnim = gameObject.GetComponent<Animator>();

        if (playerID == 0)
        {
            swingSword = "Fire1";
            
        }
        if (playerID == 1)
        {
            swingSword = "Fire4";
        }

    }


    private void Update()
    {
        if(RemainingAttackLag <= 0)
            // allow attack
        {
            if (Input.GetButtonDown(swingSword) && GetComponentInParent<PlayerStats>().stam > 0)
            {
                FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Sword/Sword Swing", gameObject);
                GetComponentInParent<PlayerStats>().stam -= 20;
                GetComponentInParent<PlayerStats>().stamDelayTimer = 0.0f;
                swordAnim.SetTrigger("Swing");

                /*Collider[] meleeHitBox = Physics.OverlapCapsule(meleeAttackPos.position, meleeAttackPos.position * 10f, meleeAttackRange, enemyInRangePlayer);
                foreach (Collider collider in meleeHitBox)
                {
                    Debug.Log(collider.name);
                    collider.gameObject.GetComponent<PlayerStats>().hp -= 1;
                    Debug.Log(collider.name + " took 1 damage");
                    collider.gameObject.GetComponent<PlayerStats>().CheckIfDead();
                    //collider.gameObject.GetComponent<Playerstats>().TakeDamage();
                }
                RemainingAttackLag = attackLag;*/
            }
            /*else
            {
                Debug.Log("Out of Stamina!");
            }*/
        }
        else
        {
            RemainingAttackLag -= Time.deltaTime;
        }
    }
    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(meleeAttackPos.position, meleeAttackRange);
    }*/
    void ActivateAttackPoint()
    {
        attackPoint.SetActive(true);
    }
    void DeactivateAttackPoint()
    {
        if (attackPoint.activeInHierarchy)
        {
            attackPoint.SetActive(false);
        }
    }
    
}
