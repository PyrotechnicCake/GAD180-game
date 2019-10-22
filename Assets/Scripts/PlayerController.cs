﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpForce = 8.0f;
    public float gravity = 20.0f;
    public float rotSpeed = 90f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("HorizontalP1"), 0, Input.GetAxis("VerticalP1"));
           // moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

        }

        RaycastHit Hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit, 100f))
        {
            Vector3 lookPosition = Hit.point;
            transform.LookAt(new Vector3(lookPosition.x, transform.position.y, lookPosition.z));
        }
      //  transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
