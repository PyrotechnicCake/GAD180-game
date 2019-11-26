using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    public LayerMask layer = 9;
    public LayerMask layerDefault;
    public float radius = 1f;
    public int damage = 1;
    bool shieldFound = false;
    bool damagedPlayer;

    private void Start()
    {
        if (GetComponentInParent<PlayerController>().gameObject.layer == 9)
        {
            layer = LayerMask.GetMask("BattleLayer2");
            //layerDefault = 10;
            //Debug.Log("layer changed to" + layer + "start");
        }
        if (GetComponentInParent<PlayerController>().gameObject.layer == 10)
        {
            layer = LayerMask.GetMask("BattleLayer1");
            //layerDefault = 9;
            // Debug.Log("layer changed to" + layer + "start");
        }
    }

    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layer);

        if (hits.Length > 0)
        {
            Debug.Log("hit enemy");
            foreach (Collider col in hits)
            {
                if (col.GetComponentInParent<Shield>() != null)
                {
                    if (col.GetComponentInParent<Shield>().shieldUp)
                    {
                        shieldFound = true;
                        GetComponentInParent<PlayerStats>().stam -= 20;
                        //Debug.Log("layer changed to" + layer + "check shield");
                    }
                }
                Debug.Log(col.name);
               // Debug.Log("layer changed to" + layer + "check hits");
            }
            if (!shieldFound)
            {
                foreach (Collider col in hits)
                {
                    if (col.GetComponent<PlayerStats>() != null && !damagedPlayer)
                    {
                        col.GetComponent<PlayerStats>().hp -= damage;
                        col.GetComponent<PlayerStats>().CheckIfDead();
                        damagedPlayer = true;
                        //Debug.Log("layer changed to" + layer + "if sield found");
                    }
                }

            }

            gameObject.SetActive(false);
            shieldFound = false;
            damagedPlayer = false;
            //Debug.Log("layer changed to" + layer + "after set active");

        }

        //layer = layerDefault;
        //Debug.Log("layer changed to" + layer + "change back");
    }
}
