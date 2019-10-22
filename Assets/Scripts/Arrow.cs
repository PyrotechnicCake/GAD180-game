using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float projectileSpeed = 20f;
    public Rigidbody2D rb;
    private Vector3 firingPoint;
    public float maxProjectileDist;
    
    // Start is called before the first frame update
    void Start()
    {
        firingPoint = transform.position;
    }

    void Update()
    {
        MoveArrow();
    }
    void MoveArrow()
    {
        if(Vector3.Distance(firingPoint, transform.position) > maxProjectileDist)
        {
            Destroy(this.gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        }
    }

}
