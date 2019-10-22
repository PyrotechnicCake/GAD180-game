using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private float RemainingAttackLag;
    public float attackLag;

    public Transform meleeAttackPos;
    public float meleeAttackRange;
    public LayerMask enemyInRangePlayer;

    private void Update()
    {
        if(RemainingAttackLag <= 0)
            // allow attack
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Collider2D[] meleeHitBox = Physics2D.OverlapCircleAll(meleeAttackPos.position, meleeAttackRange, enemyInRangePlayer);
                foreach (Collider2D collider in meleeHitBox)
                {
                    Debug.Log(collider.name);
                    collider.gameObject.GetComponent<Player2stats>().hp -= GetComponent<Player1stats>().atk;
                    //collider.gameObject.GetComponent<Player2stats>().TakeDamage();
                }
                RemainingAttackLag = attackLag;
            }
        }
        else
        {
            RemainingAttackLag -= Time.deltaTime;
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(meleeAttackPos.position, meleeAttackRange);
    }
}
