using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Destruct());
    }

    IEnumerator Destruct()
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }

}
