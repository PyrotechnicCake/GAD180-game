using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    //initial values
    private Vector3 startingPosition;
    private Vector3 newPosition;
    [SerializeField]
    private float distBetweenPlayers;
    public float maxHeight = 20;

    private GameObject player1;
    private GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        //store initial position
        startingPosition = transform.position;
        player1 = GameObject.FindGameObjectWithTag("player1");
        player2 = GameObject.FindGameObjectWithTag("player2");

    }

    // Update is called once per frame
    void Update()
    {
        //detect the player's distance apart
        distBetweenPlayers = Vector3.Distance(player1.transform.position, player2.transform.position);
        //adjust the height
        //newPosition = transform.position;
        newPosition.y = Mathf.Lerp(startingPosition.y, maxHeight, distBetweenPlayers / maxHeight);
        transform.position = new Vector3(transform.position.x,newPosition.y,transform.position.z);
    }
}
