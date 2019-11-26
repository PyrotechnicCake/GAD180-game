using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour
{
    public GameObject DeathPit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player1" || other.gameObject.tag == "player2")

        {
            other.gameObject.GetComponent<PlayerStats>().hp -= 5;
            other.gameObject.GetComponent<PlayerStats>().CheckIfDead();
        }
    }
}
