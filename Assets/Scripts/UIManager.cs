using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject myPlayer;
    public GameObject myUI;

    public Image healthBar;
    public Image stamBar;
    public Image stockLives;

    
    // Update is called once per frame
    void Update()
    {
        //healthBar.fillAmount = myPlayer.GetComponent<PlayerStats>.hp;
    }
}
