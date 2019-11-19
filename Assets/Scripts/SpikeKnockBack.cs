using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeKnockBack : MonoBehaviour
{
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player1")
        {
            Vector3 relativePos = other.transform.position - transform.position;
            other.GetComponent<CharacterController>().Move(relativePos * force * Time.deltaTime);
        }
        Debug.Log(other.name);
    }
}
