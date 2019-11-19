using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    public LayerMask layer;
    public float radius = 1f;
    public int damage = 1;
    bool shieldFound = false;
    bool damagedPlayer;

  
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layer);

        if(hits.Length > 0)
        {
            Debug.Log("hit enemy");
            foreach(Collider col in hits)
            {
                if (col.GetComponentInParent<Shield>() != null)
                {
                    if (col.GetComponentInParent<Shield>().shieldUp)
                    {
                        shieldFound = true;
                        GetComponentInParent<PlayerStats>().stam -= 20;
                    }
                }
                Debug.Log(col.name);
            }
            if (!shieldFound)
            {
                foreach(Collider col in hits)
                {
                    if(col.GetComponent<PlayerStats>() != null && !damagedPlayer)
                    {
                        col.GetComponent<PlayerStats>().hp -= damage;
                        col.GetComponent<PlayerStats>().CheckIfDead();
                        damagedPlayer = true;
                    }
                }
                
            }
            
            gameObject.SetActive(false);
            shieldFound = false;
            damagedPlayer = false;

        }
    }
}
