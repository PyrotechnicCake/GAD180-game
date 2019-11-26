using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float projectileSpeed = 20f;
    public Rigidbody2D rb;
    private Vector3 firingPoint;
    public float maxProjectileDist;
    public LayerMask layer;
    public float radius = 1f;
    public int damage = 1;
    bool shieldFound;
    bool damagedPlayer;


    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.position;
    }

    void Update()
    {

        MoveArrow();

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
                        GetComponentInParent<PlayerStats>().stam -= 5;
                    }
                }
                Debug.Log(col.name);
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
                    }
                }

            }

            gameObject.SetActive(false);
            shieldFound = false;
            damagedPlayer = false;

        }

    }
    void MoveArrow()
    {
        if(Vector3.Distance(firingPoint, transform.position) > maxProjectileDist)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.up * projectileSpeed * Time.deltaTime);
        }
    }

}
