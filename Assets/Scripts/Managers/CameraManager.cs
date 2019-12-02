using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    //initial values
    public Vector3 centre;
    private Vector3 newPosition;
    [SerializeField]
    private float distBetweenPlayers;
    public float maxHeight = 20;
    public int camHeight;

    private GameObject player1;
    private GameObject player2;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        //store initial position
        yield return new WaitForSeconds(.5f);
        Setplayers();
    }

    public void Setplayers()
    {
        player1 = GameObject.FindGameObjectWithTag("player1");
        player2 = GameObject.FindGameObjectWithTag("player2");
    }
    
    // Update is called once per frame
    void Update()
    {
        centre = ((player1.transform.position - player2.transform.position) / 2.0f) + player1.transform.position;
        //detect the player's distance apart
        distBetweenPlayers = Vector3.Distance(player1.transform.position, player2.transform.position);
        //adjust the height
        //newPosition = transform.position;
        newPosition.z = Mathf.Lerp(centre.z, maxHeight, distBetweenPlayers / maxHeight);
        newPosition.x = centre.x;
        newPosition.y = centre.y;
        transform.position = new Vector3(newPosition.x,newPosition.y + camHeight ,newPosition.z);
    }
}
