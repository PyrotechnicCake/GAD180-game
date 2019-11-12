using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool shieldUp = false;
    public Animator shieldAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        shieldAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shieldAnim.SetTrigger("Defend");
            shieldUp = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            shieldAnim.SetTrigger("Lower");
            shieldUp = false;
        }
    }
}
