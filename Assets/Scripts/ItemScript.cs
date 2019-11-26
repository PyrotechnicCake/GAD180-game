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
    public GameObject spritePlane;
    public Material healthMat;
    public Material stamMat;
    public Material arrowMat;

    private void Start()
    {
        myItem = (Items)Random.Range(0, 3);

        switch (myItem)
        {
            case Items.health:
                spritePlane.GetComponent<MeshRenderer>().material = healthMat;
                break;
            case Items.stamina:
                spritePlane.GetComponent<MeshRenderer>().material = stamMat;
                break;
            case Items.arrows:
                spritePlane.GetComponent<MeshRenderer>().material = arrowMat;
                break;
        }
    }

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
