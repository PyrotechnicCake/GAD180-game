using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    public LayerMask layer;
    public float radius = 1f;
    public int damage = 1;


  
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layer);

        if(hits.Length > 0)
        {
            Debug.Log("hit enemy");
            Debug.Log(hits);
            hits[0].GetComponent<PlayerStats>().hp -= damage;
            hits[0].GetComponent<PlayerStats>().CheckIfDead();
            //gameObject.SetActive(false);
        }

    }
}
