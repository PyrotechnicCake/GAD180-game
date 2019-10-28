using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Animator swordAnim;
    // Start is called before the first frame update
    void Start()
    {
        swordAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            swordAnim.SetTrigger("Swing");
        }
    }
}
