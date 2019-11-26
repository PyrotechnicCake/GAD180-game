using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 8.0f;
    public float gravity = 20.0f;
    public float rotSpeed = 90f;
    public int playerID;
    string horz;
    string vert;
    string rSHorz;
    string rSVert;
    

    private Vector3 moveDirection = Vector3.zero;
    private Quaternion lookDirection;
    private CharacterController controller;
    float angle;
    
    void Start()
    {
        if (this.gameObject.CompareTag("player1"))
        {
            playerID = 0;
        }
        if (this.gameObject.CompareTag("player2"))
        {
            playerID = 1;
        }
        controller = GetComponent<CharacterController>();

        if (playerID == 0)
        {
            horz = "HorizontalP1";
            vert = "VerticalP1";
            rSHorz = "HorizontalRSP1";
            rSVert = "VerticalRSP1";
        }

        else
        {
            horz = "HorizontalP2";
            vert = "VerticalP2";
            rSHorz = "HorizontalRSP2";
            rSVert = "VerticalRSP2";
        }
       

    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis(horz), 0, Input.GetAxis(vert));
           // moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }

        if (Input.GetAxis(rSHorz) >= 0.1f || Input.GetAxis(rSHorz) <= -0.1f)
        {
            angle = Mathf.Atan2(Input.GetAxis(rSHorz), Input.GetAxis(rSVert)) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }
        

        if (GetComponentInChildren<Shield>().shieldUp == true)
        {
            speed = 20f;
        }
        if (GetComponentInChildren<Shield>().shieldUp == false)
        {
            speed = 20f;
        }



            /*RaycastHit Hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit, 100f))
        {
            Vector3 lookPosition = Hit.point;
            transform.LookAt(new Vector3(lookPosition.x, transform.position.y, lookPosition.z));
        }*/
        //  transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

}
