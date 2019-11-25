using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public enum Items
    {
        health,
        stamina,
        arrows
    }
    public Items myItem;

    public int healAmount = 2;
    public float staminaRefill = 50;
    public int arrowRefill = 10;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "player1" || col.gameObject.tag == "player2")
        {
            GameObject player = col.gameObject;

            switch (myItem)
            {
                case Items.health:
                    player.GetComponent<PlayerStats>().hp += healAmount;
                    break;
                case Items.stamina:
                    player.GetComponent<PlayerStats>().stam += staminaRefill;
                    break;
                case Items.arrows:
                    player.GetComponent<Bow>().totalArrows += arrowRefill;
                    break;
            }

            Destroy(gameObject);
        }
    }
}
