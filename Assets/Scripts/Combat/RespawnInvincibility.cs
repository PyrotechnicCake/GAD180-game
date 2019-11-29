﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnIn : MonoBehaviour
{
    public float InvincibleTime = 3.0f;
    public float InvincibleActive;
     
    public void Start()
    {
        InvincibleActive = InvincibleTime;
    }

    public void Update()
    {
        if(InvincibleTime > 0)
        {
            InvincibleTime -= Time.deltaTime;
        }
    }

    void Invincibility()
    {
        if (InvincibleTime > 0)
        {
            InvincibleActive = GetComponent<GameManager>().atk = 0;
        }
    }

     

 
}